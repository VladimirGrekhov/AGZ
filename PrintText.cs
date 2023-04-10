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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  *** Автоматическая Газовая Защита  шахты  *** \n");
            
        }

        public void Mid()
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n0 - Работа.");
            Console.WriteLine("1 - Ручной режим проверки.");
            Console.WriteLine("2 - Автоматический режим проверки.");
            Console.WriteLine("Нажмите 1 - 3 ");
        }



        public void SensMetPr( double[] arHiConc, double[] arConc, string[] insLoc)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Датчики метана в шахте: ");
            for (int i = 0; i < insLoc.Length; i++) 
            {
                this.ConcColor(arHiConc[i], arConc[i], insLoc[i]);
            }
           
        }
        protected void ConcColor(double arHiConc, double arConc, string insLoc)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(insLoc);
            Console.Write(" (уставка ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{arHiConc}%");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(") - ");
            if(arConc >= arHiConc)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (arConc < 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.Write($"{arConc}%\n");
        }

    }
}
