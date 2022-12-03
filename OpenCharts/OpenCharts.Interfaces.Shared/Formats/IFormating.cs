namespace OpenCharts.Formats;

public interface IFormating
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets the tag.
    /// </summary>
    /// <value>
    /// The tag.
    /// </value>
    string Tag { get; set; }

    /// <summary>
    /// Gets or sets the arguments.
    /// </summary>
    /// <value>
    /// The arguments.
    /// </value>
    IFormatArgs Args { get; set; }
     
    /// <summary>
    /// Formats the specified source.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="format">The format.</param>
    /// <returns></returns>
    object Format(object source, string format = null);
}
