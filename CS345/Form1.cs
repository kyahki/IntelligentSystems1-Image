using System.Diagnostics;
using System.Windows.Forms;

namespace CS345
{
    public partial class Form1 : Form
    {
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
            int width = Math.Min(loaded.Width, processed.Width);
            int height = Math.Min(loaded.Height, processed.Height);

            resultImage = new Bitmap(width, height);
            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);
                    Color backpixel = processed.GetPixel(x, y);

                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractValue = Math.Abs(grey - greygreen);

                    if (subtractValue > threshold)
                    {
                        resultImage.SetPixel(x, y, backpixel);
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, pixel);
                    }
                }
            }

            pictureBox3.Image = resultImage;
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
                    int newRed = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int newGreen = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int newBlue = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);


                    newRed = Math.Min(255, newRed);
                    newGreen = Math.Min(255, newGreen);
                    newBlue = Math.Min(255, newBlue);

                    Color sepia = Color.FromArgb(newRed, newGreen, newBlue);
                    processed.SetPixel(x, y, sepia);
                }
            }
            pictureBox3.Image = processed;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                int[] histogram = new int[256];


                for (int x = 0; x < processed.Width; x++)
                {
                    for (int y = 0; y < processed.Height; y++)
                    {
                        Color pixel = processed.GetPixel(x, y);
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
    }
}