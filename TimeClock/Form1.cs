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

        }

        private void AdminAccess()
        {
            ConfigPage confForm = new ConfigPage();
            confForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        //    if (Properties.Settings.Default.AdminPassword == "firstRun")
        //    {
        //        Properties.Settings.Default.AdminPassword = encrypt.EncryptToString("password");
        //        /////////////////////////DEBUG CODE: PLS REMOVE////////////////////////////////////////////////////////
        //        MessageBox.Show("Password set to " + encrypt.DecryptString(Properties.Settings.Default.AdminPassword));
        //        MessageBox.Show("Encrypted: " + encrypt.DecryptString(Properties.Settings.Default.AdminPassword));
        //        //////////////////////////////////////////////////////////////////////////////////////////////////////
        //    }
        }
    }
}
