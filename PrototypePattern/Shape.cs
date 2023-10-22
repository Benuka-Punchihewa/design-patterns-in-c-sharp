namespace PrototypePattern;

abstract class Shape : ICloneable
{
    private string? Id;
    protected string? Type;

    public abstract void Draw();

    public new string? GetType()
    {
        return Type;
    }

    public string? GetId()
    {
        return Id;
    }

    public void SetId(string id)
    {
        Id = id;
    }

    public object Clone()
    {
        return MemberwiseClone();
    }
}