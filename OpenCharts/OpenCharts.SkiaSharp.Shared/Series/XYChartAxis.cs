using OpenCharts.Formats;
using OpenCharts.Series;
using OpenCvSharp;

namespace OpenCharts.Charts.Series;

/// <summary>
/// ChartAxis
/// </summary>
public class XYChartAxis : ChartAxis
{   
    /// <summary>
    /// Draws the vertical axis.
    /// </summary>
    protected override void OnDrawVerticalAxis(object src)
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
    /// Called when [draw horizontal axis].
    /// </summary>
    /// <param name="src">The source.</param>
    /// <exception cref="NotImplementedException"></exception>
    protected override void OnDrawHorizontalAxis(object src)
    {
        throw new NotImplementedException();
    }
     
    /// <summary>
    /// Draws the horizontal axis.
    /// </summary>
    private void DrawHorizontalAxis(object src)
    {
    } 
}
