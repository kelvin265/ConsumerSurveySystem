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
    public partial class frmAdmin : Form
    {
        database db = new database();
        public static int userId,ProductId,SurveyId;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            if (frm.Visible)
            {

            }
            else
            {
                frm.Show();
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            viewUserList();
            viewProductList();
            viewSurveyList();
        }

        //viewing available users
        public void viewUserList()
        {
            string query = "select * from user";
            DataSet ds = db.select(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewUser.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridViewUser.Rows.Add();
                    dataGridViewUser.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridViewUser.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(1).ToString();
                    dataGridViewUser.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(2).ToString();
                    dataGridViewUser.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(3).ToString();
                }
            }
        }

        //viewing available users
        public void viewSurveyList()
        {
            string query = "select s.Id, p.name, s.title, s.openDate, s.closeDate, s.description from survey s, product p where p.Id = s.productId";
            DataSet ds = db.select(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewSurvey.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridViewSurvey.Rows.Add();
                    dataGridViewSurvey.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridViewSurvey.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(1).ToString();
                    dataGridViewSurvey.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(2).ToString();
                    dataGridViewSurvey.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(3).ToString();
                    dataGridViewSurvey.Rows[n].Cells[4].Value = dr.ItemArray.GetValue(4).ToString();
                    dataGridViewSurvey.Rows[n].Cells[5].Value = dr.ItemArray.GetValue(5).ToString();
                }
            }
        }

        //viewing available products
        public void viewProductList()
        {
            string query = "select * from product";
            DataSet ds = db.select(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewProduct.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridViewProduct.Rows.Add();
                    dataGridViewProduct.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridViewProduct.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(1).ToString();
                    dataGridViewProduct.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(2).ToString();
                    dataGridViewProduct.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(3).ToString();
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

            viewUserList();
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {

            string query;
            int count = dataGridViewUser.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if(dataGridViewUser.Rows[i].Cells[4].Value != null){
                        userId = int.Parse(dataGridViewUser.Rows[i].Cells[0].Value.ToString());
                        query = "delete from user where id=" + userId + "";
                        if (db.delete(query))
                        {
                            MessageBox.Show("User '" + dataGridViewUser.Rows[i].Cells[1].Value.ToString() + "' has been successfully removed ", "Delete info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        

                    }
                }
                viewUserList();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int count = dataGridViewUser.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewUser.Rows[i].Cells[4].Value != null)
                    {
                        items += 1;
                        if(items < 2)
                        {
                            userId = int.Parse(dataGridViewUser.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one user only to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewUserList();
                            return;
                        }
                    }
                    else if(i == count - 1)
                    {
                        if(items == 0)
                        {
                            MessageBox.Show("please select the user to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewUserList();
                            return;
                        }
                    }
                    
                }
                frmUpdateUser frm = new frmUpdateUser();
                frm.Show();
            }
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            int count = dataGridViewProduct.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewProduct.Rows[i].Cells[4].Value != null)
                    {
                        items += 1;
                        if (items < 2)
                        {
                            ProductId = int.Parse(dataGridViewProduct.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one product only to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewProductList();
                            return;
                        }
                    }
                    else if (i == count - 1)
                    {
                        if (items == 0)
                        {
                            MessageBox.Show("please select the product to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewProductList();
                            return;
                        }
                    }

                }
                frmUpdateProduct frm = new frmUpdateProduct();
                frm.Show();
            }
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            string query;
            int count = dataGridViewProduct.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewProduct.Rows[i].Cells[4].Value != null)
                    {
                        ProductId = int.Parse(dataGridViewProduct.Rows[i].Cells[0].Value.ToString());
                        query = "delete from product where id=" + ProductId + "";
                        if (db.delete(query))
                        {
                            
                            MessageBox.Show("User '" + dataGridViewProduct.Rows[i].Cells[1].Value.ToString() + "' has been successfully removed ", "Delete info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridViewProduct.Rows.Clear();
                        }


                    }
                }
                viewProductList();
            }

        }

        private void BtnAddNewSurvey_Click(object sender, EventArgs e)
        {
            frmAddSurvey frm = new frmAddSurvey();
            if (frm.Visible)
            {

            }
            else
            {
                frm.Show();
            }
        }

        private void BtnRefreshSurvey_Click(object sender, EventArgs e)
        {
            viewSurveyList();
        }

        private void BtnUpdateSurvey_Click(object sender, EventArgs e)
        {
            int count = dataGridViewSurvey.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewSurvey.Rows[i].Cells[6].Value != null)
                    {
                        items += 1;
                        if (items < 2)
                        {
                            SurveyId = int.Parse(dataGridViewSurvey.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one survey only to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewSurveyList();
                            return;
                        }
                    }
                    else if (i == count - 1)
                    {
                        if (items == 0)
                        {
                            MessageBox.Show("please select the survey to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewSurveyList();
                            return;
                        }
                    }

                }
                frmUpdateSurvey frm = new frmUpdateSurvey();
                frm.Show();
            }
        }

        private void BtnDeleteSurvey_Click(object sender, EventArgs e)
        {
            string query;
            int count = dataGridViewSurvey.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewSurvey.Rows[i].Cells[4].Value != null)
                    {
                        SurveyId = int.Parse(dataGridViewSurvey.Rows[i].Cells[0].Value.ToString());
                        query = "delete from survey where id=" + SurveyId + "";
                        if (db.delete(query))
                        {

                            MessageBox.Show("Survey '" + dataGridViewSurvey.Rows[i].Cells[2].Value.ToString() + "' has been successfully removed ", "Delete info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridViewSurvey.Rows.Clear();
                        }


                    }
                }
                viewSurveyList();
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            int count = dataGridViewSurvey.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewSurvey.Rows[i].Cells[6].Value != null)
                    {
                        SurveyId = int.Parse(dataGridViewSurvey.Rows[i].Cells[0].Value.ToString());
                        frmSurvey frm = new frmSurvey();
                        frm.Show();
                    }
                }
            }
        }

        private void BtnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frm = new frmAddProduct();
            if (frm.Visible)
            {

            }
            else
            {
                frm.Show();
                frm.Visible = true;
            }
        }

        private void BtnRefreshProduct_Click(object sender, EventArgs e)
        {
            viewProductList();
        }
    }
}
