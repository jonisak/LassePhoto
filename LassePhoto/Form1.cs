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

        Bitmap SelectedImage;
        Graphics Graphics;
        Color SelectedColor;
        int TextSize;
        string m_initialOpenFileDir = "";
        string m_initialSaveFileDir = "";

        public Form1()
        {
            InitializeComponent();
            this.TextSize = 20;
            numericUpDown1.Value = 20;
            SelectedColor = Color.Black;
            btnSelectColor.BackColor = SelectedColor;

        }




        private void btnOpenImage_Click(object sender, EventArgs e)
        {

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (m_initialOpenFileDir.Length > 0)
            {
                openFileDialog.InitialDirectory = m_initialOpenFileDir;
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



                    m_initialOpenFileDir = Path.GetDirectoryName(file);


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
            if (m_initialSaveFileDir.Length > 0)
            {
                saveFileDialog.InitialDirectory = m_initialSaveFileDir;
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



                    m_initialSaveFileDir = Path.GetDirectoryName(file);

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
    }
}
