using OpenCvSharp;
using SkiaSharp;

namespace OpenCharts.Shapes.OpenCV;

/// <summary>
/// CirclePointShape
/// </summary>
public abstract class OpenCVPointShape : PointShape
{
    /// <summary>
    /// The colors
    /// </summary>
    private static Dictionary<string, Scalar> Colors = new Dictionary<string, Scalar>();
     
    /// <summary>
    /// Gets or sets the cv points.
    /// </summary>
    /// <value>
    /// The cv points.
    /// </value>
    public List<Point> CvPoints { get; set; } = new List<Point>();

    /// <summary>
    /// Gets the color.
    /// </summary>
    /// <param name="color">The color.</param>
    /// <returns>Scalar</returns>
    protected Scalar GetColor(OpenColor color)
    {
        if (!Colors.ContainsKey(color.Key))
            Colors[color.Key] = new Scalar(color.B, color.G, color.R, color.A);

        return Colors[color.Key];
    }

    /// <summary>
    /// Determines whether the specified point is hover.
    /// </summary>
    /// <param name="point">The point.</param>
    /// <returns>
    ///   <c>true</c> if the specified point is hover; otherwise, <c>false</c>.
    /// </returns>
    public override bool IsHover(OpenPoint point)
    {
        return false;
    }
}
