using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Manager
{
    public partial class FullPictureView : Form
    {
        public FullPictureView(byte[]? imageData)
        {
            InitializeComponent();
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                MessageBox.Show("No image data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
