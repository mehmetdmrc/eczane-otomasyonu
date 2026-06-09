using System;
using System.Windows.Forms;

namespace otomosyan_projesi
{
    public partial class formanasayfa : Form
    {
        public formanasayfa()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnSatisYonetimi_Click(object sender, EventArgs e)
        {
            satisyonetimi satisYonetimi = new satisyonetimi();
            satisYonetimi.ShowDialog();
        }

        private void btnStokYonetimi_Click(object sender, EventArgs e)
        {
            stokıslemlerı stokIslemleri = new stokıslemlerı();
            stokIslemleri.ShowDialog();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sİPARİŞOLUŞTURMAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünAdıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            stokıslemlerı frm = new stokıslemlerı();
            frm.ShowDialog();
        }


        private void satisYonetimi(object sender, EventArgs e)
        {
            satisyonetimi satisyonetimi = new satisyonetimi();
            satisyonetimi.ShowDialog();
        }

        private void formanasayfa_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser != null && SessionManager.CurrentUser.Rol != "Müdür")
            {
                // Personel için kısıtlamalar
                btnAyarlar.Visible = false;
                btnRaporlama.Enabled = false; // Raporlamayı pasif yap
                btnYeniIlac.Enabled = false;  // Yeni ilaç eklemeyi pasif yap
            }
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser?.Rol != "Müdür")
            {
                MessageBox.Show("Bu bölüme sadece Müdür erişebilir!", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            AyarlarForm ayarlarForm = new AyarlarForm();
            ayarlarForm.ShowDialog();
        }

        private void btnYeniIlac_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser?.Rol != "Müdür")
            {
                MessageBox.Show("Bu işlem için yetkiniz bulunmamaktadır!", "Yetki Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IlacEkleForm ilacEkleForm = new IlacEkleForm();
            ilacEkleForm.ShowDialog();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser?.Rol != "Müdür")
            {
                MessageBox.Show("Raporlama modülüne sadece Müdür erişebilir!", "Yetki Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RaporlamaForm raporlamaForm = new RaporlamaForm();
            raporlamaForm.ShowDialog();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formanasayfa_Load_1(object sender, EventArgs e)
        {

        }
    }
}