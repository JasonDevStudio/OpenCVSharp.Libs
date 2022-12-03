using System.Text.Json.Serialization;

namespace OpenCharts;

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
    /// <param name="shapeType">Type of the shape.</param>
    /// <param name="color">The color.</param>
    public PointEx(double x, double y, ShapeTypes shapeType, Scalar? color = null)
    {
        this.X = x;
        this.Y = y;
        this.ShapeType = shapeType;
        this.Color = color;
        this.Shape = GlobaService.GetService<IPointShape>(ShapeType);

        if (color != null)
            this.Shape.FillColor = this.Color.Value;
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
    /// Gets or sets the value.
    /// </summary>
    /// <value>
    /// The value.
    /// </value>
    public object Value { get; set; }

    /// <summary>
    /// Gets or sets the type of the shape.
    /// </summary>
    /// <value>
    /// The type of the shape.
    /// </value>
    public ShapeTypes ShapeType { get; set; }

    /// <summary>
    /// Gets or sets the color.
    /// </summary>
    /// <value>
    /// The color.
    /// </value>
    public Scalar? Color { get; set; }
     
    /// <summary>
    /// Gets or sets the shape.
    /// </summary>
    /// <value>
    /// The shape.
    /// </value>
    [JsonIgnore]
    public IPointShape Shape { get; set; }
}
