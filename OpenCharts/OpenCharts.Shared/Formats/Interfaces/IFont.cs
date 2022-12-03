using System.Drawing;

namespace OpenCharts.Series;

public interface IFont
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets the size.
    /// </summary>
    /// <value>
    /// The size.
    /// </value>
    double Size { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="IFont"/> is bold.
    /// </summary>
    /// <value>
    ///   <c>true</c> if bold; otherwise, <c>false</c>.
    /// </value>
    bool Bold { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="IFont"/> is italic.
    /// </summary>
    /// <value>
    ///   <c>true</c> if italic; otherwise, <c>false</c>.
    /// </value>
    bool Italic { get; set; }
}
