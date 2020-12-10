using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Otomasyon
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        int mov;
        int movX;
        int movY;

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Goldenrod;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.Goldenrod;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.Transparent;
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Freelance Yazılım Geliştirici \n\n Emrecan AY \n\n codemrecan@gmail.com \n\n 0535 260 3361 \n\n Sosyal Medya=@codemrecan ", "İletişim", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnYonetim_Click(object sender, EventArgs e)
        {
            FrmYonetim fr = new FrmYonetim();
            fr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSiteEkle fr = new FrmSiteEkle();
            fr.Show();
        }

        private void BtnGayrimenkulKayit_Click(object sender, EventArgs e)
        {
            GayrimenkulKayit fr = new GayrimenkulKayit();           
            fr.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmArsiv fr = new FrmArsiv();
            fr.Show();
            
        }
    }
}
