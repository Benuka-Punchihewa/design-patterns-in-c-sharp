namespace PrototypePattern;

class Rectangle : Shape
{
    public Rectangle()
    {
        Type = "Rectangle";
    }
    public override void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}