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
    public partial class frmAddSurvey : Form
    {
        database db = new database();
        List<int> productIds = new List<int>();
        int productId;
        public frmAddSurvey()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string openDate = DateFormatFixing(dtpOpenDate.Value.ToShortDateString());
            string closeDate = DateFormatFixing(dtpCloseDate.Value.ToShortDateString());
            if (cmbProduct.Text != "" && txtTitle.Text != "" && txtDescription.Text != "")
            {
                Survey survey = new Survey(productId, txtTitle.Text, openDate, closeDate, txtDescription.Text);
                survey.createSurvey();
                txtTitle.Text = "";
                txtDescription.Text = "";
                selectProducts();

            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            } 
        }

        private void selectProducts()
        {
            cmbProduct.Items.Clear();
            string query = "select * from product";
            DataSet ds = db.select(query);
            if(ds.Tables[0].Rows.Count > 0)
            {
                
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbProduct.Items.Add(dr[1].ToString());
                    productIds.Add(int.Parse(dr[0].ToString()));
                }
                cmbProduct.SelectedIndex = 0;
                productId = productIds[0];
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
        private void FrmAddSurvey_Load(object sender, EventArgs e)
        {
            selectProducts();
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item = cmbProduct.SelectedIndex;
            productId = productIds[item];
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
