using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace otomosyan_projesi
{
    public partial class EnAzSatanlarForm : Form
    {
        public EnAzSatanlarForm()
        {
            InitializeComponent();
        }

        private async void EnAzSatanlarForm_Load(object sender, EventArgs e)
        {
            this.Text = "En Az Satan İlaçlar Raporu";

            dgvEnAzSatanlar.Columns.Clear();
            dgvEnAzSatanlar.Columns.Add("IlacAdi", "İlaç Adı");
            dgvEnAzSatanlar.Columns.Add("SatisAdedi", "Satış Adedi");
            dgvEnAzSatanlar.Columns.Add("ToplamTutar", "Toplam Tutar");

            dgvEnAzSatanlar.Columns[0].Width = 200;
            dgvEnAzSatanlar.Columns[1].Width = 100;
            dgvEnAzSatanlar.Columns[2].Width = 150;

            await LoadEnAzSatanlar();
        }

        private async Task LoadEnAzSatanlar()
        {
            try
            {
                var api = new ApiService();
                var ilaclar = await api.GetIlaclarAsync();
                var satisDetaylari = await api.GetSatisDetaylarAsync();

                dgvEnAzSatanlar.Rows.Clear();

                var ilacSatislari = ilaclar.Select(i => new {
                    Id = i.Id,
                    Ad = i.Ad,
                    Adet = satisDetaylari.Where(d => d.ilac_id == i.Id).Sum(d => (decimal)d.adet),
                    Tutar = satisDetaylari.Where(d => d.ilac_id == i.Id).Sum(d => (decimal)d.adet * (decimal)d.birim_fiyat)
                })
                .Where(x => x.Adet > 0)
                .OrderBy(x => x.Adet)
                .Take(10)
                .ToList();

                foreach (var item in ilacSatislari)
                {
                    dgvEnAzSatanlar.Rows.Add(item.Ad, item.Adet, item.Tutar.ToString("C2"));
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