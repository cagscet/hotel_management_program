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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGir_Click(object sender, EventArgs e)
        {
            if (TxtKullanici.Text == "Admin" && TxtSifre.Text=="12345")
            {
                FrmAnaMenu fr = new FrmAnaMenu();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre hatalı. ");
            }
        }

        private void FrmAdminGiris_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
