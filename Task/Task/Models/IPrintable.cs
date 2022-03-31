using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    internal interface IPrintable
    {
        public string FileName { get; set; }

        public void Print();
    }
}
