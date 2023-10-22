
using FactoryPattern;

/**
Factory Pattern Demo
*/
// Draw Square
IShape? square = ShapeFactory.GetShape("SQUARE");
square?.Draw();

// Draw Circle
IShape? circle = ShapeFactory.GetShape("CIRCLE");
circle?.Draw();