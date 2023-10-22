namespace FactoryPattern;

class ShapeFactory
{
    public static IShape? GetShape(string ShapeType)
    {
        if (ShapeType == Circle.ShapeName) return new Circle();
        else if (ShapeType == Rectangle.ShapeName) return new Rectangle();
        else if (ShapeType == Square.ShapeName) return new Square();
        else return null;
    }
}
