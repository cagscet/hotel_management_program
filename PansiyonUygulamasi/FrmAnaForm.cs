using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonUygulamasi
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMusteri fr = new FrmMusteri();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmListe fr = new FrmListe();
            fr.Show();
            this.Hide();
        }

        private void FrmAnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                DialogResult secim = new DialogResult();
                secim = MessageBox.Show("Programı kapatmak istiyormusunuz ?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (secim == DialogResult.Yes) 
            {
                Environment.Exit(0);
            }
                if (secim == DialogResult.No) 
            {
                e.Cancel = true;
                MessageBox.Show("Çıkış işlemi iptal edildi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmListe fr = new FrmListe();
            fr.Show();
            this.Hide();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //label1.Text = DateTime.Now.ToLongDateString();
            //label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otel takip uygulaması / 2023 TÜRKİYE, İstanbul / Çağlar Çetin ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaas_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
            this.Hide();    
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            FrmStok fr = new FrmStok();
            fr.Show();
            this.Hide();
        }

        private void BtnHesap_Click(object sender, EventArgs e)
        {
            FrmHesap fr = new FrmHesap();  
            fr.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
