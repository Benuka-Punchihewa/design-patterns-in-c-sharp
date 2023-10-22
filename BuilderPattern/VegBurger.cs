namespace BuilderPattern;

public class VegBurger : Burger
{
    public override string GetName()
    {
        return "Vegitarian Burger";
    }

    public override float GetPrice()
    {
        return 600.00F;
    }
}