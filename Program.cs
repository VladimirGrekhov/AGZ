// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("*** Вас приветствует Автоматическая Газовая Защита *** \n ");
Console.Beep();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("1 - Ручной режим проверки.");
Console.WriteLine("2 - Автоматический режим проверки.");
DMS DMS1 = new DMS();
ManTest ManTest1 = new ManTest();
ManTest1.test();

DMS1.print(0.17);
 class DMS
{   
    public void print(double Conc)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Датчик Метана {Conc} %");
    }
    
}

class ManTest // Manual test - Режим ручной проверки
{
    public void test()
    {
        Console.WriteLine("Введите проверочную концентрацию газа метана.");
        char chValue ;
        double dValue = 0;
        double dValueEnd = 0;
        
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    chValue = Console.ReadKey(true).KeyChar;
                } while (chValue < '0' || chValue > '9');
                dValue = double.Parse(chValue.ToString());
                Console.Write(dValue);
                switch (i)
                {
                case 0: dValueEnd = dValue * 10; break;
                case 1: dValueEnd = dValue; break;
                case 2: dValueEnd = dValue /10; break;
                case 3: dValueEnd = dValue/100; break;
                }
            }
        Console.WriteLine(dValueEnd);
        Console.Beep();
        Console.Beep();


    }

    public int Conc { set; get; }  = 0;
   

}