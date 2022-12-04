using System.Linq;

namespace OpenCharts.Series;

/// <summary>
/// ChartSeriesData
/// </summary>
/// <typeparam name="T">T</typeparam>
public class ChartSeriesData<T> : IChartSeriesData
{
    /// <summary>
    /// Gets the length.
    /// </summary>
    /// <value>
    /// The length.
    /// </value>
    public int Length => this.Data.Count;

    /// <summary>
    /// Gets or sets the <see cref="T"/> at the specified index.
    /// </summary>
    /// <value>
    /// The <see cref="T"/>.
    /// </value>
    /// <param name="index">The index.</param>
    /// <returns>T</returns>
    public T this[int index]
    {
        get => this.Data[index];
        set => this.Data[index] = value;
    }

    /// <summary>
    /// OriginData
    /// </summary>
    public List<T> Data { get; set; }

    /// <summary>
    /// Adds the specified item.
    /// </summary>
    /// <param name="item">The item.</param>
    public void Add(T item) => this.Data.Add(item);

    /// <summary>
    /// Distincts the by.
    /// </summary> 
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <param name="source">The source.</param>
    /// <param name="keySelector">The key selector.</param>
    /// <returns>IEnumerable{T}</returns>
    public IEnumerable<T> DistinctBy<TKey>(Func<T, TKey> keySelector) => this.Data.DistinctBy(keySelector);
}
