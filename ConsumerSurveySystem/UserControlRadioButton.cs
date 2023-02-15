using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumerSurveySystem
{
    public partial class UserControlRadioButton : UserControl
    {
        private static UserControlRadioButton _instance;
        private string question;
        private int Id;
        private string answer;
        public static UserControlRadioButton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlRadioButton();
                }
                return _instance;
            }
        }
        [Category("Custom Properties")]
        public string Question
        {
            get { return question; }
            set { question = value; txtQuestion.Text = value; }
        }
        [Category("Custom Properties")]
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        [Category("Custom Properties")]
        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public UserControlRadioButton()
        {
            InitializeComponent();
        }

        private void RbtnSDisagree_CheckedChanged(object sender, EventArgs e)
        {
            Answer = "strongly disagree";
        }

        private void RbtnDisagree_CheckedChanged(object sender, EventArgs e)
        {
            Answer = "disagree";
        }

        private void RbtnNeutral_CheckedChanged(object sender, EventArgs e)
        {
            Answer = "neutral";
        }

        private void RbtnAgree_CheckedChanged(object sender, EventArgs e)
        {
            Answer = "agree";
        }

        private void RbtnStronglyAgree_CheckedChanged(object sender, EventArgs e)
        {
            Answer = "strongly agree";
        }
    }
}
