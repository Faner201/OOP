public class Account
{
    public virtual decimal GetInterest(decimal sum, int month, int rate)
    {
        if(sum < 0 || month > 12 || month < 1 || rate < 0)
            throw new System.Exception("Некорректные данные");

        decimal result = sum;

        for(int i = 0; i < month; i++)
            result += result * rate / 100;

        if(sum >= 100)
            result += 100;
        
        Console.WriteLine(result);
        return result;
    }
}