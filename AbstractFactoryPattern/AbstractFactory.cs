namespace AbstractFactoryPattern;

abstract class AbstractFactory
{
    public abstract IShape? GetShape(string ShapeType);
}
