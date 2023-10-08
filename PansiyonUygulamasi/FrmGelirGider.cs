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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PansiyonUygulamasi
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
            timer1.Start();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GSOHK16\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True");
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label22.Text = DateTime.Now.ToLongDateString();
            label23.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnSonuc_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT sum(Ucret)as toplam from MusteriEkle ",baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read()) 
            {
                LblKasa.Text = oku["toplam"].ToString();

            }
            baglanti.Close();


            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sayi3 = Convert.ToDouble(textBox3.Text);
            double sayi4 = Convert.ToDouble(textBox4.Text);
            double sayi5 = Convert.ToDouble(textBox5.Text);

            double sayi6 = Convert.ToDouble(LblKasa.Text);

            double sayi7 = Convert.ToDouble(TxtE.Text);
            double sayi8 = Convert.ToDouble(TxtS.Text);
            double sayi9 = Convert.ToDouble(TxtD.Text);


            TxtFatura.Text = Convert.ToString(sayi7 + sayi8+ sayi9);
            textBox6.Text = Convert.ToString(sayi1 + sayi2 + sayi3 + sayi4 + sayi5);
            labelsonuc.Text = Convert.ToString(sayi6 - sayi1 - sayi2 - sayi3 - sayi4 - sayi5  - sayi7 - sayi8 - sayi9);

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaMenu fr = new FrmAnaMenu();
            fr.Show();
            this.Hide();
        }

        private void LblFatura_Click(object sender, EventArgs e)
        {

        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {

        }

        private void TxtFatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmGelirGider_FormClosing(object sender, FormClosingEventArgs e)
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

        private void LblKasa_Click(object sender, EventArgs e)
        {

        }
    }
}
