namespace otomosyan_projesi
{
    partial class IlacEkleForm
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
            txtIlacAdi = new TextBox();
            txtTur = new TextBox();
            txtStok = new TextBox();
            txtFiyat = new TextBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtIlacAdi
            // 
            txtIlacAdi.BorderStyle = BorderStyle.FixedSingle;
            txtIlacAdi.Location = new Point(193, 36);
            txtIlacAdi.Margin = new Padding(3, 4, 3, 4);
            txtIlacAdi.Name = "txtIlacAdi";
            txtIlacAdi.Size = new Size(228, 27);
            txtIlacAdi.TabIndex = 0;
            // 
            // txtTur
            // 
            txtTur.BorderStyle = BorderStyle.FixedSingle;
            txtTur.Location = new Point(193, 89);
            txtTur.Margin = new Padding(3, 4, 3, 4);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(228, 27);
            txtTur.TabIndex = 1;
            // 
            // txtStok
            // 
            txtStok.BorderStyle = BorderStyle.FixedSingle;
            txtStok.Location = new Point(193, 143);
            txtStok.Margin = new Padding(3, 4, 3, 4);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(228, 27);
            txtStok.TabIndex = 2;
            // 
            // txtFiyat
            // 
            txtFiyat.BorderStyle = BorderStyle.FixedSingle;
            txtFiyat.Location = new Point(193, 196);
            txtFiyat.Margin = new Padding(3, 4, 3, 4);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(228, 27);
            txtFiyat.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.MediumSeaGreen;
            btnKaydet.FlatStyle = FlatStyle.Popup;
            btnKaydet.Location = new Point(193, 249);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(109, 40);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.IndianRed;
            btnIptal.FlatStyle = FlatStyle.Popup;
            btnIptal.Location = new Point(313, 249);
            btnIptal.Margin = new Padding(3, 4, 3, 4);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(109, 40);
            btnIptal.TabIndex = 5;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 10.2F);
            label1.Location = new Point(57, 47);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 6;
            label1.Text = "İlaç Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 10.2F);
            label2.Location = new Point(57, 97);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Tür:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Blk BT", 10.2F);
            label3.Location = new Point(57, 151);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 8;
            label3.Text = "Stok:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Swis721 Blk BT", 10.2F);
            label4.Location = new Point(57, 204);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 9;
            label4.Text = "Fiyat:";
            // 
            // IlacEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(501, 333);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtFiyat);
            Controls.Add(txtStok);
            Controls.Add(txtTur);
            Controls.Add(txtIlacAdi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "IlacEkleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni İlaç Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtIlacAdi;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
} 