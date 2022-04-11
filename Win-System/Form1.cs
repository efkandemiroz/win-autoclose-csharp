using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace Win_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ayarlar parolaAyarla = new ayarlar();
            parolaAyarla.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*
           
             */

       /*     RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            if (key.GetValue("Win-System").ToString() != "\"" + Application.ExecutablePath + "\"")
            { // Eğer regeditte varsa, checkbox ı işaretle
                RegistryKey key2 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key2.SetValue("Win-System", "\"" + Application.ExecutablePath + "\"");
            }*/
             
            numSaat.Value = ayar.Default.saat;
            numDk.Value = ayar.Default.dakika;
            numSn.Value = ayar.Default.saniye;

            if (ayar.Default.start)
            {
                timer1.Start();
                btnBaslat.Enabled = false;
                btnDurdur.Enabled = true;
            }
            else
            {
                timer1.Stop();
                btnDurdur.Enabled = false;
                btnBaslat.Enabled = true;
            }

            sistemPanel.Visible = false;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            ayar.Default.saat = Int32.Parse(numSaat.Value.ToString());
            ayar.Default.dakika = Int32.Parse(numDk.Value.ToString());
            ayar.Default.saniye = Int32.Parse(numSn.Value.ToString());
            ayar.Default.Save();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.oksijenyazilim.com");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat, dakika, saniye;
            saat = numSaat.Value.ToString();
            dakika = numDk.Value.ToString();
            saniye = numSn.Value.ToString();


            if ((Convert.ToString(DateTime.Now.Hour)) == saat && (Convert.ToString(DateTime.Now.Minute) == dakika) && (Convert.ToString(DateTime.Now.Second)) == saniye)
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "C:\\Windows\\system32\\shutdown.exe";
                psi.Arguments = "-f -s -t 0";
                Process.Start(psi);
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            startOnay start = new startOnay();

            if (start.ShowDialog(this) == DialogResult.OK)
            {
                timer1.Start();
                btnBaslat.Enabled = false;
                btnDurdur.Enabled = true;
                btnDurdur.BackColor = Color.Red;
                btnDurdur.ForeColor = Color.White;
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            stopOnay stop = new stopOnay();

            if (stop.ShowDialog(this) == DialogResult.OK)
            {
                timer1.Stop();
                btnBaslat.Enabled = true;
                btnDurdur.Enabled = false;
                btnBaslat.BackColor = Color.Green;
                btnBaslat.ForeColor = Color.White;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Normal;
         //       notifyIcon1.Visible = false;
              

              /*  if (FormWindowState.Minimized == this.WindowState)
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(1000);
                    this.Hide();
                }
                else if (FormWindowState.Normal == this.WindowState)
                {
                    notifyIcon1.Visible = false;
                    this.Show();
                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnKilitAc_Click(object sender, EventArgs e)
        {
            if (btnKilitAc.Text == "Kilit Aç")
            {
                if (txtParolaKilit.Text == ayar.Default.parola)
                {
                    sistemPanel.Visible = true;
                    btnKilitAc.Text = "Kilitle";
                    txtParolaKilit.Text = "";
                }
                else
                {
                    MessageBox.Show("Parolayı Kontrol Edin !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (txtParolaKilit.Text == ayar.Default.parola)
                {
                    sistemPanel.Visible = false;
                    btnKilitAc.Text = "Kilit Aç";
                }
                else
                {
                    MessageBox.Show("Parolayı Kontrol Edin !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ayarlarToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

    }
}
