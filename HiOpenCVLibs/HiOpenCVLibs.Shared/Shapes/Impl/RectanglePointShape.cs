using OpenCvSharp;

namespace HiOpenCVLibs.Shapes;

public class RectangleShape : PointShape
{
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
    public override void Draw(Mat src, PointEx point, SizeEx size)
    {
        base.Center = new Point(point.X, point.Y); 
        var rect = new RotatedRect(this.Center, new Size2f(size.Width, size.Height), (float)this.Angle);
        this.Points = rect.Points().Select(p => new Point(p.X, p.Y)).ToList();

        if (this.IsFill)
        {
            OpenCVHelper.Default.DrawFillPoly(src, this.Points, this.FillColor, this.LineType, this.Shift, this.Offset);
            OpenCVHelper.Default.DrawPolylines(src, this.Points, this.IsClosed, this.BorderColor, this.Thickness, this.LineType);
        }
        else
        {
            OpenCVHelper.Default.DrawPolylines(src, this.Points, this.IsClosed, this.FillColor, this.Thickness, this.LineType);
        }
    }
}
