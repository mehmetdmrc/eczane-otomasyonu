using System;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace otomosyan_projesi
{
    public partial class stokıslemlerı : Form
    {
        private readonly ApiService _apiService = new ApiService();

        public stokıslemlerı()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadIlaclar();
        }

        private void FilterStok(string filter)
        {
            foreach (DataGridViewRow row in dgvIlaclar.Rows)
            {
                if (row.Cells["ad"].Value != null)
                {
                    row.Visible = row.Cells["ad"].Value.ToString().ToLower().Contains(filter.ToLower());
                }
            }
        }

        private void InitializeDataGridView()
        {
            dgvIlaclar.Columns.Clear();
            dgvIlaclar.Columns.Add("ID", "ID");
            dgvIlaclar.Columns.Add("İsim", "İlaç Adı");
            dgvIlaclar.Columns.Add("Tür", "Kategori");
            dgvIlaclar.Columns.Add("Stok", "Stok Miktarı");
            dgvIlaclar.Columns.Add("Fiyat", "Birim Fiyat");

            dgvIlaclar.Columns[0].Width = 50;
            dgvIlaclar.Columns[1].Width = 200;
            dgvIlaclar.Columns[2].Width = 150;
            dgvIlaclar.Columns[3].Width = 100;
            dgvIlaclar.Columns[4].Width = 100;
        }

        private async void stokıslemlerı_Load(object sender, EventArgs e)
        {
            await LoadIlaclar();
        }

        private async Task LoadIlaclar()
        {
            try
            {
                dgvIlaclar.Rows.Clear();
                var ilaclar = await _apiService.GetIlaclarAsync();
                foreach (var ilac in ilaclar)
                {
                    dgvIlaclar.Rows.Add(
                        ilac.Id, 
                        ilac.Ad, 
                        ilac.KategoriId, 
                        ilac.Stok, 
                        ilac.Fiyat
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvIlaclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek ilacı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int yeniStok = int.Parse(txtYeniStok.Text);
                decimal yeniFiyat = decimal.Parse(txtYeniFiyat.Text);

                if (yeniStok < 0)
                {
                    MessageBox.Show("Stok miktarı negatif olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (yeniFiyat <= 0)
                {
                    MessageBox.Show("Fiyat 0'dan büyük olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int seciliID = int.Parse(dgvIlaclar.SelectedRows[0].Cells[0].Value.ToString());
                var ilac = await _apiService.GetIlacByIdAsync(seciliID);
                
                if (ilac != null)
                {
                    ilac.Stok = yeniStok;
                    ilac.Fiyat = yeniFiyat;
                    
                    bool success = await _apiService.UpdateIlacAsync(seciliID, ilac);
                    if (success)
                    {
                        await LoadIlaclar();
                        MessageBox.Show("İlaç bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Stok ve Fiyat alanları sayısal değer olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvIlaclar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIlaclar.SelectedRows.Count > 0 && dgvIlaclar.SelectedRows[0].Cells[3].Value != null && dgvIlaclar.SelectedRows[0].Cells[4].Value != null)
            {
                txtYeniStok.Text = dgvIlaclar.SelectedRows[0].Cells[3].Value.ToString();
                txtYeniFiyat.Text = dgvIlaclar.SelectedRows[0].Cells[4].Value.ToString();
            }
            else
            {
                txtYeniStok.Text = "";
                txtYeniFiyat.Text = "";
            }
        }
    }
}
