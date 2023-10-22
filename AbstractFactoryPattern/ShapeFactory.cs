namespace AbstractFactoryPattern;

class ShapeFactory : AbstractFactory
{
    public const string FactoryName = "Shape Factory";
    public override IShape? GetShape(string ShapeType)
    {
        if (ShapeType == Rectangle.ShapeName) return new Rectangle();
        else if (ShapeType == Square.ShapeName) return new Square();
        else return null;
    }
}