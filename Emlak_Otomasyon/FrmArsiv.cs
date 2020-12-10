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
    public partial class FrmArsiv : Form
    {
        public FrmArsiv()
        {
            InitializeComponent();
        }

        int mov;
        int movX;
        int movY;

        BaglantiSinif bgl = new BaglantiSinif();
        private void FrmArsiv_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Kayitlar ", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Goldenrod;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            BindingSource bindingSource = new BindingSource();
            SqlCommand sqlCommand = new SqlCommand(bindingSource.Filter= "Select * From Tbl_Kayitlar where OturanAd like '%" + TxtArama.Text + "%'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
