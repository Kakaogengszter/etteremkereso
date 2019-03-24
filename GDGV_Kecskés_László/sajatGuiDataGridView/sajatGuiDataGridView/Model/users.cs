using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectToMysqlDatabase;
using System.Data;

namespace sajatGuiDataGridView.Model
{
    class users
    {
        private int uid;
        private string username;
        private string email;
        private string password;

        public users(int uid, string username, string email, string password)
        {
            this.uid = uid;
            this.username = username;
            this.email = email;
            this.password = password;
        }

        public int getuid()
        {
            return uid;
        }

        public string getUsername()
        {
            return username;
        }

        public string getEmail()
        {
            return email;
        }

        public string getPassword()
        {
            return password;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }


        public void setEmail(string email)
        {
            this.email = email;
        }

        public override string ToString()
        {
            return username + "Felhasználónév" + email + "Email cím";
        }





    }
}
