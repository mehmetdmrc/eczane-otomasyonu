namespace otomosyan_projesi
{
    partial class AylikSatisRaporForm
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
            dgvAylikSatis = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAylikSatis).BeginInit();
            SuspendLayout();
            // 
            // dgvAylikSatis
            // 
            dgvAylikSatis.AllowUserToAddRows = false;
            dgvAylikSatis.AllowUserToDeleteRows = false;
            dgvAylikSatis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAylikSatis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAylikSatis.BackgroundColor = SystemColors.ControlLight;
            dgvAylikSatis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAylikSatis.Location = new Point(16, 18);
            dgvAylikSatis.Margin = new Padding(4, 5, 4, 5);
            dgvAylikSatis.Name = "dgvAylikSatis";
            dgvAylikSatis.ReadOnly = true;
            dgvAylikSatis.RowHeadersWidth = 51;
            dgvAylikSatis.Size = new Size(1035, 655);
            dgvAylikSatis.TabIndex = 0;
            // 
            // AylikSatisRaporForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 692);
            Controls.Add(dgvAylikSatis);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AylikSatisRaporForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aylık Satış Raporu";
            Load += AylikSatisRaporForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAylikSatis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAylikSatis;
    }
} 