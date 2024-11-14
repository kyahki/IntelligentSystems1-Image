using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OpenCvSharp;
using AForge.Video;
using AForge.Video.DirectShow;
using Point = System.Drawing.Point;
using static System.Net.Mime.MediaTypeNames;
using ImageProcess2;

namespace CS345
{

    public partial class Form1 : Form
    {
        private VideoCaptureDevice webcam;
        private FilterInfoCollection webcamList;

        Bitmap loaded, processed, colorgreen, resultImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mirrorHoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(loaded.Width - x - 1, y);
                    processed.SetPixel(x, y, pixel);
                }
            }
            pictureBox2.Image = processed;
        }

        private void dIPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                }
            pictureBox2.Image = processed;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void greyscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int average;
            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    average = (pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(average, average, average);
                    processed.SetPixel(x, y, gray);
                }
            pictureBox2.Image = processed;
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int average;
            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    Color inv = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processed.SetPixel(x, y, inv);
                }
            pictureBox2.Image = processed;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk_2(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processed = new Bitmap(openFileDialog2.FileName);
            pictureBox2.Image = processed;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            subtractToolStripMenuItem_Click(sender, e);
        }

        private void openForImage2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void saveForImage3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
        }

        private void saveFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            resultImage.Save(saveFileDialog2.FileName);
        }

        private void serpiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    Color sep = Color.FromArgb(
                        Math.Min(255, (int)((0.393 * pixel.R) + (0.769 * pixel.G) + (0.189 * pixel.B))),
                        Math.Min(255, (int)((0.349 * pixel.R) + (0.686 * pixel.G) + (0.168 * pixel.B))),
                        Math.Min(255, (int)((0.272 * pixel.R) + (0.534 * pixel.G) + (0.131 * pixel.B)))
                    );
                    processed.SetPixel(x, y, sep);
                }
            }
            pictureBox3.Image = processed;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                int[] histogram = new int[256];


                for (int x = 0; x < loaded.Width; x++)
                {
                    for (int y = 0; y < loaded.Height; y++)
                    {
                        Color pixel = loaded.GetPixel(x, y);
                        int intensity = (pixel.R + pixel.G + pixel.B) / 3;
                        histogram[intensity]++;
                    }
                }


                Bitmap histogramImage = new Bitmap(256, 100);
                using (Graphics g = Graphics.FromImage(histogramImage))
                {
                    g.Clear(Color.White);
                    int max = histogram.Max();


                    for (int i = 0; i < 256; i++)
                    {
                        int barHeight = (int)((histogram[i] / (float)max) * 100);
                        g.DrawLine(Pens.Black, new Point(i, 100), new Point(i, 100 - barHeight));
                    }
                }

                pictureBox3.Image = histogramImage;
            }
        }

        private void mirrorVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, loaded.Height - y - 1);
                    processed.SetPixel(x, y, pixel);
                }
            }
            pictureBox2.Image = processed;
        }

        private void cameraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            webcamList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            webcam = new VideoCaptureDevice(webcamList[0].MonikerString);
            webcam.NewFrame += new NewFrameEventHandler(webcam_NewFrame);
            webcam.Start();
        }
        private void webcam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = frame;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(processed.Width, processed.Height);
            int threshold = 150;

            for (int x = 0; x < processed.Width; x++)
            {
                for (int y = 0; y < processed.Height; y++)
                {
                    Color pixel = processed.GetPixel(x, y);
                    Color backpixel = loaded.GetPixel(x, y);
                    if (pixel.G > threshold && pixel.R < threshold / 2 && pixel.B < threshold / 2)
                        resultImage.SetPixel(x, y, backpixel);
                    else
                        resultImage.SetPixel(x, y, pixel);
                }
            }

            pictureBox3.Image = resultImage;
        }

        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool succes = BitmapFilter.Smooth(loaded, 1);
            pictureBox3.Image = loaded;
        }

        private void guassianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool succes = BitmapFilter.GaussianBlur(loaded, 4);

            pictureBox3.Image = loaded;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool succes = BitmapFilter.Sharpen(loaded, 11);

            pictureBox3.Image = loaded;
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool succes = BitmapFilter.GaussianBlur(loaded, 9);

            pictureBox3.Image = loaded;
        }

        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool succes = BitmapFilter.EmbossLaplacian(loaded);

            pictureBox3.Image = loaded;
        }

        private void edgeDetectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool succes = BitmapFilter.EdgeDetectQuick(loaded);

            pictureBox3.Image = loaded;
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool succes = BitmapFilter.EmbossLaplacianVertical(loaded);

            pictureBox3.Image = loaded;
        }

        private void horizontalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool succes = BitmapFilter.EmbossLaplacianHorizontal(loaded);

            pictureBox3.Image = loaded;
        }

        private void horzVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool succes = BitmapFilter.EmbossLaplacianHorzVert(loaded);

            pictureBox3.Image = loaded;
        }

        private void allDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool succes = BitmapFilter.EmbossLaplacianAllDir(loaded);

            pictureBox3.Image = loaded;
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool succes = BitmapFilter.EmbossLaplacianLossy(loaded);

            pictureBox3.Image = loaded;
        }
    }
}