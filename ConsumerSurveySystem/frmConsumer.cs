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
    public partial class frmConsumer : Form
    {
        public static int SurveyId;
        database db = new database();
        public frmConsumer()
        {
            InitializeComponent();
        }

        private void FrmConsumer_Load(object sender, EventArgs e)
        {
            viewSurveyList();
        }
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
                        frmConsumerSurvey frm = new frmConsumerSurvey();
                        frm.Show();
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            viewSurveyList();
        }
    }
}
