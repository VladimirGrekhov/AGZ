
using AGZ;
using System.Text;

internal class Program
{
    private static void Main(string[] args)// Основной цыкл. Точка входа
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;// Кодировка вывода
        Console.InputEncoding = System.Text.Encoding.UTF8;// Кодировка ввода
        Console.Clear();
        // Console.OutputEncoding = System.Text.Encoding.Unicode;
        // Console.OutputEncoding = Encoding.GetEncoding(866);
        double[] arHiConc = new double[] { 0.75,    1,    1,   2,   1,    2,    1,   2 };// массив уставок
        double[] arConc = new double[]   { 0.12,  0.2, 0.23, 0.5, 0.2, 0.31, 0.23, 0.41 };// массив поступающих значений

        string[] insLoc = new string[]
        {
            "1. Датчик метана расположен на исходящей струе шахты",
            "2. Датчик метана расположен на исходящей струе добычного участка №1",
            "3. Датчик метана расположен в 20 метрах от добычного участка №1",
            "4. Датчик метана расположен в забое добычного участка №1",
            "5. Датчик метана расположен на исходящей струе проходческого участка №2",
            "6. Датчик метана расположен в забое проходческого участка №2",
            "7. Датчик метана расположен на исходящей струе проходческого участка №3",
            "8. Датчик метана расположен в забое проходческого участка №3"

        };  //installation location

        PrintText PrintText1 = new();
        MetSenHan MetSenHan1 = new();
        Input Input1 = new();
        do
        {
         PrintText1.Start();
         PrintText1.SensMetPr(arHiConc, arConc, insLoc);
            PrintText1.Mid();
            char chKey;
            do 
            {
                chKey = Console.ReadKey(true).KeyChar;
            }
            while (chKey < '0' || chKey > '2');

        if (chKey == '1')// Режим проверки
            {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Режим ручной проверки \n");
        {
                    
            do 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;   
                Console.WriteLine("Режим ручной проверки \n");
                PrintText1.SensMetPr(arHiConc, arConc, insLoc);
                int NumSen = Input1.iNumSen(11);
                double ConcMet = Input1.Doub("Введите концентрацию метана в % q - имитация неисправности ");
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Режим ручной проверки \n");
                double tempConc = arConc[NumSen];
                arConc[NumSen] = ConcMet;
                PrintText1.SensMetPr(arHiConc, arConc, insLoc);
                MetSenHan1.inConc(arHiConc[NumSen], ConcMet, NumSen);
                Console.WriteLine("1 - продолжить");
                Console.WriteLine("2 - выход");
                        do
                        {
                            chKey = Console.ReadKey(true).KeyChar;
                           
                        } while (chKey != '1' && chKey != '2');
                arConc[NumSen] = tempConc;
                        if (chKey == '2')
                {
                    break;
                }
                    

            } while (true);
           
        }
            }
        } while (true);

    }
         
}