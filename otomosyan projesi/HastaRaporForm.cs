using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace otomosyan_projesi
{
    public partial class HastaRaporForm : Form
    {
        private string seciliHastaTC;
        private string seciliHastaID;

        public HastaRaporForm(string hastaTC)
        {
            InitializeComponent();
            seciliHastaTC = hastaTC;
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgvHastaRapor.Columns.Clear();
            dgvHastaRapor.AutoGenerateColumns = false;

            dgvHastaRapor.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tarih",
                HeaderText = "Tarih",
                Width = 150,
                DataPropertyName = "Tarih"
            });

            dgvHastaRapor.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "İlaçAdi",
                HeaderText = "İlaç Adı",
                Width = 200,
                DataPropertyName = "İlaçAdi"
            });

            dgvHastaRapor.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Miktar",
                HeaderText = "Miktar",
                Width = 100,
                DataPropertyName = "Miktar"
            });

            dgvHastaRapor.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BirimFiyat",
                HeaderText = "Birim Fiyat",
                Width = 100,
                DataPropertyName = "BirimFiyat"
            });

            dgvHastaRapor.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ToplamTutar",
                HeaderText = "Toplam Tutar",
                Width = 100,
                DataPropertyName = "ToplamTutar"
            });
        }

        private async void HastaRaporForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadData()
        {
            var api = new ApiService();
            
            // Hastayı getir
            var hastalar = await api.GetHastalarAsync();
            var hasta = hastalar.FirstOrDefault(h => h.Tc == seciliHastaTC);
            if (hasta == null) return;

            seciliHastaID = hasta.Id.ToString();
            lblHastaAdi.Text = $"{hasta.Ad} {hasta.Soyad}";
            lblHastaTC.Text = hasta.Tc;
            lblHastaTelefon.Text = hasta.Telefon;

            // Satışları ve detayları getir
            var satislar = await api.GetSatislarAsync();
            var satisDetaylari = await api.GetSatisDetaylarAsync();

            dgvHastaRapor.Rows.Clear();
            decimal toplamGenel = 0;

            var hastaSatislari = satislar.Where(s => s.hasta_id.ToString() == seciliHastaID);

            foreach (var satis in hastaSatislari)
            {
                int satisId = (int)satis.id;
                string tarih = satis.tarih.ToString();

                var detaylar = satisDetaylari.Where(d => d.satis_id == satisId);
                foreach (var detay in detaylar)
                {
                    decimal miktar = (decimal)detay.adet;
                    decimal birimFiyat = (decimal)detay.birim_fiyat;
                    decimal toplam = miktar * birimFiyat;

                    dgvHastaRapor.Rows.Add(
                        tarih,
                        detay.IlacAd,
                        miktar,
                        birimFiyat.ToString("C2"),
                        toplam.ToString("C2")
                    );
                    toplamGenel += toplam;
                }
            }

            lblToplamTutar.Text = $"Toplam Tutar: {toplamGenel:C2}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
} 