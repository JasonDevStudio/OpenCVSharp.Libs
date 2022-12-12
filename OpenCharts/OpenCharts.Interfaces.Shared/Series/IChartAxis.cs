using OpenCharts.Formats;
using OpenCharts.Series;

namespace OpenCharts.Charts.Series;

public interface IChartAxis
{
    /// <summary>
    /// Gets or sets the margin.
    /// </summary>
    /// <value>
    /// The margin.
    /// </value>
    (double left, double right, double top, double bottom) Margin { get; set; }
     
    /// <summary>
    /// Gets or sets the start.
    /// </summary>
    /// <value>
    /// The start.
    /// </value>
    OpenPoint Start { get; set; }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    /// <value>
    /// The height.
    /// </value>
    int Height { get; set; }

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    /// <value>
    /// The width.
    /// </value>
    int Width { get; set; }

    /// <summary>
    /// Gets or sets the maximum scale count.
    /// </summary>
    /// <value>
    /// The maximum scale count.
    /// </value>
    int MaxScaleCount { get; set; }

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
    /// Gets or sets the items.
    /// </summary>
    /// <value>
    /// The items.
    /// </value>
    List<object> Values { get; set; }

    /// <summary>
    /// Gets or sets the scales.
    /// </summary>
    /// <value>
    /// The scales.
    /// </value>
    List<OpenScale> Scales { get; set; }

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
    void Draw(object src);

    /// <summary>
    /// Adds the specified item.
    /// </summary>
    /// <param name="item">The item.</param>
    void Add(OpenScale item);

    /// <summary>
    /// Adds the specified items.
    /// </summary>
    /// <param name="items">The items.</param>
    void Add(List<OpenScale> items);

    /// <summary>
    /// Updates the specified item.
    /// </summary>
    /// <param name="item">The item.</param>
    void Update(OpenScale item);

    /// <summary>
    /// Removes the specified item.
    /// </summary>
    /// <param name="item">The item.</param>
    void Remove(OpenScale item);
}
