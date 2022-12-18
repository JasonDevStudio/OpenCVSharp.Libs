using System;
using System.Collections.Generic;
using System.Diagnostics; 
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OpenCharts.Charts.Series;
using OpenCharts.Series.Charts.Scatter;
using OpenCvSharp;
using OpenCvSharp.WpfExtensions;
using SkiaSharp;

namespace OpenCharts.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private BitmapSource source;
        private string color = "255,255,0";
        private string size = "25,25";
        private int shapeType = 7;
        private int count = 100000;

        /// <summary>
        /// Gets or sets the draw command.
        /// </summary>
        /// <value>
        /// The draw command.
        /// </value>
        public ICommand DrawCmd => new AsyncRelayCommand(DrawAsync);

        public string Color
        {
            get => this.color;
            set => this.SetProperty(ref this.color, value);
        }

        public string Size
        {
            get => this.size;
            set => SetProperty(ref this.size, value);
        }

        public int ShapeType
        {
            get => this.shapeType;
            set => SetProperty(ref this.shapeType, value);
        }

        public int Count
        {
            get => this.count;
            set => this.SetProperty(ref this.count, value);
        }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public BitmapSource Source
        {
            get => this.source;
            set => this.SetProperty(ref this.source, value);
        }

        /// <summary>
        /// Draws the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task DrawAsync()
        {
            var st = Stopwatch.StartNew();
            var task = await Task.Factory.StartNew(async () =>
            {
                var st1 = Stopwatch.StartNew(); 
                var imgInfo = new SKImageInfo(3373, 1300);
                var bitmap = new SKBitmap(imgInfo);
                var src = new SkiaSharp.SKCanvas(bitmap);
                var sarry = this.Size.Split(",");
                var size = new OpenSize(Convert.ToInt32(sarry[0]), Convert.ToInt32(sarry[1]));
                var shapeType = ShapeTypes.Pentagram;

                switch (this.ShapeType)
                {
                    case 4:
                        shapeType = ShapeTypes.Rectangle;
                        break;
                    case 6:
                        shapeType = ShapeTypes.Pentagram;
                        break;
                    case 7:
                        shapeType = ShapeTypes.Triangle;
                        break;
                    case 2:
                    default:
                        shapeType = ShapeTypes.Circle;
                        break;
                }

                var seriesData = new ScatterSeriesData() { Data = new() };
                var series = new ScatterSeries() { Data = seriesData, Size = size };
                var xrdom = new Random(DateTime.Now.Microsecond);
                var yrdom = new Random(DateTime.Now.Millisecond);
                var vrdom = new Random(DateTime.Now.Millisecond);
                var rrdom = new Random(DateTime.Now.Millisecond);
                var grdom = new Random(DateTime.Now.Millisecond);
                var brdom = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < this.Count; i++)
                {
                    var x = xrdom.Next(1, 3373 * 2);
                    var y = yrdom.Next(1, 1300 * 2);
                    var val = vrdom.Next(1, this.Count);
                    var r = rrdom.Next(0, 255);
                    var g = rrdom.Next(0, 255);
                    var b = rrdom.Next(0, 255);

                    var color1 = new OpenColor(r, g, b);
                    var point = new OpenPoint(x, y, shapeType, color1) { Value = val };
                    seriesData.Add(point);
                }

                await series.DrawAsync(src);
                src.Save(); 
                st1.Stop();
                return bitmap;
            });

            var mat = await task;

            var file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "photoImage", "1111.png");
            if (File.Exists(file))
                File.Delete(file);
            using (SKImage img = SKImage.FromBitmap(mat))
            using (SKData p = img.Encode(SKEncodedImageFormat.Jpeg, 100))
            using (var stream = File.Create(file))
                stream.Write(p.ToArray(), 0, p.ToArray().Length);

            this.Source = SkiaSharp.Views.WPF.WPFExtensions.ToWriteableBitmap(mat);
            st.Stop();
            //System.Windows.MessageBox.Show($"times [{st.Elapsed.TotalMilliseconds}] ms.");
        }

        /// <summary>
        /// Draws the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task DrawOpenCVAsync()
        {
            var st = Stopwatch.StartNew();
            var task = await Task.Factory.StartNew(async () =>
            {
                var st1 = Stopwatch.StartNew();
                var count = 0;
                var src = new Mat(new Size(3373, 1300), MatType.CV_8UC3);
                var carry = this.Color.Split(',');
                var color = new Scalar(Convert.ToInt32(carry[0]), Convert.ToInt32(carry[1]), Convert.ToInt32(carry[2]));
                var sarry = this.Size.Split(",");
                var size = new OpenSize(Convert.ToInt32(sarry[0]), Convert.ToInt32(sarry[1]));
                var shapeType = ShapeTypes.Circle;

                switch (this.ShapeType)
                {
                    case 4:
                        shapeType = ShapeTypes.Rectangle;
                        break;
                    case 6:
                        shapeType = ShapeTypes.Pentagram;
                        break;
                    case 2:
                    default:
                        shapeType = ShapeTypes.Circle;
                        break;
                }

                var seriesData = new ScatterSeriesData() { Data = new() };
                var series = new ScatterSeries() { Data = seriesData, Size = size };
                var xrdom = new Random(DateTime.Now.Microsecond);
                var yrdom = new Random(DateTime.Now.Millisecond);
                var vrdom = new Random(DateTime.Now.Millisecond);
                var rrdom = new Random(DateTime.Now.Millisecond);
                var grdom = new Random(DateTime.Now.Millisecond);
                var brdom = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < this.Count; i++)
                {
                    var x = xrdom.Next(1, 3373 * 2);
                    var y = yrdom.Next(1, 1300 * 2);
                    var val = vrdom.Next(1, this.Count);
                    var r = rrdom.Next(0, 255);
                    var g = rrdom.Next(0, 255);
                    var b = rrdom.Next(0, 255);

                    var color1 = new OpenColor(r, g, b);
                    var point = new OpenPoint(x, y, shapeType, color1) { Value = val };
                    seriesData.Add(point);
                }

                await series.DrawAsync(src);

                st1.Stop();
                Cv2.PutText(src, $"circle count [{count}] , times [{st1.Elapsed.TotalMilliseconds}] ms", new Point(100, 500), HersheyFonts.HersheySimplex, 10, new Scalar(255, 255, 255), 5);
                return src;
            });

            var mat = await task;
            this.Source = mat.ToWriteableBitmap();
            st.Stop();
            System.Windows.MessageBox.Show($"times [{st.Elapsed.TotalMilliseconds}] ms.");
        } 
    }
}
