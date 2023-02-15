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
    public partial class frmUpdateUser : Form
    {
        database db = new database();
        int id;
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        private void FrmUpdateUser_Load(object sender, EventArgs e)
        {
            id = frmAdmin.userId;
            selectUsers();
 
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "" && cmbType.Text != "")
            {
                string query = "update user set username = '" + txtUsername.Text + "', password = '" + txtPassword.Text + "', type ='" + cmbType.Text + "' where id = " + id + "";
                if (db.update(query))
                {
                    MessageBox.Show("User details successfully updated", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update user details", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void selectUsers()
        {
            string query = "select * from user where id = " + id + "";
            DataSet ds = db.select(query);
            if(ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtPassword.Text = dr.ItemArray.GetValue(2).ToString();
                cmbType.Text = dr.ItemArray.GetValue(3).ToString();
                txtUsername.Text = dr.ItemArray.GetValue(1).ToString();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
