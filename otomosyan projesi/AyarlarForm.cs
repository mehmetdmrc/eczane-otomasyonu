using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace otomosyan_projesi
{
    public partial class AyarlarForm : Form
    {
        private ApiService _api = new ApiService();
        private int _selectedUserId = 0;

        public AyarlarForm()
        {
            InitializeComponent();
        }

        private async void AyarlarForm_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser?.Rol != "Müdür")
            {
                MessageBox.Show("Yetkisiz erişim denemesi tespit edildi!", "Güvenlik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            await ListelePersonel();
        }

        private async Task ListelePersonel()
        {
            try
            {
                var personeller = await _api.GetKullanicilarAsync();
                dgvPersonel.DataSource = personeller;
                dgvPersonel.Columns["Sifre"].Visible = false; // Şifreleri gizleyelim
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre zorunludur!");
                return;
            }

            try 
            {
                var yeniKullanici = new Kullanici
                {
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text,
                    Isim = txtIsim.Text,
                    Soyisim = txtSoyisim.Text,
                    Rol = cmbRol.SelectedItem?.ToString() ?? "Personel"
                };

                bool sonuc = await _api.AddKullaniciAsync(yeniKullanici);
                if (sonuc)
                {
                    MessageBox.Show("Personel başarıyla eklendi.");
                    await ListelePersonel();
                    Temizle();
                }
                else 
                {
                    MessageBox.Show("Personel eklenemedi. Sunucu hata döndürdü.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0) return;

            try 
            {
                var kullanici = new Kullanici
                {
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text,
                    Isim = txtIsim.Text,
                    Soyisim = txtSoyisim.Text,
                    Rol = cmbRol.SelectedItem?.ToString() ?? "Personel"
                };

                bool sonuc = await _api.UpdateKullaniciAsync(_selectedUserId, kullanici);
                if (sonuc)
                {
                    MessageBox.Show("Personel güncellendi.");
                    await ListelePersonel();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0) return;

            var onay = MessageBox.Show("Bu personeli silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                bool sonuc = await _api.DeleteKullaniciAsync(_selectedUserId);
                if (sonuc)
                {
                    MessageBox.Show("Personel silindi.");
                    await ListelePersonel();
                    Temizle();
                }
            }
        }

        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPersonel.Rows[e.RowIndex];
                _selectedUserId = Convert.ToInt32(row.Cells["Id"].Value);
                txtKullaniciAdi.Text = row.Cells["KullaniciAdi"].Value?.ToString();
                txtIsim.Text = row.Cells["Isim"].Value?.ToString();
                txtSoyisim.Text = row.Cells["Soyisim"].Value?.ToString();
                txtSifre.Text = row.Cells["Sifre"].Value?.ToString();
                cmbRol.SelectedItem = row.Cells["Rol"].Value?.ToString();
            }
        }

        private void Temizle()
        {
            _selectedUserId = 0;
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtIsim.Clear();
            txtSoyisim.Clear();
            cmbRol.SelectedIndex = -1;
        }
    }
}
