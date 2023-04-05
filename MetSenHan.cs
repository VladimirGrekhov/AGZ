using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGZ
{
    internal class MetSenHan
    {
        public void Print(double Conc)
        {
            Console.WriteLine(Conc);
        }

        public void inConc(double Conc)
        {
            if (Conc > 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Внимание превышение концентрации метана метана !");
                Console.ForegroundColor = ConsoleColor.White;
            } else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Концентрация метана в норме ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
