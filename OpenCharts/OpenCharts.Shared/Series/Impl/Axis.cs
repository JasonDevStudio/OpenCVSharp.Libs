using OpenCvSharp;
using OpenCvSharp.Text;

namespace OpenCharts.Series;

public class Axis : IAxis
{
    private List<object> scales = new();
    private int maxLegend = 0;
    private double maxWidth = 0;

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
    public IFont Font { get; set; } = new Font() { Size = 7f };

    /// <summary>
    /// Gets or sets the scales.
    /// </summary>
    /// <value>
    /// The scales.
    /// </value>
    public List<object> Scales
    {
        get => this.scales;
        set
        {
            this.scales = value;
            this.FormatScales = this.Format();
            this.MaxLegend = this.FormatScales.Max(m => m.Length);
            this.maxWidth = this.MaxLegend * this.Font.Size;
        }
    }

    /// <summary>
    /// Gets or sets the format scales.
    /// </summary>
    /// <value>
    /// The format scales.
    /// </value>
    public List<string> FormatScales { get; private set; } = new();

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
    public void Draw(Mat src)
    {

    }

    /// <summary>
    /// Formats this instance.
    /// </summary>
    /// <returns>List{object}</returns>
    private List<string> Format()
    {
        if (this.Formating == null)
        {
            foreach (var scale in this.Scales)
                this.FormatScales.Add($"{scale}");
        }
        else
        {
            foreach (var scale in this.Scales)
                this.FormatScales.Add($"{this.Formating.Format(scale)}");
        }

        return this.FormatScales;
    }
}
