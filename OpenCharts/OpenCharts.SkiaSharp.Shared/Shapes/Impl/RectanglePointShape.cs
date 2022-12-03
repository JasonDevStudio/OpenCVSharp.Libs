using OpenCharts.Shapes.Skia;
using SkiaSharp;

namespace OpenCharts.Shapes.Skia;

/// <summary>
/// RectangleShape
/// </summary>
public class RectangleShape : SkiaPointShape
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RectangleShape"/> class.
    /// </summary>
    public RectangleShape()
    {
        this.Name = nameof(ShapeTypes.Rectangle);
        this.ShapeType = ShapeTypes.Rectangle;
    }
    /// <summary>
    /// Draws the specified src.
    /// </summary>
    /// <param name="src">The src.</param>
    /// <param name="point">The point.</param>
    /// <param name="size">The size.</param>
    public override void Draw(object src, OpenPoint point, OpenSize size)
    {
        base.Center = point;  
    }
}
