namespace BuilderPattern;

class Pepsi : ColdDrink
{
    public override string GetName()
    {
        return "Pepsi";
    }

    public override float GetPrice()
    {
       return 150.00f;
    }
}