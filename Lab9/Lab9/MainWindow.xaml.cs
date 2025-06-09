using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Lab9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnDraw_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtX0.Text, out double x0) ||
                !double.TryParse(txtY0.Text, out double y0) ||
                !double.TryParse(txtR.Text, out double R) || R <= 0 ||
                !double.TryParse(txtScale.Text, out double scale) || scale <= 0)
            {
                MessageBox.Show("Некоректні вхідні дані.");
                return;
            }

            int width = 700;
            int height = 500;

            using Bitmap bmp = new(width, height);
            using Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            float centerX = width / 2f;
            float centerY = height / 2f;

            Pen gridPen = new(Color.LightGray, 1);
            Pen axisPen = new(Color.Black, 2);
            Pen curvePen = new(Color.Blue, 2);
            Font font = new("Arial", 8);
            Brush labelBrush = Brushes.Black;

            for (float x = 0; x < width; x += (float)scale)
            {
                g.DrawLine(gridPen, x, 0, x, height);
                int val = (int)((x - centerX) / scale);
                if (val != 0) g.DrawString(val.ToString(), font, labelBrush, x + 2, centerY + 2);
            }

            for (float y = 0; y < height; y += (float)scale)
            {
                g.DrawLine(gridPen, 0, y, width, y);
                int val = (int)((centerY - y) / scale);
                if (val != 0) g.DrawString(val.ToString(), font, labelBrush, centerX + 2, y + 2);
            }

            g.DrawLine(axisPen, 0, centerY, width, centerY);
            g.DrawLine(axisPen, centerX, 0, centerX, height);
            g.DrawString("X", font, labelBrush, width - 15, centerY + 2);
            g.DrawString("Y", font, labelBrush, centerX + 2, 5);

            System.Drawing.PointF? last = null;
            for (double t = 0; t <= 2 * Math.PI; t += 0.01)
            {
                double x = x0 + R * Math.Cos(t);
                double y = y0 + R * Math.Sin(t);

                float px = (float)(centerX + x * scale);
                float py = (float)(centerY - y * scale);

                var pt = new System.Drawing.PointF(px, py);
                if (last != null)
                    g.DrawLine(curvePen, last.Value, pt);
                last = pt;
            }

            using MemoryStream ms = new();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            ms.Position = 0;

            BitmapImage image = new();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.StreamSource = ms;
            image.EndInit();

            imagePlot.Source = image;
        }
    }
}