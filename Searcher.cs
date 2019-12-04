using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace FindInPdfs.Winforms
{
	internal class Searcher
	{
		internal void SearchFiles(BackgroundWorker worker, DoWorkEventArgs e, string pdfDir, string searchPhrase, string logFilePath)
		{
			if (worker.CancellationPending)
			{
				e.Result = null;
			}
			else
			{
				var pdfs = Directory.GetFiles(pdfDir);
				var files = new List<string>();
				var count = 0;
				var foundCount = 0;
				var textFound = false;
				using (var sw = File.CreateText(logFilePath))
				{
					sw.AutoFlush = true;
					foreach (var pdf in pdfs)
					{
						count++;
						var percent = Convert.ToInt32(((double)count / (double)pdfs.Length) * 100);
						using (PdfReader rdr = new PdfReader(pdf))
						{
							var text = string.Empty;
							textFound = false;
							for (int i = 1; i <= rdr.NumberOfPages; i++)
							{
								text = PdfTextExtractor.GetTextFromPage(rdr, i).ToLower();
								if (text.Contains(searchPhrase.ToLower()))
								{
									foundCount++;
									textFound = true;
									sw.WriteLineAsync(pdf);
									files.Add(pdf);
									break;
								}
							}

							worker.ReportProgress(percent,
								new ProgressItem {CurrentItem = count, TotalItems = pdfs.Length, NumFound = foundCount, Pdf = textFound ? pdf : null});
						}
					}
				}
			}
		}
	}
}
