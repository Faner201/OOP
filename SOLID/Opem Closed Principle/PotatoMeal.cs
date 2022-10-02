public class PotatoMeal : MealBase
{
    internal override void Cook()
    {
        Console.WriteLine("Ставим почищенную картошку на огонь");
        Console.WriteLine("Варим около 30 минут");
        Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
    }

    internal override void FinalSteps()
    {
        Console.WriteLine("Посыпаем пюре специями и зеленью");
        Console.WriteLine("Картофельное пюре готово");
    }

    internal override void Prepare()
    {
        Console.WriteLine("Чистим и моем картошку");
    }
}