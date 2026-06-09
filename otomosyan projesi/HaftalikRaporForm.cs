using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace otomosyan_projesi
{
    public partial class HaftalikRaporForm : Form
    {
        public HaftalikRaporForm()
        {
            InitializeComponent();
        }
            
        private async void HaftalikRaporForm_Load(object sender, EventArgs e)
        {
            this.Text = "Haftalık Satış Raporu";

            dgvHaftalikSatis.Columns.Clear();
            dgvHaftalikSatis.Columns.Add("TarihAraligi", "Tarih Aralığı");
            dgvHaftalikSatis.Columns.Add("SatisAdedi", "Satış Adedi");
            dgvHaftalikSatis.Columns.Add("ToplamTutar", "Toplam Tutar");

            dgvHaftalikSatis.Columns[0].Width = 200;
            dgvHaftalikSatis.Columns[1].Width = 100;
            dgvHaftalikSatis.Columns[2].Width = 150;

            await LoadHaftalikSatisRaporu();
        }

        private async Task LoadHaftalikSatisRaporu()
        {
            try
            {
                var api = new ApiService();
                var satislar = await api.GetSatislarAsync();
                var satisDetaylari = await api.GetSatisDetaylarAsync();

                dgvHaftalikSatis.Rows.Clear();

                var son4Hafta = Enumerable.Range(0, 4)
                    .Select(i => DateTime.Now.AddDays(-7 * i))
                    .OrderBy(d => d)
                    .ToList();

                foreach (var hafta in son4Hafta)
                {
                    var haftaBasi = hafta.Date;
                    var haftaSonu = haftaBasi.AddDays(6);

                    var haftaSatislari = satislar.Where(s =>
                    {
                        DateTime satisTarihi = (DateTime)s.tarih;
                        return satisTarihi.Date >= haftaBasi && satisTarihi.Date <= haftaSonu;
                    });

                    decimal satisAdedi = 0;
                    decimal toplamTutar = 0;

                    foreach (var satis in haftaSatislari)
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

                    dgvHaftalikSatis.Rows.Add(
                        $"{haftaBasi:dd.MM.yyyy} - {haftaSonu:dd.MM.yyyy}",
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