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
    public partial class GayrimenkulGuncelle : Form
    {
        int mov;
        int movX;
        int movY;

        public GayrimenkulGuncelle()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection conn=new SqlConnection(bgl.Adres);
            conn.Open();

            SqlCommand komut= new SqlCommand("Update Tbl_Kayitlar set SiteAd=@p1, BlokAd=@p2, DaireNo=@p3, OturanAd=@p4, OturanTelefon=@p5, Adres=@p6, MülkDurum=@p7, Depozito=@p8, DepozitoOdeme=@p9, KBasTarihi=@p10, KBitTarihi=@p11, KullanimSekli=@p12, OdemeTarihi=@p13, TakipUcret=@p14, Kira=@p15, Aidat=@p16, DSahibiAd=@p17, DSahibiTelefon=@p18, DSahibiAdres=@p19, MülkTipi=@p20, OdaSayisi=@p21, Kat=@p22, Alan=@p23, Isinma=@p24, BinaYas=@p25, ElektrikNo=@p26, SuNo=@p27, GazNo=@p28, OnemliNot=@p29 where KayitId=@p30", conn);
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
            komut.Parameters.AddWithValue("@p30",TxtKayitId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgiler Güncellendi!");

            conn.Close();
        }

        public string KayitNo;
        private void GayrimenkulGuncelle_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            TxtKayitId.Text = KayitNo;
            
            conn.Open();
            SqlCommand komut1 = new SqlCommand("Select * From Tbl_Kayitlar where KayitId=@p1", conn);
            komut1.Parameters.AddWithValue("@p1", TxtKayitId.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                CmbSiteAd.Text = dr1[1].ToString();
                CmbBlok.Text = dr1[2].ToString();
                TxtDaire.Text = dr1[3].ToString();
                TxtOturan.Text = dr1[4].ToString();
                MskTelefon.Text = dr1[5].ToString();
                TxtAdres.Text = dr1[6].ToString();
                CmbMulk.Text = dr1[7].ToString();
                TxtDepozito.Text = dr1[8].ToString();
                TxtDepOdeme.Text = dr1[9].ToString();
                dateTimeBaslangic.Text = dr1[10].ToString();
                dateTimeBitis.Text = dr1[11].ToString();
                CmbKullanim.Text = dr1[12].ToString();
                dateTimeOdemeTarih.Text= dr1[13].ToString();
                TxtTakip.Text= dr1[14].ToString();
                TxtKira.Text= dr1[15].ToString();
                TxtAidat.Text= dr1[16].ToString();

                TxtDaireSahibiAdı.Text= dr1[17].ToString();
                MskDaireSahibiTelefon.Text= dr1[18].ToString();
                TxtDaireSahibiAdres.Text= dr1[19].ToString();
                CmbMulkTipi.Text= dr1[20].ToString();
                CmbOdaSayisi.Text =dr1[21].ToString();
                TxtKat.Text= dr1[22].ToString();
                TxtAlan.Text= dr1[23].ToString();
                CmbIsinma.Text= dr1[24].ToString();
                TxtBinaYas.Text= dr1[25].ToString();
                TxtElektrik.Text= dr1[26].ToString();
                TxtSu.Text= dr1[27].ToString();
                TxtGaz.Text= dr1[28].ToString();
                TxtOnemliNot.Text= dr1[29].ToString();

            }
            conn.Close();

            //Site adlarını çekme
            conn.Open();

            SqlCommand komut = new SqlCommand("Select SiteAd from Tbl_Kayitlar", conn);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbSiteAd.Items.Add(dr);
            }

            conn.Close();

            //Blok adları çekme
            conn.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Tbl_BlokApartman", conn);
            SqlDataReader dr2;
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBlok.Items.Add(dr2["BlokApartman"]);
            }
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
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}


