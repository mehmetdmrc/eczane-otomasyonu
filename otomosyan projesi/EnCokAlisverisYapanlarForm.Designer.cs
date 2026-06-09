namespace otomosyan_projesi
{
    partial class EnCokAlisverisYapanlarForm
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
            dgvEnCokAlisverisYapanlar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEnCokAlisverisYapanlar).BeginInit();
            SuspendLayout();
            // 
            // dgvEnCokAlisverisYapanlar
            // 
            dgvEnCokAlisverisYapanlar.AllowUserToAddRows = false;
            dgvEnCokAlisverisYapanlar.AllowUserToDeleteRows = false;
            dgvEnCokAlisverisYapanlar.BackgroundColor = SystemColors.ControlLight;
            dgvEnCokAlisverisYapanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnCokAlisverisYapanlar.Location = new Point(14, 16);
            dgvEnCokAlisverisYapanlar.Margin = new Padding(3, 4, 3, 4);
            dgvEnCokAlisverisYapanlar.Name = "dgvEnCokAlisverisYapanlar";
            dgvEnCokAlisverisYapanlar.ReadOnly = true;
            dgvEnCokAlisverisYapanlar.RowHeadersWidth = 51;
            dgvEnCokAlisverisYapanlar.RowTemplate.Height = 25;
            dgvEnCokAlisverisYapanlar.Size = new Size(461, 400);
            dgvEnCokAlisverisYapanlar.TabIndex = 0;
            // 
            // EnCokAlisverisYapanlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(489, 429);
            Controls.Add(dgvEnCokAlisverisYapanlar);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EnCokAlisverisYapanlarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "En Çok Alışveriş Yapan Hastalar Raporu";
            Load += EnCokAlisverisYapanlarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEnCokAlisverisYapanlar).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvEnCokAlisverisYapanlar;
    }
} 