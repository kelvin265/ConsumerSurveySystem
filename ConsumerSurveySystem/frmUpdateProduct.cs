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
    public partial class frmUpdateProduct : Form
    {
        database db = new database();
        int id;
        public frmUpdateProduct()
        {
            InitializeComponent();
        }

        private void FrmUpdateProduct_Load(object sender, EventArgs e)
        {
            id = frmAdmin.ProductId;
            selectProduct();
        }

        private void selectProduct()
        {
            string query = "select * from product where id = " + id + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtDescription.Text = dr.ItemArray.GetValue(2).ToString();
                cmbType.Text = dr.ItemArray.GetValue(3).ToString();
                txtName.Text = dr.ItemArray.GetValue(1).ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDescription.Text != "" && cmbType.Text != "")
            {
                string query = "update product set name = '" + txtName.Text + "', description = '" + txtDescription.Text + "', type ='" + cmbType.Text + "' where id = " + id + "";
                if (db.update(query))
                {
                    MessageBox.Show("Product details successfully updated", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update product details", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
    }
}
