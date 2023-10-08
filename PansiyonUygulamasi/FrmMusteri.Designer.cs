namespace PansiyonUygulamasi
{
    partial class FrmMusteri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnKyt = new System.Windows.Forms.Button();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtOda = new System.Windows.Forms.TextBox();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtSoy = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDolu = new System.Windows.Forms.Button();
            this.btnBos = new System.Windows.Forms.Button();
            this.btn108 = new System.Windows.Forms.Button();
            this.btn107 = new System.Windows.Forms.Button();
            this.btn106 = new System.Windows.Forms.Button();
            this.btn105 = new System.Windows.Forms.Button();
            this.btn104 = new System.Windows.Forms.Button();
            this.btn103 = new System.Windows.Forms.Button();
            this.btn102 = new System.Windows.Forms.Button();
            this.btn101 = new System.Windows.Forms.Button();
            this.BtnAnaMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtucret);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.combobox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.BtnKyt);
            this.groupBox1.Controls.Add(this.TxtTel);
            this.groupBox1.Controls.Add(this.TxtOda);
            this.groupBox1.Controls.Add(this.TxtTc);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtSoy);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(10, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Kalınacak gün :";
            // 
            // txtucret
            // 
            this.txtucret.Enabled = false;
            this.txtucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtucret.Location = new System.Drawing.Point(164, 276);
            this.txtucret.MaxLength = 15;
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(163, 26);
            this.txtucret.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(168, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "0";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // combobox1
            // 
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Items.AddRange(new object[] {
            "",
            "ERKEK",
            "KADIN"});
            this.combobox1.Location = new System.Drawing.Point(164, 97);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(166, 21);
            this.combobox1.TabIndex = 3;
            this.combobox1.SelectedIndexChanged += new System.EventHandler(this.ComboCin_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(63, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 41;
            this.label11.Text = "Cinsiyet :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(87, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Ücret :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(167, 350);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 311);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // BtnKyt
            // 
            this.BtnKyt.BackColor = System.Drawing.SystemColors.Window;
            this.BtnKyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKyt.Location = new System.Drawing.Point(233, 381);
            this.BtnKyt.Name = "BtnKyt";
            this.BtnKyt.Size = new System.Drawing.Size(109, 39);
            this.BtnKyt.TabIndex = 11;
            this.BtnKyt.Text = "KAYDET";
            this.BtnKyt.UseVisualStyleBackColor = false;
            this.BtnKyt.Click += new System.EventHandler(this.BtnKyt_Click);
            // 
            // TxtTel
            // 
            this.TxtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTel.Location = new System.Drawing.Point(166, 133);
            this.TxtTel.Mask = "(90) 000 000 0000 ";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(163, 22);
            this.TxtTel.TabIndex = 4;
            // 
            // TxtOda
            // 
            this.TxtOda.Enabled = false;
            this.TxtOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOda.Location = new System.Drawing.Point(166, 241);
            this.TxtOda.MaxLength = 5;
            this.TxtOda.Name = "TxtOda";
            this.TxtOda.Size = new System.Drawing.Size(162, 22);
            this.TxtOda.TabIndex = 7;
            // 
            // TxtTc
            // 
            this.TxtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTc.Location = new System.Drawing.Point(167, 205);
            this.TxtTc.MaxLength = 11;
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(163, 22);
            this.TxtTc.TabIndex = 6;
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(166, 168);
            this.TxtMail.MaxLength = 40;
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(163, 21);
            this.TxtMail.TabIndex = 5;
            // 
            // TxtSoy
            // 
            this.TxtSoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoy.Location = new System.Drawing.Point(166, 61);
            this.TxtSoy.MaxLength = 15;
            this.TxtSoy.Name = "TxtSoy";
            this.TxtSoy.Size = new System.Drawing.Size(163, 22);
            this.TxtSoy.TabIndex = 2;
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(166, 26);
            this.TxtAd.MaxLength = 15;
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(163, 22);
            this.TxtAd.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Çıkış Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(42, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Giriş Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Oda Numarası :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(78, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "TC No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(99, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.btnDolu);
            this.groupBox2.Controls.Add(this.btnBos);
            this.groupBox2.Controls.Add(this.btn108);
            this.groupBox2.Controls.Add(this.btn107);
            this.groupBox2.Controls.Add(this.btn106);
            this.groupBox2.Controls.Add(this.btn105);
            this.groupBox2.Controls.Add(this.btn104);
            this.groupBox2.Controls.Add(this.btn103);
            this.groupBox2.Controls.Add(this.btn102);
            this.groupBox2.Controls.Add(this.btn101);
            this.groupBox2.Location = new System.Drawing.Point(389, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 378);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // btnDolu
            // 
            this.btnDolu.BackColor = System.Drawing.Color.Crimson;
            this.btnDolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDolu.Location = new System.Drawing.Point(76, 324);
            this.btnDolu.Name = "btnDolu";
            this.btnDolu.Size = new System.Drawing.Size(59, 44);
            this.btnDolu.TabIndex = 21;
            this.btnDolu.Text = "DOLU";
            this.btnDolu.UseVisualStyleBackColor = false;
            this.btnDolu.Click += new System.EventHandler(this.btnDolu_Click);
            // 
            // btnBos
            // 
            this.btnBos.BackColor = System.Drawing.Color.Green;
            this.btnBos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBos.Location = new System.Drawing.Point(11, 324);
            this.btnBos.Name = "btnBos";
            this.btnBos.Size = new System.Drawing.Size(59, 44);
            this.btnBos.TabIndex = 20;
            this.btnBos.Text = "BOŞ";
            this.btnBos.UseVisualStyleBackColor = false;
            this.btnBos.Click += new System.EventHandler(this.btnBos_Click);
            // 
            // btn108
            // 
            this.btn108.BackColor = System.Drawing.Color.Green;
            this.btn108.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn108.Location = new System.Drawing.Point(145, 202);
            this.btn108.Name = "btn108";
            this.btn108.Size = new System.Drawing.Size(91, 61);
            this.btn108.TabIndex = 19;
            this.btn108.Text = "108";
            this.btn108.UseVisualStyleBackColor = false;
            this.btn108.Click += new System.EventHandler(this.btn108_Click);
            // 
            // btn107
            // 
            this.btn107.BackColor = System.Drawing.Color.Green;
            this.btn107.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn107.Location = new System.Drawing.Point(11, 202);
            this.btn107.Name = "btn107";
            this.btn107.Size = new System.Drawing.Size(91, 61);
            this.btn107.TabIndex = 18;
            this.btn107.Text = "107";
            this.btn107.UseVisualStyleBackColor = false;
            this.btn107.Click += new System.EventHandler(this.btn107_Click);
            // 
            // btn106
            // 
            this.btn106.BackColor = System.Drawing.Color.Green;
            this.btn106.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn106.Location = new System.Drawing.Point(269, 127);
            this.btn106.Name = "btn106";
            this.btn106.Size = new System.Drawing.Size(91, 61);
            this.btn106.TabIndex = 17;
            this.btn106.Text = "106";
            this.btn106.UseVisualStyleBackColor = false;
            this.btn106.Click += new System.EventHandler(this.btn106_Click);
            // 
            // btn105
            // 
            this.btn105.BackColor = System.Drawing.Color.Green;
            this.btn105.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn105.Location = new System.Drawing.Point(145, 127);
            this.btn105.Name = "btn105";
            this.btn105.Size = new System.Drawing.Size(91, 61);
            this.btn105.TabIndex = 16;
            this.btn105.Text = "105";
            this.btn105.UseVisualStyleBackColor = false;
            this.btn105.Click += new System.EventHandler(this.btn105_Click);
            // 
            // btn104
            // 
            this.btn104.BackColor = System.Drawing.Color.Green;
            this.btn104.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn104.Location = new System.Drawing.Point(11, 127);
            this.btn104.Name = "btn104";
            this.btn104.Size = new System.Drawing.Size(91, 61);
            this.btn104.TabIndex = 15;
            this.btn104.Text = "104";
            this.btn104.UseVisualStyleBackColor = false;
            this.btn104.Click += new System.EventHandler(this.btn104_Click);
            // 
            // btn103
            // 
            this.btn103.BackColor = System.Drawing.Color.Green;
            this.btn103.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn103.Location = new System.Drawing.Point(269, 43);
            this.btn103.Name = "btn103";
            this.btn103.Size = new System.Drawing.Size(91, 61);
            this.btn103.TabIndex = 14;
            this.btn103.Text = "103";
            this.btn103.UseVisualStyleBackColor = false;
            this.btn103.Click += new System.EventHandler(this.btn103_Click);
            // 
            // btn102
            // 
            this.btn102.BackColor = System.Drawing.Color.Green;
            this.btn102.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn102.Location = new System.Drawing.Point(145, 43);
            this.btn102.Name = "btn102";
            this.btn102.Size = new System.Drawing.Size(91, 61);
            this.btn102.TabIndex = 13;
            this.btn102.Text = "102";
            this.btn102.UseVisualStyleBackColor = false;
            this.btn102.Click += new System.EventHandler(this.btn102_Click);
            // 
            // btn101
            // 
            this.btn101.BackColor = System.Drawing.Color.Green;
            this.btn101.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn101.Location = new System.Drawing.Point(11, 43);
            this.btn101.Name = "btn101";
            this.btn101.Size = new System.Drawing.Size(91, 61);
            this.btn101.TabIndex = 12;
            this.btn101.Text = "101";
            this.btn101.UseVisualStyleBackColor = false;
            this.btn101.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAnaMenu
            // 
            this.BtnAnaMenu.BackColor = System.Drawing.SystemColors.Window;
            this.BtnAnaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnaMenu.Location = new System.Drawing.Point(668, 396);
            this.BtnAnaMenu.Name = "BtnAnaMenu";
            this.BtnAnaMenu.Size = new System.Drawing.Size(109, 39);
            this.BtnAnaMenu.TabIndex = 22;
            this.BtnAnaMenu.Text = "ANA MENÜ";
            this.BtnAnaMenu.UseVisualStyleBackColor = false;
            this.BtnAnaMenu.Click += new System.EventHandler(this.BtnAnaMenu_Click);
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAnaMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusteri";
            this.Text = "Yeni Müşteri ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMusteri_FormClosing);
            this.Load += new System.EventHandler(this.FrmMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKyt;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.TextBox TxtOda;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtSoy;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn101;
        private System.Windows.Forms.Button btn108;
        private System.Windows.Forms.Button btn107;
        private System.Windows.Forms.Button btn106;
        private System.Windows.Forms.Button btn105;
        private System.Windows.Forms.Button btn104;
        private System.Windows.Forms.Button btn103;
        private System.Windows.Forms.Button btn102;
        private System.Windows.Forms.Button btnDolu;
        private System.Windows.Forms.Button btnBos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnAnaMenu;
        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Label label13;
    }
}