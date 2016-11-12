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
            Properties.Settings.Default.FromEmail = NullCheck(Properties.Settings.Default.FromEmail, txt_FromEmail.Text);
            Properties.Settings.Default.FromEmailPassword = NullCheck(Properties.Settings.Default.FromEmailPassword, encrypt.EncryptToString(txt_FromEmailPass.Text)); 
            Properties.Settings.Default.ToEmail = NullCheck(Properties.Settings.Default.ToEmail, txt_ToEmail.Text);

            Properties.Settings.Default.Save();
            MessageBox.Show("Settins updated");

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

        private string NullCheck (string setting, string entry)
        {
            if (string.IsNullOrEmpty(entry) == true)
            {
                return setting;
            }
            else
            {
                return entry;
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
                txt_AdminPass.Text = "";
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

            txt_SMTP.Enabled = tf;
            txt_Port.Enabled = tf;

            btn_Submit.Enabled = tf;
        }

        private void PopulateSettings()
        {
            txt_FromEmail.Text = Properties.Settings.Default.FromEmail;
            txt_ToEmail.Text = Properties.Settings.Default.ToEmail;

            txt_Port.Text = Properties.Settings.Default.Port.ToString();
            txt_SMTP.Text = Properties.Settings.Default.SMTPServer;
        }

        private void ShowPassword (TextBox field, Button button)
        {
            if (button.Text == "Show")
            {
                field.UseSystemPasswordChar = false;
                button.Text = "Hide";
            }
            else
            {
                field.UseSystemPasswordChar = true;
                button.Text = "Show";
            }
            
        }

        private void btn_AdminPassShow_Click(object sender, EventArgs e)
        {
            ShowPassword(txt_AdminPass, btn_AdminPassShow);
        }

        private void btn_NewPassShow_Click(object sender, EventArgs e)
        {
            ShowPassword(txt_NewPass, btn_NewPassShow);
        }

        private void btn_ConfPassShow_Click(object sender, EventArgs e)
        {
            ShowPassword(txt_ConfirmPassword, btn_ConfPassShow);
        }

        private void btn_FrmEmailPassShow_Click(object sender, EventArgs e)
        {
            ShowPassword(txt_FromEmailPass, btn_FrmEmailPassShow);
        }
    }
}
