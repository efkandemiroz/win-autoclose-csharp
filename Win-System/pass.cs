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
    public partial class pass : Form
    {
        public pass()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
            if (txtParola1.Text == ayar.Default.parola)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Hide(); 
            }
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

        private void pass_Load(object sender, EventArgs e)
        {
            if (txtParola1.Text == ayar.Default.parola)
            { 
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }
    }
}
