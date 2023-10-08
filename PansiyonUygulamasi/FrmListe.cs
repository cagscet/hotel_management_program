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
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PansiyonUygulamasi
{
    public partial class FrmListe : Form
    {
        public FrmListe()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GSOHK16\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from MusteriEkle",baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read()) 
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["Odano"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Giris"].ToString());
                ekle.SubItems.Add(oku["Cikis"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAnaMenu fr = new FrmAnaMenu();
            fr.Show();
            this.Hide();
        }

        private void FrmListe_FormClosing(object sender, FormClosingEventArgs e)
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

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAd.Text= listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoy.Text = listView1.SelectedItems[0].SubItems[2].Text;
            combobox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmListe_Load(object sender, EventArgs e)
        {

        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            if(TxtOda.Text == "101")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from oda101", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOda.Text == "102")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from oda102", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOda.Text == "103")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from oda103", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOda.Text == "104")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from oda104", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOda.Text == "105")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from oda105", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOda.Text == "106")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from oda106", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOda.Text == "107")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from oda107", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOda.Text == "108")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from oda108", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }



        }

        private void BtnGun_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update MusteriEkle SET Adi='" + TxtAd.Text + "',Soyadi='" + TxtSoy.Text + "',Cinsiyet='" + combobox1.Text + "',Telefon='" + TxtTel.Text+"'where ID=" + id + "", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from MusteriEkle where adi like '%"+ TxtAra.Text+"%'", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["Odano"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Giris"].ToString());
                ekle.SubItems.Add(oku["Cikis"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }
    }
}
//Data Source=DESKTOP-GSOHK16\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True
//SqlCommand cmd = new SqlCommand("delete from MusteriEkle where ID=(" + id + ")", baglanti);