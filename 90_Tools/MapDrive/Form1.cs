using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Net;
using System.Security;

namespace MapDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbBenutzer.SelectedIndex = 0;
            cbLaufwerke.SelectedIndex = 0;
            cbPfad.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerbinden_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("net.exe", "use x: /delete").WaitForExit();
            System.Threading.Thread.Sleep(6000);
            try
            {

            }
            catch (Exception ex)
            {


                SecureString theSecureString = new NetworkCredential("", txtPasswort.Text).SecurePassword;

                Process.Start(@"C:\Windows\explorer.exe", @cbPfad.SelectedItem.ToString(), @cbBenutzer.SelectedItem.ToString(), theSecureString, @"WORKGROUP");
            }
     
        }
    }
}
