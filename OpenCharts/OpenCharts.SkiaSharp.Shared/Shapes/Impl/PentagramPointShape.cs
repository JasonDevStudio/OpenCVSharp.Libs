using System.IO;
using OpenCharts.Shapes.Skia;
using SkiaSharp;

namespace OpenCharts.Shapes.Skia;

/// <summary>
/// PentagramPointShape
/// </summary>
public class PentagramPointShape : SkiaPointShape
{
    private SKPoint[] points;

    /// <summary>
    /// Initializes a new instance of the <see cref="PentagramPointShape"/> class.
    /// </summary>
    public PentagramPointShape()
    {
        this.Name = nameof(ShapeTypes.Pentagram);
        this.ShapeType = ShapeTypes.Pentagram;
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
        this.SKFillPaint = this.GetPaint(this.FillPaint, point.Color);
        this.SKStrokePaint = this.GetPaint(this.StrokePaint);

        if (this.Center != point || size.Width != this.Radius || this.SkiaPath == null)
        {
            this.Center = point;
            this.Radius = (int)size.Width;
            this.SkiaPath = new SKPath() { FillType = SKPathFillType.Winding };
            var r0 = this.Radius;
            var p0 = this.Center;
            int r1 = (int)(r0 * Math.Sin(Math.PI / 10) / Math.Sin(Math.PI * 7 / 10));

            this.Points = new List<OpenPoint>
            {
                new OpenPoint((int)p0.X+r0*Math.Cos(Math.PI/10),(int)p0.Y-r0*Math.Sin(Math.PI/10)),
                new OpenPoint((int)p0.X+r1*Math.Cos(Math.PI*3/10),(int) p0.Y-r1*Math.Sin(Math.PI*3/10)),
                new OpenPoint((int)p0.X+r0*Math.Cos(Math.PI*5/10),(int) p0.Y-r0*Math.Sin(Math.PI*5/10)),
                new OpenPoint((int)p0.X+r1*Math.Cos(Math.PI*7/10),(int) p0.Y-r1*Math.Sin(Math.PI*7/10)),
                new OpenPoint((int)p0.X+r0*Math.Cos(Math.PI*9/10),(int) p0.Y-r0*Math.Sin(Math.PI*9/10)),
                new OpenPoint((int)p0.X+r1*Math.Cos(Math.PI*11/10),(int) p0.Y-r1*Math.Sin(Math.PI*11/10)),
                new OpenPoint((int)p0.X+r0*Math.Cos(Math.PI*13/10),(int) p0.Y-r0*Math.Sin(Math.PI*13/10)),
                new OpenPoint((int)p0.X+r1*Math.Cos(Math.PI*15/10), (int)p0.Y-r1*Math.Sin(Math.PI*15/10)),
                new OpenPoint((int)p0.X+r0*Math.Cos(Math.PI*17/10),(int) p0.Y-r0*Math.Sin(Math.PI*17/10)),
                new OpenPoint((int)p0.X+r1*Math.Cos(Math.PI*19/10), (int)p0.Y-r1*Math.Sin(Math.PI*19/10))
            };

            this.SKPoints = this.Points.Select(m => new SKPoint((float)m.X, (float)m.Y)).ToList();
            this.points = this.SKPoints.ToArray();
            this.SkiaPath.AddPoly(this.points);
        }


        if (this.IsFill)
            canvas.DrawPath(this.SkiaPath, this.SKFillPaint);

        canvas.DrawPath(this.SkiaPath, this.SKStrokePaint);
    }

    /// <summary>
    /// Draws the specified source.
    /// </summary>
    /// <param name="src">The source.</param>
    /// <param name="point">The point.</param>
    /// <param name="size">The size.</param>
    public void Draw2(object src, OpenPoint point, OpenSize size)
    {
        var canvas = (SKCanvas)src;
        this.SKFillPaint = this.GetPaint(this.FillPaint, point.Color);
        this.SKStrokePaint = this.GetPaint(this.StrokePaint);

        if (this.Center != point && size.Width != this.Radius)
        {
            this.Center = point;
            var center = new SKPoint((float)point.X, (float)point.Y);
            var radius = 0.45f * (float)Math.Min(size.Width, size.Height);
            this.SkiaPath = new SKPath() { FillType = SKPathFillType.Winding };
            this.SkiaPath.MoveTo((float)this.Center.X, (float)this.Center.Y - radius);
            for (int i = 0; i < 5; i++)
            {
                var angle = i * 4 * Math.PI / 5;
                this.SkiaPath.LineTo(center + new SKPoint(radius * (float)Math.Sin(angle),
                                            -radius * (float)Math.Cos(angle)));
            }

            this.SkiaPath.Close();
        }

        if (this.IsFill)
            canvas.DrawPath(this.SkiaPath, this.SKFillPaint);

        canvas.DrawPath(this.SkiaPath, this.SKStrokePaint);
    }
}
