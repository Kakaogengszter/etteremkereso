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
    internal partial class formTorolKommentek : Form
    {
        private comments comment;

        public formTorolKommentek(comments c)
        {
            InitializeComponent();
            this.comment = c;
            megjelenitKommentAdatokat();
        }

        public comments getTorolKommentek()
        {
            return comment;
        }

        private void megjelenitKommentAdatokat()
        {
            textBoxNev.Text = comment.getName();
            richTextBoxKomment.Text = comment.getComments();
        }

        private void buttonSaveUsers_Click(object sender, EventArgs e)
        {
            comment.setName(textBoxNev.Text);
            comment.setComments(richTextBoxKomment.Text);
            this.Close();
        }
    }
}
