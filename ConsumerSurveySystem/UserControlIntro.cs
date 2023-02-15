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
    public partial class UserControlIntro : UserControl
    {
        private string title;
        private string od;
        private string cd;
        private string description;
        private static UserControlIntro _instance;

        public static UserControlIntro Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlIntro();
                }
                return _instance;
            }
        }

        [Category("Custom Properties")]
        public string Title
        {
            get { return title; }
            set { title = value; lblTitle.Text = value; }
        }
        [Category("Custom Properties")]
        public string OD
        {
            get { return od; }
            set { od = value; lblOD.Text = value; }
        }
        public string CD
        {
            get { return cd; }
            set { cd = value; lblCD.Text = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; lblDescription.Text = value; }
        }
        public UserControlIntro()
        {
            InitializeComponent();
        }
    }
}
