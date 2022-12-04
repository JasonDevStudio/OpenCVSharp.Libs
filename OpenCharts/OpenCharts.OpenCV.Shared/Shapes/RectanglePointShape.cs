using OpenCharts.Shapes.OpenCV;
using OpenCvSharp;

namespace OpenCharts.Shapes.OpenCV;

/// <summary>
/// RectangleShape
/// </summary>
public class RectangleShape : OpenCVPointShape
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
        var mat = (Mat)src;
        base.Center = point;
        var center = new Point(point.X, point.Y);
        var rect = new RotatedRect(center, new Size2f(size.Width, size.Height), (float)this.Angle);
        this.Points = rect.Points().Select(p => new OpenPoint(p.X, p.Y)).ToList();
        this.CvPoints = this.Points.Select(p => new Point(p.X, p.Y)).ToList();
        var fillColor = base.GetColor(this.FillColor);
        var borderColor = base.GetColor(this.BorderColor);
        var offset = new Point(this.Offset.X, this.Offset.Y);

        if (this.IsFill)
        {
            OpenCVHelper.Default.DrawFillPoly(mat, this.CvPoints, fillColor, LineTypes.AntiAlias, this.Shift, offset);
            OpenCVHelper.Default.DrawPolylines(mat, this.CvPoints, this.IsClosed, borderColor, this.Thickness, LineTypes.AntiAlias);
        }
        else
        {
            OpenCVHelper.Default.DrawPolylines(mat, this.CvPoints, this.IsClosed, fillColor, this.Thickness, LineTypes.AntiAlias);
        }
    }
}
