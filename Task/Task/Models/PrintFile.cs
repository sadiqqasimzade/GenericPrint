using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    internal class PrintFile<T>
        where T : IPrintable
    {

        public void Print(T file)
        {
            file.Print();
        }
    }
}
