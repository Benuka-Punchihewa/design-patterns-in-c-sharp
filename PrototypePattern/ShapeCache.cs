using System.Collections;

namespace PrototypePattern;

class ShapeCache
{
    private static readonly Hashtable ShapeMap = new();

    public static Shape? GetShape(string shapeId)
    {
        Shape? cachedShape = (Shape?)ShapeMap[shapeId];
        return (Shape?)cachedShape?.Clone();
    }

    public static void LoadCache()
    {
        Square square = new();
        square.SetId("Square");
        string? squareId = square.GetId();
        if (squareId != null)
            ShapeMap.Add(squareId, square);

        Rectangle rectangle = new();
        rectangle.SetId("Rectangle");
        string? rectangleId = rectangle.GetId();
        if (rectangleId != null)
            ShapeMap.Add(rectangleId, rectangle);
    }
}
