using OpenCvSharp;

namespace OpenCharts.Shapes.OpenCV;

/// <summary>
/// 五角星
/// </summary>
public class PentagramPointShape : OpenCVPointShape
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
        var mat = (Mat)src;
        this.Center = point;
        var center = new Point(point.X, point.Y);
        this.Thickness = -1;
        this.IsFill = this.Thickness == -1;

        if (size.Width != this.Radius && !(this.CvPoints?.Any() ?? false))
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

            this.CvPoints = this.Points.Select(m => new Point(m.X, m.Y)).ToList();
        }

        var fillColor = base.GetColor(this.FillColor);
        var offset = new Point(this.Offset.X, this.Offset.Y);

        if (this.IsFill)
            OpenCVHelper.Default.DrawFillPoly(mat, this.CvPoints, fillColor, LineTypes.AntiAlias, this.Shift, offset);
        else
            OpenCVHelper.Default.DrawPolylines(mat, this.CvPoints, this.IsClosed, fillColor, this.Thickness, LineTypes.AntiAlias);
    }
}
