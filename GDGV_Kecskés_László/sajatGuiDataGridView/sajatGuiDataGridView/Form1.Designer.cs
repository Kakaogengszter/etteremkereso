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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEttermek)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEttermek
            // 
            this.dataGridViewEttermek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEttermek.Location = new System.Drawing.Point(57, 41);
            this.dataGridViewEttermek.Name = "dataGridViewEttermek";
            this.dataGridViewEttermek.Size = new System.Drawing.Size(521, 275);
            this.dataGridViewEttermek.TabIndex = 0;
            this.dataGridViewEttermek.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEttermek_CellDoubleClick);
            this.dataGridViewEttermek.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEttermek_CellValueChanged);
            this.dataGridViewEttermek.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewEttermek_DefaultValuesNeeded);
            // 
            // buttonBetoltes
            // 
            this.buttonBetoltes.Location = new System.Drawing.Point(666, 41);
            this.buttonBetoltes.Name = "buttonBetoltes";
            this.buttonBetoltes.Size = new System.Drawing.Size(122, 23);
            this.buttonBetoltes.TabIndex = 1;
            this.buttonBetoltes.Text = "Adatok betöltése";
            this.buttonBetoltes.UseVisualStyleBackColor = true;
            this.buttonBetoltes.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonModosit
            // 
            this.buttonModosit.Location = new System.Drawing.Point(688, 140);
            this.buttonModosit.Name = "buttonModosit";
            this.buttonModosit.Size = new System.Drawing.Size(75, 23);
            this.buttonModosit.TabIndex = 3;
            this.buttonModosit.Text = "Módosít";
            this.buttonModosit.UseVisualStyleBackColor = true;
            this.buttonModosit.Click += new System.EventHandler(this.buttonModosit_Click);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(688, 169);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonTorles.TabIndex = 4;
            this.buttonTorles.Text = "Töröl";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(688, 199);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonMentes.TabIndex = 5;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // buttonMegsem
            // 
            this.buttonMegsem.Location = new System.Drawing.Point(688, 229);
            this.buttonMegsem.Name = "buttonMegsem";
            this.buttonMegsem.Size = new System.Drawing.Size(75, 23);
            this.buttonMegsem.TabIndex = 6;
            this.buttonMegsem.Text = "Mégsem";
            this.buttonMegsem.UseVisualStyleBackColor = true;
            // 
            // buttonKilep
            // 
            this.buttonKilep.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonKilep.Location = new System.Drawing.Point(688, 404);
            this.buttonKilep.Name = "buttonKilep";
            this.buttonKilep.Size = new System.Drawing.Size(75, 23);
            this.buttonKilep.TabIndex = 7;
            this.buttonKilep.Text = "Kilép";
            this.buttonKilep.UseVisualStyleBackColor = true;
            this.buttonKilep.Click += new System.EventHandler(this.buttonKilep_Click);
            // 
            // buttonUjEtterem
            // 
            this.buttonUjEtterem.Location = new System.Drawing.Point(688, 111);
            this.buttonUjEtterem.Name = "buttonUjEtterem";
            this.buttonUjEtterem.Size = new System.Drawing.Size(75, 23);
            this.buttonUjEtterem.TabIndex = 8;
            this.buttonUjEtterem.Text = "Új étterem";
            this.buttonUjEtterem.UseVisualStyleBackColor = true;
            this.buttonUjEtterem.Click += new System.EventHandler(this.buttonUjEtterem_Click);
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(95, 323);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(171, 20);
            this.textBoxNev.TabIndex = 9;
            // 
            // textBoxTipus
            // 
            this.textBoxTipus.Location = new System.Drawing.Point(95, 350);
            this.textBoxTipus.Name = "textBoxTipus";
            this.textBoxTipus.Size = new System.Drawing.Size(171, 20);
            this.textBoxTipus.TabIndex = 10;
            // 
            // textBoxCim
            // 
            this.textBoxCim.Location = new System.Drawing.Point(95, 377);
            this.textBoxCim.Name = "textBoxCim";
            this.textBoxCim.Size = new System.Drawing.Size(171, 20);
            this.textBoxCim.TabIndex = 11;
            // 
            // comboBoxSzurGyakorisag
            // 
            this.comboBoxSzurGyakorisag.FormattingEnabled = true;
            this.comboBoxSzurGyakorisag.Location = new System.Drawing.Point(666, 294);
            this.comboBoxSzurGyakorisag.Name = "comboBoxSzurGyakorisag";
            this.comboBoxSzurGyakorisag.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSzurGyakorisag.TabIndex = 13;
            this.comboBoxSzurGyakorisag.SelectedIndexChanged += new System.EventHandler(this.comboBoxSzurGyakorisag_SelectedIndexChanged);
            this.comboBoxSzurGyakorisag.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSzurGyakorisag_SelectionChangeCommitted);
            //this.comboBoxSzurGyakorisag.DropDownClosed += new System.EventHandler(this.comboBoxSzurGyakorisag_DropDownClosed);
            // 
            // buttonUjEtteremFelv
            // 
            this.buttonUjEtteremFelv.Location = new System.Drawing.Point(333, 373);
            this.buttonUjEtteremFelv.Name = "buttonUjEtteremFelv";
            this.buttonUjEtteremFelv.Size = new System.Drawing.Size(127, 23);
            this.buttonUjEtteremFelv.TabIndex = 14;
            this.buttonUjEtteremFelv.Text = "Új étterem fevétel";
            this.buttonUjEtteremFelv.UseVisualStyleBackColor = true;
            this.buttonUjEtteremFelv.Click += new System.EventHandler(this.buttonUjEtteremFelv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUjEtteremFelv);
            this.Controls.Add(this.comboBoxSzurGyakorisag);
            this.Controls.Add(this.textBoxCim);
            this.Controls.Add(this.textBoxTipus);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.buttonUjEtterem);
            this.Controls.Add(this.buttonKilep);
            this.Controls.Add(this.buttonMegsem);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonModosit);
            this.Controls.Add(this.buttonBetoltes);
            this.Controls.Add(this.dataGridViewEttermek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEttermek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

