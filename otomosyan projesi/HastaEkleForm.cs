using System;
using System.Windows.Forms;
using System.IO;

namespace otomosyan_projesi
{
    public partial class HastaEkleForm : Form
    {
        public HastaEkleForm()
        {
            InitializeComponent();
            txtTC.KeyPress += txtTC_KeyPress;
            txtTelefon.KeyPress += txtTelefon_KeyPress;
            txtTC.MaxLength = 11;
            txtTelefon.MaxLength = 11;
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTC.Text) || txtTC.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var api = new ApiService();
                var yeniHasta = new Hasta
                {
                    Tc = txtTC.Text,
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Telefon = txtTelefon.Text,
                    Adres = "" // Varsa ekrana eklenebilir
                };

                bool success = await api.AddHastaAsync(yeniHasta);
                if (success)
                {
                    MessageBox.Show("Hasta başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hasta kaydedilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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