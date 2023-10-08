namespace PansiyonUygulamasi
{
    partial class FrmStok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblGıda = new System.Windows.Forms.Label();
            this.Lblicecek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGıda = new System.Windows.Forms.TextBox();
            this.TxtIcecek = new System.Windows.Forms.TextBox();
            this.TxtTemiz = new System.Windows.Forms.TextBox();
            this.TxtGenel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Gida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.icecek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temizlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LblGıda
            // 
            this.LblGıda.AutoSize = true;
            this.LblGıda.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGıda.Location = new System.Drawing.Point(110, 23);
            this.LblGıda.Name = "LblGıda";
            this.LblGıda.Size = new System.Drawing.Size(124, 22);
            this.LblGıda.TabIndex = 0;
            this.LblGıda.Text = "Gıda Tutarı :";
            // 
            // Lblicecek
            // 
            this.Lblicecek.AutoSize = true;
            this.Lblicecek.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblicecek.Location = new System.Drawing.Point(93, 61);
            this.Lblicecek.Name = "Lblicecek";
            this.Lblicecek.Size = new System.Drawing.Size(141, 22);
            this.Lblicecek.TabIndex = 1;
            this.Lblicecek.Text = "İçecek Tutarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temilik Ürün Maliyeti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Genel Masraflar :";
            // 
            // TxtGıda
            // 
            this.TxtGıda.Location = new System.Drawing.Point(264, 27);
            this.TxtGıda.Name = "TxtGıda";
            this.TxtGıda.Size = new System.Drawing.Size(100, 20);
            this.TxtGıda.TabIndex = 4;
            this.TxtGıda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtIcecek
            // 
            this.TxtIcecek.Location = new System.Drawing.Point(264, 65);
            this.TxtIcecek.Name = "TxtIcecek";
            this.TxtIcecek.Size = new System.Drawing.Size(100, 20);
            this.TxtIcecek.TabIndex = 5;
            // 
            // TxtTemiz
            // 
            this.TxtTemiz.Location = new System.Drawing.Point(264, 102);
            this.TxtTemiz.Name = "TxtTemiz";
            this.TxtTemiz.Size = new System.Drawing.Size(100, 20);
            this.TxtTemiz.TabIndex = 6;
            // 
            // TxtGenel
            // 
            this.TxtGenel.Location = new System.Drawing.Point(264, 144);
            this.TxtGenel.Name = "TxtGenel";
            this.TxtGenel.Size = new System.Drawing.Size(100, 20);
            this.TxtGenel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(502, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(502, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "ANA MENÜ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Gida,
            this.icecek,
            this.Temizlik,
            this.Genel});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 210);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(668, 161);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Gida
            // 
            this.Gida.Text = "Gida";
            this.Gida.Width = 164;
            // 
            // icecek
            // 
            this.icecek.Text = "icecek";
            this.icecek.Width = 173;
            // 
            // Temizlik
            // 
            this.Temizlik.Text = "Temizlik";
            this.Temizlik.Width = 175;
            // 
            // Genel
            // 
            this.Genel.Text = "Genel";
            this.Genel.Width = 150;
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(663, 369);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtGenel);
            this.Controls.Add(this.TxtTemiz);
            this.Controls.Add(this.TxtIcecek);
            this.Controls.Add(this.TxtGıda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lblicecek);
            this.Controls.Add(this.LblGıda);
            this.Name = "FrmStok";
            this.Text = "FrmStok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStok_FormClosing);
            this.Load += new System.EventHandler(this.FrmStok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGıda;
        private System.Windows.Forms.Label Lblicecek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGıda;
        private System.Windows.Forms.TextBox TxtIcecek;
        private System.Windows.Forms.TextBox TxtTemiz;
        private System.Windows.Forms.TextBox TxtGenel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Gida;
        private System.Windows.Forms.ColumnHeader icecek;
        private System.Windows.Forms.ColumnHeader Temizlik;
        private System.Windows.Forms.ColumnHeader Genel;
    }
}