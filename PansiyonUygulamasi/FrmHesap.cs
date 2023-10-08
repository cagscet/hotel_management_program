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
    public partial class FrmHesap : Form
    {

        char _islem;
        bool _ekranTemiz;
        int _ilkSayi;



        public FrmHesap()
        {
            InitializeComponent();
        }

        private void FrmHesap_Load(object sender, EventArgs e)
        {

        }

        private void FrmHesap_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnAna_Click(object sender, EventArgs e)
        {
            FrmAnaMenu fr = new FrmAnaMenu();
            fr.Show();
            this.Hide();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz)
            {
                label1.Text = " ";
                _ekranTemiz = false;

            }

            if (label1.Text == "0") label1.Text = " ";
            {
                label1.Text += "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz)
            {
                label1.Text = " ";
                _ekranTemiz = false;

            }
            if (label1.Text == "0") label1.Text = " ";
            {
                label1.Text += "2";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz)
            {
                label1.Text = " ";
                _ekranTemiz = false;

            }
            if (label1.Text == "0") label1.Text = " ";
            {
                label1.Text += "3";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz)
            {
                label1.Text = " ";
                _ekranTemiz = false;

            }
            if (label1.Text == "0") label1.Text = " ";
            {
                label1.Text += "4";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz)
            {
                label1.Text = " ";
                _ekranTemiz = false;

            }
            if (label1.Text == "0") label1.Text = " ";
            {
                label1.Text += "5";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz)
            {
                label1.Text = " ";
                _ekranTemiz = false;

            }

            if (label1.Text == "0") label1.Text = " ";
            {
                label1.Text += "6";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz)
            {
                label1.Text = " ";
                _ekranTemiz = false;

            }
            if (label1.Text == "0") label1.Text = " ";
            {
                label1.Text += "7";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz)
            {
                label1.Text = " ";
                _ekranTemiz = false;

            }
            if (label1.Text == "0") label1.Text = " ";
            {
                label1.Text += "8";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz)
            {
                label1.Text = " ";
                _ekranTemiz = false;

            }
            if (label1.Text == "0") label1.Text = " ";
            {
                label1.Text += "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz)
            {
                label1.Text = " ";
                _ekranTemiz = false;

            }
            if (label1.Text == "0") label1.Text = " ";
            {
                label1.Text += "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void BtnToplam_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemiz = true;
            _ilkSayi = Convert.ToInt32(label1.Text);


        }

        private void BtnEsit_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(label1.Text);
            int sonuc;

            switch (_islem) 
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;

                default:
                    sonuc=0;
                    break;
                    
            }
            label1.Text = Convert.ToString(sonuc);

        }

        private void BtnEksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemiz = true;
            _ilkSayi = Convert.ToInt32(label1.Text);
        }

        private void BtnCarpi_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemiz = true;
            _ilkSayi = Convert.ToInt32(label1.Text);
        }

        private void BtnBol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemiz = true;
            _ilkSayi = Convert.ToInt32(label1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
