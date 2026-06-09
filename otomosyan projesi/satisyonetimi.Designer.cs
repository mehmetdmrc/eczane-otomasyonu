namespace otomosyan_projesi
{
    partial class satisyonetimi
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
            dgvSatislar = new DataGridView();
            cmbHastalar = new ComboBox();
            cmbIlaclar = new ComboBox();
            txtAdet = new TextBox();
            btnYeniSatis = new Button();
            btnYeniHasta = new Button();
            btnKapat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstSepet = new ListBox();
            btnSatisTamamla = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSatislar).BeginInit();
            SuspendLayout();
            // 
            // dgvSatislar
            // 
            dgvSatislar.BackgroundColor = SystemColors.ControlLight;
            dgvSatislar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatislar.Location = new Point(14, 111);
            dgvSatislar.Margin = new Padding(3, 4, 3, 4);
            dgvSatislar.Name = "dgvSatislar";
            dgvSatislar.RowHeadersWidth = 51;
            dgvSatislar.RowTemplate.Height = 25;
            dgvSatislar.Size = new Size(690, 414);
            dgvSatislar.TabIndex = 0;
            dgvSatislar.CellContentClick += dgvSatislar_CellContentClick;
            // 
            // cmbHastalar
            // 
            cmbHastalar.FormattingEnabled = true;
            cmbHastalar.Location = new Point(14, 40);
            cmbHastalar.Margin = new Padding(3, 4, 3, 4);
            cmbHastalar.Name = "cmbHastalar";
            cmbHastalar.Size = new Size(228, 28);
            cmbHastalar.TabIndex = 1;
            // 
            // cmbIlaclar
            // 
            cmbIlaclar.FormattingEnabled = true;
            cmbIlaclar.Location = new Point(266, 40);
            cmbHastalar.Margin = new Padding(3, 4, 3, 4);
            cmbHastalar.Name = "cmbIlaclar";
            cmbIlaclar.Size = new Size(228, 28);
            cmbIlaclar.TabIndex = 2;
            // 
            // txtAdet
            // 
            txtAdet.BorderStyle = BorderStyle.FixedSingle;
            txtAdet.Location = new Point(513, 40);
            txtAdet.Margin = new Padding(3, 4, 3, 4);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(180, 27);
            txtAdet.TabIndex = 3;
            // 
            // btnYeniSatis
            // 
            btnYeniSatis.BackColor = Color.MediumSeaGreen;
            btnYeniSatis.FlatStyle = FlatStyle.Flat;
            btnYeniSatis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnYeniSatis.Location = new Point(713, 34);
            btnYeniSatis.Margin = new Padding(3, 4, 3, 4);
            btnYeniSatis.Name = "btnYeniSatis";
            btnYeniSatis.Size = new Size(135, 40);
            btnYeniSatis.TabIndex = 4;
            btnYeniSatis.Text = "Sepete Ekle";
            btnYeniSatis.UseVisualStyleBackColor = false;
            btnYeniSatis.Click += btnYeniSatis_Click;
            // 
            // btnYeniHasta
            // 
            btnYeniHasta.BackColor = Color.LightBlue;
            btnYeniHasta.FlatStyle = FlatStyle.Flat;
            btnYeniHasta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnYeniHasta.Location = new Point(876, 33);
            btnYeniHasta.Margin = new Padding(3, 4, 3, 4);
            btnYeniHasta.Name = "btnYeniHasta";
            btnYeniHasta.Size = new Size(135, 41);
            btnYeniHasta.TabIndex = 5;
            btnYeniHasta.Text = "Yeni Hasta";
            btnYeniHasta.UseVisualStyleBackColor = false;
            btnYeniHasta.Click += btnYeniHasta_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.IndianRed;
            btnKapat.FlatStyle = FlatStyle.Popup;
            btnKapat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKapat.Location = new Point(886, 544);
            btnKapat.Margin = new Padding(3, 4, 3, 4);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(125, 50);
            btnKapat.TabIndex = 6;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 10.2F);
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 7;
            label1.Text = "Hasta Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 10.2F);
            label2.Location = new Point(266, 16);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 8;
            label2.Text = "İlaç Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Blk BT", 10.2F);
            label3.Location = new Point(513, 16);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 9;
            label3.Text = "Adet:";
            // 
            // lstSepet
            // 
            lstSepet.FormattingEnabled = true;
            lstSepet.ItemHeight = 20;
            lstSepet.Location = new Point(720, 111);
            lstSepet.Name = "lstSepet";
            lstSepet.Size = new Size(292, 344);
            lstSepet.TabIndex = 10;
            // 
            // btnSatisTamamla
            // 
            btnSatisTamamla.BackColor = Color.Orange;
            btnSatisTamamla.FlatStyle = FlatStyle.Flat;
            btnSatisTamamla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSatisTamamla.Location = new Point(720, 465);
            btnSatisTamamla.Name = "btnSatisTamamla";
            btnSatisTamamla.Size = new Size(292, 60);
            btnSatisTamamla.TabIndex = 11;
            btnSatisTamamla.Text = "Satışı Tamamla";
            btnSatisTamamla.UseVisualStyleBackColor = false;
            btnSatisTamamla.Click += btnSatisTamamla_Click;
            // 
            // satisyonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1043, 607);
            Controls.Add(btnSatisTamamla);
            Controls.Add(lstSepet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKapat);
            Controls.Add(btnYeniHasta);
            Controls.Add(btnYeniSatis);
            Controls.Add(txtAdet);
            Controls.Add(cmbIlaclar);
            Controls.Add(cmbHastalar);
            Controls.Add(dgvSatislar);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "satisyonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Yönetimi";
            Load += satisyonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSatislar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.ComboBox cmbHastalar;
        private System.Windows.Forms.ComboBox cmbIlaclar;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button btnYeniSatis;
        private System.Windows.Forms.Button btnYeniHasta;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnSatisTamamla;
    }
}