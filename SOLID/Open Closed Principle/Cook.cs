public class Cook
{
    public void MakeDinner(MealBase[] menu)
    {
        foreach (MealBase meal in menu)
        meal.Make();
    }
}