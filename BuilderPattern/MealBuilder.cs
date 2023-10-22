namespace BuilderPattern;

class MealBuilder
{
    public static Meal PrepareVegiMeal()
    {
        Meal meal = new();
        meal.AddItem(new VegBurger());
        meal.AddItem(new Coke());
        return meal;
    }

    public static Meal PrepareNonVegiMeal()
    {
        Meal meal = new();
        meal.AddItem(new ChickenBurger());
        meal.AddItem(new Pepsi());
        return meal;
    }
}