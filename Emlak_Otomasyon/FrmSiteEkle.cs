using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Emlak_Otomasyon
{
    public partial class FrmSiteEkle : Form
    {
        public FrmSiteEkle()
        {
            InitializeComponent();
        }

        int mov;
        int movX;
        int movY;

        BaglantiSinif bgl = new BaglantiSinif();
        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        void Listele()
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_siteler", conn);
            da.Fill(dt);
            dgvSiteler.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_BlokApartman", conn);
            da2.Fill(dt2);
            dgvApartmanBlok.DataSource = dt2;
        }

        private void FrmSiteEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgvSiteler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvSiteler.SelectedCells[0].RowIndex;

            TxtSiteid.Text = dgvSiteler.Rows[secilen].Cells[0].Value.ToString();
            TxtSiteAd.Text = dgvSiteler.Rows[secilen].Cells[1].Value.ToString();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komutEkle = new SqlCommand("Insert into Tbl_Siteler (Site) values (@p1)", conn);
            komutEkle.Parameters.AddWithValue("@p1", TxtSiteAd.Text);
            komutEkle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Yeni Site Eklendi!");
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komutEkle = new SqlCommand("Insert into Tbl_BlokApartman (BlokApartman) values (@p1)", conn);
            komutEkle.Parameters.AddWithValue("@p1", TxtApartmanBlok.Text);
            komutEkle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Yeni Blok Eklendi!");
            Listele();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Siteler set Site=@p1 where SiteId=@p2", conn);
            komutGuncelle.Parameters.AddWithValue("@p1", TxtSiteAd.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", TxtSiteid.Text);
            komutGuncelle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Site Adı Güncellendi!");
            Listele();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_BlokApartman set BlokApartman=@p1 where BlokApartmanId=@p2", conn);
            komutGuncelle.Parameters.AddWithValue("@p1", TxtApartmanBlok.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", TxtBlokid.Text);
            komutGuncelle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Blok Adı Güncellendi!");
            Listele();
        }

        private void dgvApartmanBlok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvApartmanBlok.SelectedCells[0].RowIndex;

            TxtBlokid.Text = dgvApartmanBlok.Rows[secilen].Cells[0].Value.ToString();
            TxtApartmanBlok.Text = dgvApartmanBlok.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
