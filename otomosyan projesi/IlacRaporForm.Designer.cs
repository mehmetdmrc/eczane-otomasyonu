namespace otomosyan_projesi
{
    partial class IlacRaporForm
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
            dgvIlacRapor = new DataGridView();
            lblIlacAdi = new Label();
            lblKategori = new Label();
            lblStokMiktari = new Label();
            lblBirimFiyat = new Label();
            lblToplamSatis = new Label();
            lblToplamTutar = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIlacRapor).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvIlacRapor
            // 
            dgvIlacRapor.AllowUserToAddRows = false;
            dgvIlacRapor.AllowUserToDeleteRows = false;
            dgvIlacRapor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIlacRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIlacRapor.BackgroundColor = SystemColors.ControlLight;
            dgvIlacRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIlacRapor.Location = new Point(14, 179);
            dgvIlacRapor.Margin = new Padding(3, 4, 3, 4);
            dgvIlacRapor.Name = "dgvIlacRapor";
            dgvIlacRapor.ReadOnly = true;
            dgvIlacRapor.RowHeadersWidth = 51;
            dgvIlacRapor.Size = new Size(705, 221);
            dgvIlacRapor.TabIndex = 0;
            // 
            // lblIlacAdi
            // 
            lblIlacAdi.AutoSize = true;
            lblIlacAdi.Location = new Point(114, 33);
            lblIlacAdi.Name = "lblIlacAdi";
            lblIlacAdi.Size = new Size(0, 23);
            lblIlacAdi.TabIndex = 0;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(114, 67);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(0, 23);
            lblKategori.TabIndex = 1;
            // 
            // lblStokMiktari
            // 
            lblStokMiktari.AutoSize = true;
            lblStokMiktari.Location = new Point(114, 100);
            lblStokMiktari.Name = "lblStokMiktari";
            lblStokMiktari.Size = new Size(0, 23);
            lblStokMiktari.TabIndex = 2;
            // 
            // lblBirimFiyat
            // 
            lblBirimFiyat.AutoSize = true;
            lblBirimFiyat.Location = new Point(457, 33);
            lblBirimFiyat.Name = "lblBirimFiyat";
            lblBirimFiyat.Size = new Size(0, 23);
            lblBirimFiyat.TabIndex = 3;
            // 
            // lblToplamSatis
            // 
            lblToplamSatis.AutoSize = true;
            lblToplamSatis.Location = new Point(114, 33);
            lblToplamSatis.Name = "lblToplamSatis";
            lblToplamSatis.Size = new Size(0, 23);
            lblToplamSatis.TabIndex = 0;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(457, 33);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(0, 23);
            lblToplamTutar.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Azure;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblBirimFiyat);
            groupBox1.Controls.Add(lblStokMiktari);
            groupBox1.Controls.Add(lblKategori);
            groupBox1.Controls.Add(lblIlacAdi);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(395, 140);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlaç Bilgileri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 100);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 6;
            label3.Text = "Stok Miktarı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 67);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 5;
            label2.Text = "Kategori:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 4;
            label1.Text = "İlaç Adı:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Azure;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblToplamTutar);
            groupBox2.Controls.Add(lblToplamSatis);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox2.Location = new Point(415, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(304, 75);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Satış Özeti";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 33);
            label5.Name = "label5";
            label5.Size = new Size(117, 23);
            label5.TabIndex = 2;
            label5.Text = "Toplam Satış:";
            // 
            // IlacRaporForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 413);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvIlacRapor);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "IlacRaporForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İlaç Raporu";
            Load += IlacRaporForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIlacRapor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvIlacRapor;
        private System.Windows.Forms.Label lblIlacAdi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
} 