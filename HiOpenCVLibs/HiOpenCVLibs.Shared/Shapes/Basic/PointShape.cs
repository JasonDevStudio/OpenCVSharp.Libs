namespace HiOpenCVLibs;

/// <summary>
/// Shape
/// </summary>
public abstract class PointShape : IPointShape
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the type of the shape.
    /// </summary>
    /// <value>
    /// The type of the shape.
    /// </value>
    public ShapeTypes ShapeType { get; set; }

    /// <summary>
    /// Gets or sets the points.The PTS.多边形点集合，包含几个矩阵，就绘制几个多边形
    /// </summary>
    /// <value>
    /// The points.
    /// </value>
    public IEnumerable<Point> Points { get; set; } = new List<Point>();

    /// <summary>
    /// Gets or sets the center. 圆形中心点
    /// </summary>
    /// <value>
    /// The center.
    /// </value>
    public Point Center { get; set; }

    /// <summary>
    /// Gets or sets the radius.圆半径
    /// </summary>
    /// <value>
    /// The radius.
    /// </value>
    public int Radius { get; set; }

    /// <summary>
    /// Gets or sets the axes.椭圆长轴和短轴长度为边界的矩形区域，椭圆就绘制在这个矩形区域
    /// </summary>
    /// <value>
    /// The axes.
    /// </value>
    public SizeEx Axes { get; set; }

    /// <summary>
    /// Gets or sets the angle.偏转的角度（逆时针旋转）
    /// </summary>
    /// <value>
    /// The angle.
    /// </value>
    public double Angle { get; set; }

    /// <summary>
    /// Gets or sets the start angle.圆弧起始角的角度（逆时针旋转）
    /// </summary>
    /// <value>
    /// The start angle.
    /// </value>
    public double StartAngle { get; set; }

    /// <summary>
    /// Gets or sets the end angle.圆弧终结角的角度（逆时针旋转）
    /// </summary>
    /// <value>
    /// The end angle.
    /// </value>
    public double EndAngle { get; set; }

    /// <summary>
    /// Gets or sets the color of the RGB. 填充颜色
    /// </summary>
    /// <value>
    /// The color of the RGB.
    /// </value>
    public Scalar FillColor { get; set; }

    /// <summary>
    /// Gets or sets the color of the border. 边框颜色
    /// </summary>
    /// <value>
    /// The color of the border.
    /// </value>
    public Scalar BorderColor { get; set; } = new Scalar(255, 255, 255, 30);

    /// <summary>
    /// Gets or sets the type of the line.边框类型 
    /// </summary>
    /// <value>
    /// The type of the line.
    /// </value>
    public LineTypes LineType { get; set; } = LineTypes.AntiAlias;

    /// <summary>
    /// Gets or sets the thickness. 线条粗细
    /// </summary>
    /// <value>
    /// The thickness.
    /// </value>
    public int Thickness { get; set; } = 1;

    /// <summary>
    /// Gets or sets a value indicating whether this instance is closed.
    /// if set to <c>true</c> [is closed]. 是否闭合，如为False，您将获得连接所有点的折线，而不是闭合形状
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is closed; otherwise, <c>false</c>.
    /// </value>
    public bool IsClosed { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether this instance is filled. 是否填充
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is filled; otherwise, <c>false</c>.
    /// </value>
    public bool IsFill { get; set; } = true;

    /// <summary>
    /// Gets or sets the shift.缩放参数 中心坐标和轴值中的小数位数
    /// </summary>
    /// <value>
    /// The shift.
    /// </value>
    public int Shift { get; set; } = 0;

    /// <summary>
    /// Gets or sets the offset.偏移
    /// </summary>
    /// <value>
    /// The offset.
    /// </value>
    public Point Offset { get; set; } = new Point(0, 0);

    /// <summary>
    /// Draws the specified src.
    /// </summary>
    /// <param name="src">The src.</param>
    /// <param name="point">The point.</param>
    /// <param name="size">The size.</param>
    public abstract void Draw(Mat src, PointEx point, SizeEx size);
}
