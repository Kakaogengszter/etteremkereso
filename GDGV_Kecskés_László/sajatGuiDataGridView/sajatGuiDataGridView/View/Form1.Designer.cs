namespace sajatGuiDataGridView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewEttermek = new System.Windows.Forms.DataGridView();
            this.buttonBetoltes = new System.Windows.Forms.Button();
            this.buttonModosit = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonMegsem = new System.Windows.Forms.Button();
            this.buttonKilep = new System.Windows.Forms.Button();
            this.buttonUjEtterem = new System.Windows.Forms.Button();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxTipus = new System.Windows.Forms.TextBox();
            this.textBoxCim = new System.Windows.Forms.TextBox();
            this.comboBoxSzurGyakorisag = new System.Windows.Forms.ComboBox();
            this.buttonUjEtteremFelv = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEttermek = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageFelhasználók = new System.Windows.Forms.TabPage();
            this.buttonExitUsers = new System.Windows.Forms.Button();
            this.buttonCancelUsers = new System.Windows.Forms.Button();
            this.buttonMentUsers = new System.Windows.Forms.Button();
            this.buttonTorolUsers = new System.Windows.Forms.Button();
            this.buttonModositUsers = new System.Windows.Forms.Button();
            this.buttonBetoltesUsers = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.tabPageKommentek = new System.Windows.Forms.TabPage();
            this.buttonKilepKommentek = new System.Windows.Forms.Button();
            this.buttonCancelKommentek = new System.Windows.Forms.Button();
            this.buttonSaveKommentek = new System.Windows.Forms.Button();
            this.buttonTorolKomment = new System.Windows.Forms.Button();
            this.buttonAdatokKommentek = new System.Windows.Forms.Button();
            this.dataGridViewKommentek = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEttermek)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageEttermek.SuspendLayout();
            this.tabPageFelhasználók.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPageKommentek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKommentek)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEttermek
            // 
            this.dataGridViewEttermek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEttermek.Location = new System.Drawing.Point(7, 38);
            this.dataGridViewEttermek.Name = "dataGridViewEttermek";
            this.dataGridViewEttermek.Size = new System.Drawing.Size(521, 275);
            this.dataGridViewEttermek.TabIndex = 0;
            this.dataGridViewEttermek.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEttermek_CellDoubleClick);
            this.dataGridViewEttermek.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEttermek_CellValueChanged);
            this.dataGridViewEttermek.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewEttermek_DefaultValuesNeeded);
            // 
            // buttonBetoltes
            // 
            this.buttonBetoltes.Location = new System.Drawing.Point(574, 23);
            this.buttonBetoltes.Name = "buttonBetoltes";
            this.buttonBetoltes.Size = new System.Drawing.Size(206, 23);
            this.buttonBetoltes.TabIndex = 1;
            this.buttonBetoltes.Text = "Adatok betöltése";
            this.buttonBetoltes.UseVisualStyleBackColor = true;
            this.buttonBetoltes.Click += new System.EventHandler(this.buttonBetoltes_Click);
            // 
            // buttonModosit
            // 
            this.buttonModosit.Location = new System.Drawing.Point(640, 99);
            this.buttonModosit.Name = "buttonModosit";
            this.buttonModosit.Size = new System.Drawing.Size(75, 23);
            this.buttonModosit.TabIndex = 3;
            this.buttonModosit.Text = "Módosít";
            this.buttonModosit.UseVisualStyleBackColor = true;
            this.buttonModosit.Click += new System.EventHandler(this.buttonModosit_Click);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(640, 128);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonTorles.TabIndex = 4;
            this.buttonTorles.Text = "Töröl";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(640, 157);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonMentes.TabIndex = 5;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // buttonMegsem
            // 
            this.buttonMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonMegsem.Location = new System.Drawing.Point(640, 186);
            this.buttonMegsem.Name = "buttonMegsem";
            this.buttonMegsem.Size = new System.Drawing.Size(75, 23);
            this.buttonMegsem.TabIndex = 6;
            this.buttonMegsem.Text = "Mégsem";
            this.buttonMegsem.UseVisualStyleBackColor = true;
            // 
            // buttonKilep
            // 
            this.buttonKilep.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonKilep.Location = new System.Drawing.Point(640, 290);
            this.buttonKilep.Name = "buttonKilep";
            this.buttonKilep.Size = new System.Drawing.Size(75, 23);
            this.buttonKilep.TabIndex = 7;
            this.buttonKilep.Text = "Kilép";
            this.buttonKilep.UseVisualStyleBackColor = true;
            this.buttonKilep.Click += new System.EventHandler(this.buttonKilep_Click);
            // 
            // buttonUjEtterem
            // 
            this.buttonUjEtterem.Location = new System.Drawing.Point(640, 70);
            this.buttonUjEtterem.Name = "buttonUjEtterem";
            this.buttonUjEtterem.Size = new System.Drawing.Size(75, 23);
            this.buttonUjEtterem.TabIndex = 8;
            this.buttonUjEtterem.Text = "Új étterem";
            this.buttonUjEtterem.UseVisualStyleBackColor = true;
            this.buttonUjEtterem.Click += new System.EventHandler(this.buttonUjEtterem_Click);
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(91, 414);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(171, 20);
            this.textBoxNev.TabIndex = 9;
            // 
            // textBoxTipus
            // 
            this.textBoxTipus.Location = new System.Drawing.Point(91, 371);
            this.textBoxTipus.Name = "textBoxTipus";
            this.textBoxTipus.Size = new System.Drawing.Size(171, 20);
            this.textBoxTipus.TabIndex = 10;
            // 
            // textBoxCim
            // 
            this.textBoxCim.Location = new System.Drawing.Point(91, 328);
            this.textBoxCim.Name = "textBoxCim";
            this.textBoxCim.Size = new System.Drawing.Size(171, 20);
            this.textBoxCim.TabIndex = 11;
            // 
            // comboBoxSzurGyakorisag
            // 
            this.comboBoxSzurGyakorisag.FormattingEnabled = true;
            this.comboBoxSzurGyakorisag.Location = new System.Drawing.Point(761, 72);
            this.comboBoxSzurGyakorisag.Name = "comboBoxSzurGyakorisag";
            this.comboBoxSzurGyakorisag.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSzurGyakorisag.TabIndex = 13;
            this.comboBoxSzurGyakorisag.SelectedIndexChanged += new System.EventHandler(this.comboBoxSzurGyakorisag_SelectedIndexChanged);
            this.comboBoxSzurGyakorisag.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSzurGyakorisag_SelectionChangeCommitted);
            // 
            // buttonUjEtteremFelv
            // 
            this.buttonUjEtteremFelv.Location = new System.Drawing.Point(335, 414);
            this.buttonUjEtteremFelv.Name = "buttonUjEtteremFelv";
            this.buttonUjEtteremFelv.Size = new System.Drawing.Size(127, 23);
            this.buttonUjEtteremFelv.TabIndex = 14;
            this.buttonUjEtteremFelv.Text = "Új étterem fevétel";
            this.buttonUjEtteremFelv.UseVisualStyleBackColor = true;
            this.buttonUjEtteremFelv.Click += new System.EventHandler(this.buttonUjEtteremFelv_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEttermek);
            this.tabControl1.Controls.Add(this.tabPageFelhasználók);
            this.tabControl1.Controls.Add(this.tabPageKommentek);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 588);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPageEttermek
            // 
            this.tabPageEttermek.BackColor = System.Drawing.Color.DimGray;
            this.tabPageEttermek.Controls.Add(this.label3);
            this.tabPageEttermek.Controls.Add(this.label2);
            this.tabPageEttermek.Controls.Add(this.label1);
            this.tabPageEttermek.Controls.Add(this.dataGridViewEttermek);
            this.tabPageEttermek.Controls.Add(this.buttonUjEtteremFelv);
            this.tabPageEttermek.Controls.Add(this.comboBoxSzurGyakorisag);
            this.tabPageEttermek.Controls.Add(this.textBoxCim);
            this.tabPageEttermek.Controls.Add(this.buttonMegsem);
            this.tabPageEttermek.Controls.Add(this.textBoxTipus);
            this.tabPageEttermek.Controls.Add(this.buttonMentes);
            this.tabPageEttermek.Controls.Add(this.textBoxNev);
            this.tabPageEttermek.Controls.Add(this.buttonTorles);
            this.tabPageEttermek.Controls.Add(this.buttonKilep);
            this.tabPageEttermek.Controls.Add(this.buttonUjEtterem);
            this.tabPageEttermek.Controls.Add(this.buttonBetoltes);
            this.tabPageEttermek.Controls.Add(this.buttonModosit);
            this.tabPageEttermek.Location = new System.Drawing.Point(4, 22);
            this.tabPageEttermek.Name = "tabPageEttermek";
            this.tabPageEttermek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEttermek.Size = new System.Drawing.Size(900, 562);
            this.tabPageEttermek.TabIndex = 0;
            this.tabPageEttermek.Text = "Éttermek";
            this.tabPageEttermek.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Típus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cím";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Név";
            // 
            // tabPageFelhasználók
            // 
            this.tabPageFelhasználók.BackColor = System.Drawing.Color.DimGray;
            this.tabPageFelhasználók.Controls.Add(this.buttonExitUsers);
            this.tabPageFelhasználók.Controls.Add(this.buttonCancelUsers);
            this.tabPageFelhasználók.Controls.Add(this.buttonMentUsers);
            this.tabPageFelhasználók.Controls.Add(this.buttonTorolUsers);
            this.tabPageFelhasználók.Controls.Add(this.buttonModositUsers);
            this.tabPageFelhasználók.Controls.Add(this.buttonBetoltesUsers);
            this.tabPageFelhasználók.Controls.Add(this.dataGridViewUsers);
            this.tabPageFelhasználók.Location = new System.Drawing.Point(4, 22);
            this.tabPageFelhasználók.Name = "tabPageFelhasználók";
            this.tabPageFelhasználók.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFelhasználók.Size = new System.Drawing.Size(900, 562);
            this.tabPageFelhasználók.TabIndex = 1;
            this.tabPageFelhasználók.Text = "Felhasználók";
            // 
            // buttonExitUsers
            // 
            this.buttonExitUsers.Location = new System.Drawing.Point(758, 261);
            this.buttonExitUsers.Name = "buttonExitUsers";
            this.buttonExitUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonExitUsers.TabIndex = 7;
            this.buttonExitUsers.Text = "Kilép";
            this.buttonExitUsers.UseVisualStyleBackColor = true;
            this.buttonExitUsers.Click += new System.EventHandler(this.buttonExitUsers_Click);
            // 
            // buttonCancelUsers
            // 
            this.buttonCancelUsers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelUsers.Location = new System.Drawing.Point(758, 155);
            this.buttonCancelUsers.Name = "buttonCancelUsers";
            this.buttonCancelUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelUsers.TabIndex = 6;
            this.buttonCancelUsers.Text = "Mégsem";
            this.buttonCancelUsers.UseVisualStyleBackColor = true;
            // 
            // buttonMentUsers
            // 
            this.buttonMentUsers.Location = new System.Drawing.Point(758, 126);
            this.buttonMentUsers.Name = "buttonMentUsers";
            this.buttonMentUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonMentUsers.TabIndex = 5;
            this.buttonMentUsers.Text = "Mentés";
            this.buttonMentUsers.UseVisualStyleBackColor = true;
            this.buttonMentUsers.Click += new System.EventHandler(this.buttonMentUsers_Click);
            // 
            // buttonTorolUsers
            // 
            this.buttonTorolUsers.Location = new System.Drawing.Point(758, 97);
            this.buttonTorolUsers.Name = "buttonTorolUsers";
            this.buttonTorolUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonTorolUsers.TabIndex = 4;
            this.buttonTorolUsers.Text = "Töröl";
            this.buttonTorolUsers.UseVisualStyleBackColor = true;
            this.buttonTorolUsers.Click += new System.EventHandler(this.buttonTorolUsers_Click);
            // 
            // buttonModositUsers
            // 
            this.buttonModositUsers.Location = new System.Drawing.Point(758, 68);
            this.buttonModositUsers.Name = "buttonModositUsers";
            this.buttonModositUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonModositUsers.TabIndex = 3;
            this.buttonModositUsers.Text = "Módosít";
            this.buttonModositUsers.UseVisualStyleBackColor = true;
            this.buttonModositUsers.Click += new System.EventHandler(this.buttonModositUsers_Click);
            // 
            // buttonBetoltesUsers
            // 
            this.buttonBetoltesUsers.Location = new System.Drawing.Point(724, 7);
            this.buttonBetoltesUsers.Name = "buttonBetoltesUsers";
            this.buttonBetoltesUsers.Size = new System.Drawing.Size(149, 23);
            this.buttonBetoltesUsers.TabIndex = 1;
            this.buttonBetoltesUsers.Text = "Adatok betöltése";
            this.buttonBetoltesUsers.UseVisualStyleBackColor = true;
            this.buttonBetoltesUsers.Click += new System.EventHandler(this.buttonBetoltesUsers_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(691, 417);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellDoubleClick);
            this.dataGridViewUsers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellValueChanged);
            // 
            // tabPageKommentek
            // 
            this.tabPageKommentek.BackColor = System.Drawing.Color.DimGray;
            this.tabPageKommentek.Controls.Add(this.buttonKilepKommentek);
            this.tabPageKommentek.Controls.Add(this.buttonCancelKommentek);
            this.tabPageKommentek.Controls.Add(this.buttonSaveKommentek);
            this.tabPageKommentek.Controls.Add(this.buttonTorolKomment);
            this.tabPageKommentek.Controls.Add(this.buttonAdatokKommentek);
            this.tabPageKommentek.Controls.Add(this.dataGridViewKommentek);
            this.tabPageKommentek.Location = new System.Drawing.Point(4, 22);
            this.tabPageKommentek.Name = "tabPageKommentek";
            this.tabPageKommentek.Size = new System.Drawing.Size(900, 562);
            this.tabPageKommentek.TabIndex = 2;
            this.tabPageKommentek.Text = "Kommentek";
            // 
            // buttonKilepKommentek
            // 
            this.buttonKilepKommentek.Location = new System.Drawing.Point(724, 223);
            this.buttonKilepKommentek.Name = "buttonKilepKommentek";
            this.buttonKilepKommentek.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepKommentek.TabIndex = 6;
            this.buttonKilepKommentek.Text = "Kilép";
            this.buttonKilepKommentek.UseVisualStyleBackColor = true;
            this.buttonKilepKommentek.Click += new System.EventHandler(this.buttonKilepKommentek_Click);
            // 
            // buttonCancelKommentek
            // 
            this.buttonCancelKommentek.Location = new System.Drawing.Point(724, 137);
            this.buttonCancelKommentek.Name = "buttonCancelKommentek";
            this.buttonCancelKommentek.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelKommentek.TabIndex = 5;
            this.buttonCancelKommentek.Text = "Mégsem";
            this.buttonCancelKommentek.UseVisualStyleBackColor = true;
            // 
            // buttonSaveKommentek
            // 
            this.buttonSaveKommentek.Location = new System.Drawing.Point(724, 108);
            this.buttonSaveKommentek.Name = "buttonSaveKommentek";
            this.buttonSaveKommentek.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveKommentek.TabIndex = 4;
            this.buttonSaveKommentek.Text = "Mentés";
            this.buttonSaveKommentek.UseVisualStyleBackColor = true;
            this.buttonSaveKommentek.Click += new System.EventHandler(this.buttonSaveKommentek_Click);
            // 
            // buttonTorolKomment
            // 
            this.buttonTorolKomment.Location = new System.Drawing.Point(724, 79);
            this.buttonTorolKomment.Name = "buttonTorolKomment";
            this.buttonTorolKomment.Size = new System.Drawing.Size(75, 23);
            this.buttonTorolKomment.TabIndex = 3;
            this.buttonTorolKomment.Text = "Töröl";
            this.buttonTorolKomment.UseVisualStyleBackColor = true;
            this.buttonTorolKomment.Click += new System.EventHandler(this.buttonTorolKomment_Click);
            // 
            // buttonAdatokKommentek
            // 
            this.buttonAdatokKommentek.Location = new System.Drawing.Point(678, 15);
            this.buttonAdatokKommentek.Name = "buttonAdatokKommentek";
            this.buttonAdatokKommentek.Size = new System.Drawing.Size(168, 23);
            this.buttonAdatokKommentek.TabIndex = 1;
            this.buttonAdatokKommentek.Text = "Adatok betöltése";
            this.buttonAdatokKommentek.UseVisualStyleBackColor = true;
            this.buttonAdatokKommentek.Click += new System.EventHandler(this.buttonAdatokKommentek_Click);
            // 
            // dataGridViewKommentek
            // 
            this.dataGridViewKommentek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKommentek.Location = new System.Drawing.Point(7, 0);
            this.dataGridViewKommentek.Name = "dataGridViewKommentek";
            this.dataGridViewKommentek.Size = new System.Drawing.Size(619, 441);
            this.dataGridViewKommentek.TabIndex = 0;
            this.dataGridViewKommentek.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKommentek_CellDoubleClick);
            this.dataGridViewKommentek.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKommentek_CellValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(912, 613);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEttermek)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageEttermek.ResumeLayout(false);
            this.tabPageEttermek.PerformLayout();
            this.tabPageFelhasználók.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPageKommentek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKommentek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEttermek;
        private System.Windows.Forms.Button buttonBetoltes;
        private System.Windows.Forms.Button buttonModosit;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonMegsem;
        private System.Windows.Forms.Button buttonKilep;
        private System.Windows.Forms.Button buttonUjEtterem;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxTipus;
        private System.Windows.Forms.TextBox textBoxCim;
        private System.Windows.Forms.ComboBox comboBoxSzurGyakorisag;
        private System.Windows.Forms.Button buttonUjEtteremFelv;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEttermek;
        private System.Windows.Forms.TabPage tabPageFelhasználók;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelUsers;
        private System.Windows.Forms.Button buttonMentUsers;
        private System.Windows.Forms.Button buttonTorolUsers;
        private System.Windows.Forms.Button buttonModositUsers;
        private System.Windows.Forms.Button buttonBetoltesUsers;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonExitUsers;
        private System.Windows.Forms.TabPage tabPageKommentek;
        private System.Windows.Forms.DataGridView dataGridViewKommentek;
        private System.Windows.Forms.Button buttonAdatokKommentek;
        private System.Windows.Forms.Button buttonCancelKommentek;
        private System.Windows.Forms.Button buttonSaveKommentek;
        private System.Windows.Forms.Button buttonTorolKomment;
        private System.Windows.Forms.Button buttonKilepKommentek;
    }
}

