using OpenCvSharp;

namespace HiOpenCVLibs.Shapes;

public class PentagramPointShape : PointShape
{
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
    public override void Draw(Mat src, PointEx point, SizeEx size)
    {
        this.Center = new Point(point.X, point.Y);
        this.Thickness = -1;
        this.IsFill = this.Thickness == -1;
        this.Radius = (int)size.Width;
        var r0 = this.Radius;
        var p0 = this.Center;
        int r1 = (int)(r0 * Math.Sin(Math.PI / 10) / Math.Sin(Math.PI * 7 / 10));

        this.Points = new List<Point>
        {
            new Point((int)p0.X+r0*Math.Cos(Math.PI/10),(int)p0.Y-r0*Math.Sin(Math.PI/10)),
            new Point((int)p0.X+r1*Math.Cos(Math.PI*3/10),(int) p0.Y-r1*Math.Sin(Math.PI*3/10)),
            new Point((int)p0.X+r0*Math.Cos(Math.PI*5/10),(int) p0.Y-r0*Math.Sin(Math.PI*5/10)),
            new Point((int)p0.X+r1*Math.Cos(Math.PI*7/10),(int) p0.Y-r1*Math.Sin(Math.PI*7/10)),
            new Point((int)p0.X+r0*Math.Cos(Math.PI*9/10),(int) p0.Y-r0*Math.Sin(Math.PI*9/10)),
            new Point((int)p0.X+r1*Math.Cos(Math.PI*11/10),(int) p0.Y-r1*Math.Sin(Math.PI*11/10)),
            new Point((int)p0.X+r0*Math.Cos(Math.PI*13/10),(int) p0.Y-r0*Math.Sin(Math.PI*13/10)),
            new Point((int)p0.X+r1*Math.Cos(Math.PI*15/10), (int)p0.Y-r1*Math.Sin(Math.PI*15/10)),
            new Point((int)p0.X+r0*Math.Cos(Math.PI*17/10),(int) p0.Y-r0*Math.Sin(Math.PI*17/10)),
            new Point((int)p0.X+r1*Math.Cos(Math.PI*19/10), (int)p0.Y-r1*Math.Sin(Math.PI*19/10))
        };

        if (this.IsFill)
            OpenCVHelper.Default.DrawFillPoly(src, this.Points, this.FillColor, this.LineType, this.Shift, this.Offset);
        else
            OpenCVHelper.Default.DrawPolylines(src, new List<IEnumerable<Point>> { this.Points }, this.IsClosed, this.FillColor, this.Thickness, this.LineType);
    }
}
