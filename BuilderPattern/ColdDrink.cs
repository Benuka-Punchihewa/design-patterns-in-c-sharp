
namespace BuilderPattern;

public abstract class ColdDrink : IItem
{

    public IPacking GetPacking()
    {
        return new Bottle();
    }

    public abstract string GetName();

    public abstract float GetPrice();
}