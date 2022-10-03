public class MicroAccount : Account
{
    public MicroAccount(int sum) : base(sum)
    {
    }

    public override int Capital 
    {
        get { return capital; }

        set
        {
            capital = value;
        }
    }
}