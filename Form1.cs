using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace InfoAboutFile2._0
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1;

        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;

                    using (Stream str = openFileDialog1.OpenFile())
                    {
                        FileInfo fileInfo = new FileInfo(filePath);
                        NameVal.Text = fileInfo.Name;
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
                            SizeVal.Text = width.ToString() + "x" + height.ToString();
                            PerVal.Text = "inch: " + widthInInches.ToString() + "x" + heightInInches.ToString() + ", dot: " + dpiX.ToString() + "x" + dpiY.ToString();
                            ColorVal.Text = bitsPerPixel.ToString() + " bits/pixel";
                            ComVal.Text = fileInfo.Length.ToString();
                        }
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
