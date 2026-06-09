namespace otomosyan_projesi
{
    partial class HastaRaporForm
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
            dgvHastaRapor = new DataGridView();
            lblHastaAdi = new Label();
            lblHastaTC = new Label();
            lblHastaTelefon = new Label();
            lblHastaAdres = new Label();
            lblToplamTutar = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHastaRapor).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHastaRapor
            // 
            dgvHastaRapor.AllowUserToAddRows = false;
            dgvHastaRapor.AllowUserToDeleteRows = false;
            dgvHastaRapor.BackgroundColor = SystemColors.ControlLight;
            dgvHastaRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHastaRapor.Location = new Point(12, 185);
            dgvHastaRapor.Margin = new Padding(3, 4, 3, 4);
            dgvHastaRapor.Name = "dgvHastaRapor";
            dgvHastaRapor.ReadOnly = true;
            dgvHastaRapor.RowHeadersWidth = 51;
            dgvHastaRapor.RowTemplate.Height = 25;
            dgvHastaRapor.Size = new Size(804, 400);
            dgvHastaRapor.TabIndex = 0;
            // 
            // lblHastaAdi
            // 
            lblHastaAdi.AutoSize = true;
            lblHastaAdi.Location = new Point(114, 27);
            lblHastaAdi.Name = "lblHastaAdi";
            lblHastaAdi.Size = new Size(0, 23);
            lblHastaAdi.TabIndex = 1;
            // 
            // lblHastaTC
            // 
            lblHastaTC.AutoSize = true;
            lblHastaTC.Location = new Point(114, 67);
            lblHastaTC.Name = "lblHastaTC";
            lblHastaTC.Size = new Size(0, 23);
            lblHastaTC.TabIndex = 2;
            // 
            // lblHastaTelefon
            // 
            lblHastaTelefon.AutoSize = true;
            lblHastaTelefon.Location = new Point(114, 107);
            lblHastaTelefon.Name = "lblHastaTelefon";
            lblHastaTelefon.Size = new Size(0, 23);
            lblHastaTelefon.TabIndex = 3;
            // 
            // lblHastaAdres
            // 
            lblHastaAdres.AutoSize = true;
            lblHastaAdres.Location = new Point(114, 147);
            lblHastaAdres.Name = "lblHastaAdres";
            lblHastaAdres.Size = new Size(0, 23);
            lblHastaAdres.TabIndex = 4;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblToplamTutar.Location = new Point(14, 680);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(0, 28);
            lblToplamTutar.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Azure;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblHastaAdres);
            groupBox1.Controls.Add(lblHastaTelefon);
            groupBox1.Controls.Add(lblHastaTC);
            groupBox1.Controls.Add(lblHastaAdi);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(797, 145);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgileri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 104);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 7;
            label3.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 72);
            label2.Name = "label2";
            label2.Size = new Size(35, 23);
            label2.TabIndex = 6;
            label2.Text = "TC:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 37);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 5;
            label1.Text = "Hasta Adı:";
            // 
            // HastaRaporForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(828, 604);
            Controls.Add(groupBox1);
            Controls.Add(lblToplamTutar);
            Controls.Add(dgvHastaRapor);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HastaRaporForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Raporu";
            Load += HastaRaporForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHastaRapor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvHastaRapor;
        private System.Windows.Forms.Label lblHastaAdi;
        private System.Windows.Forms.Label lblHastaTC;
        private System.Windows.Forms.Label lblHastaTelefon;
        private System.Windows.Forms.Label lblHastaAdres;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
} 