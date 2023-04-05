
using AGZ;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("*** Вас приветствует Автоматическая Газовая Защита *** \n ");
Console.Beep();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("1 - Ручной режим проверки.");
Console.WriteLine("2 - Автоматический режим проверки.");
DMS DMS1 = new DMS();
ManTest ManTest1 = new ManTest();
Input Input1= new Input();

ManTest1.test(Input1.Doub("Введите концентрацию метана "));
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
    public void test(double Conc)
    {
        Console.WriteLine(Conc);
        Console.Beep();
        Console.Beep();
    }
    public int Conc { set; get; }  = 0;
}