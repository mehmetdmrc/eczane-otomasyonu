using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace otomosyan_projesi
{
    public partial class EnCokSatanlarForm : Form
    {
        public EnCokSatanlarForm()
        {
            InitializeComponent();
        }

        private async void EnCokSatanlarForm_Load(object sender, EventArgs e)
        {
            this.Text = "En Çok Satan İlaçlar Raporu";

            dgvEnCokSatanlar.Columns.Clear();
            dgvEnCokSatanlar.Columns.Add("IlacAdi", "İlaç Adı");
            dgvEnCokSatanlar.Columns.Add("SatisAdedi", "Satış Adedi");
            dgvEnCokSatanlar.Columns.Add("ToplamTutar", "Toplam Tutar");

            dgvEnCokSatanlar.Columns[0].Width = 200;
            dgvEnCokSatanlar.Columns[1].Width = 100;
            dgvEnCokSatanlar.Columns[2].Width = 150;

            await LoadEnCokSatanlar();
        }

        private async Task LoadEnCokSatanlar()
        {
            try
            {
                var api = new ApiService();
                var ilaclar = await api.GetIlaclarAsync();
                var satisDetaylari = await api.GetSatisDetaylarAsync();

                dgvEnCokSatanlar.Rows.Clear();

                var ilacSatislari = ilaclar.Select(i => new {
                    Id = i.Id,
                    Ad = i.Ad,
                    Adet = satisDetaylari.Where(d => d.ilac_id == i.Id).Sum(d => (decimal)d.adet),
                    Tutar = satisDetaylari.Where(d => d.ilac_id == i.Id).Sum(d => (decimal)d.adet * (decimal)d.birim_fiyat)
                })
                .OrderByDescending(x => x.Adet)
                .Take(10)
                .ToList();

                foreach (var item in ilacSatislari)
                {
                    dgvEnCokSatanlar.Rows.Add(item.Ad, item.Adet, item.Tutar.ToString("C2"));
                }

                lblToplamSatis.Text = $"Toplam Satış: {ilacSatislari.Sum(x => x.Adet)} adet";
                lblToplamTutar.Text = $"Toplam Tutar: {ilacSatislari.Sum(x => x.Tutar):C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
} 