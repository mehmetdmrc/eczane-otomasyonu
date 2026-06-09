namespace otomosyan_projesi
{
    partial class EnCokSatanlarForm
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
            dgvEnCokSatanlar = new DataGridView();
            lblToplamSatis = new Label();
            lblToplamTutar = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvEnCokSatanlar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEnCokSatanlar
            // 
            dgvEnCokSatanlar.AllowUserToAddRows = false;
            dgvEnCokSatanlar.AllowUserToDeleteRows = false;
            dgvEnCokSatanlar.BackgroundColor = SystemColors.ControlLight;
            dgvEnCokSatanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnCokSatanlar.Location = new Point(14, 16);
            dgvEnCokSatanlar.Margin = new Padding(3, 4, 3, 4);
            dgvEnCokSatanlar.Name = "dgvEnCokSatanlar";
            dgvEnCokSatanlar.ReadOnly = true;
            dgvEnCokSatanlar.RowHeadersWidth = 51;
            dgvEnCokSatanlar.RowTemplate.Height = 25;
            dgvEnCokSatanlar.Size = new Size(575, 400);
            dgvEnCokSatanlar.TabIndex = 0;
            // 
            // lblToplamSatis
            // 
            lblToplamSatis.AutoSize = true;
            lblToplamSatis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblToplamSatis.Location = new Point(7, 27);
            lblToplamSatis.Name = "lblToplamSatis";
            lblToplamSatis.Size = new Size(0, 28);
            lblToplamSatis.TabIndex = 1;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblToplamTutar.Location = new Point(7, 67);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(0, 28);
            lblToplamTutar.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Azure;
            groupBox1.Controls.Add(lblToplamTutar);
            groupBox1.Controls.Add(lblToplamSatis);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(14, 424);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(575, 121);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Özet";
            // 
            // EnCokSatanlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(602, 558);
            Controls.Add(groupBox1);
            Controls.Add(dgvEnCokSatanlar);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EnCokSatanlarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "En Çok Satan İlaçlar Raporu";
            Load += EnCokSatanlarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEnCokSatanlar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvEnCokSatanlar;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
} 