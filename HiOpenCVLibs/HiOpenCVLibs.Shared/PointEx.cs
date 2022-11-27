using System.Text.Json.Serialization;

namespace HiOpenCVLibs;

/// <summary>
/// Size
/// </summary>
public struct PointEx
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PointEx"/> struct.
    /// </summary>
    /// <param name="x">The x.</param>
    /// <param name="y">The y.</param>
    public PointEx(double x, double y) 
    {
        this.X= x; 
        this.Y = y;
    }

    /// <summary>
    /// Gets or sets the x.
    /// </summary>
    /// <value>
    /// The x.
    /// </value>
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the y.
    /// </summary>
    /// <value>
    /// The y.
    /// </value>
    public double Y { get; set; }

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
    public IPointShape Shape => GlobaService.GetService<IPointShape>(ShapeType);
}
