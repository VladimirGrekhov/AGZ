﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGZ
{
    class Input
    {
        public double Doub(string Text)
        {
            Console.Write(Text);
            char chValue;
            double dValue = 0;
            double dValueEnd = 0;
            

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    chValue = Console.ReadKey(true).KeyChar;
                    if (chValue == 'q')
                    {
                        i = 5;
                        dValueEnd = -1;
                        chValue = '1';
                        break;
                    }
                } while (chValue < '0' || chValue > '9');
                dValue = double.Parse(chValue.ToString());
                switch (i)
                {
                    case 0: dValueEnd = dValue * 10; Console.Write(dValue); break;
                    case 1: dValueEnd = dValueEnd + dValue; Console.Write(dValue); Console.Write(','); break;
                    case 2: dValueEnd = dValueEnd + dValue / 10; Console.Write(dValue); break;
                    case 3: dValueEnd = dValueEnd + dValue / 100; Console.Write(dValue); Console.Write('\n'); break;
                }
            }
                        return Math.Round(dValueEnd, 2); //returns 2.00dValueEnd; очень важно !!!
        }
        public int iNumSen(int max)
        {
            char chValue;
            int iValue = 0;
            int iValueEnd = 0;
            for (int i = 0; i < 1; i++) {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n Введите номер датчика ");
                do
                {
                    chValue = Console.ReadKey(true).KeyChar;
                } while (chValue < '1' || chValue > '8');
                iValue = int.Parse(chValue.ToString());
            }
            iValueEnd = iValue - 1 ;
            Console.Write($"{iValueEnd + 1}\n");
            return iValueEnd;
        }
    }
}
