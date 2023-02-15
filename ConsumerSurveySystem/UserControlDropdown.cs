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
    public partial class UserControlDropdown : UserControl
    {
        List<string> answers;
        private string question;
        private int Id;
        private string answer;
        private static UserControlDropdown _instance;

        public static UserControlDropdown Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlDropdown();
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
        [Category("Custom Properties")]
        public List<string> Answers
        {
            get { return answers; }
            set { answers = value;
                comboBox1.Items.Clear();
                int count = Answers.Count;
                for (int i = 0; i < count; i++)
                {
                    comboBox1.Items.Add(Answers[i]);
                }
            }
        }
        public UserControlDropdown()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Answer = answers[comboBox1.SelectedIndex];
        }

        private void UserControlDropdown_Load(object sender, EventArgs e)
        {
            
        }
    }
}
