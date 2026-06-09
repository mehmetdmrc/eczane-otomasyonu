namespace otomosyan_projesi
{
    partial class formanasayfa
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
            btnCikis = new Button();
            btnYeniIlac = new Button();
            btnSatisYonetimi = new Button();
            btnStokYonetimi = new Button();
            label1 = new Label();
            btnRaporlama = new Button();
            btnAyarlar = new Button();
            SuspendLayout();
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.IndianRed;
            btnCikis.FlatStyle = FlatStyle.Popup;
            btnCikis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikis.Location = new Point(387, 305);
            btnCikis.Margin = new Padding(3, 4, 3, 4);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(148, 45);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnYeniIlac
            // 
            btnYeniIlac.BackColor = Color.Honeydew;
            btnYeniIlac.FlatStyle = FlatStyle.Popup;
            btnYeniIlac.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnYeniIlac.Location = new Point(25, 182);
            btnYeniIlac.Margin = new Padding(3, 4, 3, 4);
            btnYeniIlac.Name = "btnYeniIlac";
            btnYeniIlac.Size = new Size(171, 70);
            btnYeniIlac.TabIndex = 1;
            btnYeniIlac.Text = "Yeni İlaç Ekle";
            btnYeniIlac.UseVisualStyleBackColor = false;
            btnYeniIlac.Click += btnYeniIlac_Click;
            // 
            // btnSatisYonetimi
            // 
            btnSatisYonetimi.BackColor = Color.Honeydew;
            btnSatisYonetimi.FlatStyle = FlatStyle.Popup;
            btnSatisYonetimi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSatisYonetimi.Location = new Point(259, 182);
            btnSatisYonetimi.Margin = new Padding(3, 4, 3, 4);
            btnSatisYonetimi.Name = "btnSatisYonetimi";
            btnSatisYonetimi.Size = new Size(171, 70);
            btnSatisYonetimi.TabIndex = 2;
            btnSatisYonetimi.Text = "Satış Yönetimi";
            btnSatisYonetimi.UseVisualStyleBackColor = false;
            btnSatisYonetimi.Click += btnSatisYonetimi_Click;
            // 
            // btnStokYonetimi
            // 
            btnStokYonetimi.BackColor = Color.Honeydew;
            btnStokYonetimi.FlatStyle = FlatStyle.Popup;
            btnStokYonetimi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStokYonetimi.Location = new Point(490, 182);
            btnStokYonetimi.Margin = new Padding(3, 4, 3, 4);
            btnStokYonetimi.Name = "btnStokYonetimi";
            btnStokYonetimi.Size = new Size(171, 70);
            btnStokYonetimi.TabIndex = 3;
            btnStokYonetimi.Text = "Stok Yönetimi";
            btnStokYonetimi.UseVisualStyleBackColor = false;
            btnStokYonetimi.Click += btnStokYonetimi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(277, 78);
            label1.Name = "label1";
            label1.Size = new Size(384, 50);
            label1.TabIndex = 6;
            label1.Text = "Eczane Otomasyonu";
            // 
            // btnRaporlama
            // 
            btnRaporlama.BackColor = Color.Honeydew;
            btnRaporlama.FlatStyle = FlatStyle.Popup;
            btnRaporlama.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRaporlama.Location = new Point(725, 182);
            btnRaporlama.Margin = new Padding(3, 4, 3, 4);
            btnRaporlama.Name = "btnRaporlama";
            btnRaporlama.Size = new Size(171, 70);
            btnRaporlama.TabIndex = 7;
            btnRaporlama.Text = "Raporlama";
            btnRaporlama.UseVisualStyleBackColor = false;
            btnRaporlama.Click += btnRaporlama_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.Tan;
            btnAyarlar.FlatStyle = FlatStyle.Popup;
            btnAyarlar.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAyarlar.Location = new Point(12, 13);
            btnAyarlar.Margin = new Padding(3, 4, 3, 4);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(80, 43);
            btnAyarlar.TabIndex = 8;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // formanasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 413);
            Controls.Add(label1);
            Controls.Add(btnStokYonetimi);
            Controls.Add(btnSatisYonetimi);
            Controls.Add(btnYeniIlac);
            Controls.Add(btnCikis);
            Controls.Add(btnRaporlama);
            Controls.Add(btnAyarlar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formanasayfa";
            Text = "Ana Sayfa";
            Load += formanasayfa_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYeniIlac;
        private System.Windows.Forms.Button btnSatisYonetimi;
        private System.Windows.Forms.Button btnStokYonetimi;
        private System.Windows.Forms.Button btnDepoYonetimi;
        private System.Windows.Forms.Button btnSiparisYonetimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRaporlama;
        private System.Windows.Forms.Button btnAyarlar;
    }
}