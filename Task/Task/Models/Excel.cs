using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    internal class Excel : IPrintable
    {
        public string FileName { get ; set ; }
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }

        public Excel(string filename,int columncount,int rowcount)
        {
            FileName = filename;
            ColumnCount = columncount;
            RowCount = rowcount;
        }
        public void Print()
        {
            Console.WriteLine($"FileName:{FileName},ColumnCount:{ColumnCount},RowCount:{RowCount}");
        }
    }
}
