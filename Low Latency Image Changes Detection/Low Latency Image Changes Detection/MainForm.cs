using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using static Low_Latency_Image_Changes_Detection.NativeAPIs;

namespace Low_Latency_Image_Changes_Detection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectImageButtons_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectImageDialog = new OpenFileDialog
            {
                Title = "Select An Image:",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = ".png",
                Filter = "Png Files (*.png)|*.png",
            };

            if (selectImageDialog.ShowDialog() == DialogResult.OK)
            {

                Button clickedButton = (Button)sender;
                if (clickedButton == firstSelectImageButton)
                {
                    firstImageTextBox.Text = selectImageDialog.FileName;
                }
                else
                {
                    secondImageTextBox.Text = selectImageDialog.FileName;
                }
            }

        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            if (
                firstImageTextBox.Text.Length == 0 ||
                secondImageTextBox.Text.Length == 0)
            {
                return;
            }

            Bitmap firstSnapshot = new Bitmap(firstImageTextBox.Text);
            Bitmap secondSnapshot = new Bitmap(secondImageTextBox.Text);

            if (firstSnapshot.Size != secondSnapshot.Size)
            {
                return;
            }

            Rectangle screenRect = new Rectangle(
                new Point(0, 0),
                new Size(
                    firstSnapshot.Size.Width,
                    firstSnapshot.Size.Height
                )
            );

            List<Rectangle> screenBlocks = new List<Rectangle>();
            List<Rectangle> changedBlocks = new List<Rectangle>();

            for (int x = 0, i = screenRect.Width - 1; x <= i; x += 85)
            {

                int widthChunck = 85;
                if (x + 85 > screenRect.Width)
                {
                    widthChunck = screenRect.Width - x;
                }

                Rectangle screenBlock = new Rectangle(x, screenRect.Y, widthChunck, screenRect.Height);
                for (int Y = 0, ii = screenBlock.Height - 1; Y <= ii; Y += 85)
                {
                    int heightChunk = 85;
                    if (Y + 85 > screenBlock.Height)
                    {
                        heightChunk = screenBlock.Height - Y;
                    }
                    screenBlocks.Add(new Rectangle(screenBlock.X, Y, screenBlock.Width, heightChunk));
                }
            }

            Stopwatch latencyWatch = new Stopwatch();
            latencyWatch.Start();

            foreach (Rectangle scanBlock in screenBlocks)
            {

                BitmapData firstBlockData = firstSnapshot.LockBits(scanBlock, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData secondBlockData = secondSnapshot.LockBits(scanBlock, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                int blockStride = Math.Abs(secondBlockData.Stride) * firstBlockData.Height;

                if (memcmp(firstBlockData.Scan0, secondBlockData.Scan0, (IntPtr)blockStride) != 0)
                {
                    changedBlocks.Add(scanBlock);
                }

                firstSnapshot.UnlockBits(firstBlockData);
                secondSnapshot.UnlockBits(secondBlockData);

            }

            latencyWatch.Stop();
            LatencyLabel.Text = string.Format("Latency: {0} ms, total changes: {1}", latencyWatch.ElapsedMilliseconds, changedBlocks.Count.ToString());

            if (changedBlocks.Count > 0)
            {

                using (Graphics graphicsEngine = Graphics.FromImage(firstSnapshot))
                {
                    graphicsEngine.DrawRectangles(Pens.Red, changedBlocks.ToArray());
                }
                imagePictureBox.Image = firstSnapshot;

            }
            else
            {
                MessageBox.Show("No changes dected", "-", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
