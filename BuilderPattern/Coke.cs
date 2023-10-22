namespace BuilderPattern;

class Coke : ColdDrink
{
    public override string GetName()
    {
        return "Coke";
    }

    public override float GetPrice()
    {
       return 150.00f;
    }
}