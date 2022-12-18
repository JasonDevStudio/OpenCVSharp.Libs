using OpenCharts.Shapes.Skia;
using SkiaSharp;

namespace OpenCharts.Shapes.Skia;

/// <summary>
/// TrianglePointShape
/// </summary>
public class TrianglePointShape : SkiaPointShape
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrianglePointShape"/> class.
    /// </summary>
    public TrianglePointShape()
    {
        this.Name = nameof(ShapeTypes.Triangle);
        this.ShapeType = ShapeTypes.Triangle;
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
            this.Center = new OpenPoint(point.X, point.Y);
            this.SkiaPath = new SKPath() { FillType = SKPathFillType.Winding };
            var top = new SKPoint((float)this.Center.X, (float)(this.Center.Y + this.Radius));
            var left = new SKPoint((float)this.Center.X - this.Radius, (float)this.Center.Y - this.Radius);
            var right = new SKPoint((float)this.Center.X + this.Radius, (float)this.Center.Y - this.Radius);
            this.SkiaPath.AddPoly(new SKPoint[] { top, left, right });
        }

        if (this.IsFill) 
            canvas.DrawPath(this.SkiaPath, this.SKFillPaint); 

        canvas.DrawPath(this.SkiaPath, this.SKStrokePaint);
    }
}
