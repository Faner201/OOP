public class LettuceMeal : MealBase
{
    internal override void Cook()
    {
        Console.WriteLine("Нарезаем помидоры и огурцы");
        Console.WriteLine("Посыпаем зеленью, солью и специями");
    }

    internal override void FinalSteps()
    {
        Console.WriteLine("Поливаем подсолночным маслом");
        Console.WriteLine("Салат готов");
    }

    internal override void Prepare()
    {
        Console.WriteLine("Моем помидоры и огурцы");
    }
    
}