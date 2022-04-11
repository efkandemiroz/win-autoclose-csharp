using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Win_System
{
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtParola1.Text == txtParola2.Text)
            {
                ayar.Default.parola = txtParola1.Text;
                ayar.Default.Save();
                MessageBox.Show("Parola Başarı İle Güncellendi", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            }
            else
            {
                MessageBox.Show("İki parola eşleşmiyor. Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            txtParola1.Text = ayar.Default.parola.ToString();
        }
    }
}
