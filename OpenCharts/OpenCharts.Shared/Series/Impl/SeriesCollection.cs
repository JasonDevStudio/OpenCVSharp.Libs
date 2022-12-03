namespace OpenCharts.Series;

/// <summary>
/// SeriesCollection
/// </summary>
public class SeriesCollection : ISeriesCollection
{
    /// <summary>
    /// The series
    /// </summary>
    public List<ISeries> Series { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="ISeries"/> at the specified index.
    /// </summary>
    /// <value>
    /// The <see cref="ISeries"/>.
    /// </value>
    /// <param name="index">The index.</param>
    /// <returns></returns>
    public ISeries this[int index]
    {
        get => this.Series[index];
        set => this.Series[index] = value;
    }
}
