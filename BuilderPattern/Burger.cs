
namespace BuilderPattern;

public abstract class Burger : IItem
{

    public IPacking GetPacking()
    {
        return new Wrapper();
    }

    public abstract string GetName();

    public abstract float GetPrice();
}