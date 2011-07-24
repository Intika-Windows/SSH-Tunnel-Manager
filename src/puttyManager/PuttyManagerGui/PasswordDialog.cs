using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuttyManagerGui
{
    public partial class PasswordDialog : Form
    {
        private EMode _mode;

        public PasswordDialog()
        {
            InitializeComponent();
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            private set
            {
                _password = value;
                textBoxPwd.Text = value;
            }
        }

        public bool SavePassword { get; private set; }

        public enum EMode
        {
            CreatePassword,
            RequestPassword
        }

        public void Setup(EMode mode)
        {
            _mode = mode;

            switch (mode)
            {
            case EMode.CreatePassword:
                Size = new Size(239,154);
                labelPwdReq.Visible = false;
                textBoxPwd.Visible = false;
                break;
            case EMode.RequestPassword:
                labelCre.Visible = false;
                labelPwd1.Visible = false;
                labelPwd2.Visible = false;
                textBoxPwd2.Visible = false;
                textBoxPwd1.Visible = false;
                Size = new Size(200,109);
                break;
            default:
                throw new ArgumentOutOfRangeException("mode");
            }

            updateGui();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!isPasswordValid()) return;

            Password = _mode == EMode.RequestPassword 
                ? textBoxPwd.Text 
                : textBoxPwd1.Text;
            SavePassword = checkBoxSavePwd.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBoxPwd1_TextChanged(object sender, EventArgs e)
        {
            updateGui();
        }

        private void textBoxPwd2_TextChanged(object sender, EventArgs e)
        {
            updateGui();
        }

        private void textBoxPwd_TextChanged(object sender, EventArgs e)
        {
            updateGui();
        }

        private void updateGui()
        {
            buttonEnter.Enabled = isPasswordValid();
        }

        private bool isPasswordValid()
        {
            if (_mode == EMode.RequestPassword)
            {
                var pwd = textBoxPwd.Text;
                return !string.IsNullOrWhiteSpace(pwd);
            } else
            {
                var pwd1 = textBoxPwd1.Text;
                var pwd2 = textBoxPwd2.Text;
                return pwd1 == pwd2 && !string.IsNullOrWhiteSpace(pwd1);
            }
        }
    }
}
