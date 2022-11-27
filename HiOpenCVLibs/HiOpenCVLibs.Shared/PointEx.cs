using System.Text.Json.Serialization;

namespace HiOpenCVLibs;

/// <summary>
/// Size
/// </summary>
public struct PointEx
{
    /// <summary>
    /// Gets or sets the x.
    /// </summary>
    /// <value>
    /// The x.
    /// </value>
    public int X { get; set; }

    /// <summary>
    /// Gets or sets the y.
    /// </summary>
    /// <value>
    /// The y.
    /// </value>
    public int Y { get; set; }

    /// <summary>
    /// Gets or sets the type of the shape.
    /// </summary>
    /// <value>
    /// The type of the shape.
    /// </value>
    public ShapeTypes ShapeType { get; set; }

    /// <summary>
    /// Gets or sets the shape.
    /// </summary>
    /// <value>
    /// The shape.
    /// </value>
    [JsonIgnore]
    public IShape Shape => GlobaService.GetService<IShape>(ShapeType);
}
