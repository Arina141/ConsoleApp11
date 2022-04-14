using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Periodicals : PrintedEdition
    {
        public override void ProductionTime()//Время производства
        {
            Console.WriteLine("Periodicals - печать");
        }
        public override void Paints()//Краски
        {
            Console.WriteLine("Periodicals - черная-цветная");
        }

        public void Material()//материал
        {
            Console.WriteLine("Periodicals - бумага");
        }

        public void FinalProcess()//Заключительный процесс
        {
            Console.WriteLine("Periodicals - сушка под прессом");
        }

        public void PriceNeed()//Цено потребность
        {
            Console.WriteLine("Periodicals - очень низкая");
        }
    }
}
