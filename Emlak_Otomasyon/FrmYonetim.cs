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
using System.Runtime.CompilerServices;

namespace Emlak_Otomasyon
{
    public partial class FrmYonetim : Form
    {
        int mov;
        int movX;
        int movY;


        public FrmYonetim()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();

        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UL405C7\\SQLEXPRESS;Initial Catalog=AslanbayGayrimenkul;Integrated Security=True");
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        
        private void FrmYonetim_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Siteler", conn);
            da.Fill(dt);
            dgvSiteler.DataSource = dt;
            dgvSiteler.Columns[0].Width =35;
            dgvSiteler.Columns[0].HeaderText = "Id";

            // Site adlarını çekme
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("Select * From Tbl_Siteler", baglanti);
            //SqlDataReader dr;
            //dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    CmbSiteAd.Items.Add(dr["Site"]);
            //}
            //baglanti.Close();

            // Blok adları çekme
            //baglanti.Open();
            //SqlCommand komut2 = new SqlCommand("Select * From Tbl_BlokApartman", baglanti);
            //SqlDataReader dr2;
            //dr2 = komut2.ExecuteReader();
            //while (dr2.Read())
            //{
            //    CmbBlok.Items.Add(dr2["BlokApartman"]);
            //}
            //baglanti.Close();

             

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnYeniKayit_Click(object sender, EventArgs e)
        {
            GayrimenkulKayit fr = new GayrimenkulKayit();
            fr.Show();
        }

        private void dgvSiteler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand komut2 = new SqlCommand("Select BlokAd from Tbl_Kayitlar where SiteAd = @p1", conn);
            var result = dgvSiteler.CurrentRow.Cells[1].Value.ToString();
            komut2.Parameters.AddWithValue("@p1", result);
            SqlDataAdapter da = new SqlDataAdapter(komut2); // ek bilgileri girmeye gerek yokmuş. Direk komut 2'de çekmişim zaten.
            da.Fill(dt);
            dgvBlokApartman.DataSource = dt;
            conn.Close();
        }

        private void dgvBlokApartman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand komut2 = new SqlCommand("Select * from Tbl_Kayitlar where SiteAd=@p1 and BlokAd = @p2", conn);
            var result = dgvBlokApartman.CurrentRow.Cells[0].Value.ToString();
            var result2= dgvSiteler.CurrentRow.Cells[1].Value.ToString();
            komut2.Parameters.AddWithValue("@p1", result2);
            komut2.Parameters.AddWithValue("@p2", result);
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            da.Fill(dt);
            dgvDaireOturan.DataSource = dt;
            dgvDaireOturan.Columns[3].Width = 20;
            dgvDaireOturan.Columns[3].HeaderText = "Daire No";
            dgvDaireOturan.Columns[4].HeaderText = "Ad Soyad";
            dgvDaireOturan.Columns[0].Visible = false; //3-4 dışında hepsi false;
            dgvDaireOturan.Columns[1].Visible = false;
            dgvDaireOturan.Columns[2].Visible = false;
            dgvDaireOturan.Columns[5].Visible = false;
            dgvDaireOturan.Columns[6].Visible = false;
            dgvDaireOturan.Columns[7].Visible = false;
            dgvDaireOturan.Columns[8].Visible = false;
            dgvDaireOturan.Columns[9].Visible = false;
            dgvDaireOturan.Columns[10].Visible = false;
            dgvDaireOturan.Columns[11].Visible = false;
            dgvDaireOturan.Columns[12].Visible = false;
            dgvDaireOturan.Columns[13].Visible = false;
            dgvDaireOturan.Columns[14].Visible = false;
            dgvDaireOturan.Columns[15].Visible = false;
            dgvDaireOturan.Columns[16].Visible = false;
            dgvDaireOturan.Columns[17].Visible = false;
            dgvDaireOturan.Columns[18].Visible = false;
            dgvDaireOturan.Columns[19].Visible = false;
            dgvDaireOturan.Columns[20].Visible = false;
            dgvDaireOturan.Columns[21].Visible = false;
            dgvDaireOturan.Columns[22].Visible = false;
            dgvDaireOturan.Columns[23].Visible = false;
            dgvDaireOturan.Columns[24].Visible = false;
            dgvDaireOturan.Columns[25].Visible = false;
            dgvDaireOturan.Columns[26].Visible = false;
            dgvDaireOturan.Columns[27].Visible = false;
            dgvDaireOturan.Columns[28].Visible = false;
            dgvDaireOturan.Columns[29].Visible = false;



            conn.Close();
        }

        private void dgvDaireOturan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            int secilen = dgvDaireOturan.SelectedCells[0].RowIndex;
            TxtKayitId.Text = dgvDaireOturan.Rows[secilen].Cells[0].Value.ToString();
            TxtSite.Text = dgvDaireOturan.Rows[secilen].Cells[1].Value.ToString();
            TxtBlokApartman.Text = dgvDaireOturan.Rows[secilen].Cells[2].Value.ToString();
            TxtDaire.Text = dgvDaireOturan.Rows[secilen].Cells[3].Value.ToString();
            TxtOturan.Text = dgvDaireOturan.Rows[secilen].Cells[4].Value.ToString();
            MskTelefon.Text = dgvDaireOturan.Rows[secilen].Cells[5].Value.ToString();
            TxtAdres.Text = dgvDaireOturan.Rows[secilen].Cells[6].Value.ToString();
            TxtMulkDurum.Text = dgvDaireOturan.Rows[secilen].Cells[7].Value.ToString();
            TxtDepozito.Text = dgvDaireOturan.Rows[secilen].Cells[8].Value.ToString();
            TxtDepOdeme.Text = dgvDaireOturan.Rows[secilen].Cells[9].Value.ToString();
            dTimeBaslangic.Text = dgvDaireOturan.Rows[secilen].Cells[10].Value.ToString();
            dTimeBitis.Text = dgvDaireOturan.Rows[secilen].Cells[11].Value.ToString();
            TxtKullanimSekil.Text = dgvDaireOturan.Rows[secilen].Cells[12].Value.ToString();
            dTimeOdemeTarih.Text = dgvDaireOturan.Rows[secilen].Cells[13].Value.ToString();
            TxtTakip.Text = dgvDaireOturan.Rows[secilen].Cells[14].Value.ToString();
            TxtKira.Text = dgvDaireOturan.Rows[secilen].Cells[15].Value.ToString();
            TxtAidat.Text = dgvDaireOturan.Rows[secilen].Cells[16].Value.ToString();
            TxtDaireSahibiAdı.Text = dgvDaireOturan.Rows[secilen].Cells[17].Value.ToString();
            MskDaireSahibiTelefon.Text = dgvDaireOturan.Rows[secilen].Cells[18].Value.ToString();
            TxtDaireSahibiAdres.Text = dgvDaireOturan.Rows[secilen].Cells[19].Value.ToString();
            TxtMulkTipi.Text = dgvDaireOturan.Rows[secilen].Cells[20].Value.ToString();
            TxtOdaSayisi.Text = dgvDaireOturan.Rows[secilen].Cells[21].Value.ToString();
            TxtKat.Text = dgvDaireOturan.Rows[secilen].Cells[22].Value.ToString();
            TxtAlan.Text = dgvDaireOturan.Rows[secilen].Cells[23].Value.ToString();
            TxtIsinma.Text = dgvDaireOturan.Rows[secilen].Cells[24].Value.ToString();
            TxtBinaYas.Text = dgvDaireOturan.Rows[secilen].Cells[25].Value.ToString();
            TxtElektrik.Text = dgvDaireOturan.Rows[secilen].Cells[26].Value.ToString();
            TxtSu.Text = dgvDaireOturan.Rows[secilen].Cells[27].Value.ToString();
            TxtGaz.Text = dgvDaireOturan.Rows[secilen].Cells[28].Value.ToString();
            TxtOnemliNot.Text = dgvDaireOturan.Rows[secilen].Cells[29].Value.ToString();

            TxtKiraKayitid.Text= dgvDaireOturan.Rows[secilen].Cells[0].Value.ToString();
            TxtKiraci.Text = dgvDaireOturan.Rows[secilen].Cells[4].Value.ToString();

            conn.Open();
            DataTable dt2 = new DataTable();
            SqlCommand komut2 = new SqlCommand("Select * from Tbl_OdemeKayit where AlanKisi=@p1", conn);
            var result = dgvDaireOturan.Rows[secilen].Cells[4].Value.ToString();
            komut2.Parameters.AddWithValue("@p1", result);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            da2.Fill(dt2);
            dgvOdemeler.DataSource = dt2;
            dgvOdemeler.Columns[0].Visible = false;
            dgvOdemeler.Columns[1].Visible = false;
            dgvOdemeler.Columns[2].Visible = false;
            dgvOdemeler.Columns[3].HeaderText = "Kira";
            dgvOdemeler.Columns[3].Width = 50;
            dgvOdemeler.Columns[4].HeaderText = "Tarih";
            dgvOdemeler.Columns[5].HeaderText = "Açıklama";
            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            BindingSource bindingSource = new BindingSource();
            SqlCommand sqlCommand = new SqlCommand(bindingSource.Filter = "Select * From Tbl_Kayitlar where OturanAd like '%" + TxtArama.Text + "%'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dgvDaireOturan.DataSource = dt;
            dgvDaireOturan.DataSource = dt;
            dgvDaireOturan.Columns[3].Width = 30;
            dgvDaireOturan.Columns[3].HeaderText = "Daire No";
            dgvDaireOturan.Columns[4].HeaderText = "Ad Soyad";
            dgvDaireOturan.Columns[0].Visible = false; //3-4 dışında hepsi false;
            dgvDaireOturan.Columns[1].Visible = false;
            dgvDaireOturan.Columns[2].Visible = false;
            dgvDaireOturan.Columns[5].Visible = false;
            dgvDaireOturan.Columns[6].Visible = false;
            dgvDaireOturan.Columns[7].Visible = false;
            dgvDaireOturan.Columns[8].Visible = false;
            dgvDaireOturan.Columns[9].Visible = false;
            dgvDaireOturan.Columns[10].Visible = false;
            dgvDaireOturan.Columns[11].Visible = false;
            dgvDaireOturan.Columns[12].Visible = false;
            dgvDaireOturan.Columns[13].Visible = false;
            dgvDaireOturan.Columns[14].Visible = false;
            dgvDaireOturan.Columns[15].Visible = false;
            dgvDaireOturan.Columns[16].Visible = false;
            dgvDaireOturan.Columns[17].Visible = false;
            dgvDaireOturan.Columns[18].Visible = false;
            dgvDaireOturan.Columns[19].Visible = false;
            dgvDaireOturan.Columns[20].Visible = false;
            dgvDaireOturan.Columns[21].Visible = false;
            dgvDaireOturan.Columns[22].Visible = false;
            dgvDaireOturan.Columns[23].Visible = false;
            dgvDaireOturan.Columns[24].Visible = false;
            dgvDaireOturan.Columns[25].Visible = false;
            dgvDaireOturan.Columns[26].Visible = false;
            dgvDaireOturan.Columns[27].Visible = false;
            dgvDaireOturan.Columns[28].Visible = false;
            dgvDaireOturan.Columns[29].Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand komutAra = new SqlCommand("Select OturanAd From Tbl_Kayitlar where ");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            GayrimenkulGuncelle fr = new GayrimenkulGuncelle();
            fr.KayitNo = TxtKayitId.Text;
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("Insert into Tbl_OdemeKayit (AlanKisi, AlinanKira, KiraTarih, KiraNot) values (@p1,@p2,@p3,@p4)", conn);
            komut.Parameters.AddWithValue("@p1", TxtKiraci.Text);
            komut.Parameters.AddWithValue("@p2", MskKiraAlinan.Text);
            komut.Parameters.AddWithValue("@p3", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@p4", TxtKiraNot.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ödeme Kaydı Eklendi!");
            conn.Close();

        }

        private void dgvDaireOturan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOdemeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvOdemeler.SelectedCells[0].RowIndex;

            TxtKiraKayitid.Text = dgvOdemeler.Rows[secilen].Cells[0].Value.ToString();
            TxtKiraci.Text= dgvOdemeler.Rows[secilen].Cells[2].Value.ToString();
            MskKiraAlinan.Text= dgvOdemeler.Rows[secilen].Cells[3].Value.ToString();
            dateTimePicker1.Text= dgvOdemeler.Rows[secilen].Cells[4].Value.ToString();
            TxtKiraNot.Text= dgvOdemeler.Rows[secilen].Cells[5].Value.ToString();
        }

        private void dateTimePicker1_BindingContextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnYeniKayit_Click_1(object sender, EventArgs e)
        {
            GayrimenkulKayit fr = new GayrimenkulKayit();
            fr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_OdemeKayit set AlanKisi=@p1, AlinanKira=@p2, KiraTarih=@p3, KiraNot=@p4 where OdemeKayitid=@p5", conn);
            komut.Parameters.AddWithValue("@p1", TxtKiraci.Text);
            komut.Parameters.AddWithValue("@p2", MskKiraAlinan.Text);
            komut.Parameters.AddWithValue("@p3", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@p4", TxtKiraNot.Text);
            komut.Parameters.AddWithValue("@p5", TxtKiraKayitid.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Güncellendi!");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov==1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Goldenrod;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
