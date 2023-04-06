
using AGZ;

internal class Program
{
    private static void Main(string[] args)
    {
       
        PrintText PrintText1 = new PrintText();
        MetSenHan MetSenHan1 = new MetSenHan();
        Input Input1 = new Input();
        do
        {
         Console.Clear();
         PrintText1.Start();
        PrintText1.SensMetPr();
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
                PrintText1.SensMetPr();
                Console.WriteLine(Input1.iNumSen(11));
                MetSenHan1.inConc(Input1.Doub("Введите концентрацию метана в % "));
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