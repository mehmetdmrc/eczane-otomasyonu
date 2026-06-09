using System;
using System.Linq; // FirstOrDefault kullanımı için bu kütüphanenin ekli olduğundan emin ol
using System.Windows.Forms;

namespace otomosyan_projesi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ApiService api = new ApiService();
                Kullanici user = await api.LoginAsync(username, password);

                if (user != null)
                {
                    SessionManager.CurrentUser = user;
                    MessageBox.Show($"Hoş geldiniz, {user.Isim} {user.Soyisim}!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    formanasayfa mainForm = new formanasayfa();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sunucuya bağlanılamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}