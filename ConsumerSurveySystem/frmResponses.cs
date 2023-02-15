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
    public partial class frmResponses : Form
    {
        database db = new database();
        public int Id;
        string body;
        public frmResponses()
        {
            InitializeComponent();
        }

        private void FrmResponses_Load(object sender, EventArgs e)
        {
            Id = frmSurvey.QuestionId;
            selectQuestionTitle();
            questionResponses();
        }

        void selectQuestionTitle()
        {
            string query = "select * from question where Id=" + Id + "";
            DataSet ds = db.select(query);
            if(ds.Tables[0].Rows.Count > 0)
            {
                txtQuestion.Text = ds.Tables[0].Rows[0][3].ToString();
               
            }
        }

        void questionResponses()
        {
            int number = 0;
            string query = "select * from userResponse where questionId = "+Id+"";
            DataSet ds = db.select(query);
            if(ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewResponses.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    number += 1;
                    int n = dataGridViewResponses.Rows.Add();
                    dataGridViewResponses.Rows[n].Cells[0].Value = number.ToString();
                    dataGridViewResponses.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(1).ToString();
                    dataGridViewResponses.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(2).ToString();
                 
                }
            }
        }
    }
}
