using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    internal class Word : IPrintable
    {
        public string FileName { get ; set ; }

        public int WordCount { get; set; }

        public Word(string filename,int wordcount)
        {
            FileName = filename;
            WordCount = wordcount;
        }
        public void Print()
        {
            Console.WriteLine($"File:{FileName},Word Count:{WordCount}");
        }
    }
}
