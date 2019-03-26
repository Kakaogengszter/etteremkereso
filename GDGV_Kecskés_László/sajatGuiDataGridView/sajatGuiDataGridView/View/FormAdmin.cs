using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectToMysqlDatabase;
using sajatGuiDataGridView.Model;
using sajatGuiDataGridView.View;

namespace sajatGuiDataGridView
{
    public partial class Form1 : Form
    {
        private MySQLDatabaseInterface mdi;
        ///<value>Adatbázisból való beolvasás után ebben a táblában vannak a halfajadatok</value> 
        private DataTable ettermekDT;
        private DataTable usersDT;
        private DataTable kommentekDT;
        private DataGridViewComboBoxColumn columnGyakorisag;

        public Form1()
        {
            InitializeComponent();
        }
        private bool lettModositva = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            beallitVezerloketIndulaskor();
        }

        #region Tab 1 éttermek

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            feltoltVezerlotAdatbazisbolMindenAdattal();
            beallitVezerloketNemSzerkeszthetoAdateleressel();
        }

        private void beallitVezerloketIndulaskor()
        {
            buttonUjEtterem.Visible = false;
            buttonModosit.Visible = false;
            buttonTorles.Visible = false;
            buttonMentes.Visible = false;
            buttonMegsem.Visible = false;
        }

        private void buttonKilep_Click(object sender, EventArgs e)
        {
            feltoltVezerlotAdatbazisbolMindenAdattal();
            beallitVezerloketNemSzerkeszthetoAdateleressel();

            if (lettModositva)
            {
                if (MessageBox.Show(
                    "Nem mentett adatok vannak! Valóban ki akar lépni?",
                    "Kilépés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mdi.close();
                    this.Close();
                }
            }
            else
            {
                mdi.close();
                this.Close();
            }
        }
        private void feltoltVezerlotAdatbazisbolMindenAdattal()
        {
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas(); mdi.open();
            ettermekDT = mdi.getToDataTable("SELECT * FROM etterem");
            dataGridViewEttermek.DataSource = ettermekDT;
           

        }


        private void beallitVezerloketNemSzerkeszthetoAdateleressel()
        {        //gombok beállítása     
            buttonUjEtterem.Visible = true;
            buttonModosit.Visible = true;
            buttonTorles.Visible = true;
            buttonMentes.Visible = false;
            buttonMegsem.Visible = true;

            //dataGridView beállítása     
            dataGridViewEttermek.ReadOnly = true;
            dataGridViewEttermek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEttermek.AllowUserToDeleteRows = false;

            buttonUjEtterem.Enabled = true;
            buttonModosit.Enabled = true;
            buttonTorles.Enabled = true;

            lettModositva = false;
        }

        private void buttonModosit_Click(object sender, EventArgs e)
        {
            beallitVezerloketDataGridViewSzerkesztoUzemmodba();
        }

        private void beallitVezerloketDataGridViewSzerkesztoUzemmodba()
        {     //gombok beállítása    
            buttonUjEtterem.Visible = false;
            buttonModosit.Visible = false;
            buttonTorles.Visible = false;
            buttonMentes.Visible = true;

            //dataGridView beállítása 

            dataGridViewEttermek.ReadOnly = false;
            dataGridViewEttermek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEttermek.AllowUserToDeleteRows = false;
            //új gombot kell felvenni, mert a szerkesztés akár megszakítható is     
            buttonKilep.Visible = true;
            //módosítás beállítása    
            lettModositva = false;
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            try
            {        
                //meghatározzuk a kijelölt sort        
                int sor = dataGridViewEttermek.SelectedRows[0].Index;
                if (MessageBox.Show(
                    "Valóban törölni akarja a sort?",
                    "Törlés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                    ) == DialogResult.Yes)
                {
                    //töröljük a sort a DataGridView-ból                     
                    dataGridViewEttermek.Rows.RemoveAt(sor);
                    //Lehetővé tesszük a mentést                     
                    buttonMentes.Visible = true;
                    lettModositva = true;
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        "Jelölje ki a törlendő sort!",
                        "Törlés",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            if (!lettModositva)
            {

                MessageBox.Show
                    ("Nem lett módosítva egy adat sem.",
                    "Módosítás",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else
            {
                mdi.updateChangesInTable(ettermekDT);
                beallitVezerloketNemSzerkeszthetoAdateleressel();
            }



        }
        private void beallitVezerloketUjAdatfelvitelkor()
        {
            buttonUjEtterem.Visible = false;
            buttonMentes.Enabled = true;
            buttonMentes.Visible = true;
            buttonModosit.Enabled = false;
            buttonTorles.Enabled = false;
            buttonKilep.Visible = true;
            buttonKilep.Enabled = true;
            dataGridViewEttermek.AllowUserToAddRows = true;
            dataGridViewEttermek.SelectionMode = DataGridViewSelectionMode.CellSelect;

            buttonMentes.Visible = true;


        }

        private void buttonUjEtterem_Click(object sender, EventArgs e)
        {
            beallitVezerloketUjAdatfelvitelkor();
            int sor = dataGridViewEttermek.Rows.Count - 1;
            dataGridViewEttermek.Rows[sor].Cells[0].Selected = true;

            dataGridViewEttermek.Rows[sor].Cells[0].Value = "Írja ide az új adatot";
            dataGridViewEttermek.ReadOnly = false;
            for (int i = 0; i < sor; i = i + 1) dataGridViewEttermek.Rows[i].ReadOnly = true;
            dataGridViewEttermek.FirstDisplayedScrollingRowIndex = sor;
            dataGridViewEttermek.Columns[3].ReadOnly = true;

            this.ActiveControl = textBoxNev;
        }

        private void dataGridViewEttermek_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sor = dataGridViewEttermek.SelectedRows[0].Index;
            int Id = Convert.ToInt32(dataGridViewEttermek.SelectedRows[0].Cells["Id"].Value);

            ettermek h = new ettermek(
                dataGridViewEttermek.SelectedRows[0].Cells["Nev"].Value.ToString(),
                dataGridViewEttermek.SelectedRows[0].Cells["Tipus"].Value.ToString(),
                dataGridViewEttermek.SelectedRows[0].Cells["Cim"].Value.ToString(),
                Convert.ToInt32(dataGridViewEttermek.SelectedRows[0].Cells["Id"].Value)
            );

            formModosit fh = new formModosit(h);

            if (fh.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("Sikeres módosítás!");
                ettermek modositottEtterem = fh.getModositottEttermek();

                Adatbazis updataDatabase = new Adatbazis();


                MySQLDatabaseInterface umdi = updataDatabase.kapcsolodas();
                umdi.open();

                string query = "";
                query += "UPDATE etterem ";
                query += "SET Nev=\"" + modositottEtterem.getNev() + "\"";
                query += ", Tipus=\" " + modositottEtterem.getTipus() + "\"";
                query += ", Cim=\" " + modositottEtterem.getCim() + "\"";
                query += " WHERE Id= " + modositottEtterem.getId();



                MessageBox.Show(query);

                umdi.executeDMQuery(query);

                MessageBox.Show("Sikeres módosítás:" + modositottEtterem.ToString());
                umdi.close();



                dataGridViewEttermek.Rows[sor].Cells["Nev"].Value = modositottEtterem.getNev();
                dataGridViewEttermek.Rows[sor].Cells["Tipus"].Value = modositottEtterem.getTipus();
                dataGridViewEttermek.Rows[sor].Cells["Cim"].Value = modositottEtterem.getCim();


            }
        }

        private void buttonUjEtteremFelv_Click(object sender, EventArgs e)
        {
            Adatbazis ujida = new Adatbazis();
            MySQLDatabaseInterface mdiujid = ujida.kapcsolodas();
            mdiujid.open();
            int Id = Convert.ToInt32(mdiujid.executeScalarQuery("SELECT MAX(Id) FROM etterem"));
            int ujId = Id + 1;
            mdiujid.close();

            string nev = textBoxNev.Text;
            string tipus = textBoxTipus.Text;
            string cim = textBoxCim.Text;

            Adatbazis updateDatabase = new Adatbazis();
            MySQLDatabaseInterface umdi = updateDatabase.kapcsolodas();
            umdi.open(); string query = "";
            query += "INSERT INTO etterem (Id,Nev,Tipus,Cim) VALUES ";
            query += "(" + ujId + ", ";
            query += "\"" + nev + "\", ";
            query += "\"" + tipus + "\", ";
            query += "\"" + cim + ")";
            umdi.executeDMQuery(query);
            MessageBox.Show(query);

            MessageBox.Show("Sikeres Adatfelvétel");
            umdi.close();

            int sor = dataGridViewEttermek.Rows.Count - 1;

            dataGridViewEttermek.Rows[sor].Cells["Id"].Value = ujId;
            dataGridViewEttermek.Rows[sor].Cells["Nev"].Value = nev;
            dataGridViewEttermek.Rows[sor].Cells["Tipus"].Value = tipus;
            dataGridViewEttermek.Rows[sor].Cells["Cim"].Value = cim;
        }

        private void comboBoxSzurGyakorisag_SelectionChangeCommitted(object sender, EventArgs e)
        {
            feltoltVezerlotAdatbazisbolMindenAdattal();
        }

        private void comboBoxSzurGyakorisag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        /*private void comboBoxSzurGyakorisag_DropDownClosed(object sender, EventArgs e)
       {
           Adatbazis a = new Adatbazis();
           mdi = a.kapcsolodas();
           mdi.open();
           //ettermekDT = mdi.getToDataTable("SELECT * FROM tipus WHERE Tipus='" + comboBoxSzurGyakorisag.SelectedValue.ToString()+ "'") ;
           dataGridViewEttermek.DataSource = ettermekDT;
       }*/

        #endregion


        #region Tab 2 Felhasználók

        private void buttonBetoltesUsers_Click(object sender, EventArgs e)
        {
            feltoltVezerlotAdatbazisbolMindenAdattalUsers();
            beallitVezerloketNemSzerkeszthetoAdateleresselUsers();
        }

        private void beallitVezerloketIndulaskorUsers()
        {
            buttonModositUsers.Visible = false;
            buttonTorolUsers.Visible = false;
            buttonMentUsers.Visible = false;
            buttonCancelUsers.Visible = false;

        }

        private void buttonExitUsers_Click(object sender, EventArgs e)
        {
            feltoltVezerlotAdatbazisbolMindenAdattalUsers();
            beallitVezerloketNemSzerkeszthetoAdateleresselUsers();

            if (lettModositva)
            {
                if (MessageBox.Show(
                    "Nem mentett adatok vannak! Valóban ki akar lépni?",
                    "Kilépés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mdi.close();
                    this.Close();
                }
            }
            else
            {
                mdi.close();
                this.Close();
            }
        }

        private void feltoltVezerlotAdatbazisbolMindenAdattalUsers()
        {
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas(); mdi.open();
            usersDT = mdi.getToDataTable("SELECT * FROM user");
            dataGridViewUsers.DataSource = usersDT;

        }

        private void beallitVezerloketNemSzerkeszthetoAdateleresselUsers()
        {       
            //gombok beállítása     
            buttonModositUsers.Visible = true;
            buttonTorolUsers.Visible = true;
            buttonMentUsers.Visible = false;
            buttonCancelUsers.Visible = true;

            //dataGridView beállítása     
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.AllowUserToDeleteRows = false;

            buttonModositUsers.Enabled = true;
            buttonTorolUsers.Enabled = true;

            lettModositva = false;
        }

        private void buttonModositUsers_Click(object sender, EventArgs e)
        {
            beallitVezerloketDataGridViewSzerkesztoUzemmodbaUsers();
        }

        private void beallitVezerloketDataGridViewSzerkesztoUzemmodbaUsers()
        {    
            //gombok beállítása    
            buttonModositUsers.Visible = false;
            buttonTorolUsers.Visible = false;
            buttonMentUsers.Visible = true;

            //dataGridView beállítása 

            dataGridViewUsers.ReadOnly = false;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            //új gombot kell felvenni, mert a szerkesztés akár megszakítható is     
            buttonKilep.Visible = true;
            //módosítás beállítása    
            lettModositva = false;
        }

        private void buttonTorolUsers_Click(object sender, EventArgs e)
        {
            try
            {
                //meghatározzuk a kijelölt sort        
                int sor = dataGridViewUsers.SelectedRows[0].Index;
                if (MessageBox.Show(
                    "Valóban törölni akarja a sort?",
                    "Törlés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                    ) == DialogResult.Yes)
                {
                    //töröljük a sort a DataGridView-ból                     
                    dataGridViewUsers.Rows.RemoveAt(sor);
                    //Lehetővé tesszük a mentést                     
                    buttonMentUsers.Visible = true;
                    lettModositva = true;
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        "Jelölje ki a törlendő sort!",
                        "Törlés",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonMentUsers_Click(object sender, EventArgs e)
        {
            if (!lettModositva)
            {

                MessageBox.Show
                    ("Nem lett módosítva egy adat sem.",
                    "Módosítás",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else
            {
                mdi.updateChangesInTable(usersDT);
                beallitVezerloketNemSzerkeszthetoAdateleresselUsers();
            }


        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sor = dataGridViewUsers.SelectedRows[0].Index;
            int Id = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["uid"].Value);

            users u = new users(
                Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["uid"].Value),
                dataGridViewUsers.SelectedRows[0].Cells["username"].Value.ToString(),
                dataGridViewUsers.SelectedRows[0].Cells["email"].Value.ToString(),
                dataGridViewUsers.SelectedRows[0].Cells["password"].Value.ToString()
                
            );

            formModositUsers fmu = new formModositUsers(u);

            if (fmu.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("Sikeres módosítás!");
                users modositottUsers = fmu.getModositottUsers();

                Adatbazis updataDatabase = new Adatbazis();


                MySQLDatabaseInterface umdi = updataDatabase.kapcsolodas();
                umdi.open();

                string query = "";
                query += "UPDATE user ";
                query += "SET username=\"" + modositottUsers.getUsername() + "\"";
                query += ", email=\" " + modositottUsers.getEmail() + "\"";
                query += " WHERE uid= " + modositottUsers.getuid();



                MessageBox.Show(query);

                umdi.executeDMQuery(query);

                MessageBox.Show("Sikeres módosítás:" + modositottUsers.ToString());
                umdi.close();



                dataGridViewUsers.Rows[sor].Cells["username"].Value = modositottUsers.getUsername();
                dataGridViewUsers.Rows[sor].Cells["email"].Value = modositottUsers.getEmail();
                


            }
        }

        #endregion


        #region Tab 3 kommentek



        private void dataGridViewUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lettModositva = true;
        }

        private void buttonAdatokKommentek_Click(object sender, EventArgs e)
        {
            feltoltVezerlotAdatbazisbolMindenAdattalKomment();
            beallitVezerloketNemSzerkeszthetoAdateleresselKomment();
        }

        private void beallitVezerloketIndulaskorKommentek()
        {
            buttonTorolKomment.Visible = false;
            buttonMentUsers.Visible = false;
            buttonCancelUsers.Visible = false;

        }

        private void buttonKilepKommentek_Click(object sender, EventArgs e)
        {
            feltoltVezerlotAdatbazisbolMindenAdattalKomment();
            beallitVezerloketNemSzerkeszthetoAdateleresselKomment();

            if (lettModositva)
            {
                if (MessageBox.Show(
                    "Nem mentett adatok vannak! Valóban ki akar lépni?",
                    "Kilépés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mdi.close();
                    this.Close();
                }
            }
            else
            {
                mdi.close();
                this.Close();
            }
        }
        private void feltoltVezerlotAdatbazisbolMindenAdattalKomment()
        {
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas(); mdi.open();
            kommentekDT = mdi.getToDataTable("SELECT * FROM comments");
            dataGridViewKommentek.DataSource = kommentekDT;

        }

        private void beallitVezerloketNemSzerkeszthetoAdateleresselKomment()
        {
            //gombok beállítása     
            buttonTorolKomment.Visible = true;
            buttonSaveKommentek.Visible = false;
            buttonCancelKommentek.Visible = true;

            //dataGridView beállítása     
            dataGridViewKommentek.ReadOnly = true;
            dataGridViewKommentek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKommentek.AllowUserToDeleteRows = false;

            buttonTorolKomment.Enabled = true;

            lettModositva = false;
        }

        private void buttonTorolKomment_Click(object sender, EventArgs e)
        {
            try
            {
                //meghatározzuk a kijelölt sort        
                int sor = dataGridViewKommentek.SelectedRows[0].Index;
                if (MessageBox.Show(
                    "Valóban törölni akarja a sort?",
                    "Törlés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                    ) == DialogResult.Yes)
                {
                    //töröljük a sort a DataGridView-ból                     
                    dataGridViewKommentek.Rows.RemoveAt(sor);
                    //Lehetővé tesszük a mentést                     
                    buttonSaveKommentek.Visible = true;
                    lettModositva = true;
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        "Jelölje ki a törlendő sort!",
                        "Törlés",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonSaveKommentek_Click(object sender, EventArgs e)
        {
            if (!lettModositva)
            {

                MessageBox.Show
                    ("Nem lett módosítva egy adat sem.",
                    "Módosítás",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else
            {
                mdi.updateChangesInTable(kommentekDT);
                beallitVezerloketNemSzerkeszthetoAdateleresselUsers();
            }
        }

        private void dataGridViewKommentek_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lettModositva = true;
        }


        #endregion

        private void dataGridViewKommentek_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sor = dataGridViewKommentek.SelectedRows[0].Index;
            int Id = Convert.ToInt32(dataGridViewKommentek.SelectedRows[0].Cells["id"].Value);

            comments c = new comments(
                Convert.ToInt32(dataGridViewKommentek.SelectedRows[0].Cells["id"].Value),
                dataGridViewKommentek.SelectedRows[0].Cells["Name"].Value.ToString(),
                dataGridViewKommentek.SelectedRows[0].Cells["Comments"].Value.ToString()

            );

            formTorolKommentek ftk = new formTorolKommentek(c);

            if (ftk.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("Sikeres módosítás!");
                comments torolKomment = ftk.getTorolKommentek();

                Adatbazis updataDatabase = new Adatbazis();


                MySQLDatabaseInterface umdi = updataDatabase.kapcsolodas();
                umdi.open();

                string query = "";
                query += "UPDATE comments ";
                query += "SET username=\"" + torolKomment.getName() + "\"";
                query += ", email=\" " + torolKomment.getComments() + "\"";


                MessageBox.Show(query);

                umdi.executeDMQuery(query);

                MessageBox.Show("Sikeres módosítás:" + torolKomment.ToString());
                umdi.close();



                dataGridViewUsers.Rows[sor].Cells["username"].Value = torolKomment.getName();
                dataGridViewUsers.Rows[sor].Cells["email"].Value = torolKomment.getComments();



            }
        }
    }

}

