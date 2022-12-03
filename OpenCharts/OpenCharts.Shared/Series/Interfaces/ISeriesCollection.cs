namespace HiOpenCVLibs.Series;

public interface ISeriesCollection
{
    /// <summary>
    /// The series
    /// </summary>
    List<ISeries> Series { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="ISeries"/> at the specified index.
    /// </summary>
    /// <value>
    /// The <see cref="ISeries"/>.
    /// </value>
    /// <param name="index">The index.</param>
    /// <returns></returns>
    ISeries this[int index] { get; set; }
}
