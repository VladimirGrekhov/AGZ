
using AGZ;

internal class Program
{
    private static void Main(string[] args)
    {
        double[] arHiConc = new double[] { 0.75,    1,    1,   2,   1,    2,    1,   2 };
        double[] arConc = new double[]   { 0.12,  0.2, 0.23, 0.5, 0.2, 0.31, 0.23, 0.41 };

        PrintText PrintText1 = new PrintText();
        MetSenHan MetSenHan1 = new MetSenHan();
        Input Input1 = new Input();
        do
        {
         Console.Clear();
         PrintText1.Start();
        PrintText1.SensMetPr(arHiConc);
            char chKey;
            do 
            {
                chKey = Console.ReadKey(true).KeyChar;
            }
            while (chKey < '0' || chKey > '2');

        if (chKey == '1')// Режим проверки
            {
            Console.Clear();
        Console.WriteLine("Режим ручной проверки \n");
        {
            do 
            {   
                Console.Clear();
                PrintText1.SensMetPr(arHiConc);
                MetSenHan1.inConc(arHiConc[Input1.iNumSen(11)],Input1.Doub("Введите концентрацию метана в % "));
                Console.WriteLine("1 - продолжить");
                Console.WriteLine("2 - выход");
                chKey = Console.ReadKey(true).KeyChar;
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