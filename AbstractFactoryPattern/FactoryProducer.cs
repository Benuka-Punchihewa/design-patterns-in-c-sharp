namespace AbstractFactoryPattern;
class FactoryProducer
{
    public static AbstractFactory GetAbstractFactory(string FactoryType)
    {
        if (FactoryType == ShapeFactory.FactoryName) return new ShapeFactory();
        else return new RoundedShapeFactory();
    }
}