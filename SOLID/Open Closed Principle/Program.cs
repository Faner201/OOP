class Program 
{
    static void Main(string[] args)
    {
       MealBase[] menu = new MealBase[] { new PotatoMeal(), new LettuceMeal() };

       Cook people = new Cook();
       people.MakeDinner(menu);
    }
}
