namespace OpenCharts.Series;

public interface IAxis
{
    /// <summary>
    /// Gets or sets a value indicating whether this instance is vertical.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is vertical; otherwise, <c>false</c>.
    /// </value>
    bool IsVertical { get; set; }

    /// <summary>
    /// Gets or sets the formating.
    /// </summary>
    /// <value>
    /// The formating.
    /// </value>
    IFormating Formating { get; set; }

    /// <summary>
    /// Gets or sets the font.
    /// </summary>
    /// <value>
    /// The font.
    /// </value>
    IFont Font { get; set; }
     
    /// <summary>
    /// Gets or sets the scales.
    /// </summary>
    /// <value>
    /// The scales.
    /// </value>
    List<object> Scales { get; set; }

    /// <summary>
    /// Gets or sets the format scales.
    /// </summary>
    /// <value>
    /// The format scales.
    /// </value>
    List<string> FormatScales { get; }

    /// <summary>
    /// Gets the maximum legend.
    /// </summary>
    /// <value>
    /// The maximum legend.
    /// </value>
    int MaxLegend { get; }

    /// <summary>
    /// Draws the specified source.
    /// </summary>
    /// <param name="src">The source.</param>
    void Draw(Mat src);
}
