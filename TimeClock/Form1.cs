using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace TimeClock
{
    public partial class Form1 : Form
    {
        //SimpleAES encrypt = new SimpleAES();
        SimplerAES encrypt = new SimplerAES();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_punchin_Click(object sender, EventArgs e)
        {
            if(txt_name.Text != "")
            {
                NameCheck(txt_name.Text);
            }
            else
            {
                MessageBox.Show("Please enter a name");
            }
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
            string EmailPassword = encrypt.Decrypt(Properties.Settings.Default.FromEmailPassword);
            string smtp = Properties.Settings.Default.SMTPServer;
            int port = Properties.Settings.Default.Port;


            using (SmtpClient client = new SmtpClient(smtp, port))
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(FromEmail, EmailPassword);

                try
                {
                    MailMessage message = new MailMessage(FromEmail, ToEmail, "Punch In: " + name + " " + System.DateTime.Now,
                    "Employee " + name + " has punched in with a local time stamp of " + System.DateTime.Now + ". This should match the"
                    + "time this email  was recieved, if it does not, please confirm the local time on the client machine is accurate.");

                    client.Send(message);

                    MessageBox.Show("Punch In for " + name + " successfully registered at " + DateTime.Now);
                }
                catch (FormatException e)
                {
                    MessageBox.Show(e.Message + " This may mean the 'To' or 'From' email address is improperly formatted, please contact your system's administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SmtpException e)
                {
                    MessageBox.Show(e.Message + " Check the 'From' Email address password and/or SMTP settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void AdminAccess()
        {
            ConfigPage confForm = new ConfigPage();
            confForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Password encryption debugging tools
            lst_out.Items.Add(Properties.Settings.Default.AdminPassword);
            lst_out.Items.Add(encrypt.Decrypt(Properties.Settings.Default.AdminPassword));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AdminPassword = encrypt.Encrypt("test");
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lst_out.Items.Add(Properties.Settings.Default.AdminPassword);
            lst_out.Items.Add(encrypt.Decrypt(Properties.Settings.Default.AdminPassword));
            lst_out.Items.Add(Properties.Settings.Default.FromEmail);
            lst_out.Items.Add(Properties.Settings.Default.FromEmailPassword);
            lst_out.Items.Add(encrypt.Decrypt(Properties.Settings.Default.FromEmailPassword));
            lst_out.Items.Add(Properties.Settings.Default.ToEmail);
            lst_out.Items.Add(Properties.Settings.Default.SMTPServer);
            lst_out.Items.Add(Properties.Settings.Default.Port);
        }
    }
}
