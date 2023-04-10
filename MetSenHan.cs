using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGZ
{
    internal class MetSenHan
    {
        
        public void Print()
        {

        }
        public void inConc( double HiConc, double Conc, int numSen)
        {
            if (Conc > HiConc)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Conc}% Внимание превышение концентрации метана метана на датчике №{numSen + 1} !");
                Console.WriteLine($"Оповещение отправлено оператору АГЗ и СМС отвественным руководителям");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
            } else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Концентрация метана в норме ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
