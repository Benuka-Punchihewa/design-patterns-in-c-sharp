namespace BuilderPattern;

public class ChickenBurger : Burger
{
    public override string GetName()
    {
        return "Chicken Burger";
    }

    public override float GetPrice()
    {
        return 900.00F;
    }
}