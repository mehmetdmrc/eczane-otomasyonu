namespace otomosyan_projesi
{
    partial class stokıslemlerı
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
            dgvIlaclar = new DataGridView();
            txtYeniStok = new TextBox();
            txtYeniFiyat = new TextBox();
            btnGuncelle = new Button();
            btnKapat = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIlaclar).BeginInit();
            SuspendLayout();
            // 
            // dgvIlaclar
            // 
            dgvIlaclar.BackgroundColor = SystemColors.ControlLight;
            dgvIlaclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIlaclar.Location = new Point(14, 13);
            dgvIlaclar.Margin = new Padding(3, 4, 3, 4);
            dgvIlaclar.Name = "dgvIlaclar";
            dgvIlaclar.RowHeadersWidth = 51;
            dgvIlaclar.RowTemplate.Height = 25;
            dgvIlaclar.Size = new Size(768, 400);
            dgvIlaclar.TabIndex = 0;
            dgvIlaclar.SelectionChanged += dgvIlaclar_SelectionChanged;
            // 
            // txtYeniStok
            // 
            txtYeniStok.BorderStyle = BorderStyle.FixedSingle;
            txtYeniStok.Location = new Point(37, 447);
            txtYeniStok.Margin = new Padding(3, 4, 3, 4);
            txtYeniStok.Name = "txtYeniStok";
            txtYeniStok.Size = new Size(228, 27);
            txtYeniStok.TabIndex = 1;
            // 
            // txtYeniFiyat
            // 
            txtYeniFiyat.BorderStyle = BorderStyle.FixedSingle;
            txtYeniFiyat.Location = new Point(290, 447);
            txtYeniFiyat.Margin = new Padding(3, 4, 3, 4);
            txtYeniFiyat.Name = "txtYeniFiyat";
            txtYeniFiyat.Size = new Size(228, 27);
            txtYeniFiyat.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.MediumSeaGreen;
            btnGuncelle.FlatStyle = FlatStyle.Popup;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(535, 434);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(101, 40);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.IndianRed;
            btnKapat.FlatStyle = FlatStyle.Popup;
            btnKapat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKapat.Location = new Point(668, 434);
            btnKapat.Margin = new Padding(3, 4, 3, 4);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(101, 40);
            btnKapat.TabIndex = 4;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 10.2F);
            label1.Location = new Point(37, 423);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 5;
            label1.Text = "Stok:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 10.2F);
            label2.Location = new Point(290, 423);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 6;
            label2.Text = "Fiyat:";
            // 
            // stokıslemlerı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(797, 496);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKapat);
            Controls.Add(btnGuncelle);
            Controls.Add(txtYeniFiyat);
            Controls.Add(txtYeniStok);
            Controls.Add(dgvIlaclar);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "stokıslemlerı";
            Text = "Stok İşlemleri";
            Load += stokıslemlerı_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIlaclar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIlaclar;
        private System.Windows.Forms.TextBox txtYeniStok;
        private System.Windows.Forms.TextBox txtYeniFiyat;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}