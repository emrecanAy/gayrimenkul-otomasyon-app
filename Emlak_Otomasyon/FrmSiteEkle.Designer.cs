namespace Emlak_Otomasyon
{
    partial class FrmSiteEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiteEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TxtApartmanBlok = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtSiteAd = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dgvSiteler = new System.Windows.Forms.DataGridView();
            this.dgvApartmanBlok = new System.Windows.Forms.DataGridView();
            this.TxtSiteid = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TxtBlokid = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiteler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmanBlok)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 30);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(338, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 124;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Coolvetica Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gayrimenkul Kayıt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Coolvetica Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(29, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 116;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Coolvetica Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(132, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 34);
            this.button4.TabIndex = 114;
            this.button4.Text = "Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TxtApartmanBlok
            // 
            this.TxtApartmanBlok.Font = new System.Drawing.Font("Coolvetica Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtApartmanBlok.Location = new System.Drawing.Point(155, 327);
            this.TxtApartmanBlok.Name = "TxtApartmanBlok";
            this.TxtApartmanBlok.Size = new System.Drawing.Size(176, 30);
            this.TxtApartmanBlok.TabIndex = 117;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Coolvetica Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(29, 327);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(127, 30);
            this.textBox2.TabIndex = 115;
            this.textBox2.Text = "Apartman-Blok:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Coolvetica Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(29, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 34);
            this.button3.TabIndex = 112;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Coolvetica Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(132, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 34);
            this.button2.TabIndex = 110;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // TxtSiteAd
            // 
            this.TxtSiteAd.Font = new System.Drawing.Font("Coolvetica Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSiteAd.Location = new System.Drawing.Point(132, 82);
            this.TxtSiteAd.Name = "TxtSiteAd";
            this.TxtSiteAd.Size = new System.Drawing.Size(199, 30);
            this.TxtSiteAd.TabIndex = 113;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Coolvetica Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(29, 82);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(104, 30);
            this.textBox7.TabIndex = 111;
            this.textBox7.Text = "Site Adı:";
            // 
            // dgvSiteler
            // 
            this.dgvSiteler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiteler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiteler.Location = new System.Drawing.Point(29, 162);
            this.dgvSiteler.Name = "dgvSiteler";
            this.dgvSiteler.ReadOnly = true;
            this.dgvSiteler.Size = new System.Drawing.Size(302, 113);
            this.dgvSiteler.TabIndex = 118;
            this.dgvSiteler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiteler_CellClick);
            // 
            // dgvApartmanBlok
            // 
            this.dgvApartmanBlok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApartmanBlok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartmanBlok.Location = new System.Drawing.Point(29, 406);
            this.dgvApartmanBlok.Name = "dgvApartmanBlok";
            this.dgvApartmanBlok.ReadOnly = true;
            this.dgvApartmanBlok.Size = new System.Drawing.Size(302, 113);
            this.dgvApartmanBlok.TabIndex = 119;
            this.dgvApartmanBlok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApartmanBlok_CellClick);
            // 
            // TxtSiteid
            // 
            this.TxtSiteid.Font = new System.Drawing.Font("Coolvetica Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSiteid.Location = new System.Drawing.Point(132, 53);
            this.TxtSiteid.Name = "TxtSiteid";
            this.TxtSiteid.ReadOnly = true;
            this.TxtSiteid.Size = new System.Drawing.Size(199, 30);
            this.TxtSiteid.TabIndex = 121;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Coolvetica Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(29, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(104, 30);
            this.textBox4.TabIndex = 120;
            this.textBox4.Text = "Site Id:";
            // 
            // TxtBlokid
            // 
            this.TxtBlokid.Font = new System.Drawing.Font("Coolvetica Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBlokid.Location = new System.Drawing.Point(155, 298);
            this.TxtBlokid.Name = "TxtBlokid";
            this.TxtBlokid.ReadOnly = true;
            this.TxtBlokid.Size = new System.Drawing.Size(176, 30);
            this.TxtBlokid.TabIndex = 123;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Coolvetica Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(29, 298);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(127, 30);
            this.textBox6.TabIndex = 122;
            this.textBox6.Text = "Apart-Blok Id:";
            // 
            // FrmSiteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 541);
            this.Controls.Add(this.TxtBlokid);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.TxtSiteid);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dgvApartmanBlok);
            this.Controls.Add(this.dgvSiteler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TxtApartmanBlok);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtSiteAd);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSiteEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSiteEkle";
            this.Load += new System.EventHandler(this.FrmSiteEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiteler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmanBlok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox TxtApartmanBlok;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtSiteAd;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dgvSiteler;
        private System.Windows.Forms.DataGridView dgvApartmanBlok;
        private System.Windows.Forms.TextBox TxtSiteid;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TxtBlokid;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}