using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerSurveySystem.classes
{
    class User
    {
        private string username;
        private string password;
        private string type;
        private int id;

        public string Username
        {
            get{return username; }
            set{username = value;}
        }
        public string Password
        {
            get{ return password;}
            set{password = value;}
        }
        public string Type
        {
            get{return type; }
            set{type = value;}
        }
        public int Id
        {
            get{return id;}
            set{ id = value; }
        }
    }
}
