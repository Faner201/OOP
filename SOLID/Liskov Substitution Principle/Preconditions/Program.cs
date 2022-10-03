public class Program 
{
    static void Main(string[] args)
    {
        Account acc = new MicroAccount();

        InitializaAccount(acc);

        Console.Read();
    }

    public static void InitializaAccount(Account account)
    {
        account.SetCapital(200);
        Console.WriteLine(account.Capital);
    }
}

// С точки зрения класса Account метод InitializeAccount() вполне является работоспособным. 
// Однако при передаче в него объекта MicroAccount мы столкнемся с ошибкой. 
// В итоге пинцип Лисков будет нарушен.
