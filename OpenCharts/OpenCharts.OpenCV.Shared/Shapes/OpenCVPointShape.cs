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
}
