using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace otomosyan_projesi
{
    public partial class RaporlamaForm : Form
    {
        public RaporlamaForm()
        {
            InitializeComponent();
        }

        private async void RaporlamaForm_Load(object sender, EventArgs e)
        {
            await LoadHastalar();
            await LoadIlaclar();
        }

        private async Task LoadHastalar()
        {
            try
            {
                cmbHastalar.Items.Clear();
                var api = new ApiService();
                var hastalar = await api.GetHastalarAsync();

                foreach (var hasta in hastalar)
                {
                    cmbHastalar.Items.Add(new KeyValuePair<string, string>(hasta.Tc, $"{hasta.Ad} {hasta.Soyad}"));
                }

                cmbHastalar.DisplayMember = "Value";
                cmbHastalar.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hasta listesi yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadIlaclar()
        {
            try
            {
                cmbIlaclar.Items.Clear();
                var api = new ApiService();
                var ilaclar = await api.GetIlaclarAsync();

                foreach (var ilac in ilaclar)
                {
                    cmbIlaclar.Items.Add(new KeyValuePair<string, string>(ilac.Id.ToString(), ilac.Ad));
                }

                cmbIlaclar.DisplayMember = "Value";
                cmbIlaclar.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İlaç listesi yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHastaRaporu_Click(object sender, EventArgs e)
        {
            if (cmbHastalar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir hasta seçin.");
                return;
            }

            var hastaTC = ((KeyValuePair<string, string>)cmbHastalar.SelectedItem).Key;
            var form = new HastaRaporForm(hastaTC);
            form.ShowDialog();
        }

        private void btnIlacRaporu_Click(object sender, EventArgs e)
        {
            if (cmbIlaclar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ilaç seçin.");
                return;
            }

            var ilacId = ((KeyValuePair<string, string>)cmbIlaclar.SelectedItem).Key;
            var form = new IlacRaporForm(ilacId);
            form.ShowDialog();
        }

        private void btnHaftalikRapor_Click(object sender, EventArgs e)
        {
            var form = new HaftalikRaporForm();
            form.ShowDialog();
        }

        private void btnAylikRapor_Click(object sender, EventArgs e)
        {
            var form = new AylikSatisRaporForm();
            form.ShowDialog();
        }

        private void btnEnCokSatanlar_Click(object sender, EventArgs e)
        {
            var form = new EnCokSatanlarForm();
            form.ShowDialog();
        }

        private void btnEnAzSatanlar_Click(object sender, EventArgs e)
        {
            var form = new EnAzSatanlarForm();
            form.ShowDialog();
        }

        private void btnEnCokAlisverisYapanlar_Click(object sender, EventArgs e)
        {
            var form = new EnCokAlisverisYapanlarForm();
            form.ShowDialog();
        }
    }
} 