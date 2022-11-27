namespace HiOpenCVLibs.Shapes;

public class CircleShape : Shape
{
    public CircleShape()
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
        base.Center = new Point(point.X, point.Y);
        this.Radius = Convert.ToInt32(size.Width);
        this.IsFilled = this.Thickness == -1;
        OpenCVHelper.Default.DrawCircle(src, this.Center, this.Radius, this.RgbColor, this.Thickness, this.LineType, this.Shift);
    }
}
