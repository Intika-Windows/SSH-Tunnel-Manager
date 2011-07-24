namespace PuttyManagerGui
{
    partial class PasswordDialog
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelCre = new System.Windows.Forms.Label();
            this.labelPwd1 = new System.Windows.Forms.Label();
            this.labelPwd2 = new System.Windows.Forms.Label();
            this.textBoxPwd1 = new System.Windows.Forms.TextBox();
            this.textBoxPwd2 = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.labelPwdReq = new System.Windows.Forms.Label();
            this.checkBoxSavePwd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnter.Location = new System.Drawing.Point(9, 95);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(215, 23);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelCre
            // 
            this.labelCre.Location = new System.Drawing.Point(7, 9);
            this.labelCre.Name = "labelCre";
            this.labelCre.Size = new System.Drawing.Size(217, 16);
            this.labelCre.TabIndex = 1;
            this.labelCre.Text = "Придумайте пароль для файла настроек:";
            // 
            // labelPwd1
            // 
            this.labelPwd1.AutoSize = true;
            this.labelPwd1.Location = new System.Drawing.Point(7, 31);
            this.labelPwd1.Name = "labelPwd1";
            this.labelPwd1.Size = new System.Drawing.Size(48, 13);
            this.labelPwd1.TabIndex = 2;
            this.labelPwd1.Text = "Пароль:";
            // 
            // labelPwd2
            // 
            this.labelPwd2.AutoSize = true;
            this.labelPwd2.Location = new System.Drawing.Point(7, 55);
            this.labelPwd2.Name = "labelPwd2";
            this.labelPwd2.Size = new System.Drawing.Size(53, 13);
            this.labelPwd2.TabIndex = 2;
            this.labelPwd2.Text = "Еще раз:";
            // 
            // textBoxPwd1
            // 
            this.textBoxPwd1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPwd1.Location = new System.Drawing.Point(60, 28);
            this.textBoxPwd1.MaxLength = 128;
            this.textBoxPwd1.Name = "textBoxPwd1";
            this.textBoxPwd1.PasswordChar = '*';
            this.textBoxPwd1.Size = new System.Drawing.Size(164, 20);
            this.textBoxPwd1.TabIndex = 0;
            this.textBoxPwd1.UseSystemPasswordChar = true;
            this.textBoxPwd1.TextChanged += new System.EventHandler(this.textBoxPwd1_TextChanged);
            // 
            // textBoxPwd2
            // 
            this.textBoxPwd2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPwd2.Location = new System.Drawing.Point(60, 52);
            this.textBoxPwd2.MaxLength = 128;
            this.textBoxPwd2.Name = "textBoxPwd2";
            this.textBoxPwd2.PasswordChar = '*';
            this.textBoxPwd2.Size = new System.Drawing.Size(164, 20);
            this.textBoxPwd2.TabIndex = 1;
            this.textBoxPwd2.UseSystemPasswordChar = true;
            this.textBoxPwd2.TextChanged += new System.EventHandler(this.textBoxPwd2_TextChanged);
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPwd.Location = new System.Drawing.Point(55, 6);
            this.textBoxPwd.MaxLength = 128;
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = '*';
            this.textBoxPwd.Size = new System.Drawing.Size(169, 20);
            this.textBoxPwd.TabIndex = 3;
            this.textBoxPwd.UseSystemPasswordChar = true;
            this.textBoxPwd.TextChanged += new System.EventHandler(this.textBoxPwd_TextChanged);
            // 
            // labelPwdReq
            // 
            this.labelPwdReq.AutoSize = true;
            this.labelPwdReq.Location = new System.Drawing.Point(7, 9);
            this.labelPwdReq.Name = "labelPwdReq";
            this.labelPwdReq.Size = new System.Drawing.Size(48, 13);
            this.labelPwdReq.TabIndex = 4;
            this.labelPwdReq.Text = "Пароль:";
            // 
            // checkBoxSavePwd
            // 
            this.checkBoxSavePwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSavePwd.AutoSize = true;
            this.checkBoxSavePwd.Location = new System.Drawing.Point(11, 76);
            this.checkBoxSavePwd.Name = "checkBoxSavePwd";
            this.checkBoxSavePwd.Size = new System.Drawing.Size(118, 17);
            this.checkBoxSavePwd.TabIndex = 5;
            this.checkBoxSavePwd.Text = "Сохранить пароль";
            this.checkBoxSavePwd.UseVisualStyleBackColor = true;
            // 
            // PasswordDialog
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 126);
            this.Controls.Add(this.checkBoxSavePwd);
            this.Controls.Add(this.labelPwdReq);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxPwd2);
            this.Controls.Add(this.textBoxPwd1);
            this.Controls.Add(this.labelPwd2);
            this.Controls.Add(this.labelPwd1);
            this.Controls.Add(this.labelCre);
            this.Controls.Add(this.buttonEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuTTY Manager - Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelCre;
        private System.Windows.Forms.Label labelPwd1;
        private System.Windows.Forms.Label labelPwd2;
        private System.Windows.Forms.TextBox textBoxPwd1;
        private System.Windows.Forms.TextBox textBoxPwd2;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Label labelPwdReq;
        private System.Windows.Forms.CheckBox checkBoxSavePwd;
    }
}