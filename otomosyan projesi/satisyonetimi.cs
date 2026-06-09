using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace otomosyan_projesi
{
    public class SepetItem
    {
        public Ilac Ilac { get; set; }
        public int Adet { get; set; }
        public override string ToString()
        {
            return $"{Ilac.Ad} - {Adet} Adet - {Ilac.Fiyat * Adet:C2}";
        }
    }

    public partial class satisyonetimi : Form
    {
        private readonly ApiService _apiService = new ApiService();
        private List<Ilac> _ilaclar = new List<Ilac>();
        private List<Hasta> _hastalar = new List<Hasta>();
        private List<SepetItem> _sepet = new List<SepetItem>();

        public satisyonetimi()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadSatislar();
        }

        private void FilterSatis(string filter)
        {
            foreach (DataGridViewRow row in dgvSatislar.Rows)
            {
                bool visible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(filter.ToLower()))
                    {
                        visible = true;
                        break;
                    }
                }
                row.Visible = visible;
            }
        }

        private void InitializeDataGridView()
        {
            dgvSatislar.Columns.Clear();
            dgvSatislar.Columns.Add("ID", "ID");
            dgvSatislar.Columns.Add("Tarih", "Tarih");
            dgvSatislar.Columns.Add("Hasta", "Hasta");
            dgvSatislar.Columns.Add("ToplamTutar", "Toplam Tutar");

            dgvSatislar.Columns[0].Width = 50;
            dgvSatislar.Columns[1].Width = 150;
            dgvSatislar.Columns[2].Width = 200;
            dgvSatislar.Columns[3].Width = 150;
        }

        private async void satisyonetimi_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadSatislar();
            await LoadIlaclar();
            await LoadHastalar();
        }

        private async Task LoadSatislar()
        {
            try
            {
                dgvSatislar.Rows.Clear();
                var satislar = await _apiService.GetSatislarAsync();
                foreach (var satis in satislar)
                {
                    dgvSatislar.Rows.Add(
                        satis.id,
                        satis.tarih,
                        $"{satis.HastaAd} {satis.HastaSoyad}",
                        ((decimal)satis.toplam_tutar).ToString("C2")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Satışlar yüklenirken hata: {ex.Message}");
            }
        }

        private async Task LoadIlaclar()
        {
            try
            {
                cmbIlaclar.Items.Clear();
                _ilaclar = await _apiService.GetIlaclarAsync();
                foreach (var ilac in _ilaclar)
                {
                    cmbIlaclar.Items.Add($"{ilac.Ad} - Stok: {ilac.Stok}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İlaçlar yüklenirken hata: {ex.Message}");
            }
        }

        private async Task LoadHastalar()
        {
            try
            {
                cmbHastalar.Items.Clear();
                _hastalar = await _apiService.GetHastalarAsync();
                foreach (var hasta in _hastalar)
                {
                    cmbHastalar.Items.Add($"{hasta.Ad} {hasta.Soyad} - TC: {hasta.Tc}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hastalar yüklenirken hata: {ex.Message}");
            }
        }

        private void btnYeniSatis_Click(object sender, EventArgs e)
        {
            if (cmbIlaclar.SelectedIndex == -1 || string.IsNullOrEmpty(txtAdet.Text))
            {
                MessageBox.Show("Lütfen ilaç ve adet seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int adet = int.Parse(txtAdet.Text);
                var seciliIlac = _ilaclar[cmbIlaclar.SelectedIndex];

                int sepettekiAdet = _sepet.Where(s => s.Ilac.Id == seciliIlac.Id).Sum(s => s.Adet);
                if (adet + sepettekiAdet > seciliIlac.Stok)
                {
                    MessageBox.Show($"Yeterli stok yok! Mevcut: {seciliIlac.Stok}, Sepetteki: {sepettekiAdet}");
                    return;
                }

                var varOlanItem = _sepet.FirstOrDefault(s => s.Ilac.Id == seciliIlac.Id);
                if (varOlanItem != null)
                {
                    varOlanItem.Adet += adet;
                    // Trigger refresh
                    GuncelleSepetUI();
                }
                else
                {
                    _sepet.Add(new SepetItem { Ilac = seciliIlac, Adet = adet });
                    GuncelleSepetUI();
                }

                txtAdet.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void GuncelleSepetUI()
        {
            lstSepet.Items.Clear();
            foreach (var item in _sepet)
            {
                lstSepet.Items.Add(item);
            }
        }

        private async void btnSatisTamamla_Click(object sender, EventArgs e)
        {
            if (cmbHastalar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen hasta seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_sepet.Count == 0)
            {
                MessageBox.Show("Sepet boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var seciliHasta = _hastalar[cmbHastalar.SelectedIndex];
                decimal toplamTutar = _sepet.Sum(s => s.Ilac.Fiyat * s.Adet);

                var detaylar = new List<object>();
                foreach (var item in _sepet)
                {
                    detaylar.Add(new { IlacId = item.Ilac.Id, Adet = item.Adet, BirimFiyat = item.Ilac.Fiyat });
                }

                var satisData = new
                {
                    KullaniciId = 1, // Örnek admin id
                    HastaId = seciliHasta.Id,
                    ToplamTutar = toplamTutar,
                    Detaylar = detaylar
                };

                bool success = await _apiService.AddSatisAsync(satisData);
                if (success)
                {
                    MessageBox.Show("Satış başarıyla kaydedildi!");
                    _sepet.Clear();
                    GuncelleSepetUI();
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Satış kaydedilemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private async void btnYeniHasta_Click(object sender, EventArgs e)
        {
            HastaEkleForm hastaEkleForm = new HastaEkleForm();
            hastaEkleForm.ShowDialog();
            await LoadHastalar();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSatislar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
