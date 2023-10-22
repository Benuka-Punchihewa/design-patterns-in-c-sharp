namespace FactoryPattern;
class Circle : IShape
{
    public const string ShapeName = "CIRCLE";
    public void Draw()
    {
        Console.WriteLine("Drawing Circle!");
    }
}