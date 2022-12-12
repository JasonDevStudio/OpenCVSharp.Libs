using OpenCharts.Formats;
using OpenCharts.Series;
using OpenCvSharp;

namespace OpenCharts.Charts.Series;

/// <summary>
/// ChartAxis
/// </summary>
public class ChartAxis : IChartAxis
{
    private List<OpenScale> scales = new();
    private int maxLegend = 0;
    private double maxWidth = 0;

    /// <summary>
    /// Gets or sets the start.
    /// </summary>
    /// <value>
    /// The start.
    /// </value>
    public OpenPoint Start { get; set; } = new OpenPoint { X = 0, Y = 0 };

    /// <summary>
    /// Gets or sets the margin.
    /// </summary>
    /// <value>
    /// The margin.
    /// </value>
    public (double left, double right, double top, double bottom) Margin { get; set; } = (20, 20, 20, 20);

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    /// <value>
    /// The height.
    /// </value>
    public int Height { get; set; }

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    /// <value>
    /// The width.
    /// </value>
    public int Width { get; set; } = 50;

    /// <summary>
    /// Gets or sets the maximum scale count.
    /// </summary>
    /// <value>
    /// The maximum scale count.
    /// </value>
    public int MaxScaleCount { get; set; } = 8;

    /// <summary>
    /// Gets the first.
    /// </summary>
    /// <value>
    /// The first.
    /// </value>
    public object First => this.Scales.FirstOrDefault();

    /// <summary>
    /// Gets the last.
    /// </summary>
    /// <value>
    /// The last.
    /// </value>
    public object Last => this.Scales.LastOrDefault();

    /// <summary>
    /// Gets or sets a value indicating whether this instance is vertical.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is vertical; otherwise, <c>false</c>.
    /// </value>
    public bool IsVertical { get; set; }

    /// <summary>
    /// Gets or sets the formating.
    /// </summary>
    /// <value>
    /// The formating.
    /// </value>
    public IFormating Formating { get; set; }

    /// <summary>
    /// Gets or sets the font.
    /// </summary>
    /// <value>
    /// The font.
    /// </value>
    public IFont Font { get; set; } = new Font();

    /// <summary>
    /// Gets or sets the scales.
    /// </summary>
    /// <value>
    /// The scales.
    /// </value>
    public List<OpenScale> Scales
    {
        get => this.scales;
        set
        {
            this.scales = value;
            this.Format();
            this.MaxLegend = this.Scales.Max(m => m.FormatScale.Length);
            this.maxWidth = this.MaxLegend * this.Font.Size;
        }
    }

    /// <summary>
    /// Gets or sets the Values.
    /// </summary>
    /// <value>
    /// The Values.
    /// </value>
    public List<object> Values { get; set; }

    /// <summary>
    /// Gets the maximum legend.
    /// </summary>
    /// <value>
    /// The maximum legend.
    /// </value> 
    public int MaxLegend { get; private set; } 

    /// <summary>
    /// Draws the specified source.
    /// </summary>
    /// <param name="src">The source.</param>
    public void Draw(object src)
    {
        if (this.IsVertical)
            this.DrawVerticalAxis(src);
        else
            this.DrawHorizontalAxis(src);
    }

    /// <summary>
    /// Adds the specified item.
    /// </summary>
    /// <param name="item">The item.</param>
    public void Add(OpenScale item)
    {
        item.FormatScale = $"{this.Formating.Format(item.Value)}";
        this.Scales.Add(item);
    }

    /// <summary>
    /// Adds the specified items.
    /// </summary>
    /// <param name="items">The items.</param>
    public void Add(List<OpenScale> items)
    {
        for (int i = 0; i < items.Count; i++)
        {
            var item = items[i];
            item.FormatScale = $"{this.Formating.Format(item.Value)}";
            this.Scales.Add(item);
        }
    }

    /// <summary>
    /// Updates the specified item.
    /// </summary>
    /// <param name="item">The item.</param>
    public void Update(OpenScale item) => item.FormatScale = $"{this.Formating.Format(item.Value)}";

    /// <summary>
    /// Removes the specified item.
    /// </summary>
    /// <param name="item">The item.</param>
    public void Remove(OpenScale item) => this.Scales.Remove(item);

    /// <summary>
    /// Draws the vertical axis.
    /// </summary>
    private void DrawVerticalAxis(object src)
    {
        var mat = (Mat)src;
        var startY = this.Start.Y + this.Margin.bottom;
        var startX = this.Start.X + this.Margin.left;
        var fcolor = new Scalar(this.Font.Color.B, this.Font.Color.G, this.Font.Color.R, this.Font.Color.A);

        foreach (var scale in this.Scales)
        {
            OpenCVHelper.Default.DrawText(mat, scale.FormatScale, new Point(startX, startY), this.Font.Size, fcolor, thickness: this.Font.Bold ? 2 : 1);
        }
    }

    /// <summary>
    /// Draws the horizontal axis.
    /// </summary>
    private void DrawHorizontalAxis(object src)
    {
    }

    /// <summary>
    /// Formats this instance.
    /// </summary>
    /// <returns>List{object}</returns>
    private void Format()
    {
        for (int i = 0; i < this.Scales.Count; i++)
        {
            var scale = this.Scales[i];
            scale.FormatScale = this.Formating == null ? $"{scale.Value}" : $"{this.Formating.Format(scale)}";
        }
    }
}
