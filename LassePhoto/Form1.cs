using LassePhoto.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LassePhoto
{
    public partial class Form1 : Form
    {

        Bitmap SelectedImage;
        Graphics Graphics;
        Color SelectedColor;
        int TextSize;

        public Form1()
        {
            InitializeComponent();
            this.TextSize = 20;
            numericUpDown1.Value = 20;
            SelectedColor = Color.Black;
            btnSelectColor.BackColor = SelectedColor;



            //Panel MyPanel = new Panel();
            //PictureBox pictureBox1 = new PictureBox();

            //Image image = Image.FromFile("image.png");

            ////pictureBox1.Image = image;
            ////pictureBox1.Height = image.Height;
            //pictureBox1.Width = image.Width;

            //MyPanel.Controls.Add(pictureBox1);
            //MyPanel.AutoScroll = true;
            //this.Controls.Add(MyPanel);
            panel1.AutoScroll = true;
            this.imgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;



        }




        private void btnOpenImage_Click(object sender, EventArgs e)
        {

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (Settings.Default.OpenFileDialoge != null && Settings.Default.OpenFileDialoge.Length > 0)
            {
                openFileDialog.InitialDirectory = Settings.Default.OpenFileDialoge;
            }
          



            int size = -1;
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    SelectedImage = new Bitmap(file);
                    imgView.Image = (Bitmap)SelectedImage;
                    txtImageText.Text = Path.GetFileNameWithoutExtension(file);



                    Settings.Default.OpenFileDialoge = Path.GetDirectoryName(file);
                    Settings.Default.Save();

                }
                catch (Exception ex)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.


        }

        private void txtImageText_TextChanged(object sender, EventArgs e)
        {
            imgView.Refresh();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Jpg Image|*.jpg";

            //saveFileDialog.FileName = openFileDialog.FileName;
            if (Settings.Default.SaveFileDialoge != null && Settings.Default.SaveFileDialoge.Length > 0)
            {
                saveFileDialog.InitialDirectory = Settings.Default.SaveFileDialoge;
            }
            saveFileDialog.FileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + "_kommentar" + Path.GetExtension(openFileDialog.FileName);



            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = saveFileDialog.FileName;
                try
                {


                    RectangleF header2Rect = new RectangleF();
                    Graphics = System.Drawing.Graphics.FromImage(imgView.Image);

                    using (Font useFont = new Font("Gotham Medium", Convert.ToInt32(numericUpDown1.Value), FontStyle.Bold))
                    {
                        var height = ((int)Graphics.MeasureString(txtImageText.Text, useFont, imgView.Image.Width, StringFormat.GenericTypographic).Height);
                        header2Rect.Location = new Point(0, imgView.Image.Height - height);
                        header2Rect.Size = new Size(imgView.Image.Width, ((int)Graphics.MeasureString(txtImageText.Text, useFont, imgView.Image.Width, StringFormat.GenericTypographic).Height));
                        var brush = new SolidBrush(Color.FromArgb(255, (byte)this.SelectedColor.R, (byte)this.SelectedColor.G, (byte)this.SelectedColor.B));

                        Graphics.DrawString(txtImageText.Text, useFont, brush, header2Rect);
                    }


                    Bitmap bm = new Bitmap(imgView.Image);
                    bm.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);



                    Settings.Default.SaveFileDialoge = Path.GetDirectoryName(file);
                    Settings.Default.Save();

                    MessageBox.Show("Bild sparad!");


                    imgView.Image = null;
                    Graphics = null;
                    txtImageText.Text = "";
                    imgView.Refresh();

                }
                catch (Exception ex)
                {
                }
            }

        }

        private void imgView_Paint_1(object sender, PaintEventArgs e)
        {

            if (imgView.Image == null)
            {
                return;
            }
            RectangleF header2Rect = new RectangleF();
            using (Font useFont = new Font("Gotham Medium", Convert.ToInt32(numericUpDown1.Value), FontStyle.Bold))
            {
                var height = ((int)e.Graphics.MeasureString(txtImageText.Text, useFont, imgView.Image.Width, StringFormat.GenericTypographic).Height);
                header2Rect.Location = new Point(0, imgView.Image.Height - height);
                var brush = new SolidBrush(Color.FromArgb(255, (byte)this.SelectedColor.R, (byte)this.SelectedColor.G, (byte)this.SelectedColor.B));
                header2Rect.Size = new Size(imgView.Image.Width, ((int)e.Graphics.MeasureString(txtImageText.Text, useFont, imgView.Image.Width, StringFormat.GenericTypographic).Height));
                e.Graphics.DrawString(txtImageText.Text, useFont, brush, header2Rect);
            }

        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnSelectColor.BackColor = colorDialog.Color;
                this.SelectedColor = colorDialog.Color;
                imgView.Refresh();

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.TextSize = (int)numericUpDown1.Value;
            imgView.Refresh();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            Bitmap bm = new Bitmap(imgView.Image);
            var myImage = bm.Clone() as Image;



            RectangleF header2Rect = new RectangleF();
            Graphics Gra = System.Drawing.Graphics.FromImage(myImage);

            using (Font useFont = new Font("Gotham Medium", Convert.ToInt32(numericUpDown1.Value), FontStyle.Bold))
            {
                var height = ((int)Gra.MeasureString(txtImageText.Text, useFont, imgView.Image.Width, StringFormat.GenericTypographic).Height);
                header2Rect.Location = new Point(0, imgView.Image.Height - height);
                header2Rect.Size = new Size(imgView.Image.Width, ((int)Gra.MeasureString(txtImageText.Text, useFont, imgView.Image.Width, StringFormat.GenericTypographic).Height));
                var brush = new SolidBrush(Color.FromArgb(255, (byte)this.SelectedColor.R, (byte)this.SelectedColor.G, (byte)this.SelectedColor.B));

                Gra.DrawString(txtImageText.Text, useFont, brush, header2Rect);
            }

            var frm = new frmPreview(myImage);

            frm.ShowDialog();

        }


        private void btnRotateImage_Click(object sender, EventArgs e)
        {

            Size size = imgView.Size;


            //Bitmap bm = new Bitmap(imgView.Image);
            //imgView.Image = RotateImage(bm, 90);
            imgView.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            //imgView.Height = imgView.Image.Height;
            //imgView.Width = imgView.Image.Width;


            //Size size2 = new Size(size.Height, size.Width);
            //imgView.Size = size2;
            imgView.Invalidate();

            imgView.Update();
            panel1.Refresh();
            imgView.Refresh();
        }


        ///// <summary>
        ///// method to rotate an image either clockwise or counter-clockwise
        ///// </summary>
        ///// <param name="img">the image to be rotated</param>
        ///// <param name="rotationAngle">the angle (in degrees).
        ///// NOTE: 
        ///// Positive values will rotate clockwise
        ///// negative values will rotate counter-clockwise
        ///// </param>
        ///// <returns></returns>
        //public static Image RotateImage(Image img, float rotationAngle)
        //{
        //    //create an empty Bitmap image
        //    Bitmap bmp = new Bitmap(img.Width, img.Height);

        //    //turn the Bitmap into a Graphics object
        //    Graphics gfx = Graphics.FromImage(bmp);

        //    //now we set the rotation point to the center of our image
        //    gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

        //    //now rotate the image
        //    gfx.RotateTransform(rotationAngle);

        //    gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

        //    //set the InterpolationMode to HighQualityBicubic so to ensure a high
        //    //quality image once it is transformed to the specified size
        //    gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

        //    //now draw our new image onto the graphics object
        //    gfx.DrawImage(img, new Point(0, 0));

        //    //dispose of our Graphics object
        //    gfx.Dispose();

        //    //return the image
        //    return bmp;
        //}
    }
}
