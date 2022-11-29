using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HiOpenCVLibs;
using HiOpenCVLibs.Series.Charts;
using OpenCvSharp;
using OpenCvSharp.WpfExtensions;

namespace WpfApp1.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private BitmapSource source;
        private string color = "255,255,0";
        private string size = "25,25";
        private int shapeType = 4;
        private int count = 10000;

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
                var count = 0;
                var src = new Mat(new Size(3373, 1300), MatType.CV_8UC3);
                var carry = this.Color.Split(',');
                var color = new Scalar(Convert.ToInt32(carry[0]), Convert.ToInt32(carry[1]), Convert.ToInt32(carry[2]));
                var sarry = this.Size.Split(",");
                var size = new SizeEx(Convert.ToInt32(sarry[0]), Convert.ToInt32(sarry[1]));
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
                    var x = xrdom.Next(1, 3373*2);
                    var y = yrdom.Next(1, 1300*2);
                    var val = vrdom.Next(1, this.Count);
                    var r = rrdom.Next(0, 255);
                    var g = rrdom.Next(0, 255);
                    var b = rrdom.Next(0, 255);

                    var color1 = new Scalar(r,g,b);
                    var point = new PointEx(x, y, shapeType, color1) { Value = val };
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

        /// <summary>
        /// Draws the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task Draw1Async()
        {
            var st = Stopwatch.StartNew();
            var mat = await Task.Factory.StartNew(() =>
            {
                var st1 = Stopwatch.StartNew();
                var count = 0;
                var scalar = new Scalar(255, 69, 0);
                var src = new Mat(new Size(7680, 4320), MatType.CV_8UC3);

                for (int i = 0; i < 7680;)
                {
                    for (int j = 0; j < 4320;)
                    {
                        this.DrawCircle(src, new Point(i + 2, j + 2), 2, scalar);
                        j += 3;
                        count++;
                    }

                    i += 3;
                }

                st1.Stop();
                Cv2.PutText(src, $"circle count [{count}] , times [{st1.Elapsed.TotalMilliseconds}] ms", new Point(100, 500), HersheyFonts.HersheySimplex, 10, new Scalar(255, 255, 255), 5);

                return src;
            });
            this.Source = mat.ToWriteableBitmap();
            st.Stop();
            System.Windows.MessageBox.Show($"times [{st.Elapsed.TotalMilliseconds}] ms.");
        }

        /// <summary>
        /// Draws the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task Draw2Async()
        {
            var mat = await Task.Factory.StartNew(() =>
            {
                Mat src = new Mat("b.png", ImreadModes.AnyColor | ImreadModes.AnyDepth);

                Point pt1 = new Point(100, 100);
                Point pt2 = new Point(300, 300);
                Scalar scalar = new Scalar(0, 255, 0);
                Cv2.Line(src, pt1, pt2, scalar, 1, LineTypes.AntiAlias, 0);//画线 参数1:操作图像 2:直线起点  3:直线终点 4:颜色 5:线宽  6:线型  7:缩放参数（0为不缩放）

                Cv2.Rectangle(src, pt1, pt2, scalar, 5, LineTypes.AntiAlias, 0);//绘制矩形 参数1:操作图像 2:矩形左上点 3:矩形右下点 4:颜色 5:线宽  6:线型  7:缩放参数（0为不缩放）

                pt1 = new Point(200, 200);
                scalar = new Scalar(0, 100, 0);
                Cv2.Circle(src, pt1, 100, scalar, 3, LineTypes.AntiAlias, 0);//绘制园 参数1:操作图像 2:圆心 3:半径 4:颜色 5:线宽  6:线型  7:缩放参数（0为不缩放）

                Size size = new Size(80, 50);
                scalar = new Scalar(0, 100, 100);
                Cv2.Ellipse(src, pt1, size, 180, 90, 270, scalar, -1, LineTypes.AntiAlias, 0);//绘制椭圆 参数1:操作图像 2:椭圆中心 3:以椭圆长轴和短轴长度为边界的矩形区域，椭圆就绘制在这个矩形区域 4:椭圆旋转角度 5:起始角度  6:终止角度  7:颜色 8:线宽 9:线型 10:缩放参数（0为不缩放）

                List<Point> pts1 = new List<Point>
            {
                new Point(400,400),
                new Point(400,500),
                new Point(500,500),
                new Point(500,400),
                new Point(450,350),
                new Point(400,400)
            };
                List<Point> pts2 = new List<Point>
            {
                new Point(10,10),
                new Point(10,150),
                new Point(150,150),
                new Point(150,10),
                new Point(10,10)
            };
                List<List<Point>> pts = new List<List<Point>>() { pts1, pts2 }; //包含几个矩阵，就绘制几个多边形
                Scalar color = new Scalar(0, 100, 33);
                Cv2.FillPoly(src, pts, color, LineTypes.Link8, 0, new Point(0, 0));//多边形填充绘制
                Cv2.Polylines(src, pts, true, scalar, 10, LineTypes.AntiAlias, 0);//绘制多边形 

                Cv2.DrawContours(src, pts, -1, new Scalar(0, 255, 0), -1, LineTypes.AntiAlias);//contourIdx参数：绘制轮廓的编号，如果是负数，则绘制所有的轮廓

                Cv2.PutText(src, "Opencv", new Point(0, 100), HersheyFonts.Italic, 3, color, 1, LineTypes.AntiAlias, false);//绘制文本 
                return src;
            });
            this.Source = mat.ToWriteableBitmap();
        }

        /// <summary>
        /// Draws the rectangle.
        /// </summary>
        /// <param name="src">The mat. 操作图像.</param>
        /// <param name="leftTop">The left top.矩形左上角坐标</param>
        /// <param name="rightBottom">The right bottom.矩形右下角坐标</param>
        /// <param name="color">The color.填充颜色</param>
        /// <param name="thickness">The thickness.边框粗细</param>
        /// <param name="lineType">Type of the line.边框类型</param>
        /// <param name="shift">The shift.缩放参数</param>
        public void DrawRectangle(Mat src, Point leftTop, Point rightBottom, Scalar color, int thickness = 1,
            LineTypes lineType = LineTypes.Link8, int shift = 0) => Cv2.Rectangle(src, leftTop, rightBottom, color, thickness, lineType, shift);

        /// <summary>
        /// Draws the line.
        /// </summary>
        /// <param name="src">The mat. 操作图像.</param>
        /// <param name="leftTop">The left top.矩形左上角坐标</param>
        /// <param name="rightBottom">The right bottom.矩形右下角坐标</param>
        /// <param name="color">The color.填充颜色</param>
        /// <param name="thickness">The thickness.边框粗细</param>
        /// <param name="lineType">Type of the line.边框类型</param>
        /// <param name="shift">The shift.缩放参数</param>
        public void DrawLine(Mat src, Point leftTop, Point rightBottom, Scalar color, int thickness = 1,
            LineTypes lineType = LineTypes.Link8, int shift = 0) => Cv2.Line(src, leftTop, rightBottom, color, thickness, lineType, shift);

        /// <summary>
        /// Draws the circle.
        /// </summary>
        /// <param name="src">The source.操作图像</param>
        /// <param name="center">The center.圆形中心点</param>
        /// <param name="radius">The radius.圆半径</param>
        /// <param name="color">The color.填充颜色</param>
        /// <param name="thickness">The thickness.边框粗细</param>
        /// <param name="lineType">Type of the line.边框类型</param>
        /// <param name="shift">The shift.缩放参数</param>
        public void DrawCircle(Mat src, Point center, int radius, Scalar color, int thickness = 1, LineTypes lineType = LineTypes.Link8, int shift = 0) => Cv2.Circle(src, center, radius, color, thickness, lineType, shift);

        /// <summary>
        /// Draws the ellipse.
        /// </summary>
        /// <param name="src">The source. 操作图像</param>
        /// <param name="center">The center.中心点</param>
        /// <param name="axes">The axes.椭圆长轴和短轴长度为边界的矩形区域，椭圆就绘制在这个矩形区域</param>
        /// <param name="angle">The angle.椭圆旋转角度</param>
        /// <param name="startAngle">The start angle.椭圆起始角度</param>
        /// <param name="endAngle">The end angle.椭圆结束角度</param>
        /// <param name="color">The color.填充颜色</param>
        /// <param name="thickness">The thickness.边框粗细</param>
        /// <param name="lineType">Type of the line.边框类型</param>
        /// <param name="shift">The shift.缩放参数</param>
        public void DrawEllipse(Mat src, Point center, Size axes, double angle, double startAngle, double endAngle, Scalar color,
                    int thickness = 1, LineTypes lineType = LineTypes.Link8, int shift = 0) => Cv2.Ellipse(src, center, axes, angle, startAngle, endAngle, color, thickness, lineType, shift);
        /// <summary>
        /// Draws the polylines. 未填充
        /// </summary>
        /// <param name="src">The source.操作图像</param>
        /// <param name="pts">The PTS.多边形点集合，包含几个矩阵，就绘制几个多边形</param>
        /// <param name="isClosed">if set to <c>true</c> [is closed]. 是否闭合，如为False，您将获得连接所有点的折线，而不是闭合形状</param>
        /// <param name="color">The color.填充颜色</param>
        /// <param name="thickness">The thickness.边框粗细</param>
        /// <param name="lineType">Type of the line.边框类型</param>
        /// <param name="shift">The shift.</param>
        public void DrawPolylines(Mat src, IEnumerable<IEnumerable<Point>> pts, bool isClosed, Scalar color, int thickness = 1, LineTypes lineType = LineTypes.Link8, int shift = 0) => Cv2.Polylines(src, pts, isClosed, color, thickness, lineType, shift);

        /// <summary>
        /// Draws the fill poly. 绘制填充的多边形
        /// </summary>
        /// <param name="src">The source.操作图像</param>
        /// <param name="pts">The PTS.多边形点集合，包含几个矩阵，就绘制几个多边形</param>
        /// <param name="color">The color.填充颜色</param>
        /// <param name="lineType">Type of the line.边框类型</param>
        /// <param name="shift">The shift.缩放参数</param>
        /// <param name="offset">The offset.偏移</param>
        public void DrawFillPoly(Mat src, IEnumerable<IEnumerable<Point>> pts, Scalar color, LineTypes lineType = LineTypes.Link8, int shift = 0, Point? offset = null) => Cv2.FillPoly(src, pts, color, lineType, shift, offset);
    }
}
