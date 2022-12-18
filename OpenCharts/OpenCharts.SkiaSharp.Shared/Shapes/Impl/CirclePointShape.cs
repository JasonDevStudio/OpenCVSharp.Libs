using OpenCharts.Shapes.Skia;
using SkiaSharp;

namespace OpenCharts.Shapes.Skia;

/// <summary>
/// CirclePointShape
/// </summary>
public class CirclePointShape : SkiaPointShape
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CirclePointShape"/> class.
    /// </summary>
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
        var canvas = (SKCanvas)src;
        this.Center = new OpenPoint(point.X, point.Y);
        this.Radius = Convert.ToInt32(size.Width);
        this.SKFillPaint = this.GetPaint(this.FillPaint, point.Color);
        this.SKStrokePaint = this.GetPaint(this.StrokePaint);

        if (this.Center != point || size.Width != this.Radius || this.SkiaPath == null)
        {
            this.SkiaPath = new SKPath();
            this.SkiaPath.AddCircle((float)point.X, (float)point.Y, this.Radius);
        }

        if (this.IsFill)
            canvas.DrawPath(this.SkiaPath, this.SKFillPaint);

        canvas.DrawPath(this.SkiaPath, this.SKStrokePaint);
    }
}
