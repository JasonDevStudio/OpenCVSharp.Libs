using SkiaSharp;

namespace OpenCharts.Shapes.Skia;

/// <summary>
/// CirclePointShape
/// </summary>
public abstract class SkiaPointShape : PointShape
{
    /// <summary>
    /// The colors
    /// </summary>
    private static Dictionary<OpenColor, SKColor> Colors = new Dictionary<OpenColor, SKColor>();

    /// <summary>
    /// Gets or sets the cv points.
    /// </summary>
    /// <value>
    /// The cv points.
    /// </value>
    public List<SKPoint> SKPoints { get; set; }

    /// <summary>
    /// Gets the color.
    /// </summary>
    /// <param name="color">The color.</param>
    /// <returns>Scalar</returns>
    protected SKColor GetColor(OpenColor color)
    {
        if (!Colors.ContainsKey(color))
            Colors[color] = new SKColor((byte)this.FillColor.R, (byte)this.FillColor.G, (byte)this.FillColor.B, (byte)this.FillColor.A);

        return Colors[color];
    }
}
