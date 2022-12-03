using OpenCharts.Shapes.Skia;
using SkiaSharp;

namespace OpenCharts.Shapes.Skia;

/// <summary>
/// PentagramPointShape
/// </summary>
public class PentagramPointShape : SkiaPointShape
{
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
        this.Center = point;
        this.Thickness = -1;
        this.IsFill = this.Thickness == -1; 

        if (size.Width != this.Radius && !(this.SKPoints?.Any() ?? false))
        {
            this.Radius = (int)size.Width;
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
        }

        var fillColor = base.GetColor(this.FillColor);
        var offset = new SKPoint((float)this.Offset.X, (float)this.Offset.Y); 
    }
}
