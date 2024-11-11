using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace InfoAboutFile2._0
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("FileName", "File Name");
            dataGridView1.Columns.Add("ImageSize", "Image Size");
            dataGridView1.Columns.Add("Resolution", "Resolution");
            dataGridView1.Columns.Add("ColorDepth", "Color Depth");
            dataGridView1.Columns.Add("Compression", "Compression");
        }

        private void ProcessImage(string filePath, string fileName)
        {
            try
            {
                using (Bitmap bitmap = new Bitmap(filePath))
                {
                    int width = bitmap.Width;
                    int height = bitmap.Height;
                    float dpiX = bitmap.HorizontalResolution;
                    float dpiY = bitmap.VerticalResolution;
                    float widthInInches = width / dpiX;
                    float heightInInches = height / dpiY;
                    PixelFormat format = bitmap.PixelFormat;
                    int bitsPerPixel = Image.GetPixelFormatSize(format);
                    dataGridView1.Rows.Add(fileName,
                        $"{width}x{height}",
                        $"inch: {widthInInches:F2}x{heightInInches:F2}, dot: {dpiX}x{dpiY}",
                        $"{bitsPerPixel} bits/pixel",
                        $"{new FileInfo(filePath).Length} bytes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing image {fileName}: {ex.Message}");
            }
        }

        private void ExtractImagesFromZip(string zipPath)
        {
            try
            {
                using (var zipArchive = ZipFile.OpenRead(zipPath))
                {
                    foreach (var entry in zipArchive.Entries)
                    {
                        if (entry.FullName.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                            entry.FullName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                            entry.FullName.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                        {
                            using (var stream = entry.Open())
                            {
                                string tempFilePath = Path.GetTempFileName();
                                using (var fileStream = new FileStream(tempFilePath, FileMode.Create))
                                {
                                    stream.CopyTo(fileStream);
                                }

                                ProcessImage(tempFilePath, entry.FullName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while extracting images: {ex.Message}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ChooseZip_Click_1(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "ZIP Files (*.zip)|*.zip";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExtractImagesFromZip(openFileDialog1.FileName);
            }
        }

        private void ChooseImage_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ProcessImage(openFileDialog1.FileName, openFileDialog1.FileName);
            }
        }
    }
}