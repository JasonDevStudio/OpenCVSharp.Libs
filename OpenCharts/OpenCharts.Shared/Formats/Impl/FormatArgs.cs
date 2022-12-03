namespace OpenCharts.Series;

public class FormatArgs : IFormatArgs
{
    /// <summary>
    /// Gets or sets the digits.
    /// </summary>
    /// <value>
    /// The digits.
    /// </value>
    public int Digits { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is thousands separator.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is thousands separator; otherwise, <c>false</c>.
    /// </value>
    public bool IsThousandsSeparator { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is scientific.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is scientific; otherwise, <c>false</c>.
    /// </value>
    public bool IsScientific { get; set; }

    /// <summary>
    /// Gets or sets the format string.
    /// </summary>
    /// <value>
    /// The format string.
    /// </value>
    public string FormatString { get; set; }
}
