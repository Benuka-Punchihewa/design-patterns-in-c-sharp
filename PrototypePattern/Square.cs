namespace PrototypePattern;

class Square : Shape
{
    public Square()
    {
        Type = "Square";
    }
    public override void Draw()
    {
        Console.WriteLine("Drawing Square");
    }
}