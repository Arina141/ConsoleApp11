using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Newspaper : PrintedEdition
    { 
        public override void ProductionTime()//Время производства
        {
            Console.WriteLine("Newspaper - печать");
        }
        public override void Paints()//Краски
        {
            Console.WriteLine("Newspaper - черная-цветная");
        }

        public void Material()//материал
        {
            Console.WriteLine("Newspaper - бумага");
        }

    }
}
