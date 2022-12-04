using System.Reflection;
using OpenCvSharp;

namespace OpenCharts.Shapes.OpenCV;

/// <summary>
/// CirclePointShape
/// </summary>
public class CirclePointShape : OpenCVPointShape
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
        this.Center = point;
        var center = new Point(point.X, point.Y);
        this.Radius = Convert.ToInt32(size.Width);
        var mat = (Mat)src;
        var fillColor = this.GetColor(this.FillColor);
        var borderColor = this.GetColor(this.BorderColor);
         
        // 绘制实心圆
        OpenCVHelper.Default.DrawCircle(mat, center, this.Radius, fillColor, this.IsFill ? -1 : this.Thickness, LineTypes.AntiAlias, this.Shift);

        if (this.IsFill)
            // 绘制圆边框
            OpenCVHelper.Default.DrawCircle(mat, center, this.Radius, borderColor, 1, LineTypes.AntiAlias, this.Shift);
    } 
}
