
/**
Factory Pattern Demo
*/
// using FactoryPattern;

// // Draw square
// IShape? square = ShapeFactory.GetShape(Square.ShapeName);
// square?.Draw();

// // Draw circle
// IShape? circle = ShapeFactory.GetShape(Circle.ShapeName);
// circle?.Draw();

/**
Abstract Factory Pattern Demo
*/
// using AbstractFactoryPattern;

// // Get rounded shape factory
// AbstractFactory roundedShapeFactory = FactoryProducer.GetAbstractFactory(RoundedShapeFactory.FactoryName);

// // Draw square
// IShape? roundedSquare = roundedShapeFactory.GetShape(RoundedSquare.ShapeName);
// roundedSquare?.Draw();

// // Get shape factory
// AbstractFactory shapeFactory = FactoryProducer.GetAbstractFactory(ShapeFactory.FactoryName);

// // Draw rounded square
// IShape? square = shapeFactory.GetShape(Square.ShapeName);
// square?.Draw();

/**
Abstract Factory Pattern Demo
*/
// using SingletonPattern;

// SingleObj singleObj = SingleObj.GetInstance();
// singleObj.SayHello();