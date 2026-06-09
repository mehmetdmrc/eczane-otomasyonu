namespace otomosyan_projesi
{
    partial class HaftalikRaporForm
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
            dgvHaftalikSatis = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHaftalikSatis).BeginInit();
            SuspendLayout();
            // 
            // dgvHaftalikSatis
            // 
            dgvHaftalikSatis.AllowUserToAddRows = false;
            dgvHaftalikSatis.AllowUserToDeleteRows = false;
            dgvHaftalikSatis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHaftalikSatis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHaftalikSatis.BackgroundColor = SystemColors.ControlLight;
            dgvHaftalikSatis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHaftalikSatis.Location = new Point(16, 18);
            dgvHaftalikSatis.Margin = new Padding(4, 5, 4, 5);
            dgvHaftalikSatis.Name = "dgvHaftalikSatis";
            dgvHaftalikSatis.ReadOnly = true;
            dgvHaftalikSatis.RowHeadersWidth = 51;
            dgvHaftalikSatis.Size = new Size(1035, 655);
            dgvHaftalikSatis.TabIndex = 0;
            // 
            // HaftalikRaporForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_77g4xo77g4xo77g4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 692);
            Controls.Add(dgvHaftalikSatis);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "HaftalikRaporForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Haftalık Satış Raporu";
            Load += HaftalikRaporForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHaftalikSatis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHaftalikSatis;
    }
} 