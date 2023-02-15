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
    public partial class frmNewQuestion : Form
    {
        int count;
        database db = new database();
        int surveyId;
        int questionId;
        public string questionType;
        string answer;
        int answerId;
        public frmNewQuestion()
        {
            InitializeComponent();
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            if(rbtnYesOrNo.Checked == true)
            {
                questionType = "YesOrNo";
                if (!panel.Controls.Contains(UserControlYesOrNo.Instance))
                {
                    panel.Controls.Add(UserControlYesOrNo.Instance);
                    UserControlYesOrNo.Instance.Dock = DockStyle.Fill;
                    UserControlYesOrNo.Instance.BringToFront();
                }
                else
                    UserControlYesOrNo.Instance.BringToFront();
            }
            else if (rbtnDropdown.Checked == true)
            {
                questionType = "Dropdown";
                if (!panel.Controls.Contains(UserControlDropdown.Instance))
                {
                    panel.Controls.Add(UserControlDropdown.Instance);
                    UserControlDropdown.Instance.Dock = DockStyle.Fill;
                    UserControlDropdown.Instance.BringToFront();
                }
                else
                    UserControlDropdown.Instance.BringToFront();
            }
            else if (rbtnRatingScale.Checked == true)
            {
                questionType = "Radiobutton";
                if (!panel.Controls.Contains(UserControlRadioButton.Instance))
                {
                    panel.Controls.Add(UserControlRadioButton.Instance);
                    UserControlRadioButton.Instance.Dock = DockStyle.Fill;
                    UserControlRadioButton.Instance.BringToFront();
                }
                else
                    UserControlRadioButton.Instance.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select required question type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (rbtnYesOrNo.Checked == true)
            {
                questionType = "YesOrNo";
                panelQuestion.Show();
            }
            else if (rbtnDropdown.Checked == true)
            {
                questionType = "Dropdown";
                panelQuestionAndAnswer.Show();
            }
            else if (rbtnRatingScale.Checked == true)
            {
                questionType = "Radiobutton";
                panelQuestion.Show();
            }
            else
            {
                MessageBox.Show("Please select required question type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("'" + questionType + "'");
        }

        private void BtnBack1_Click(object sender, EventArgs e)
        {
            panelQuestion.Hide();
            
        }

        private void BtnSave1_Click(object sender, EventArgs e)
        {
            addQuestion(txtQuestion1.Text);
        }


        private void BtnBack2_Click(object sender, EventArgs e)
        {
            panelQuestionAndAnswer.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(txtAnswer.Text != "")
            {
                string value = txtAnswer.Text;
                cmbQAnswers.Items.Add(value);
                txtAnswer.Text = "";
                MessageBox.Show("answer added");
            }
            else
            {
                MessageBox.Show("Please enter desired answer");
            }
        }

        private void BtnSave2_Click(object sender, EventArgs e)
        {
            if(cmbQAnswers.Items.Count > 0 && txtQuestion2.Text != "")
            {
                addQuestion(txtQuestion2.Text);
                addAnswer();
            }
        }

        private void FrmNewQuestion_Load(object sender, EventArgs e)
        {
            surveyId = frmSurvey.surveyId;
        }

        private void addQuestion(string question)
        {
            
            questionId = db.codeGenerator("question");
            if (question != "")
            {
                string query = "insert into question(Id,surveyId,questionType,body) Values(" + questionId + "," + surveyId + ",'" + questionType + "','" + question + "')";
                if (db.insert(query))
                {
                    MessageBox.Show("question added successfully", "Save info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void addAnswer()
        {
            count = cmbQAnswers.Items.Count;
            if(count > 0)
            {
                for(int i=0; i < count; i++)
                {
                    answer = cmbQAnswers.Items[i].ToString();
                    answerId = db.codeGenerator("response");
                    string query = "insert into response Values(" + answerId + "," + questionId + ",'" + answer + "')";
                    if(db.insert(query))
                    {
                        MessageBox.Show("Response '"+answer+"' saved successfully", "Save info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
        }
    }
}
