public abstract class MealBase
{
    public void Make()
    {
        Prepare();
        Cook();
        FinalSteps();
    }

    internal abstract void Prepare();
    internal abstract void Cook();
    internal abstract void FinalSteps();
}