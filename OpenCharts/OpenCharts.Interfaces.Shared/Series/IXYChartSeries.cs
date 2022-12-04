namespace OpenCharts.Series;

public interface IXYChartSeries : IChartSeries
{
    /// <summary>
    /// Gets or sets the y axis.
    /// </summary>
    /// <value>
    /// The y axis.
    /// </value>
    IChartAxis YAxis { get; set; }

    /// <summary>
    /// Gets or sets the x axis.
    /// </summary>
    /// <value>
    /// The x axis.
    /// </value>
    IChartAxis XAxis { get; set; }
}
