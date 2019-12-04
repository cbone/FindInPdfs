namespace FindInPdfs.Winforms
{
	partial class SearchForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pdfLocationLabel = new System.Windows.Forms.Label();
			this.PdfLocationTextBox = new System.Windows.Forms.TextBox();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.SearchPhrasesTextBox = new System.Windows.Forms.TextBox();
			this.SearchPhrasesLabel = new System.Windows.Forms.Label();
			this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SearchButton = new System.Windows.Forms.Button();
			this.worker = new System.ComponentModel.BackgroundWorker();
			this.SaveLogButton = new System.Windows.Forms.Button();
			this.SaveLogTextBox = new System.Windows.Forms.TextBox();
			this.SaveLogLabel = new System.Windows.Forms.Label();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.ResultsTextBox = new System.Windows.Forms.TextBox();
			this.ProgressLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pdfLocationLabel
			// 
			this.pdfLocationLabel.AutoSize = true;
			this.pdfLocationLabel.Location = new System.Drawing.Point(26, 11);
			this.pdfLocationLabel.Name = "pdfLocationLabel";
			this.pdfLocationLabel.Size = new System.Drawing.Size(87, 13);
			this.pdfLocationLabel.TabIndex = 0;
			this.pdfLocationLabel.Text = "Location of Pdfs:";
			// 
			// PdfLocationTextBox
			// 
			this.PdfLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PdfLocationTextBox.Location = new System.Drawing.Point(119, 5);
			this.PdfLocationTextBox.Name = "PdfLocationTextBox";
			this.PdfLocationTextBox.ReadOnly = true;
			this.PdfLocationTextBox.Size = new System.Drawing.Size(344, 20);
			this.PdfLocationTextBox.TabIndex = 1;
			this.PdfLocationTextBox.TextChanged += new System.EventHandler(this.PdfLocationTextBox_TextChanged);
			// 
			// BrowseButton
			// 
			this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseButton.Location = new System.Drawing.Point(469, 3);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(75, 23);
			this.BrowseButton.TabIndex = 2;
			this.BrowseButton.Text = "Browse...";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// SearchPhrasesTextBox
			// 
			this.SearchPhrasesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchPhrasesTextBox.Location = new System.Drawing.Point(119, 56);
			this.SearchPhrasesTextBox.Name = "SearchPhrasesTextBox";
			this.SearchPhrasesTextBox.Size = new System.Drawing.Size(344, 20);
			this.SearchPhrasesTextBox.TabIndex = 5;
			this.SearchPhrasesTextBox.TextChanged += new System.EventHandler(this.SearchPhrasesTextBox_TextChanged);
			// 
			// SearchPhrasesLabel
			// 
			this.SearchPhrasesLabel.AutoSize = true;
			this.SearchPhrasesLabel.Location = new System.Drawing.Point(28, 59);
			this.SearchPhrasesLabel.Name = "SearchPhrasesLabel";
			this.SearchPhrasesLabel.Size = new System.Drawing.Size(80, 13);
			this.SearchPhrasesLabel.TabIndex = 4;
			this.SearchPhrasesLabel.Text = "Search Phrase:";
			// 
			// SearchButton
			// 
			this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchButton.Enabled = false;
			this.SearchButton.Location = new System.Drawing.Point(469, 54);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(75, 23);
			this.SearchButton.TabIndex = 7;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// worker
			// 
			this.worker.WorkerReportsProgress = true;
			this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
			this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
			this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
			// 
			// SaveLogButton
			// 
			this.SaveLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveLogButton.Location = new System.Drawing.Point(469, 28);
			this.SaveLogButton.Name = "SaveLogButton";
			this.SaveLogButton.Size = new System.Drawing.Size(75, 23);
			this.SaveLogButton.TabIndex = 10;
			this.SaveLogButton.Text = "Browse...";
			this.SaveLogButton.UseVisualStyleBackColor = true;
			this.SaveLogButton.Click += new System.EventHandler(this.SaveLogButton_Click);
			// 
			// SaveLogTextBox
			// 
			this.SaveLogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveLogTextBox.Location = new System.Drawing.Point(119, 30);
			this.SaveLogTextBox.Name = "SaveLogTextBox";
			this.SaveLogTextBox.ReadOnly = true;
			this.SaveLogTextBox.Size = new System.Drawing.Size(344, 20);
			this.SaveLogTextBox.TabIndex = 9;
			// 
			// SaveLogLabel
			// 
			this.SaveLogLabel.AutoSize = true;
			this.SaveLogLabel.Location = new System.Drawing.Point(41, 33);
			this.SaveLogLabel.Name = "SaveLogLabel";
			this.SaveLogLabel.Size = new System.Drawing.Size(72, 13);
			this.SaveLogLabel.TabIndex = 8;
			this.SaveLogLabel.Text = "Save Log To:";
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(15, 449);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(561, 23);
			this.progressBar1.TabIndex = 12;
			// 
			// ResultsTextBox
			// 
			this.ResultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsTextBox.Location = new System.Drawing.Point(12, 106);
			this.ResultsTextBox.Multiline = true;
			this.ResultsTextBox.Name = "ResultsTextBox";
			this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ResultsTextBox.Size = new System.Drawing.Size(564, 337);
			this.ResultsTextBox.TabIndex = 13;
			// 
			// ProgressLabel
			// 
			this.ProgressLabel.Location = new System.Drawing.Point(12, 87);
			this.ProgressLabel.Name = "ProgressLabel";
			this.ProgressLabel.Size = new System.Drawing.Size(351, 16);
			this.ProgressLabel.TabIndex = 14;
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 478);
			this.Controls.Add(this.ProgressLabel);
			this.Controls.Add(this.ResultsTextBox);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.SaveLogButton);
			this.Controls.Add(this.SaveLogTextBox);
			this.Controls.Add(this.SaveLogLabel);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchPhrasesTextBox);
			this.Controls.Add(this.SearchPhrasesLabel);
			this.Controls.Add(this.BrowseButton);
			this.Controls.Add(this.PdfLocationTextBox);
			this.Controls.Add(this.pdfLocationLabel);
			this.MinimumSize = new System.Drawing.Size(604, 517);
			this.Name = "SearchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search for Text in PDF Files";
			this.Load += new System.EventHandler(this.SearchForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pdfLocationLabel;
		private System.Windows.Forms.TextBox PdfLocationTextBox;
		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.TextBox SearchPhrasesTextBox;
		private System.Windows.Forms.Label SearchPhrasesLabel;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
		private System.Windows.Forms.Button SearchButton;
		private System.ComponentModel.BackgroundWorker worker;
		private System.Windows.Forms.Button SaveLogButton;
		private System.Windows.Forms.TextBox SaveLogTextBox;
		private System.Windows.Forms.Label SaveLogLabel;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox ResultsTextBox;
		private System.Windows.Forms.Label ProgressLabel;
	}
}

