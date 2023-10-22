namespace AbstractFactoryPattern;
class RoundedRectangle : IShape
{
    public const string ShapeName = "ROUNDED RECTANGLE";
    public void Draw()
    {
        Console.WriteLine("Drawing Rounded Rectangle!");
    }
}