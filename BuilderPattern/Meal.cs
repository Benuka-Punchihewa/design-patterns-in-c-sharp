namespace BuilderPattern;

class Meal
{
    private readonly List<IItem> Items = new();

    public void AddItem(IItem item)
    {
        Items.Add(item);
    }

    public float GetCost()
    {
        float cost = 0;

        foreach (IItem item in Items)
        {
            cost += item.GetPrice();
        }

        return cost;
    }

    public void ShowMeal()
    {
        foreach (IItem item in Items)
        {
            Console.WriteLine($"Item: {item.GetName}");
            Console.WriteLine($"Packaging: {item.GetPacking}");
            Console.WriteLine($"Price: {item.GetPrice}");
            Console.WriteLine();
        }
    }
}