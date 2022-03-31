using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    internal class Pdf : IPrintable
    {
        public string FileName { get ; set ; }
        public int PageCount { get; set; }
        public Pdf(string filename,int pagecount)
        {
            FileName = filename;
            PageCount = pagecount;
        }
        public void Print()
        {
            Console.WriteLine($"FileName:{FileName},PageCount:{PageCount}");
        }
    }
}
