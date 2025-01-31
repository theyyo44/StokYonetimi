using StokYönetimi.Model;
using System;
using System.Windows.Forms;

namespace StokYönetimi
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // Varsayılan olarak AdminSiparişOnayla panelini yükle
            LoadAdminSiparisOnaylaPanel();
        }

        private void KullaniciYonetimiButon_Click(object sender, EventArgs e)
        {
            IcerikPanel.Controls.Clear(); // Panel içeriğini temizle

            KullaniciYonetimi kullaniciPanel = new KullaniciYonetimi
            {
                TopLevel = false, // Form embed edilmeli
                FormBorderStyle = FormBorderStyle.None, // Kenarlıkları kaldır
                Dock = DockStyle.Fill // İçerik panelinin tamamını kapla
            };

            IcerikPanel.Controls.Add(kullaniciPanel);
            kullaniciPanel.Show();
        }

        private void StokYönetimiButon_Click(object sender, EventArgs e)
        {
            IcerikPanel.Controls.Clear(); // Panel içeriğini temizle

            StokYoneti stokPanel = new StokYoneti
            {
                TopLevel = false, // Form embed edilmeli
                FormBorderStyle = FormBorderStyle.None, // Kenarlıkları kaldır
                Dock = DockStyle.Fill // İçerik panelinin tamamını kapla
            };

            IcerikPanel.Controls.Add(stokPanel);
            stokPanel.Show();
        }

        private void OnayYonetimButon_Click(object sender, EventArgs e)
        {
            LoadAdminSiparisOnaylaPanel();
        }

        private void LoadAdminSiparisOnaylaPanel()
        {
            IcerikPanel.Controls.Clear(); // Panel içeriğini temizle

            AdminSiparişOnayla adminSiparişOnayla = new AdminSiparişOnayla
            {
                TopLevel = false, // Form embed edilmeli
                FormBorderStyle = FormBorderStyle.None, // Kenarlıkları kaldır
                Dock = DockStyle.Fill // İçerik panelinin tamamını kapla
            };

            IcerikPanel.Controls.Add(adminSiparişOnayla);
            adminSiparişOnayla.Show(); // Formu görüntüle
        }

        private void cıkısButon_Click(object sender, EventArgs e)
        {
            this.Close();

            // Giriş formunu yeniden başlat
            Form1 girisFormu = new Form1();
            girisFormu.Show();
        }
    }
}
