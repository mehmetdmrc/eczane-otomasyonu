# Eczane Otomasyonu 💊

Bu proje, eczanelerin günlük işleyişini kolaylaştırmak amacıyla geliştirilmiş kapsamlı bir **Eczane Otomasyon Sistemi**'dir. C# Windows Forms kullanılarak geliştirilen masaüstü uygulaması ve PHP tabanlı bir API ile desteklenmektedir. 

## 🚀 Özellikler

Sistem, eczane süreçlerini dijitalleştirmek için aşağıdaki temel modülleri içerir:

- **🔐 Kullanıcı Girişi (Login):** Güvenli personel giriş ekranı.
- **📦 Stok Yönetimi:** İlaç ekleme, düzenleme ve stok takibi (`stokıslemlerı.cs`, `IlacEkleForm.cs`).
- **💰 Satış Yönetimi:** Hızlı ve kolay satış işlemleri (`satisyonetimi.cs`).
- **🩺 Hasta Takibi:** Hasta kaydı oluşturma ve geçmiş işlemlerini izleme (`HastaEkleForm.cs`, `HastaRaporForm.cs`).
- **📊 Raporlama Sistemi:** Kapsamlı analiz ve raporlama araçları (`RaporlamaForm.cs`):
  - Günlük/Haftalık/Aylık Satış Raporları
  - En Çok/En Az Satan İlaçlar
  - En Çok Alışveriş Yapan Müşteriler (Hastalar)
- **⚙️ Ayarlar:** Sistem yapılandırmaları (`AyarlarForm.cs`).

## 🛠️ Kullanılan Teknolojiler

- **Masaüstü Uygulaması:** C# (.NET Framework, Windows Forms)
- **Arka Yüz (Backend API):** PHP (`API.php`)
- **Veritabanı:** MySQL (`eczane_db.sql`)

## 💻 Kurulum

Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1. Bu projeyi bilgisayarınıza klonlayın:
   ```bash
   git clone https://github.com/mehmetdmrc/eczane-otomasyonu.git
   ```
2. Veritabanı Kurulumu:
   - XAMPP, WAMP veya benzeri bir yerel sunucu başlatın.
   - phpMyAdmin üzerinden `eczane_db` adında yeni bir veritabanı oluşturun.
   - Proje ana dizininde bulunan `eczane_db.sql` dosyasını bu veritabanına içe aktarın (import).
3. API Bağlantısı:
   - `API.php` dosyasını sunucunuzun kök dizinine (ör. XAMPP için `htdocs`) yerleştirin ve veritabanı bağlantı bilgilerinin doğruluğunu kontrol edin.
4. C# Projesini Çalıştırma:
   - Visual Studio uygulamasını açın.
   - `otomosyan projesi.sln` dosyasını açın.
   - Çözümü derleyin (Build) ve başlatın (Start).

## 📝 Lisans

Bu proje kişisel gelişim ve eğitim amacıyla hazırlanmıştır. 