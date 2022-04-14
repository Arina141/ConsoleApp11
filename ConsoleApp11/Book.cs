using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Book : PrintedEdition
    {
        public override void ProductionTime()//Время производства
        {
            Console.WriteLine("Book - печать");
        }
        public override void Paints()//Краски
        {
            Console.WriteLine("Book - черная-цветная");
        }

        public void Material()//материал
        {
            Console.WriteLine("Book - бумага");
        }

        public void FinalProcess()//Заключительный процесс
        {
            Console.WriteLine("Book - сушка под прессом");
        }
    }
}
