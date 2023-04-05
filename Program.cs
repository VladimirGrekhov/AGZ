
using AGZ;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("*** Вас приветствует Автоматическая Газовая Защита *** \n ");
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("1 - Ручной режим проверки.");
        Console.WriteLine("2 - Автоматический режим проверки.");

        MetSenHan MetSenHan1 = new MetSenHan();
        Input Input1 = new Input();

        MetSenHan1.inConc(Input1.Doub("Введите концентрацию метана "));
    }
}