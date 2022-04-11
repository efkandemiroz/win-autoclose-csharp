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
    public partial class startOnay : Form
    {
        public startOnay()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtParola1.Text == ayar.Default.parola)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Parolayı Kontrol Edin !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
