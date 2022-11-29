namespace HiOpenCVLibs.Series;

public interface IFormatingArgs
{
    /// <summary>
    /// Gets or sets the digits.
    /// </summary>
    /// <value>
    /// The digits.
    /// </value>
    int Digits { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is thousands separator.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is thousands separator; otherwise, <c>false</c>.
    /// </value>
    bool IsThousandsSeparator { get; set; }
     
    /// <summary>
    /// Gets or sets a value indicating whether this instance is scientific.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is scientific; otherwise, <c>false</c>.
    /// </value>
    bool IsScientific { get; set; }

    /// <summary>
    /// Gets or sets the format string.
    /// </summary>
    /// <value>
    /// The format string.
    /// </value>
    string FormatString { get; set; } 
}
