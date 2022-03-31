using System;
using Task.Models;
namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Excel excel = new Excel("Excell", 5, 5);
            Word word = new Word("Word", 5);
            Pdf pdf = new Pdf("Pdf", 11);
            PrintFile<Excel> printExcel=new PrintFile<Excel>();
            PrintFile<Word> printWord=new PrintFile<Word>();
            PrintFile<Pdf> printPdf=new PrintFile<Pdf>();

            printExcel.Print(excel);
            printWord.Print(word);
            printPdf.Print(pdf);
        }
    }
}
