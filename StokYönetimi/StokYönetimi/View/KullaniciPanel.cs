using StokYönetimi.Model;
using System;
using System.Windows.Forms;

namespace StokYönetimi
{
    public partial class KullaniciPanel : Form
    {
        private int _customerId; // Giriş yapan kullanıcının CustomerID'si

        public KullaniciPanel(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }

        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            // Kullanıcı paneli ilk açıldığında Ürün Alım kısmını yükle
            LoadUrunAlimPanel();
        }

        private void LoadUrunAlimPanel()
        {
            // İçerik Panelini Temizle
            IcerikPanel.Controls.Clear();

            // UrunAlım Formunu Yükle
            UrunAlım urunAlimPanel = new UrunAlım(_customerId)
            {
                TopLevel = false, // Form yerine panel gibi çalışması için
                FormBorderStyle = FormBorderStyle.None, // Kenarlık olmadan
                Dock = DockStyle.Fill // İçerik Paneline tam oturacak şekilde
            };

            IcerikPanel.Controls.Add(urunAlimPanel); // İçerik Paneline ekle
            urunAlimPanel.Show(); // Görüntüle
        }

        private void SatınAlmaPanelButon_Click(object sender, EventArgs e)
        {
            LoadUrunAlimPanel();
        }

        private void CikisButon_Click(object sender, EventArgs e)
        {
            // Kullanıcı panelini kapat
            this.Close();

            // Giriş formunu yeniden başlat
            Form1 girisFormu = new Form1();
            girisFormu.Show();
        }

        private void gecmisSiparisButon_Click(object sender, EventArgs e)
        {
            // İçerik Panelini Temizle
            IcerikPanel.Controls.Clear();

            // GecmisSiparisler Formunu Yükle
            GecmisSiparisler gecmisSiparislerPanel = new GecmisSiparisler(_customerId)
            {
                TopLevel = false, // Form yerine panel gibi çalışması için
                FormBorderStyle = FormBorderStyle.None, // Kenarlık olmadan
                Dock = DockStyle.Fill // İçerik Paneline tam oturacak şekilde
            };

            IcerikPanel.Controls.Add(gecmisSiparislerPanel); // İçerik Paneline ekle
            gecmisSiparislerPanel.Show(); // Görüntüle
        }
    }
}
