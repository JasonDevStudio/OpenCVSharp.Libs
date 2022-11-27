using OpenCvSharp;

namespace HiOpenCVLibs.Shapes;

public class RectanglePointShape : PointShape
{
    public RectanglePointShape()
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
    public override void Draw(Mat src, PointEx point, SizeEx size)
    {
        base.Center = new Point(point.X, point.Y);
        this.IsFilled = this.Thickness == -1;
        var rect = new RotatedRect(this.Center, new Size2f(size.Width, size.Height), (float)this.Angle);
        this.Points = rect.Points().Select(p => new Point(p.X, p.Y)).ToList();

        if (this.IsFilled)
            OpenCVHelper.Default.DrawFillPoly(src, this.Points, this.RgbColor, this.LineType, this.Shift, this.Offset);
        else
            OpenCVHelper.Default.DrawPolylines(src, new List<IEnumerable<Point>> { this.Points }, this.IsClosed, this.RgbColor, this.Thickness, this.LineType);
    }
}
