namespace HiOpenCVLibs.Series;

public class XYSeries : Series, IXYSeries
{
    /// <summary>
    /// Gets or sets the y axis.
    /// </summary>
    /// <value>
    /// The y axis.
    /// </value>
    public IAxis YAxis { get; set; }

    /// <summary>
    /// Gets or sets the x axis.
    /// </summary>
    /// <value>
    /// The x axis.
    /// </value>
    public IAxis XAxis { get; set; }

    /// <summary>
    /// Draws the asynchronous.
    /// </summary>
    /// <param name="src">The source.</param>
    /// <returns>Mat</returns> 
    public override async Task<Mat> DrawAsync(Mat src)
    { 
        return await Task.Factory.StartNew(()=> new Mat());
    }
}
