using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Job_Application_Manager
{
    public partial class AccountTypeReg : Form
    {
        private JobHunterSignUpForm? JobHunterTypeAccountRegister;
        private CompanySignUp? CompanyTypeAccountRegister;
        public AccountTypeReg()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void JobHunterAccType_Click(object sender, EventArgs e)
        {
            if (JobHunterTypeAccountRegister == null || JobHunterTypeAccountRegister.IsDisposed)
            {
                JobHunterTypeAccountRegister = new JobHunterSignUpForm();
                JobHunterTypeAccountRegister.Show();
                this.Close();
            }
            else
            {
                JobHunterTypeAccountRegister.BringToFront();
            }
        }

        private void CompanyTypeAcc_Click(object sender, EventArgs e)
        {
            if (CompanyTypeAccountRegister == null || CompanyTypeAccountRegister.IsDisposed)
            {
                CompanyTypeAccountRegister = new CompanySignUp();
                CompanyTypeAccountRegister.Show();
                this.Close();
            }
            else
            {
                CompanyTypeAccountRegister.BringToFront();
            }
        }
    }
}
