using System.Drawing;
using SkiaSharp;

namespace OpenCharts.Shapes.Skia;

/// <summary>
/// CirclePointShape
/// </summary>
public abstract class SkiaPointShape : PointShape
{
    private SKPoint skCenter;

    /// <summary>
    /// The colors
    /// </summary>
    private readonly static Dictionary<string, SKColor> Colors = new Dictionary<string, SKColor>();

    /// <summary>
    /// The paints
    /// </summary>
    private readonly static Dictionary<string, SKPaint> Paints = new Dictionary<string, SKPaint>();

    /// <summary>
    /// Gets or sets the cv points.
    /// </summary>
    /// <value>
    /// The cv points.
    /// </value>
    public List<SKPoint> SKPoints { get; set; }

    /// <summary>
    /// Gets or sets the skia path.
    /// </summary>
    /// <value>
    /// The skia path.
    /// </value>
    public SKPath SkiaPath { get; set; }

    /// <summary>
    /// Gets or sets the fill paint.
    /// </summary>
    /// <value>
    /// The fill paint.
    /// </value>
    public SKPaint SKFillPaint { get; set; }

    /// <summary>
    /// Gets or sets the stroke paint.
    /// </summary>
    /// <value>
    /// The stroke paint.
    /// </value>
    public SKPaint SKStrokePaint { get; set; }

    /// <summary>
    /// Gets the color.
    /// </summary>
    /// <param name="color">The color.</param>
    /// <returns>Scalar</returns>
    protected SKColor GetColor(OpenColor color)
    {
        if (!Colors.ContainsKey(color.Key))
            Colors[color.Key] = new SKColor((byte)color.R, (byte)color.G, (byte)color.B, (byte)color.A);

        return Colors[color.Key];
    }

    /// <summary>
    /// Gets the paint.
    /// </summary>
    /// <param name="color">The color.</param>
    /// <returns>SKPaint</returns>
    protected SKPaint GetPaint(OpenPaint paint, OpenColor? color = null)
    {
        if (color != null)
            paint.Color = color.Value;

        if (!Paints.ContainsKey(paint.Key))
        {
            var skpaint = new SKPaint
            {
                Color = GetColor(paint.Color),
                Style = (SKPaintStyle)paint.PaintStyle,
                IsAntialias = true,
            };

            if (skpaint.Style == SKPaintStyle.Stroke)
                skpaint.StrokeJoin = SKStrokeJoin.Round;

            Paints[paint.Key] = skpaint;
        }

        return Paints[paint.Key];
    }

    /// <summary>
    /// Determines whether the specified point is hover.
    /// </summary>
    /// <param name="point">The point.</param>
    /// <returns>
    ///   <c>true</c> if the specified point is hover; otherwise, <c>false</c>.
    /// </returns>
    public override bool IsHover(OpenPoint point) => this.SkiaPath?.Contains((float)point.X, (float)point.Y) ?? false;
}
