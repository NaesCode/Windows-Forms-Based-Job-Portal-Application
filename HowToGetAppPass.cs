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
    public partial class HowToGetAppPass : Form
    {
        public HowToGetAppPass()
        {
            InitializeComponent();
            label7.ForeColor = Color.Firebrick;
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
