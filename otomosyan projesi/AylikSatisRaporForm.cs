using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace otomosyan_projesi
{
    public partial class AylikSatisRaporForm : Form
    {
        public AylikSatisRaporForm()
        {
            InitializeComponent();
        }

        private async void AylikSatisRaporForm_Load(object sender, EventArgs e)
        {
            this.Text = "Aylık Satış Raporu";

            dgvAylikSatis.Columns.Clear();
            dgvAylikSatis.Columns.Add("Tarih", "Tarih");
            dgvAylikSatis.Columns.Add("SatisAdedi", "Satış Adedi");
            dgvAylikSatis.Columns.Add("ToplamTutar", "Toplam Tutar");

            dgvAylikSatis.Columns[0].Width = 150;
            dgvAylikSatis.Columns[1].Width = 100;
            dgvAylikSatis.Columns[2].Width = 150;

            await LoadAylikSatisRaporu();
        }

        private async Task LoadAylikSatisRaporu()
        {
            try
            {
                var api = new ApiService();
                var satislar = await api.GetSatislarAsync();
                var satisDetaylari = await api.GetSatisDetaylarAsync();

                dgvAylikSatis.Rows.Clear();

                var son6Ay = Enumerable.Range(0, 6)
                    .Select(i => DateTime.Now.AddMonths(-i))
                    .OrderBy(d => d)
                    .ToList();

                foreach (var ay in son6Ay)
                {
                    var ayBasi = new DateTime(ay.Year, ay.Month, 1);
                    var aySonu = ayBasi.AddMonths(1).AddDays(-1);

                    var aySatislari = satislar.Where(s =>
                    {
                        DateTime satisTarihi = (DateTime)s.tarih;
                        return satisTarihi.Date >= ayBasi && satisTarihi.Date <= aySonu;
                    });

                    decimal satisAdedi = 0;
                    decimal toplamTutar = 0;

                    foreach (var satis in aySatislari)
                    {
                        int satisId = (int)satis.id;
                        var detaylar = satisDetaylari.Where(d => d.satis_id == satisId);

                        foreach (var detay in detaylar)
                        {
                            decimal miktar = (decimal)detay.adet;
                            decimal birimFiyat = (decimal)detay.birim_fiyat;
                            satisAdedi += miktar;
                            toplamTutar += miktar * birimFiyat;
                        }
                    }

                    dgvAylikSatis.Rows.Add(
                        ay.ToString("MMMM yyyy"),
                        satisAdedi,
                        toplamTutar.ToString("C2")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
} 