public class ConsolePrinter : IPrinter
{
    public void Print(string Text)
    {
        Console.WriteLine("Печать на консоли");
    }
}