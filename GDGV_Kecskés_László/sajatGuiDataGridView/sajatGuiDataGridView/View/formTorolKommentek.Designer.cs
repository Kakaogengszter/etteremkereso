namespace sajatGuiDataGridView.View
{
    partial class formTorolKommentek
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
            this.buttonSaveUsers = new System.Windows.Forms.Button();
            this.buttonMegsemUsers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBoxKomment = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonSaveUsers
            // 
            this.buttonSaveUsers.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveUsers.Location = new System.Drawing.Point(172, 239);
            this.buttonSaveUsers.Name = "buttonSaveUsers";
            this.buttonSaveUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveUsers.TabIndex = 22;
            this.buttonSaveUsers.Text = "Mentés";
            this.buttonSaveUsers.UseVisualStyleBackColor = true;
            this.buttonSaveUsers.Click += new System.EventHandler(this.buttonSaveUsers_Click);
            // 
            // buttonMegsemUsers
            // 
            this.buttonMegsemUsers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonMegsemUsers.Location = new System.Drawing.Point(172, 210);
            this.buttonMegsemUsers.Name = "buttonMegsemUsers";
            this.buttonMegsemUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonMegsemUsers.TabIndex = 21;
            this.buttonMegsemUsers.Text = "Mégsem";
            this.buttonMegsemUsers.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Komment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Felhasználónév";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(110, 24);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(137, 20);
            this.textBoxNev.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBoxKomment
            // 
            this.richTextBoxKomment.Location = new System.Drawing.Point(66, 64);
            this.richTextBoxKomment.Name = "richTextBoxKomment";
            this.richTextBoxKomment.Size = new System.Drawing.Size(278, 140);
            this.richTextBoxKomment.TabIndex = 24;
            this.richTextBoxKomment.Text = "";
            // 
            // formTorolKommentek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 400);
            this.Controls.Add(this.richTextBoxKomment);
            this.Controls.Add(this.buttonSaveUsers);
            this.Controls.Add(this.buttonMegsemUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNev);
            this.Name = "formTorolKommentek";
            this.Text = "formTorolKommentek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveUsers;
        private System.Windows.Forms.Button buttonMegsemUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBoxKomment;
    }
}