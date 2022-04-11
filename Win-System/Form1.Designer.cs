namespace Win_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numSaat = new System.Windows.Forms.NumericUpDown();
            this.numDk = new System.Windows.Forms.NumericUpDown();
            this.numSn = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtParolaKilit = new System.Windows.Forms.TextBox();
            this.btnKilitAc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sistemPanel = new System.Windows.Forms.Panel();
            this.btnkapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.sistemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "KAPATMA ZAMAN AYARI";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "SAAT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(180, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "KAPAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(91, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "AYARLAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(10, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "KAYDET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(94, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "DAKİKA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(166, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "SANİYE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSaat
            // 
            this.numSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numSaat.Location = new System.Drawing.Point(22, 37);
            this.numSaat.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numSaat.Name = "numSaat";
            this.numSaat.Size = new System.Drawing.Size(66, 24);
            this.numSaat.TabIndex = 13;
            this.numSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numDk
            // 
            this.numDk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDk.Location = new System.Drawing.Point(94, 37);
            this.numDk.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numDk.Name = "numDk";
            this.numDk.Size = new System.Drawing.Size(66, 24);
            this.numDk.TabIndex = 14;
            this.numDk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSn
            // 
            this.numSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numSn.Location = new System.Drawing.Point(166, 37);
            this.numSn.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSn.Name = "numSn";
            this.numSn.Size = new System.Drawing.Size(66, 24);
            this.numSn.TabIndex = 15;
            this.numSn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Win_System.Properties.Resources.ustlogokucuk;
            this.pictureBox2.Location = new System.Drawing.Point(277, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(290, 160);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(127, 14);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.oksijenyazilim.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDurdur.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurdur.ForeColor = System.Drawing.Color.Black;
            this.btnDurdur.Location = new System.Drawing.Point(128, 113);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(85, 25);
            this.btnDurdur.TabIndex = 19;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBaslat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.ForeColor = System.Drawing.Color.Black;
            this.btnBaslat.Location = new System.Drawing.Point(47, 113);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 25);
            this.btnBaslat.TabIndex = 20;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Windows System App";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            this.ayarlarToolStripMenuItem.DoubleClick += new System.EventHandler(this.ayarlarToolStripMenuItem_DoubleClick);
            // 
            // txtParolaKilit
            // 
            this.txtParolaKilit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParolaKilit.Location = new System.Drawing.Point(69, 56);
            this.txtParolaKilit.Name = "txtParolaKilit";
            this.txtParolaKilit.PasswordChar = '×';
            this.txtParolaKilit.Size = new System.Drawing.Size(100, 23);
            this.txtParolaKilit.TabIndex = 22;
            // 
            // btnKilitAc
            // 
            this.btnKilitAc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKilitAc.Location = new System.Drawing.Point(173, 56);
            this.btnKilitAc.Name = "btnKilitAc";
            this.btnKilitAc.Size = new System.Drawing.Size(66, 23);
            this.btnKilitAc.TabIndex = 23;
            this.btnKilitAc.Text = "Kilit Aç";
            this.btnKilitAc.UseVisualStyleBackColor = true;
            this.btnKilitAc.Click += new System.EventHandler(this.btnKilitAc_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "PAROLA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sistemPanel
            // 
            this.sistemPanel.Controls.Add(this.label2);
            this.sistemPanel.Controls.Add(this.button1);
            this.sistemPanel.Controls.Add(this.button2);
            this.sistemPanel.Controls.Add(this.button3);
            this.sistemPanel.Controls.Add(this.label3);
            this.sistemPanel.Controls.Add(this.btnBaslat);
            this.sistemPanel.Controls.Add(this.label4);
            this.sistemPanel.Controls.Add(this.btnDurdur);
            this.sistemPanel.Controls.Add(this.numSaat);
            this.sistemPanel.Controls.Add(this.numDk);
            this.sistemPanel.Controls.Add(this.numSn);
            this.sistemPanel.Location = new System.Drawing.Point(7, 85);
            this.sistemPanel.Name = "sistemPanel";
            this.sistemPanel.Size = new System.Drawing.Size(264, 153);
            this.sistemPanel.TabIndex = 25;
            // 
            // btnkapat
            // 
            this.btnkapat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.Location = new System.Drawing.Point(240, 56);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(26, 23);
            this.btnkapat.TabIndex = 26;
            this.btnkapat.Text = "X";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 245);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.txtParolaKilit);
            this.Controls.Add(this.sistemPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKilitAc);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System App";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.sistemPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSaat;
        private System.Windows.Forms.NumericUpDown numDk;
        private System.Windows.Forms.NumericUpDown numSn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtParolaKilit;
        private System.Windows.Forms.Button btnKilitAc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel sistemPanel;
        private System.Windows.Forms.Button btnkapat;
    }
}

