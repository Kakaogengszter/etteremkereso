using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sajatGuiDataGridView
{
    internal partial class formModosit : Form
    {
        private ettermek etterem;
            
        public formModosit(ettermek h)
        {
            InitializeComponent();
            this.etterem = h;
            megjelenitEtteremAdatokat();
        }

        public ettermek getModositottEttermek()
        {
            return etterem;
        }

        private void megjelenitEtteremAdatokat()
        {
            textBoxNev.Text = etterem.getNev();
            textBoxTipus.Text = etterem.getTipus();
            textBoxCim.Text = etterem.getCim();
            textBoxKepEleres.Text = etterem.getKepEleres();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            etterem.setNev(textBoxNev.Text);
            etterem.setTipus(textBoxTipus.Text);
            etterem.setCim(textBoxCim.Text);
            etterem.setKepEleres(textBoxKepEleres.Text);
            this.Close();
        }

  
    }
}
