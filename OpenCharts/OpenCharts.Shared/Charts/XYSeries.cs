namespace OpenCharts.Charts;

/// <summary>
/// XYSeries
/// </summary>
public abstract class XYSeries : Series, IXYSeries
{
    /// <summary>
    /// Gets or sets the y axis.
    /// </summary>
    /// <value>
    /// The y axis.
    /// </value>
    public IAxis YAxis { get; set; }

    /// <summary>
    /// Gets or sets the x axis.
    /// </summary>
    /// <value>
    /// The x axis.
    /// </value>
    public IAxis XAxis { get; set; }
}
