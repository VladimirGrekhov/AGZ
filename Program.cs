// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("*** Вас приветствует Автоматическая Газовая Защита *** \n ");
Console.Beep();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("1 - Ручной режим проверки.");
Console.WriteLine("2 - Автоматический режим проверки.");
DMS DMS1 = new DMS();
DMS1.print(0.17);
 class DMS
{   
    public void print(double Conc)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Датчик Метана {Conc} %");
    }
    
}

