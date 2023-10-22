namespace FactoryPattern;
class Square : IShape
{
    public const string ShapeName = "SQUARE";
    public void Draw()
    {
        Console.WriteLine("Drawing Square!");
    }
}