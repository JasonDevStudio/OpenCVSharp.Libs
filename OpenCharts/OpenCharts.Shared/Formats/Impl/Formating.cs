namespace OpenCharts.Series;

public abstract class Formating : IFormating
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the tag.
    /// </summary>
    /// <value>
    /// The tag.
    /// </value>
    public string Tag { get; set; }

    /// <summary>
    /// Gets or sets the arguments.
    /// </summary>
    /// <value>
    /// The arguments.
    /// </value>
    public IFormatArgs Args { get; set; }

    /// <summary>
    /// Formats the specified source.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="format">The format.</param>
    /// <returns></returns>
    public abstract object Format(object source, string format = null);
}
