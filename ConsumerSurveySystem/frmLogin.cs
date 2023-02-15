using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace ConsumerSurveySystem
{
    public partial class frmLogin : Form
    {
        int loginFails = 0;
        int inc = 10;
        database con = new database();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                con.openConnection();
                string query = "select * from user where username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(query, con.Con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.closeConnection();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    string type = ds.Tables[0].Rows[0][3].ToString();
                    if (type == "admin")
                    {
                        this.Hide();
                        frmAdmin frm = new frmAdmin();
                        frm.Show();
                    }
                    else
                    {
                        this.Hide();
                        frmConsumer frm = new frmConsumer();
                        frm.Show();
                    }
                }
                else
                {
                    loginFails += 1;
                    MessageBox.Show("" + loginFails.ToString() + " failed attempt(s) to login into the system. You will be temporarily locked out after 3 attempts!", "Wrong Password or Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (loginFails.Equals(3))
                    {

                        timerSplash.Start();


                        lbnNotification.Visible = true;

                        txtPassword.Enabled = false;
                        txtUsername.Enabled = false;

                        button1.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill the empty fields","Login Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Interval = 1000;
            inc += 5;
            if(inc >= 425)
            {
                timerSplash.Stop();
                lbnNotification.Visible = false;
                txtPassword.Enabled = true;
                txtUsername.Enabled = true;
                button1.Enabled = true;
                inc = 10;
                loginFails = 0;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
