namespace otomosyan_projesi
{
    partial class RaporlamaForm
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
            groupBox1 = new GroupBox();
            btnHastaRaporu = new Button();
            label1 = new Label();
            cmbHastalar = new ComboBox();
            groupBox2 = new GroupBox();
            btnIlacRaporu = new Button();
            label2 = new Label();
            cmbIlaclar = new ComboBox();
            groupBox3 = new GroupBox();
            btnAylikRapor = new Button();
            btnHaftalikRapor = new Button();
            groupBox4 = new GroupBox();
            btnEnCokAlisverisYapanlar = new Button();
            btnEnAzSatanlar = new Button();
            btnEnCokSatanlar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnHastaRaporu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbHastalar);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(49, 24);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(286, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bazlı Raporlar";
            // 
            // btnHastaRaporu
            // 
            btnHastaRaporu.BackColor = Color.LightBlue;
            btnHastaRaporu.FlatStyle = FlatStyle.Popup;
            btnHastaRaporu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHastaRaporu.Location = new Point(7, 98);
            btnHastaRaporu.Margin = new Padding(3, 4, 3, 4);
            btnHastaRaporu.Name = "btnHastaRaporu";
            btnHastaRaporu.Size = new Size(270, 31);
            btnHastaRaporu.TabIndex = 2;
            btnHastaRaporu.Text = "Hasta Raporu";
            btnHastaRaporu.UseVisualStyleBackColor = false;
            btnHastaRaporu.Click += btnHastaRaporu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 35);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 1;
            label1.Text = "Hasta Adı:";
            // 
            // cmbHastalar
            // 
            cmbHastalar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHastalar.FormattingEnabled = true;
            cmbHastalar.Location = new Point(7, 59);
            cmbHastalar.Margin = new Padding(3, 4, 3, 4);
            cmbHastalar.Name = "cmbHastalar";
            cmbHastalar.Size = new Size(270, 31);
            cmbHastalar.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnIlacRaporu);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cmbIlaclar);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(49, 186);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(285, 139);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İlaç Bazlı Raporlar";
            // 
            // btnIlacRaporu
            // 
            btnIlacRaporu.BackColor = Color.LightBlue;
            btnIlacRaporu.FlatStyle = FlatStyle.Popup;
            btnIlacRaporu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIlacRaporu.ForeColor = SystemColors.ControlText;
            btnIlacRaporu.Location = new Point(6, 98);
            btnIlacRaporu.Margin = new Padding(3, 4, 3, 4);
            btnIlacRaporu.Name = "btnIlacRaporu";
            btnIlacRaporu.Size = new Size(270, 31);
            btnIlacRaporu.TabIndex = 2;
            btnIlacRaporu.Text = "İlaç Raporu";
            btnIlacRaporu.UseVisualStyleBackColor = false;
            btnIlacRaporu.Click += btnIlacRaporu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 35);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 1;
            label2.Text = "İlaç:";
            // 
            // cmbIlaclar
            // 
            cmbIlaclar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIlaclar.FormattingEnabled = true;
            cmbIlaclar.Location = new Point(6, 59);
            cmbIlaclar.Margin = new Padding(3, 4, 3, 4);
            cmbIlaclar.Name = "cmbIlaclar";
            cmbIlaclar.Size = new Size(270, 31);
            cmbIlaclar.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(btnAylikRapor);
            groupBox3.Controls.Add(btnHaftalikRapor);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(384, 24);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(286, 110);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Zaman Bazlı Raporlar";
            // 
            // btnAylikRapor
            // 
            btnAylikRapor.BackColor = Color.LightBlue;
            btnAylikRapor.FlatStyle = FlatStyle.Popup;
            btnAylikRapor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAylikRapor.Location = new Point(7, 68);
            btnAylikRapor.Margin = new Padding(3, 4, 3, 4);
            btnAylikRapor.Name = "btnAylikRapor";
            btnAylikRapor.Size = new Size(270, 31);
            btnAylikRapor.TabIndex = 1;
            btnAylikRapor.Text = "Aylık Satış Raporu";
            btnAylikRapor.UseVisualStyleBackColor = false;
            btnAylikRapor.Click += btnAylikRapor_Click;
            // 
            // btnHaftalikRapor
            // 
            btnHaftalikRapor.BackColor = Color.LightBlue;
            btnHaftalikRapor.FlatStyle = FlatStyle.Popup;
            btnHaftalikRapor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHaftalikRapor.Location = new Point(7, 29);
            btnHaftalikRapor.Margin = new Padding(3, 4, 3, 4);
            btnHaftalikRapor.Name = "btnHaftalikRapor";
            btnHaftalikRapor.Size = new Size(270, 31);
            btnHaftalikRapor.TabIndex = 0;
            btnHaftalikRapor.Text = "Haftalık Satış Raporu";
            btnHaftalikRapor.UseVisualStyleBackColor = false;
            btnHaftalikRapor.Click += btnHaftalikRapor_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(btnEnCokAlisverisYapanlar);
            groupBox4.Controls.Add(btnEnAzSatanlar);
            groupBox4.Controls.Add(btnEnCokSatanlar);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(384, 174);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(285, 151);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Özel Raporlar";
            // 
            // btnEnCokAlisverisYapanlar
            // 
            btnEnCokAlisverisYapanlar.BackColor = Color.LightBlue;
            btnEnCokAlisverisYapanlar.FlatStyle = FlatStyle.Popup;
            btnEnCokAlisverisYapanlar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEnCokAlisverisYapanlar.Location = new Point(7, 107);
            btnEnCokAlisverisYapanlar.Margin = new Padding(3, 4, 3, 4);
            btnEnCokAlisverisYapanlar.Name = "btnEnCokAlisverisYapanlar";
            btnEnCokAlisverisYapanlar.Size = new Size(270, 31);
            btnEnCokAlisverisYapanlar.TabIndex = 2;
            btnEnCokAlisverisYapanlar.Text = "En Çok Alışveriş Yapan Hastalar";
            btnEnCokAlisverisYapanlar.UseVisualStyleBackColor = false;
            btnEnCokAlisverisYapanlar.Click += btnEnCokAlisverisYapanlar_Click;
            // 
            // btnEnAzSatanlar
            // 
            btnEnAzSatanlar.BackColor = Color.LightBlue;
            btnEnAzSatanlar.FlatStyle = FlatStyle.Popup;
            btnEnAzSatanlar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEnAzSatanlar.Location = new Point(7, 68);
            btnEnAzSatanlar.Margin = new Padding(3, 4, 3, 4);
            btnEnAzSatanlar.Name = "btnEnAzSatanlar";
            btnEnAzSatanlar.Size = new Size(270, 31);
            btnEnAzSatanlar.TabIndex = 1;
            btnEnAzSatanlar.Text = "En Az Satan İlaçlar";
            btnEnAzSatanlar.UseVisualStyleBackColor = false;
            btnEnAzSatanlar.Click += btnEnAzSatanlar_Click;
            // 
            // btnEnCokSatanlar
            // 
            btnEnCokSatanlar.BackColor = Color.LightBlue;
            btnEnCokSatanlar.FlatStyle = FlatStyle.Popup;
            btnEnCokSatanlar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEnCokSatanlar.Location = new Point(7, 29);
            btnEnCokSatanlar.Margin = new Padding(3, 4, 3, 4);
            btnEnCokSatanlar.Name = "btnEnCokSatanlar";
            btnEnCokSatanlar.Size = new Size(270, 31);
            btnEnCokSatanlar.TabIndex = 0;
            btnEnCokSatanlar.Text = "En Çok Satan İlaçlar";
            btnEnCokSatanlar.UseVisualStyleBackColor = false;
            btnEnCokSatanlar.Click += btnEnCokSatanlar_Click;
            // 
            // RaporlamaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(714, 383);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "RaporlamaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raporlama";
            Load += RaporlamaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbHastalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHastaRaporu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbIlaclar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIlacRaporu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHaftalikRapor;
        private System.Windows.Forms.Button btnAylikRapor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEnCokSatanlar;
        private System.Windows.Forms.Button btnEnAzSatanlar;
        private System.Windows.Forms.Button btnEnCokAlisverisYapanlar;
    }
} 