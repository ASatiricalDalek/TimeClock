using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace TimeClock
{
    public partial class Form1 : Form
    {
        SimpleAES encrypt = new SimpleAES();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_punchin_Click(object sender, EventArgs e)
        {
            NameCheck(txt_name.Text);
        }

        private void NameCheck(string name)
        {
            if (name.ToLower() == "admin")
            {
                AdminAccess();
            }
            else
            {
                Submit(name);
            }
        }

        private void Submit(string name)
        {
            string FromEmail = Properties.Settings.Default.FromEmail, ToEmail = Properties.Settings.Default.ToEmail;
            string EmailPassword = encrypt.DecryptString(Properties.Settings.Default.FromEmailPassword);

            MailMessage mail = new MailMessage(FromEmail, ToEmail);
            SmtpClient client = new SmtpClient();

            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(ToEmail, EmailPassword);
            client.Host = "smtp.google.com";
            mail.Subject = "Punch In: " + name + " " + System.DateTime.Now;
            mail.Body = "Employee " + name + " has punched in with a local time stamp of " + System.DateTime.Now + ". This should match the time this email "
                + "was recieved, if it does not, please confirm the local time on the client machine is accurate.";
            client.Send(mail);
        }

        private void AdminAccess()
        {
            ConfigPage confForm = new ConfigPage();
            confForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.AdminPassword == "238176090217083244046012006009098097222227193013")
            {
                Properties.Settings.Default.AdminPassword = encrypt.EncryptToString("password");

                Properties.Settings.Default.Save();
            }
        }
    }
}
