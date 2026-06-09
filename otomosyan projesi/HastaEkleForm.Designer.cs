namespace otomosyan_projesi
{
    partial class HastaEkleForm
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
            txtTC = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtTC
            // 
            txtTC.BackColor = SystemColors.Window;
            txtTC.BorderStyle = BorderStyle.FixedSingle;
            txtTC.Location = new Point(160, 36);
            txtTC.Margin = new Padding(4, 5, 4, 5);
            txtTC.MaxLength = 11;
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(265, 27);
            txtTC.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.Window;
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Location = new Point(160, 77);
            txtAd.Margin = new Padding(4, 5, 4, 5);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(265, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.Window;
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Location = new Point(160, 118);
            txtSoyad.Margin = new Padding(4, 5, 4, 5);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(265, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = SystemColors.Window;
            txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.Location = new Point(160, 159);
            txtTelefon.Margin = new Padding(4, 5, 4, 5);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(265, 27);
            txtTelefon.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.MediumSeaGreen;
            btnKaydet.FlatStyle = FlatStyle.Popup;
            btnKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(172, 209);
            btnKaydet.Margin = new Padding(4, 5, 4, 5);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(108, 45);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.IndianRed;
            btnIptal.FlatStyle = FlatStyle.Popup;
            btnIptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIptal.Location = new Point(297, 209);
            btnIptal.Margin = new Padding(4, 5, 4, 5);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(108, 45);
            btnIptal.TabIndex = 7;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 10.2F);
            label1.Location = new Point(98, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 8;
            label1.Text = "TC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 10.2F);
            label2.Location = new Point(98, 79);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 9;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Blk BT", 10.2F);
            label3.Location = new Point(65, 125);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Swis721 Blk BT", 10.2F);
            label5.Location = new Point(53, 161);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 12;
            label5.Text = "Telefon:";
            // 
            // HastaEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(459, 287);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtTC);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HastaEkleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yeni Hasta Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
} 