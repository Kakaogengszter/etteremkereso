using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectToMysqlDatabase;
using System.Data;


namespace sajatGuiDataGridView
{
    class ettermek
    {
        

        private string Nev;
        private string Tipus;
        private string Cim;
        private string kep_eleres;
        private int Id;

        public ettermek(int Id)
        {
            this.Id = Id;
            this.Nev = string.Empty;
            this.Tipus = string.Empty;
            this.Cim = string.Empty;
        }

        public ettermek(int Id, string Nev, string Tipus, string Cim, string kep_eleres)
        {
            this.Id = Id;
            this.Nev = Nev;
            this.Tipus = Tipus;
            this.Cim = Cim;
            this.kep_eleres = kep_eleres;
        }

        public int getId()
        {
            return Id;
        }

        public string getNev()
        {
            return Nev;
        }

        public string getTipus()
        {
            return Tipus;
        }

        public string getCim()
        {
            return Cim;
        }

        public string getKepEleres()
        {
            return kep_eleres;
        }

        public void setNev(string Nev)
        {
            this.Nev = Nev;
        }


        public void setTipus (string Tipus)
        {
            this.Tipus = Tipus;
        }

        public void setCim (string Cim)
        {
            this.Cim = Cim;
        }

        public void setKepEleres (string kep_eleres){

            this.kep_eleres = kep_eleres;
        }

    }
}
