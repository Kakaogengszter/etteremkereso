using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sajatGuiDataGridView.Model
{
    class comments
    {
        private int uid;
        private string name;
        private string comment;

        public comments(int uid,string name,string comment)
        {
            this.uid = uid;
            this.name = name;
            this.comment = comment;
        }

        public int getuid()
        {
            return uid;
        }

        public string getName()
        {
            return name;
        }

        public string getComments()
        {
            return comment;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setComments(string comment)
        {
            this.comment = comment;
        }

        public override string ToString()
        {
            return name + "Felhasználónév" + comment + "Kommentek";
        }
    }
}
