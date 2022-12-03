using OpenCharts.Shapes.Skia;
using SkiaSharp;

namespace OpenCharts.Shapes.Skia;

/// <summary>
/// CirclePointShape
/// </summary>
public class CirclePointShape : SkiaPointShape
{ 
    public CirclePointShape()
    {
        this.Name = nameof(ShapeTypes.Circle);
        this.ShapeType = ShapeTypes.Circle;  
    }
    /// <summary>
    /// Draws the specified src.
    /// </summary>
    /// <param name="src">The src.</param>
    /// <param name="point">The point.</param>
    /// <param name="size">The size.</param>
    public override void Draw(object src, OpenPoint point, OpenSize size)
    {
        this.Center = new OpenPoint(point.X, point.Y);
        this.Radius = Convert.ToInt32(size.Width);  
    } 
}
