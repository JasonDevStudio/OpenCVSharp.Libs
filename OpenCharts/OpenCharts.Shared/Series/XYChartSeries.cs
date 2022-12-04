using OpenCharts.Series;

namespace OpenCharts.Charts;

/// <summary>
/// XYSeries
/// </summary>
public abstract class XYChartSeries : ChartSeries, IXYChartSeries
{
    /// <summary>
    /// Gets or sets the y axis.
    /// </summary>
    /// <value>
    /// The y axis.
    /// </value>
    public IChartAxis YAxis { get; set; }

    /// <summary>
    /// Gets or sets the x axis.
    /// </summary>
    /// <value>
    /// The x axis.
    /// </value>
    public IChartAxis XAxis { get; set; }
}
