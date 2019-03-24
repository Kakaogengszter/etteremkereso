using sajatGuiDataGridView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sajatGuiDataGridView.View
{
    internal partial class formModositUsers : Form
    {
        private users users;

        public formModositUsers(users u)
        {
            InitializeComponent();
            this.users = u;
            megjelenitUsersAdatokat();


        }
        public users getModositottUsers()
        {
            return users;
        }

        private void megjelenitUsersAdatokat()
        {
            textBoxNev.Text = users.getUsername();
            textBoxEmail.Text = users.getEmail();
        }

        private void buttonSaveUsers_Click(object sender, EventArgs e)
        {
            users.setUsername(textBoxNev.Text);
            users.setEmail(textBoxEmail.Text);
            this.Close();
        }
    }
}
