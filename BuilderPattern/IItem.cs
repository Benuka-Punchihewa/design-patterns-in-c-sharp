namespace BuilderPattern;

public interface IItem
{
    public string GetName();
    public IPacking GetPacking();
    public float GetPrice();
}