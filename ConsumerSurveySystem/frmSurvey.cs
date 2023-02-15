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
    public partial class frmSurvey : Form
    {
        database db = new database();
        public static int surveyId, QuestionId;
        int questionId;
        public frmSurvey()
        {
            InitializeComponent();
        }

        private void BtnNewQuestion_Click(object sender, EventArgs e)
        {
            frmNewQuestion frm = new frmNewQuestion();
            if (frm.Visible)
            {

            }
            else
            {
                frm.Show();
            }
        }

        private void FrmSurvey_Load(object sender, EventArgs e)
        {
            surveyId = frmAdmin.SurveyId;
            selectTite();
            viewQuestions();
        }

        private void selectTite()
        {
            string query = "select title from survey where id = " + surveyId + "";
            DataSet ds = db.select(query);
            if(ds.Tables[0].Rows.Count > 0)
            {
                lblTitle.Text = ds.Tables[0].Rows[0][0].ToString();
            }
        }

        private void viewQuestions()
        {
            string query = "select * from question where surveyId = " + surveyId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewQuestion.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridViewQuestion.Rows.Add();
                    dataGridViewQuestion.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridViewQuestion.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(2).ToString();
                    dataGridViewQuestion.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(3).ToString();
                    dataGridViewQuestion.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(4).ToString();
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            viewQuestions();
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            string query;
            int count = dataGridViewQuestion.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i <= count - 1; i++)
                {
                    if (dataGridViewQuestion.Rows[i].Cells[4].Value != null)
                    {
                        questionId = int.Parse(dataGridViewQuestion.Rows[i].Cells[0].Value.ToString());
                        query = "delete from question where id=" + questionId + "";
                        if (db.delete(query))
                        {

                            MessageBox.Show("Survey '" + dataGridViewQuestion.Rows[i].Cells[2].Value.ToString() + "' has been successfully removed ", "Delete info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridViewQuestion.Rows.Clear();
                        }


                    }
                }
                viewQuestions();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int count = dataGridViewQuestion.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewQuestion.Rows[i].Cells[4].Value != null)
                    {
                        QuestionId = int.Parse(dataGridViewQuestion.Rows[i].Cells[0].Value.ToString());
                        frmResponses frm = new frmResponses();
                        frm.Show();
                    }
                }
            }
        }
    }
}
