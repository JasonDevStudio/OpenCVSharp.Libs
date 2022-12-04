namespace OpenCharts.Series;

public interface IXYSeries : ISeries
{
    /// <summary>
    /// Gets or sets the y axis.
    /// </summary>
    /// <value>
    /// The y axis.
    /// </value>
    
    
    
    Axis YAxis { get; set; }

    /// <summary>
    /// Gets or sets the x axis.
    /// </summary>
    /// <value>
    /// The x axis.
    /// </value>
    IAxis XAxis { get; set; }
}
