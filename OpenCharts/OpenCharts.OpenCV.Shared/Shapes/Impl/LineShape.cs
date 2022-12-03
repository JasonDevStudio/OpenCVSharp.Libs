namespace HiOpenCVLibs.Shapes;

public class LineShape : Shape
{
    public LineShape()
    {
        this.Name = nameof(ShapeTypes.Line);
        this.ShapeType = ShapeTypes.Line;
    }
    /// <summary>
    /// Draws the specified src.
    /// </summary>
    /// <param name="src">The src.</param>
    /// <param name="point">The point.</param>
    /// <param name="size">The size.</param>
    public override void Draw(Mat src, PointEx point, SizeEx size)
    {
          
        OpenCVHelper.Default.DrawLine(src, this.Center, this.Radius, this.RgbColor, this.Thickness, this.LineType, this.Shift);
    }
}
