namespace otomosyan_projesi
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; }
    }

    public static class SessionManager
    {
        public static Kullanici CurrentUser { get; set; }
    }
}
