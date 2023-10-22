namespace AbstractFactoryPattern;
class Rectangle : IShape
{
    public const string ShapeName = "RECTANGLE";
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle!");
    }
}