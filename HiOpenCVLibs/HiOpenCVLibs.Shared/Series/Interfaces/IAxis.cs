namespace HiOpenCVLibs.Series;

public interface IAxis
{
    /// <summary>
    /// Gets or sets a value indicating whether this instance is vertical.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is vertical; otherwise, <c>false</c>.
    /// </value>
    bool IsVertical { get; set; }

    /// <summary>
    /// Gets or sets the formating.
    /// </summary>
    /// <value>
    /// The formating.
    /// </value>
    IFormating Formating { get; set; }

    /// <summary>
    /// Gets or sets the scales.
    /// </summary>
    /// <value>
    /// The scales.
    /// </value>
    object[] Scales { get; set; }
}
