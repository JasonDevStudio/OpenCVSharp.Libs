namespace OpenCharts;

/// <summary>
/// Size
/// </summary>
public struct SizeEx
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SizeEx"/> struct.
    /// </summary>
    /// <param name="w">The w.</param>
    /// <param name="h">The h.</param>
    public SizeEx(double w, double h)
    {
        this.Width = w; 
        this.Height = h;
    }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    /// <value>
    /// The height.
    /// </value>
    public double Height { get; set; }

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    /// <value>
    /// The width.
    /// </value>
    public double Width { get; set; }
}
