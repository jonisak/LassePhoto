using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LassePhoto
{
    public partial class frmPreview : Form
    {
        public Image Img { get; set; }

        public frmPreview(Image img)
        {
            InitializeComponent();
            this.imgView.Image = img;

        }
    }
}
