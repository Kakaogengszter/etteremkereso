namespace sajatGuiDataGridView.View
{
    partial class formModositUsers
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
            this.buttonSaveUsers = new System.Windows.Forms.Button();
            this.buttonMegsemUsers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSaveUsers
            // 
            this.buttonSaveUsers.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveUsers.Location = new System.Drawing.Point(112, 195);
            this.buttonSaveUsers.Name = "buttonSaveUsers";
            this.buttonSaveUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveUsers.TabIndex = 16;
            this.buttonSaveUsers.Text = "Mentés";
            this.buttonSaveUsers.UseVisualStyleBackColor = true;
            this.buttonSaveUsers.Click += new System.EventHandler(this.buttonSaveUsers_Click);
            // 
            // buttonMegsemUsers
            // 
            this.buttonMegsemUsers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonMegsemUsers.Location = new System.Drawing.Point(112, 148);
            this.buttonMegsemUsers.Name = "buttonMegsemUsers";
            this.buttonMegsemUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonMegsemUsers.TabIndex = 15;
            this.buttonMegsemUsers.Text = "Mégsem";
            this.buttonMegsemUsers.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Felhasználónév";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(112, 80);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(137, 20);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(112, 40);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(137, 20);
            this.textBoxNev.TabIndex = 9;
            // 
            // formModositUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 383);
            this.Controls.Add(this.buttonSaveUsers);
            this.Controls.Add(this.buttonMegsemUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNev);
            this.Name = "formModositUsers";
            this.Text = "formModositUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveUsers;
        private System.Windows.Forms.Button buttonMegsemUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNev;
    }
}