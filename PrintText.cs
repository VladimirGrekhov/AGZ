using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGZ
{
    internal class PrintText
    {
        public void Start() 
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("*** Вас приветствует Автоматическая Газовая Защита *** \n ");
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("0 - Работа.");
            Console.WriteLine("1 - Ручной режим проверки.");
            Console.WriteLine("2 - Автоматический режим проверки. \n");
        }

        public void SensMetPr()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Датчики метана в шахте. ");
            Console.WriteLine("1. Датчик метана рассположен на исходящей струе шахты (уставка 0.75%) - 0.1% ");

            Console.WriteLine("2. Датчик метана рассположен на исходящей струе добычного участка №1  (уставка 1%) - 0.13% ");
            Console.WriteLine("3. Датчик метана рассположен в 20 метрах от добычного участка №1 (уставка 1%) - 0.26% ");
            Console.WriteLine("4. Датчик метана рассположен в забое добычного участка №1 (уставка 2%) - 0.31% ");

            Console.WriteLine("5. Датчик метана рассположен на исходящей струе проходческого участка №2  (уставка 1%) - 0.15% ");
            Console.WriteLine("6. Датчик метана рассположен в забое проходческого участка №2 (уставка 2%) - 0.22% ");

            Console.WriteLine("7. Датчик метана рассположен на исходящей струе проходческого участка №3  (уставка 1%) - 0.24% ");
            Console.WriteLine("8. Датчик метана рассположен в забое проходческого участка №3 (уставка 2%) - 0.35% ");
        }

    }
}
