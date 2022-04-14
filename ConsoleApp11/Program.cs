using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Periodicals periodicals = new Periodicals();
            Newspaper newspaper = new Newspaper();
            Book book = new Book();

            newspaper.ProductionTime();
            newspaper.Paints();
            newspaper.Material();


            book.ProductionTime();
            book.Paints();
            book.Material();
            book.FinalProcess();


            periodicals.ProductionTime();
            periodicals.Paints();
            periodicals.Material();
            periodicals.FinalProcess();
            periodicals.PriceNeed();

            Console.ReadKey();

        }
    }
}
