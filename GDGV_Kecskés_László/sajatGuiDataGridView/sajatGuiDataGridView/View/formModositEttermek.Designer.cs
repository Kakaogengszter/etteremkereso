namespace sajatGuiDataGridView
{
    partial class formModosit
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxTipus = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxCim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMegsem = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxKepEleres = new System.Windows.Forms.TextBox();
            this.labelKepEleres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(86, 38);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(137, 20);
            this.textBoxNev.TabIndex = 0;
            // 
            // textBoxTipus
            // 
            this.textBoxTipus.Location = new System.Drawing.Point(86, 81);
            this.textBoxTipus.Name = "textBoxTipus";
            this.textBoxTipus.Size = new System.Drawing.Size(137, 20);
            this.textBoxTipus.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxCim
            // 
            this.textBoxCim.Location = new System.Drawing.Point(86, 125);
            this.textBoxCim.Name = "textBoxCim";
            this.textBoxCim.Size = new System.Drawing.Size(137, 20);
            this.textBoxCim.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Típus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cim";
            // 
            // buttonMegsem
            // 
            this.buttonMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonMegsem.Location = new System.Drawing.Point(86, 227);
            this.buttonMegsem.Name = "buttonMegsem";
            this.buttonMegsem.Size = new System.Drawing.Size(75, 23);
            this.buttonMegsem.TabIndex = 7;
            this.buttonMegsem.Text = "Mégsem";
            this.buttonMegsem.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(86, 267);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxKepEleres
            // 
            this.textBoxKepEleres.Location = new System.Drawing.Point(86, 173);
            this.textBoxKepEleres.Name = "textBoxKepEleres";
            this.textBoxKepEleres.Size = new System.Drawing.Size(137, 20);
            this.textBoxKepEleres.TabIndex = 9;
            // 
            // labelKepEleres
            // 
            this.labelKepEleres.AutoSize = true;
            this.labelKepEleres.Location = new System.Drawing.Point(13, 176);
            this.labelKepEleres.Name = "labelKepEleres";
            this.labelKepEleres.Size = new System.Drawing.Size(63, 13);
            this.labelKepEleres.TabIndex = 10;
            this.labelKepEleres.Text = "Kép elérése";
            // 
            // formModosit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.labelKepEleres);
            this.Controls.Add(this.textBoxKepEleres);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonMegsem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCim);
            this.Controls.Add(this.textBoxTipus);
            this.Controls.Add(this.textBoxNev);
            this.Name = "formModosit";
            this.Text = "formModosit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxTipus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxCim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMegsem;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxKepEleres;
        private System.Windows.Forms.Label labelKepEleres;
    }
}