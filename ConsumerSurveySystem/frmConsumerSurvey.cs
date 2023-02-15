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
    public partial class frmConsumerSurvey : Form
    {
        string questionType;
        int current = 0;
        int total;
        List<int> questionIds = new List<int>();
        List<string> answers = new List<string>();

        List<string> UserResponses = new List<string>();
        database db = new database();
        int surveyId;
        public frmConsumerSurvey()
        {
            InitializeComponent();
        }

        private void FrmConsumerSurvey_Load(object sender, EventArgs e)
        {
            surveyId = frmConsumer.SurveyId;

            DataSet ds = selectSurvey();
            try
            {
                if (!panel.Controls.Contains(UserControlIntro.Instance))
                {
                    panel.Controls.Add(UserControlIntro.Instance);
                    UserControlIntro.Instance.Dock = DockStyle.Fill;
                    UserControlIntro.Instance.BringToFront();
                }
                else
                {
                    UserControlIntro.Instance.BringToFront();
                }
                UserControlIntro.Instance.Title = ds.Tables[0].Rows[0][2].ToString();
                UserControlIntro.Instance.OD = ds.Tables[0].Rows[0][3].ToString();
                UserControlIntro.Instance.CD = ds.Tables[0].Rows[0][4].ToString();
                UserControlIntro.Instance.Description = ds.Tables[0].Rows[0][5].ToString();
                btnNext.Enabled = true;
            }
            catch
            {
                MessageBox.Show("you can not undertake the same survey twice", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;

            }

        }

        private DataSet selectSurvey()
        {
            string query = "select * from survey where Id = " + surveyId + "";

            return db.select(query);
        }
        private void saveQuestionAndAnswers()
        {
            
            if (panel.Controls.Contains(UserControlYesOrNo.Instance) && questionType == "YesOrNo")
            {
                questionIds.Add(UserControlYesOrNo.Instance.ID);
                UserResponses.Add(UserControlYesOrNo.Instance.Answer);
            }
            else if (panel.Controls.Contains(UserControlDropdown.Instance) && questionType == "Dropdown")
            {
                questionIds.Add(UserControlDropdown.Instance.ID);
                UserResponses.Add(UserControlDropdown.Instance.Answer);
            }
            else if (panel.Controls.Contains(UserControlRadioButton.Instance) && questionType == "Rate")
            {
                questionIds.Add(UserControlRadioButton.Instance.ID);
                UserResponses.Add(UserControlRadioButton.Instance.Answer);
            }
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            string query = "select * from question where surveyId = " + surveyId + "";

            DataSet ds = db.select(query);
            total = ds.Tables[0].Rows.Count;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (current < total)
                {
                    if (ds.Tables[0].Rows[current][2].ToString() == "YesOrNo")
                    {
                        questionType = "YesOrNo";
                        if (!panel.Controls.Contains(UserControlYesOrNo.Instance))
                        {
                            panel.Controls.Add(UserControlYesOrNo.Instance);
                            UserControlYesOrNo.Instance.Dock = DockStyle.Fill;
                            UserControlYesOrNo.Instance.BringToFront();
                        }
                        else
                        {
                            UserControlYesOrNo.Instance.BringToFront();
                        }
                        UserControlYesOrNo.Instance.Question = ds.Tables[0].Rows[current][3].ToString();
                        UserControlYesOrNo.Instance.ID = int.Parse(ds.Tables[0].Rows[current][0].ToString());
                        
                    }
                    else if (ds.Tables[0].Rows[current][2].ToString() == "Dropdown")
                    {
                        questionType = "Dropdown";
                        if (!panel.Controls.Contains(UserControlDropdown.Instance))
                        {
                            panel.Controls.Add(UserControlDropdown.Instance);
                            UserControlDropdown.Instance.Dock = DockStyle.Fill;
                            UserControlDropdown.Instance.BringToFront();
                        }
                        else
                        {
                            UserControlDropdown.Instance.BringToFront();
                        }
                        UserControlDropdown.Instance.Question = ds.Tables[0].Rows[current][3].ToString();
                        UserControlDropdown.Instance.ID = int.Parse(ds.Tables[0].Rows[current][0].ToString());
                        DataSet ds1 = db.select("select * from response where questionId =" + ds.Tables[0].Rows[current][0].ToString() + "");
                        foreach (DataRow dr in ds1.Tables[0].Rows)
                        {
                            answers.Add(dr.ItemArray.GetValue(2).ToString());
                        }
                        UserControlDropdown.Instance.Answers = answers;
                    }
                    else if (ds.Tables[0].Rows[current][2].ToString() == "Radiobutton")
                    {
                        questionType = "Radiobutton";
                        if (!panel.Controls. Contains(UserControlRadioButton.Instance))
                        {
                            panel.Controls.Add(UserControlRadioButton.Instance);
                            UserControlRadioButton.Instance.Dock = DockStyle.Fill;
                            UserControlRadioButton.Instance.BringToFront();
                        }
                        else
                        {
                            UserControlRadioButton.Instance.BringToFront();
                        }
                        UserControlRadioButton.Instance.Question = ds.Tables[0].Rows[current][3].ToString();
                        UserControlRadioButton.Instance.ID = int.Parse(ds.Tables[0].Rows[current][0].ToString());

                    }
                    
                    current += 1;
                    if (current == total)
                    {
                        btnNext.Enabled = false;
                        
                    }
                }
                
                
            }
            else
            {
                MessageBox.Show("Cannot view question coz there are no questions in survey", "View erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string query;
            int count = UserResponses.Count;
            for(int i = 0; i < count; i++)
            {
               
                int id = db.codeGenerator("userResponse");
                query = "Insert into userResponse Values(" + id + "," + questionIds[i]+", '" + UserResponses[i]+"')";

                if(db.insert(query))
                {
                    query = "select * from question where id = " + questionIds[i] + "";
                    DataSet ds = db.select(query);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int response = 0;
                        DataRow dr = ds.Tables[0].Rows[0];
                        if (dr.ItemArray.GetValue(4).ToString() != "")
                        {
                            response = int.Parse(dr.ItemArray.GetValue(4).ToString());
                        }

                        response += 1;
                        query = "update question set responses =" + response + " where id = " + questionIds[i] + "";
                        if (db.update(query))
                        {

                        }
                        else
                        {
                            MessageBox.Show("failed to enter number of responses", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("failed to save", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            MessageBox.Show("Survey answers saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(current == total)
            {
                saveQuestionAndAnswers();
                btnSave.Enabled = true;
            }
            else
            {
                saveQuestionAndAnswers();
            }
            button1.Enabled = false;
        }
    }
}
