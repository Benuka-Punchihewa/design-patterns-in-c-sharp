namespace AbstractFactoryPattern;
class RoundedSquare : IShape
{
    public const string ShapeName = "ROUNDED SQUARE";
    public void Draw()
    {
        Console.WriteLine("Drawing Rounded Square!");
    }
}