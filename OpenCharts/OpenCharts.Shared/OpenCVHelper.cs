namespace OpenCharts;

/// <summary>
/// OpenCVHelper
/// </summary>
public class OpenCVHelper
{
    /// <summary>
    /// The default
    /// </summary>
    public static OpenCVHelper Default = new OpenCVHelper();

    #region Draw

    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="src">The mat. 操作图像.</param>
    /// <param name="leftTop">The left top.矩形左上角坐标</param>
    /// <param name="rightBottom">The right bottom.矩形右下角坐标</param>
    /// <param name="color">The color.填充颜色</param>
    /// <param name="thickness">The thickness.边框粗细</param>
    /// <param name="lineType">Type of the line.边框类型</param>
    /// <param name="shift">The shift.缩放参数</param>
    public void DrawRectangle(Mat src, Point leftTop, Point rightBottom, Scalar color, int thickness = 1,
        LineTypes lineType = LineTypes.AntiAlias, int shift = 0) => Cv2.Rectangle(src, leftTop, rightBottom, color, thickness, lineType, shift);

    /// <summary>
    /// Draws the line.
    /// </summary>
    /// <param name="src">The mat. 操作图像.</param>
    /// <param name="start">The left top.矩形左上角坐标</param>
    /// <param name="end">The right bottom.矩形右下角坐标</param>
    /// <param name="color">The color.填充颜色</param>
    /// <param name="thickness">The thickness.边框粗细</param>
    /// <param name="lineType">Type of the line.边框类型</param>
    /// <param name="shift">The shift.缩放参数</param>
    public void DrawLine(Mat src, Point start, Point end, Scalar color, int thickness = 1,
        LineTypes lineType = LineTypes.AntiAlias, int shift = 0) => Cv2.Line(src, start, end, color, thickness, lineType, shift);

    /// <summary>
    /// Draws the circle.
    /// </summary>
    /// <param name="src">The source.操作图像</param>
    /// <param name="center">The center.圆形中心点</param>
    /// <param name="radius">The radius.圆半径</param>
    /// <param name="color">The color.填充颜色</param>
    /// <param name="thickness">The thickness.边框粗细</param>
    /// <param name="lineType">Type of the line.边框类型</param>
    /// <param name="shift">The shift.缩放参数</param>
    public void DrawCircle(Mat src, Point center, int radius, Scalar color, int thickness = 1, LineTypes lineType = LineTypes.AntiAlias, int shift = 0) => Cv2.Circle(src, center, radius, color, thickness, lineType, shift);

    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="src">The source. 操作图像</param>
    /// <param name="center">The center.中心点</param>
    /// <param name="axes">The axes.椭圆长轴和短轴长度为边界的矩形区域，椭圆就绘制在这个矩形区域</param>
    /// <param name="angle">The angle.椭圆旋转角度</param>
    /// <param name="startAngle">The start angle.椭圆起始角度</param>
    /// <param name="endAngle">The end angle.椭圆结束角度</param>
    /// <param name="color">The color.填充颜色</param>
    /// <param name="thickness">The thickness.边框粗细</param>
    /// <param name="lineType">Type of the line.边框类型</param>
    /// <param name="shift">The shift.缩放参数</param>
    public void DrawEllipse(Mat src, Point center, Size axes, double angle, double startAngle, double endAngle, Scalar color,
                int thickness = 1, LineTypes lineType = LineTypes.AntiAlias, int shift = 0) => Cv2.Ellipse(src, center, axes, angle, startAngle, endAngle, color, thickness, lineType, shift);
    /// <summary>
    /// Draws the polylines. 未填充
    /// </summary>
    /// <param name="src">The source.操作图像</param>
    /// <param name="pts">The PTS.多边形点集合，包含几个矩阵，就绘制几个多边形</param>
    /// <param name="isClosed">if set to <c>true</c> [is closed]. 是否闭合，如为False，您将获得连接所有点的折线，而不是闭合形状</param>
    /// <param name="color">The color.填充颜色</param>
    /// <param name="thickness">The thickness.边框粗细</param>
    /// <param name="lineType">Type of the line.边框类型</param>
    /// <param name="shift">The shift.</param>
    public void DrawPolylines(Mat src, IEnumerable<IEnumerable<Point>> pts, bool isClosed, Scalar color, int thickness = 1, LineTypes lineType = LineTypes.AntiAlias, int shift = 0) => Cv2.Polylines(src, pts, isClosed, color, thickness, lineType, shift);

    /// <summary>
    /// Draws the polylines. 未填充
    /// </summary>
    /// <param name="src">The source.操作图像</param>
    /// <param name="pts">The PTS.多边形点集合，包含几个矩阵，就绘制几个多边形</param>
    /// <param name="isClosed">if set to <c>true</c> [is closed]. 是否闭合，如为False，您将获得连接所有点的折线，而不是闭合形状</param>
    /// <param name="color">The color.填充颜色</param>
    /// <param name="thickness">The thickness.边框粗细</param>
    /// <param name="lineType">Type of the line.边框类型</param>
    /// <param name="shift">The shift.</param>
    public void DrawPolylines(Mat src, IEnumerable<Point> pts, bool isClosed, Scalar color, int thickness = 1, LineTypes lineType = LineTypes.AntiAlias, int shift = 0) => Cv2.Polylines(src, new List<IEnumerable<Point>> { pts }, isClosed, color, thickness, lineType, shift);

    /// <summary>
    /// Draws the fill poly. 绘制填充的多边形
    /// </summary>
    /// <param name="src">The source.操作图像</param>
    /// <param name="pts">The PTS.多边形点集合，包含几个矩阵，就绘制几个多边形</param>
    /// <param name="color">The color.填充颜色</param>
    /// <param name="lineType">Type of the line.边框类型</param>
    /// <param name="shift">The shift.缩放参数</param>
    /// <param name="offset">The offset.偏移</param>
    public void DrawFillPoly(Mat src, IEnumerable<IEnumerable<Point>> pts, Scalar color, LineTypes lineType = LineTypes.AntiAlias, int shift = 0, Point? offset = null) => Cv2.FillPoly(src, pts, color, lineType, shift, offset);

    /// <summary>
    /// Draws the fill poly. 绘制填充的多边形
    /// </summary>
    /// <param name="src">The source.操作图像</param>
    /// <param name="pts">The PTS.多边形点集合，包含几个矩阵，就绘制几个多边形</param>
    /// <param name="color">The color.填充颜色</param>
    /// <param name="lineType">Type of the line.边框类型</param>
    /// <param name="shift">The shift.缩放参数</param>
    /// <param name="offset">The offset.偏移</param>
    public void DrawFillPoly(Mat src, IEnumerable<Point> pts, Scalar color, LineTypes lineType = LineTypes.AntiAlias, int shift = 0, Point? offset = null) => Cv2.FillPoly(src, new List<IEnumerable<Point>> { pts }, color, lineType, shift, offset);

    #endregion
}
