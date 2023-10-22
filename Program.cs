
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

//////////////////////////////////////////////////////////////////////////////////////////////////////////

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

//////////////////////////////////////////////////////////////////////////////////////////////////////////

/**
Singleton Pattern Demo
*/
// using SingletonPattern;

// SingleObj singleObj = SingleObj.GetInstance();
// singleObj.SayHello();

//////////////////////////////////////////////////////////////////////////////////////////////////////////

/**
Builder Pattern Demo
*/
// using BuilderPattern;

// // Vegi meal
// Meal vegiMeal = MealBuilder.PrepareVegiMeal();
// Console.WriteLine("Vegitarian Meal");
// vegiMeal.ShowMeal();
// Console.WriteLine($"Cost: {vegiMeal.GetCost()}");

// Console.WriteLine("\n============================\n");

// // Vegi meal
// Meal nonVegiMeal = MealBuilder.PrepareNonVegiMeal();
// Console.WriteLine("Non Vegitarian Meal");
// nonVegiMeal.ShowMeal();
// Console.WriteLine($"Cost: {nonVegiMeal.GetCost()}");

//////////////////////////////////////////////////////////////////////////////////////////////////////////

/**
Builder Pattern Demo
*/
using PrototypePattern;

ShapeCache.LoadCache();

// Clone square
Shape? clonedSquare = (Shape?)ShapeCache.GetShape("Square");
if (clonedSquare != null)
{
    Console.WriteLine($"Shape: {clonedSquare.GetType()}");
}

// clone rectangle
Shape? clonedRectangle = (Shape?)ShapeCache.GetShape("Rectangle");
if (clonedRectangle != null)
{
    Console.WriteLine($"Shape: {clonedRectangle.GetType()}");
}