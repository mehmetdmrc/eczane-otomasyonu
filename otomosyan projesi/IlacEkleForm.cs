namespace otomosyan_projesi
{
    public partial class IlacEkleForm : Form
    {
        private readonly ApiService _apiService = new ApiService();

        public IlacEkleForm()
        {
            InitializeComponent();
            txtStok.KeyPress += txtStok_KeyPress;
            txtFiyat.KeyPress += txtFiyat_KeyPress;
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIlacAdi.Text) || string.IsNullOrEmpty(txtTur.Text) ||
                string.IsNullOrEmpty(txtStok.Text) || string.IsNullOrEmpty(txtFiyat.Text))
            {
                MessageBox.Show("Tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int stok = int.Parse(txtStok.Text);
                decimal fiyat = decimal.Parse(txtFiyat.Text);

                var yeniIlac = new Ilac
                {
                    Ad = txtIlacAdi.Text,
                    KategoriId = 1, // Basitlik için varsayılan kategori
                    Stok = stok,
                    Fiyat = fiyat,
                    Aciklama = ""
                };

                bool success = await _apiService.AddIlacAsync(yeniIlac);
                if (success)
                {
                    MessageBox.Show("İlaç başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("İlaç eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
