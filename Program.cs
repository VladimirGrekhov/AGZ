
using AGZ;

internal class Program
{
    private static void Main(string[] args)
    {
       
        PrintText PrintText1 = new PrintText();
        MetSenHan MetSenHan1 = new MetSenHan();
        Input Input1 = new Input();

        PrintText1.Start();
        char chKey = Console.ReadKey(true).KeyChar;
        if (chKey == '1')

        {
            do
            {
                MetSenHan1.inConc(Input1.Doub("Введите концентрацию метана "));
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
}