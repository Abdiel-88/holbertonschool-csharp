using System;

/// <summary>
/// Represents a shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Calculates the area of the shape. This method is not implemented in the base class.
    /// </summary>
    /// <returns>Throws NotImplementedException.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
