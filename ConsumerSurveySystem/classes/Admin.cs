using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumerSurveySystem.classes
{
    class Admin : User
    {
        database db = new database();
        public Admin(string password, string username, string type)
        {
            Password = password;
            Username = username;
            Type = type;
        }

        public void registerUser()
        {
            Id = db.codeGenerator("user");
            string query = " INSERT INTO user(id,username,password,type) VALUES(" + Id + ",'" + Username + "','" + Password + "','" + Type + "')";
            bool result = db.insert(query);
            if (result)
            {
                MessageBox.Show("User registered successfully as '" + Type + "'", "Register info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to register the user !", "Register error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
