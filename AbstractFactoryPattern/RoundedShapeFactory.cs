namespace AbstractFactoryPattern;

class RoundedShapeFactory : AbstractFactory
{
    public const string FactoryName = "Rounded Shape Factory";
    public override IShape? GetShape(string ShapeType)
    {
        if (ShapeType == RoundedRectangle.ShapeName) return new RoundedRectangle();
        else if (ShapeType == RoundedSquare.ShapeName) return new RoundedSquare();
        else return null;
    }
}