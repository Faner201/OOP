public class Program 
{
    static void Main(string[] args)
    {
        Account acc = new MicroAccount();
        CalculateInterest(acc);

        Console.Read();
    }

    public static void CalculateInterest(Account account)
    {
        decimal sum = account.GetInterest(1000, 1, 10);
        if(sum != 1200)
            throw new Exception("Неожиданная сумма при вычислениях");
    }
}


