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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDescription.Text != "" && cmbType.Text != "")
            {
                Product product = new Product(txtName.Text, txtDescription.Text, cmbType.Text);
                product.registerProduct();
                txtDescription.Text = "";
                txtName.Text = "";
                cmbType.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
