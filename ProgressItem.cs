using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindInPdfs.Winforms
{
	internal class ProgressItem
	{
		public string Pdf { get; set; }
		public int CurrentItem { get; set; }
		public int TotalItems { get; set; }
		public int NumFound { get; set; }
	}
}
