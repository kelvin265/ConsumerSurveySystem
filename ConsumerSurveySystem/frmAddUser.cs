using ConsumerSurveySystem.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumerSurveySystem
{
    public partial class frmAddUser : Form
    {
        
        
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "" && cmbType.Text != "")
            {
                Admin admin = new Admin(txtPassword.Text, txtUsername.Text, cmbType.Text);
                admin.registerUser();
                txtPassword.Text = "";
                txtUsername.Text = "";
                cmbType.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }

        }

        
    }
}
