namespace OpenCharts.Shapes;

public class CirclePointShape : PointShape
{
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
    public override void Draw(Mat src, PointEx point, SizeEx size)
    {
        this.Center = new Point(point.X, point.Y);
        this.Radius = Convert.ToInt32(size.Width); 

        // 绘制实心圆
        OpenCVHelper.Default.DrawCircle(src, this.Center, this.Radius, this.FillColor, this.IsFill ? -1 : this.Thickness, this.LineType, this.Shift);

        if (this.IsFill)
            // 绘制圆边框
            OpenCVHelper.Default.DrawCircle(src, this.Center, this.Radius, this.BorderColor, 1, this.LineType, this.Shift);
    }
}
