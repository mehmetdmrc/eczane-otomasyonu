namespace otomosyan_projesi
{
    partial class AyarlarForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPersonel = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbRol = new ComboBox();
            txtSoyisim = new TextBox();
            txtIsim = new TextBox();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPersonel
            // 
            dgvPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonel.BackgroundColor = Color.White;
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonel.Location = new Point(12, 12);
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.RowHeadersWidth = 51;
            dgvPersonel.Size = new Size(776, 200);
            dgvPersonel.TabIndex = 0;
            dgvPersonel.CellClick += dgvPersonel_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbRol);
            groupBox1.Controls.Add(txtSoyisim);
            groupBox1.Controls.Add(txtIsim);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 218);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel İşlemleri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 123);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 12;
            label5.Text = "Rol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 83);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 11;
            label4.Text = "Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 43);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 10;
            label3.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 83);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 9;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 43);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 8;
            label1.Text = "Kullanıcı Adı";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Müdür", "Personel" });
            cmbRol.Location = new Point(120, 120);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(150, 28);
            cmbRol.TabIndex = 7;
            // 
            // txtSoyisim
            // 
            txtSoyisim.BorderStyle = BorderStyle.FixedSingle;
            txtSoyisim.Location = new Point(380, 80);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(150, 27);
            txtSoyisim.TabIndex = 6;
            // 
            // txtIsim
            // 
            txtIsim.BorderStyle = BorderStyle.FixedSingle;
            txtIsim.Location = new Point(380, 40);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(150, 27);
            txtIsim.TabIndex = 5;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Location = new Point(120, 80);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(150, 27);
            txtSifre.TabIndex = 4;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKullaniciAdi.Location = new Point(120, 40);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(150, 27);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.Location = new Point(580, 140);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 40);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightBlue;
            btnGuncelle.FlatStyle = FlatStyle.Popup;
            btnGuncelle.Location = new Point(580, 90);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(150, 40);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LawnGreen;
            btnEkle.FlatStyle = FlatStyle.Popup;
            btnEkle.Location = new Point(580, 40);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(150, 40);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // AyarlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvPersonel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AyarlarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Personel Yönetimi";
            Load += AyarlarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
