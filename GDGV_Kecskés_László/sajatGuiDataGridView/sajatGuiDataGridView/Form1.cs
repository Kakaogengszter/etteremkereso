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


namespace sajatGuiDataGridView
{
    public partial class Form1 : Form
    {
        private MySQLDatabaseInterface mdi;
        ///<value>Adatbázisból való beolvasás után ebben a táblában vannak a halfajadatok</value> 
        private DataTable ettermekDT;
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

        private void button1_Click(object sender, EventArgs e)
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
            /*string query = "SELECT Tipus FROM tipus";
            DataTable dataTableTipus;
            dataTableTipus = mdi.getToDataTable(query);*/
            int selectedGyakorisag = 0;
            string where = "";

            //if (int.TryParse(comboBoxSzurGyakorisag.SelectedValue.ToString(), out selectedGyakorisag))
                if
                (selectedGyakorisag != 0)
                {
                    where = " WHERE Tipus=" + selectedGyakorisag;
                    dataGridViewEttermek.Columns.RemoveAt(5);
                    columnGyakorisag = null;
                    dataGridViewEttermek.DataSource = null;
                }
            ettermekDT = mdi.getToDataTable("SELECT * FROM tipus" + where);

            if (columnGyakorisag == null)
            {
                //Példányosítjuk a ComboBox oszlopot
                columnGyakorisag = new DataGridViewComboBoxColumn();
                //Megadjuk a ComboBox oszlop tulajdonságait
                columnGyakorisag.HeaderText = "Típus";
                columnGyakorisag.Name = "gyakorisagComboBox";
                columnGyakorisag.Width = 120;
                //columnGyakorisag.DataSource = dataTableTipus;

                dataGridViewEttermek.Columns.Add(columnGyakorisag);


                dataGridViewEttermek.Columns["Id"].HeaderText = "Id";
                dataGridViewEttermek.Columns["Nev"].HeaderText = "Név";
                dataGridViewEttermek.Columns["Tipus"].HeaderText = "Típus";
                dataGridViewEttermek.Columns["Cim"].HeaderText = "Cím";




                Adatbazis gy = new Adatbazis();
                MySQLDatabaseInterface mdiGyakorisag;
                mdiGyakorisag = gy.kapcsolodas();
                mdiGyakorisag.open();
                DataTable dataTableGyakorisag = new DataTable();
                dataTableGyakorisag = mdiGyakorisag.getToDataTable("SELECT Id,Tipus FROM tipus");
                mdiGyakorisag.close();
                columnGyakorisag.DataSource = dataTableGyakorisag;

                //columnGyakorisag.DataSource = dataTableTipus;
                columnGyakorisag.ValueMember = "Id";
                columnGyakorisag.DisplayMember = "Tipus";


                setColumnGyakorisagComboBoxValue();
            }
            else
                setColumnGyakorisagComboBoxValue();

        }
          

        public void feltoltAdatokkalComboBoxSzurGyakorisag()
        {
            Adatbazis gy = new Adatbazis();
            MySQLDatabaseInterface mdiGyakorisag;
            mdiGyakorisag = gy.kapcsolodas();
            mdiGyakorisag.open();
            DataTable dataTableGyakorisag = new DataTable();
            dataTableGyakorisag = mdiGyakorisag.getToDataTable("SELECT Id,Tipus FROM tipus");
            mdiGyakorisag.close();
            DataRow newRow = dataTableGyakorisag.NewRow();
            newRow[0] = "0";
            newRow[1] = "Összes";
            dataTableGyakorisag.Rows.InsertAt(newRow, 0);
            comboBoxSzurGyakorisag.DataSource = dataTableGyakorisag;
            comboBoxSzurGyakorisag.ValueMember = "Id";
            comboBoxSzurGyakorisag.DisplayMember = "Tipus";
        }

        private void setColumnGyakorisagComboBoxValue()
        {
            for
            (
            int
            i = 0; i < dataGridViewEttermek.Rows.Count - 1; i++)
            {
                //DataTable - ból olvasva ki az adatokat(1.megoldás)
                //dataGridViewHalfaj.Rows[i].Cells["gyakorisagComboBox"].Value = halfajokDT.Rows[i]["gyakorisagid"];
                //DataGridView-ból olvasva az adatokat(2.megoldás)
                dataGridViewEttermek.Rows[i].Cells["gyakorisagComboBox"].Value =
                    dataGridViewEttermek.Rows[i].Cells["TipusId"].Value;
            }
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
            {         //meghatározzuk a kijelölt sort        
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

            /// <summary> 
            ///Beállítjuk a vezérlőket 
            ///  Az utolsó sorba görgetünk és ott engedjük meg az új adatfelvitelt 
            ///  Bizonyos oszlopokat vagy sorokat elérhetetlenné  tehetünk 
            /// </summary> 
        }

       

        private void dataGridViewEttermek_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lettModositva = true;

            if (e.ColumnIndex == 5)
            {
                DataGridViewComboBoxCell cb =
                (DataGridViewComboBoxCell)dataGridViewEttermek.Rows[e.RowIndex].Cells["gyakorisagComboBox"];
                if (cb.Value != null)
                {
                    dataGridViewEttermek.Invalidate();
                    dataGridViewEttermek.Rows[e.RowIndex].Cells["TipusId"].Value = cb.Value;
                }
            }
        }

        private void dataGridViewEttermek_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
           

            //Készítünk egy új kapcsolatot az adatbázishoz     
            Adatbazis ujida = new Adatbazis();
            MySQLDatabaseInterface mdiujid = ujida.kapcsolodas();
            mdiujid.open();
            //Készítünk egy lekérdezést az új halid meghatározására     
            int max;
            bool siker = int.TryParse(mdiujid.executeScalarQuery("SELECT MAX(Id) FROM etterem"), out max);
            if (!siker)
            {
                MessageBox.Show(
                    "Nem lehet megállapítani a következő rekord kulcsát. Adatbázis lekérdezési hiba.",
                    "Hiba...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            mdiujid.close();

            e.Row.Cells[0].Value = max + 1;
            e.Row.Cells["gyakorisagComboBox"].Value = 1;
        }

        private void buttonUjEtterem_Click(object sender, EventArgs e)
        {
            beallitVezerloketUjAdatfelvitelkor();
            int sor = dataGridViewEttermek.Rows.Count - 1 ;
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
            int Id =    Convert.ToInt32(dataGridViewEttermek.SelectedRows[0].Cells["Id"].Value);

                ettermek h = new ettermek(
                    dataGridViewEttermek.SelectedRows[0].Cells["Nev"].Value.ToString(),
                    dataGridViewEttermek.SelectedRows[0].Cells["Tipus"].Value.ToString(),
                    dataGridViewEttermek.SelectedRows[0].Cells["Cim"].Value.ToString(),
                    Convert.ToInt32(dataGridViewEttermek.SelectedRows[0].Cells["Id"].Value)
                );

            formModosit fh = new formModosit (h);

            if (fh.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show( "Sikeres módosítás!");
                ettermek modositottEtterem = fh.getModositottEttermek();
               
                Adatbazis updataDatabase = new Adatbazis();


                MySQLDatabaseInterface umdi = updataDatabase.kapcsolodas();
                umdi.open();
                
                string query = "";
                query += "UPDATE etterem ";
                query += "SET Nev=\"" +  modositottEtterem.getNev() + "\""  ;
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

        /*private void comboBoxSzurGyakorisag_DropDownClosed(object sender, EventArgs e)
        {
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas();
            mdi.open();
            //ettermekDT = mdi.getToDataTable("SELECT * FROM tipus WHERE Tipus='" + comboBoxSzurGyakorisag.SelectedValue.ToString()+ "'") ;
            dataGridViewEttermek.DataSource = ettermekDT;
        }*/
    }

    }

