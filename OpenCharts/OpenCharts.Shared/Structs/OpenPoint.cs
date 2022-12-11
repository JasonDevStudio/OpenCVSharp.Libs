using System.Text.Json.Serialization;
using OpenCharts.Shapes;

namespace OpenCharts;

/// <summary>
/// Size
/// </summary>
public struct OpenPoint
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenPoint"/> struct.
    /// </summary>
    /// <param name="x">The x.</param>
    /// <param name="y">The y.</param>
    public OpenPoint(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenPoint"/> struct.
    /// </summary>
    /// <param name="x">The x.</param>
    /// <param name="y">The y.</param>
    /// <param name="shapeType">Type of the shape.</param>
    /// <param name="color">The color.</param>
    public OpenPoint(double x, double y, ShapeTypes shapeType, OpenColor? color = null)
    {
        this.X = x;
        this.Y = y;
        this.ShapeType = shapeType;
        this.Color = color;
        this.Shape = GlobaService.GetService<IPointShape>(ShapeType);

        if (color != null)
            this.Shape.FillPaint.Color = this.Color.Value;
    }

    /// <summary>
    /// Implements the operator =.
    /// </summary>
    /// <param name="p1">The p1.</param>
    /// <param name="p2">The p2.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator == (OpenPoint p1, OpenPoint p2) => p1.X == p2.X && p1.Y == p2.Y;

    /// <summary>
    /// Implements the operator !=.
    /// </summary>
    /// <param name="p1">The p1.</param>
    /// <param name="p2">The p2.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator != (OpenPoint p1, OpenPoint p2) => !(p1 == p2);

    /// <summary>
    /// Gets or sets the x.
    /// </summary>
    /// <value>
    /// The x.
    /// </value>
    public double X { get; set; } = 0;

    /// <summary>
    /// Gets or sets the y.
    /// </summary>
    /// <value>
    /// The y.
    /// </value>
    public double Y { get; set; } = 0;

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
    public OpenColor? Color { get; set; }

    /// <summary>
    /// Gets or sets the shape.
    /// </summary>
    /// <value>
    /// The shape.
    /// </value>
    [JsonIgnore]
    public IPointShape Shape { get; set; }
}
