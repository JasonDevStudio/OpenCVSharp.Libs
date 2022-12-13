using OpenCharts.Enums;
using OpenCharts.Formats;

namespace OpenCharts;

public class OpenPaint
{
    public readonly static OpenPaint Fill = new OpenPaint() { PaintStyle = PaintStyle.StrokeAndFill };

    public readonly static OpenPaint Stroke = new OpenPaint() { Color = new OpenColor(40, 40, 40, 100), PaintStyle = PaintStyle.Stroke, StrokeWidth = 5 };

    /// <summary>
    /// Gets the key.
    /// </summary>
    /// <value>
    /// The key.
    /// </value>
    public string Key => $"{this.StrokeWidth}_{this.PaintStyle}_{this.Color.Key}";

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenPaint"/> struct.
    /// </summary>
    public OpenPaint()
    {
    }

    /// <summary>
    /// Gets or sets the width of the stroke.
    /// </summary>
    /// <value>
    /// The width of the stroke.
    /// </value>
    public int StrokeWidth { get; set; } 

    /// <summary>
    /// Gets or sets the font.
    /// </summary>
    /// <value>
    /// The font.
    /// </value>
    public IFont Font { get; set; } = new Font();

    /// <summary>
    /// Gets or sets the paint style.
    /// </summary>
    /// <value>
    /// The paint style.
    /// </value>
    public PaintStyle PaintStyle { get; set; } = PaintStyle.StrokeAndFill;

    /// <summary>
    /// Gets or sets the color of the fill.
    /// </summary>
    /// <value>
    /// The color of the fill.
    /// </value>
    public OpenColor Color { get; set; } 
}
