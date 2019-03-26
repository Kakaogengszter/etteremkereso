using ConnectToMysqlDatabase;
using CryptSharp;
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
    public partial class FormLogin : Form
    {
        private MySQLDatabaseInterface mdi;
        private DataTable userDT;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas();
            mdi.open();
            string Username = textBoxUsername.Text;
            string Password = textBoxJelszo.Text;
           
                userDT = mdi.getToDataTable("SELECT username,password FROM user WHERE username = '" + Username + "'");
                if (userDT.Rows.Count != 0)
                {

                    foreach (DataRow row in userDT.Rows)
                    {
                        if (Crypter.CheckPassword(Password, row["password"].ToString()))
                        {
                            this.Hide();
                            Form1 lg = new Form1();
                            lg.ShowDialog();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Helytelen Jelszó!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Helytelen Felhasználónév!");
                    mdi.close();
                }
        }
            
        
    }
}
