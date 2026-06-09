using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace otomosyan_projesi
{
    public partial class EnCokAlisverisYapanlarForm : Form
    {
        public EnCokAlisverisYapanlarForm()
        {
            InitializeComponent();
        }

        private async void EnCokAlisverisYapanlarForm_Load(object sender, EventArgs e)
        {
            this.Text = "En Çok Alışveriş Yapan Hastalar Raporu";

            dgvEnCokAlisverisYapanlar.Columns.Clear();
            dgvEnCokAlisverisYapanlar.Columns.Add("HastaAdi", "Hasta Adı");
            dgvEnCokAlisverisYapanlar.Columns.Add("ToplamTutar", "Toplam Tutar");

            dgvEnCokAlisverisYapanlar.Columns[0].Width = 200;
            dgvEnCokAlisverisYapanlar.Columns[1].Width = 150;

            await LoadEnCokAlisverisYapanlar();
        }

        private async Task LoadEnCokAlisverisYapanlar()
        {
            try
            {
                var api = new ApiService();
                var hastalar = await api.GetHastalarAsync();
                var satislar = await api.GetSatislarAsync();

                dgvEnCokAlisverisYapanlar.Rows.Clear();

                var hastaAlisverisleri = hastalar.Select(h => new {
                    AdSoyad = $"{h.Ad} {h.Soyad}",
                    Toplam = satislar.Where(s => s.hasta_id == h.Id).Sum(s => (decimal)s.toplam_tutar)
                })
                .Where(x => x.Toplam > 0)
                .OrderByDescending(x => x.Toplam)
                .Take(10)
                .ToList();

                foreach (var item in hastaAlisverisleri)
                {
                    dgvEnCokAlisverisYapanlar.Rows.Add(item.AdSoyad, item.Toplam.ToString("C2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
} 