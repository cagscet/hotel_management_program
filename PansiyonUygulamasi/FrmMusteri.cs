using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PansiyonUygulamasi
{
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
            //baglanti.ConnectionString = "Data Source=DESKTOP-GSOHK16\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True";
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GSOHK16\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True");

        //string connectionString = "Data Source=DESKTOP-GSOHK16\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True";
        //SqlConnection baglanti = new SqlConnection("connectionString");




        private void button2_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "101";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into oda101(Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoy.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "102";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into oda102(Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoy.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "103";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into oda103(Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoy.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "104";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into oda104(Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoy.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "105";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into oda105(Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoy.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "106";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into oda106(Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoy.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "107";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into oda107(Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoy.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "108";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into oda108(Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoy.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli numaralar dolu odaları temsil eder.");
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli odalar boş odaları temsil eder.");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu fr = new FrmAnaMenu();
            fr.Show();
            this.Hide();
        }

        private void BtnKyt_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,Tc,Odano,Ucret,Giris,Cikis) values('" + TxtAd.Text+ "','"+ TxtSoy.Text + "','"+ combobox1.Text+"','"+TxtTel.Text+ "','"+TxtMail.Text+ "','"+TxtTc.Text+ "','"+TxtOda.Text+ "','"+txtucret.Text+ "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboCin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmMusteri_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Programı kapatmak istiyormusunuz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            if (secim == DialogResult.No)
            {
                e.Cancel = true;
                MessageBox.Show("Çıkış işlemi iptal edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            //oda 1
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku1 = cmd.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();
                //btn101.BackColor = Color.Red;
            }
            baglanti.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
                btn101.Enabled = false;
            }


            //oda 2
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select * from oda102", baglanti);
            SqlDataReader oku2 = cmd1.ExecuteReader();

            while (oku2.Read())
            {
                btn102.Text = oku2["adi"].ToString() + " " + oku2["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
                btn102.Enabled = false;
            }

            //oda 3
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select * from oda103", baglanti);
            SqlDataReader oku3 = cmd3.ExecuteReader();

            while (oku3.Read())
            {
                btn103.Text = oku3["adi"].ToString() + " " + oku3["soyadi"].ToString();

            }
            baglanti.Close();
            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
                btn103.Enabled = false;
            }

            //oda 4
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("select * from oda104", baglanti);
            SqlDataReader oku4 = cmd4.ExecuteReader();

            while (oku4.Read())
            {
                btn104.Text = oku4["adi"].ToString() + " " + oku4["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
                btn104.Enabled = false;
            }


            //oda 5
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("select * from oda105", baglanti);
            SqlDataReader oku5 = cmd5.ExecuteReader();

            while (oku5.Read())
            {
                btn105.Text = oku5["adi"].ToString() + " " + oku5["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
                btn105.Enabled = false;
            }


            //oda 6
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("select * from oda106", baglanti);
            SqlDataReader oku6 = cmd6.ExecuteReader();

            while (oku6.Read())
            {
                btn106.Text = oku6["adi"].ToString() + " " + oku6["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
                btn106.Enabled = false;
            }

            //oda 7
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select * from oda107", baglanti);
            SqlDataReader oku7 = cmd7.ExecuteReader();

            while (oku7.Read())
            {
                btn107.Text = oku7["adi"].ToString() + " " + oku7["soyadi"].ToString();
                //btn107.BackColor = Color.Red;
                
            }
            baglanti.Close();
            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
                btn107.Enabled = false;
            }

            //oda 8
            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("select * from oda108", baglanti);
            SqlDataReader oku8 = cmd8.ExecuteReader();

            while (oku8.Read())
            {
                btn108.Text = oku8["adi"].ToString() + " " + oku8["soyadi"].ToString();
               // btn108.BackColor = Color.Red;
            }
            baglanti.Close();

            if (btn108.Text != "108")
            {
               btn108.BackColor = Color.Red;
               btn108.Enabled = false;
            }





        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-GSOHK16\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True