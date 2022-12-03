using OpenCharts.Formats;

namespace OpenCharts.Series;

public struct FormatArgs : IFormatArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FormatArgs"/> struct.
    /// </summary>
    public FormatArgs() { }

    /// <summary>
    /// Gets or sets the digits. 精度
    /// </summary>
    /// <value>
    /// The digits.
    /// </value>
    public int Digits { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is thousands separator. 是否千分位分隔
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is thousands separator; otherwise, <c>false</c>.
    /// </value>
    public bool IsThousandsSeparator { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is scientific. 是否科学计数
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is scientific; otherwise, <c>false</c>.
    /// </value>
    public bool IsScientific { get; set; }

    /// <summary>
    /// Gets or sets the format string. Format 字符串
    /// </summary>
    /// <value>
    /// The format string.
    /// </value>
    public string FormatString { get; set; }
}
