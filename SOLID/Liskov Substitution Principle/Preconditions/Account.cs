public class Account 
{
    public int Capital { get; internal set; }

    public virtual void SetCapital(int money)
    {
        if (money < 0)
            throw new System.Exception("Нельзя положить на чёт меньше 0");
        this.Capital = money;
    }
}