using OpenCvSharp;

namespace OpenCharts.Shapes.OpenCV;

/// <summary>
/// CirclePointShape
/// </summary>
public abstract class OpenCVPointShape : PointShape
{
    /// <summary>
    /// The colors
    /// </summary>
    private static Dictionary<OpenColor, Scalar> Colors = new Dictionary<OpenColor, Scalar>();

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
        if (!Colors.ContainsKey(color))
            Colors[color] = new Scalar(this.FillColor.B, this.FillColor.G, this.FillColor.R, this.FillColor.A);

        return Colors[color];
    }
}
