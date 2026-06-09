using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace otomosyan_projesi
{
    public partial class IlacRaporForm : Form
    {
        private string seciliIlacId;

        public IlacRaporForm(string ilacId)
        {
            InitializeComponent();
            seciliIlacId = ilacId;
        }

        private async void IlacRaporForm_Load(object sender, EventArgs e)
        {
            this.Text = "İlaç Raporu";

            dgvIlacRapor.Columns.Clear();
            dgvIlacRapor.Columns.Add("Tarih", "Tarih");
            dgvIlacRapor.Columns.Add("HastaAdi", "Hasta Adı");
            dgvIlacRapor.Columns.Add("Miktar", "Miktar");
            dgvIlacRapor.Columns.Add("BirimFiyat", "Birim Fiyat");
            dgvIlacRapor.Columns.Add("ToplamTutar", "Toplam Tutar");

            dgvIlacRapor.Columns[0].Width = 150;
            dgvIlacRapor.Columns[1].Width = 200;
            dgvIlacRapor.Columns[2].Width = 100;
            dgvIlacRapor.Columns[3].Width = 100;
            dgvIlacRapor.Columns[4].Width = 100;

            await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                var api = new ApiService();
                
                // İlacı getir
                var ilac = await api.GetIlacByIdAsync(int.Parse(seciliIlacId));
                if (ilac == null) return;

                lblIlacAdi.Text = ilac.Ad;
                lblKategori.Text = ilac.KategoriId.ToString(); // Kategori adını API'den çekmek daha iyi olurdu
                lblStokMiktari.Text = ilac.Stok.ToString();
                lblBirimFiyat.Text = ilac.Fiyat.ToString("C2");

                // Satışları ve detayları getir
                var satislar = await api.GetSatislarAsync();
                var satisDetaylari = await api.GetSatisDetaylarAsync();

                dgvIlacRapor.Rows.Clear();
                decimal toplamSatisAdet = 0;
                decimal toplamGenelTutar = 0;

                var ilacSatislari = satisDetaylari.Where(d => d.ilac_id.ToString() == seciliIlacId);

                foreach (var detay in ilacSatislari)
                {
                    var satis = satislar.FirstOrDefault(s => s.id == detay.satis_id);
                    if (satis == null) continue;

                    decimal miktar = (decimal)detay.adet;
                    decimal birimFiyat = (decimal)detay.birim_fiyat;
                    decimal toplam = miktar * birimFiyat;

                    dgvIlacRapor.Rows.Add(
                        satis.tarih.ToString(),
                        $"{satis.HastaAd} {satis.HastaSoyad}",
                        miktar,
                        birimFiyat.ToString("C2"),
                        toplam.ToString("C2")
                    );

                    toplamSatisAdet += miktar;
                    toplamGenelTutar += toplam;
                }

                lblToplamSatis.Text = toplamSatisAdet.ToString();
                lblToplamTutar.Text = toplamGenelTutar.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken hata oluştu: {ex.Message}");
            }
        }
    }
} 
 