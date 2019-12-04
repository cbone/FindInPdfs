using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FindInPdfs.Winforms
{
	public partial class SearchForm : Form
	{
		public SearchForm()
		{
			InitializeComponent();
		}

		private void BrowseButton_Click(object sender, EventArgs e)
		{
			if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				PdfLocationTextBox.Text = FolderBrowserDialog.SelectedPath;
			}
		}

		private void PdfLocationTextBox_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(SearchPhrasesTextBox.Text) == false)
			{
				SearchButton.Enabled = true;
			}
		}

		private void SearchPhrasesTextBox_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(PdfLocationTextBox.Text) == false)
			{
				SearchButton.Enabled = true;
			}
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			ResultsTextBox.Clear();
			worker.RunWorkerAsync();
		}


		

		private void SaveLogButton_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				SaveLogTextBox.Text = saveFileDialog.FileName;
			}
		}

		private void SearchForm_Load(object sender, EventArgs e)
		{
#if DEBUG
			SearchPhrasesTextBox.Text = "deborah";
			PdfLocationTextBox.Text = @"L:\Carl\EDLRegr";
			SaveLogTextBox.Text = @"c:\temp\Pdf Find List.txt";
#endif
		}

		private void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			new Searcher().SearchFiles(sender as BackgroundWorker, e, PdfLocationTextBox.Text, SearchPhrasesTextBox.Text, SaveLogTextBox.Text);
		}

		private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			var progressItem = e.UserState as ProgressItem;

			ProgressLabel.Text =
				$"Searching file {progressItem.CurrentItem} of {progressItem.TotalItems} ({progressItem.NumFound} files found with text)";
			if (string.IsNullOrEmpty(progressItem.Pdf) == false)
			{
				ResultsTextBox.Text += progressItem.Pdf + Environment.NewLine;
			}
			progressBar1.Value = e.ProgressPercentage;
			progressBar1.Refresh();
		}

		private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			progressBar1.Value = 100;
			progressBar1.Refresh();

			Clipboard.SetText(ResultsTextBox.Text);

			MessageBox.Show("Files list copied to clipboard.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}
}
