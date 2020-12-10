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
    public partial class GayrimenkulKayit : Form
    {
        public GayrimenkulKayit()
        {
            InitializeComponent();
        }

        int mov;
        int movX;
        int movY;

        BaglantiSinif bgl = new BaglantiSinif();
        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UL405C7\\SQLEXPRESS;Initial Catalog=AslanbayGayrimenkul;Integrated Security=True");
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();

            SqlCommand komut = new SqlCommand("Insert into Tbl_Kayitlar (SiteAd, BlokAd, DaireNo, OturanAd, OturanTelefon, Adres, MülkDurum, Depozito, DepozitoOdeme, KBasTarihi, KBitTarihi, KullanimSekli, OdemeTarihi, TakipUcret, Kira, Aidat, DSahibiAd, DSahibiTelefon, DSahibiAdres, MülkTipi, OdaSayisi, Kat, Alan, Isinma, BinaYas, ElektrikNo, SuNo, GazNo, OnemliNot) values (@p1, @p2, @p3,@p4,@p5,@p6, @p7, @p8,@p9,@p10,@p11, @p12, @p13,@p14,@p15,@p16, @p17, @p18,@p19,@p20,@p21, @p22, @p23,@p24,@p25,@p26, @p27, @p28,@p29)", conn);
            komut.Parameters.AddWithValue("@p1", CmbSiteAd.Text);
            komut.Parameters.AddWithValue("@p2", CmbBlok.Text);
            komut.Parameters.AddWithValue("@p3", TxtDaire.Text);
            komut.Parameters.AddWithValue("@p4", TxtOturan.Text);
            komut.Parameters.AddWithValue("@p5", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p7", CmbMulk.Text);
            komut.Parameters.AddWithValue("@p8", TxtDepozito.Text);
            komut.Parameters.AddWithValue("@p9", TxtDepOdeme.Text);
            komut.Parameters.AddWithValue("@p10", dateTimeBaslangic.Text);
            komut.Parameters.AddWithValue("@p11", dateTimeBitis.Text);
            komut.Parameters.AddWithValue("@p12", CmbKullanim.Text);
            komut.Parameters.AddWithValue("@p13", dateTimeOdemeTarih.Text);
            komut.Parameters.AddWithValue("@p14", TxtTakip.Text);
            komut.Parameters.AddWithValue("@p15", TxtKira.Text);
            komut.Parameters.AddWithValue("@p16", TxtAidat.Text);
            komut.Parameters.AddWithValue("@p17", TxtDaireSahibiAdı.Text);
            komut.Parameters.AddWithValue("@p18", MskDaireSahibiTelefon.Text);
            komut.Parameters.AddWithValue("@p19", TxtDaireSahibiAdres.Text);
            komut.Parameters.AddWithValue("@p20", CmbMulkTipi.Text);
            komut.Parameters.AddWithValue("@p21", CmbOdaSayisi.Text);
            komut.Parameters.AddWithValue("@p22", TxtKat.Text);
            komut.Parameters.AddWithValue("@p23", TxtAlan.Text);
            komut.Parameters.AddWithValue("@p24", CmbIsinma.Text);
            komut.Parameters.AddWithValue("@p25", TxtBinaYas.Text);
            komut.Parameters.AddWithValue("@p26", TxtElektrik.Text);
            komut.Parameters.AddWithValue("@p27", TxtSu.Text);
            komut.Parameters.AddWithValue("@p28", TxtGaz.Text);
            komut.Parameters.AddWithValue("@p29", TxtOnemliNot.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgiler Eklendi!");

            conn.Close();

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void GayrimenkulKayit_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Siteler", conn);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbSiteAd.Items.Add(dr["Site"]);
            }
            conn.Close();

            conn.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Tbl_BlokApartman", conn);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBlok.Items.Add(dr2["BlokApartman"]);
            }
            conn.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
