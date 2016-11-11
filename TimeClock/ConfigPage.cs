using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClock
{
    public partial class ConfigPage : Form
    {

        SimpleAES encrypt = new SimpleAES();

        public ConfigPage()
        {
            InitializeComponent();
            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AdminPassword = PassCheck(txt_NewPass.Text, txt_ConfirmPassword.Text);
            Properties.Settings.Default.FromEmail = txt_FromEmail.Text;
            Properties.Settings.Default.FromEmailPassword = encrypt.EncryptToString(txt_FromEmailPass.Text); 
            Properties.Settings.Default.ToEmail = txt_ToEmail.Text;

            Properties.Settings.Default.Save();

        }

        private string PassCheck(string pass, string confirmPass)
        {
            if (pass == confirmPass)
            {
                return encrypt.EncryptToString(pass);
            }
            else
            {
                MessageBox.Show("Passwords do not match, password has not been changed");
                return Properties.Settings.Default.AdminPassword;
            }

        }

        private void btn_ConfirmPass_Click(object sender, EventArgs e)
        {
            string AttemptedPassword, ActualPassword;
                    
            AttemptedPassword = txt_AdminPass.Text;
            ActualPassword = encrypt.DecryptString(Properties.Settings.Default.AdminPassword);
            
            if(AttemptedPassword == ActualPassword)
            {
                ToggleTextBoxes(true);
                PopulateSettings();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }

        }

        private void ToggleTextBoxes(bool tf)
        {
            txt_FromEmail.Enabled = tf;
            txt_FromEmailPass.Enabled = tf;
            
            txt_ToEmail.Enabled = tf;

            txt_NewPass.Enabled = tf;
            txt_ConfirmPassword.Enabled = tf;

            btn_Submit.Enabled = tf;
        }

        private void PopulateSettings()
        {
            txt_FromEmail.Text = Properties.Settings.Default.FromEmail;
            txt_ToEmail.Text = Properties.Settings.Default.ToEmail;
        }
    }
}
