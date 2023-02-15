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
    public partial class frmUpdateSurvey : Form
    {
        database db = new database();
        int id;
        List<int> productIds = new List<int>();
        int productId;
        public frmUpdateSurvey()
        {
            InitializeComponent();
        }

        private void FrmUpdateSurvey_Load(object sender, EventArgs e)
        {
            id = frmAdmin.SurveyId;
            selectProducts();
            selectSurvey();
        }

        private void selectProducts()
        {
            int index = 0;
            cmbProduct.Items.Clear();
            string query = "select * from product";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    index += 1;
                    cmbProduct.Items.Add(dr[1].ToString());
                    productIds.Add(int.Parse(dr[0].ToString()));
                    if( id == int.Parse(dr[0].ToString()))
                    {
                        cmbProduct.SelectedIndex = index-1;
                        productId = productIds[index-1];
                    }
                }
                
                
            }
            else
            {
                MessageBox.Show("no product has been added. Please add a new product first", "System error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item = cmbProduct.SelectedIndex;
            productId = productIds[item];
        }
        private void selectSurvey()
        {
            string query = "select * from survey where id = " + id + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtTitle.Text = dr.ItemArray.GetValue(2).ToString();
                dtpOpenDate.Value = Convert.ToDateTime(dr.ItemArray.GetValue(3).ToString());
                dtpCloseDate.Value = Convert.ToDateTime(dr.ItemArray.GetValue(4).ToString());
                txtDescription.Text = dr.ItemArray.GetValue(5).ToString();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string openDate = DateFormatFixing(dtpOpenDate.Value.ToShortDateString());
            string closeDate = DateFormatFixing(dtpCloseDate.Value.ToShortDateString());
            if (cmbProduct.Text != "" && txtTitle.Text != "" && txtDescription.Text != "")
            {
                string query = "update survey set productId = " + productId + ", title = '" + txtTitle.Text + "', openDate ='" + openDate + "', closeDate ='" + closeDate + "', description ='" + txtDescription.Text + "' where id = " + id + "";
                if (db.update(query))
                {
                    MessageBox.Show("Survey details successfully updated", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update survey details", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
