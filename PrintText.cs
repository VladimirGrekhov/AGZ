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
            Console.WriteLine("1 - Ручной режим проверки.");
            Console.WriteLine("2 - Автоматический режим проверки.");
        }

    }
}
