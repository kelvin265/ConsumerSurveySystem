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
    public partial class UserControlYesOrNo : UserControl
    {
        private static UserControlYesOrNo _instance;
        private string question;
        private int Id;
        private string answer;
        public static UserControlYesOrNo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlYesOrNo();
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
            set { answer = value;}
        }
        [Category("Custom Properties")]
        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public UserControlYesOrNo()
        {
            InitializeComponent();
        }

        private void RbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            Answer = "No";
        }

        private void RbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            Answer = "Yes";
        }
    }
}
