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
        var canvas = (SKCanvas)src;   
        this.Radius = Convert.ToInt32(size.Width);
        this.SKFillPaint = this.GetPaint(this.FillPaint, point.Color);
        this.SKStrokePaint = this.GetPaint(this.StrokePaint);

        if (this.Center != point || size.Width != this.Radius || this.SkiaPath == null)
        {
            this.SkiaPath = new SKPath();
            this.Center = new OpenPoint(point.X, point.Y);
            var top = this.Center.Y + this.Radius;
            var left = this.Center.X - this.Radius;
            var right = this.Center.X + this.Radius;
            var bottom = this.Center.Y - this.Radius;  
            this.SkiaPath.AddRect(new SKRect((float)left, (float)top, (float)right, (float)bottom));
        }

        if (this.IsFill)
            canvas.DrawPath(this.SkiaPath, this.SKFillPaint);

        canvas.DrawPath(this.SkiaPath, this.SKStrokePaint);
    }
}
