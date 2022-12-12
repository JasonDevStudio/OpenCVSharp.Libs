namespace OpenCharts.Charts.Series;

public interface IChartSeries
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    /// <value>
    /// The title.
    /// </value>
    string Title { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether [show label].
    /// </summary>
    /// <value>
    ///   <c>true</c> if [show label]; otherwise, <c>false</c>.
    /// </value>
    bool ShowLabel { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    /// <value>
    /// The type.
    /// </value>
    ChartType Type { get; set; }

    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    /// <value>
    /// The data.
    /// </value>

    IChartSeriesData Data { get; set; }

    /// <summary>
    /// Draws the asynchronous.
    /// </summary>
    /// <param name="src">The source.</param>
    /// <returns>Mat Or Skia</returns>
    Task<object> DrawAsync(object src);
}
