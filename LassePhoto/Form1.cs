using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LassePhoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.TextSize = 20;
            numericUpDown1.Value = 20;
        }


        Bitmap SelectedImage;
        Graphics Graphics;
        Color SelectedColor;
        int TextSize;
        


        //private bool IsSelecting = false;
        //// The area we are selecting.
        //private int X0, Y0, X1, Y1;

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            int size = -1;
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {


                    SelectedImage = new Bitmap(file);
                    //imgView.Image = (Bitmap)SelectedImage.Clone();
                    imgView.Image = (Bitmap)SelectedImage;

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
            //imgView.Image = null;


            //imgView.Image = (Bitmap)SelectedImage.Clone();
            //Graphics = System.Drawing.Graphics.FromImage(imgView.Image);

            //Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            //var brush = new SolidBrush(Color.FromArgb(255, (byte)this.SelectedColor.R, (byte)this.SelectedColor.G, (byte)this.SelectedColor.B));
            //Graphics.DrawString(txtImageText.Text, new Font("Tahoma", this.TextSize), brush, new PointF(0, 0));



            //imgView.Refresh();

        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = saveFileDialog.FileName;
                try
                {
                    imgView.Image.Save(saveFileDialog.FileName);


                    //Jonas


                }
                catch (Exception ex)
                {
                }
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            imgView.Image = (Bitmap)SelectedImage.Clone();
            Graphics = System.Drawing.Graphics.FromImage(imgView.Image);

            Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            var brush = new SolidBrush(Color.FromArgb(255, (byte)this.SelectedColor.R, (byte)this.SelectedColor.G, (byte)this.SelectedColor.B));
            Graphics.DrawString(txtImageText.Text, new Font("Tahoma", this.TextSize), brush, new PointF(0, 0));


            //RectangleF header2Rect = new RectangleF();
            //using (Font useFont = new Font("Gotham Medium", 28, FontStyle.Bold))
            //{
            //    header2Rect.Location = new Point(30, 105);
            //    header2Rect.Size = new Size(600, ((int)e.Graphics.MeasureString(header2, useFont, 600, StringFormat.GenericTypographic).Height));
            //    e.Graphics.DrawString(header2, useFont, Brushes.Black, header2Rect);
            //}



        }

        private void imgView_Paint_1(object sender, PaintEventArgs e)
        {
            //string header2 = "This is a much, much longer Header";
            //string description = "This is a description of the header.";

            RectangleF header2Rect = new RectangleF();
            using (Font useFont = new Font("Gotham Medium", 28, FontStyle.Bold))
            {
                header2Rect.Location = new Point(30, 105);
                header2Rect.Size = new Size(600, ((int)e.Graphics.MeasureString(txtImageText.Text, useFont, 600, StringFormat.GenericTypographic).Height));
                e.Graphics.DrawString(txtImageText.Text, useFont, Brushes.Black, header2Rect);
            }

            //RectangleF descrRect = new RectangleF();
            //using (Font useFont = new Font("Gotham Medium", 28, FontStyle.Italic))
            //{
            //    descrRect.Location = new Point(30, (int)header2Rect.Bottom);
            //    descrRect.Size = new Size(600, ((int)e.Graphics.MeasureString(description, useFont, 600, StringFormat.GenericTypographic).Height));
            //    e.Graphics.DrawString(description.ToLower(), useFont, SystemBrushes.WindowText, descrRect);
            //}
        }

        private void imgView_Paint(object sender, PaintEventArgs e)
        {

            //using (Font myFont = new Font("Arial", 14))
            //{
            //    e.Graphics.DrawString("Hello .NET Guide!", myFont, Brushes.Green, new Point(2, 2));
            //}
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnSelectColor.BackColor = colorDialog.Color;
                this.SelectedColor = colorDialog.Color;


            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.TextSize = (int)numericUpDown1.Value;
        }





   


 

    }
}
