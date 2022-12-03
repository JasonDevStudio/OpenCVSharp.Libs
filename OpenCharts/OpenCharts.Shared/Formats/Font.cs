using OpenCharts.Formats;

namespace OpenCharts.Formats;

public struct Font : IFont
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Font"/> struct.
    /// </summary>
    public Font()
    {
    }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the size.
    /// </summary>
    /// <value>
    /// The size.
    /// </value>
    public double Size { get; set; } = 7f;

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="IFont"/> is bold.
    /// </summary>
    /// <value>
    ///   <c>true</c> if bold; otherwise, <c>false</c>.
    /// </value>
    public bool Bold { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="IFont"/> is italic.
    /// </summary>
    /// <value>
    ///   <c>true</c> if italic; otherwise, <c>false</c>.
    /// </value>
    public bool Italic { get; set; }

    /// <summary>
    /// Gets or sets the color.
    /// </summary>
    /// <value>
    /// The color.
    /// </value>
    public OpenColor Color { get; set; } = OpenColor.Black;
}
