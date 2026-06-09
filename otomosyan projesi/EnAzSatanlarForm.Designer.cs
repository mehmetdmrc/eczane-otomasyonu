namespace otomosyan_projesi
{
    partial class EnAzSatanlarForm
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
            dgvEnAzSatanlar = new DataGridView();
            lblToplamSatis = new Label();
            lblToplamTutar = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvEnAzSatanlar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEnAzSatanlar
            // 
            dgvEnAzSatanlar.AllowUserToAddRows = false;
            dgvEnAzSatanlar.AllowUserToDeleteRows = false;
            dgvEnAzSatanlar.BackgroundColor = SystemColors.ControlLight;
            dgvEnAzSatanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnAzSatanlar.Location = new Point(14, 16);
            dgvEnAzSatanlar.Margin = new Padding(3, 4, 3, 4);
            dgvEnAzSatanlar.Name = "dgvEnAzSatanlar";
            dgvEnAzSatanlar.ReadOnly = true;
            dgvEnAzSatanlar.RowHeadersWidth = 51;
            dgvEnAzSatanlar.RowTemplate.Height = 25;
            dgvEnAzSatanlar.Size = new Size(575, 400);
            dgvEnAzSatanlar.TabIndex = 0;
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
            // EnAzSatanlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(603, 561);
            Controls.Add(groupBox1);
            Controls.Add(dgvEnAzSatanlar);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EnAzSatanlarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "En Az Satan İlaçlar Raporu";
            Load += EnAzSatanlarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEnAzSatanlar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvEnAzSatanlar;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
} 