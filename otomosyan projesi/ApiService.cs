using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace otomosyan_projesi
{

    //admin - 1234

    public class ApiService
    {
        private static readonly HttpClient client = new HttpClient();
        private string baseUrl;

        public ApiService()
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "api_config.txt");
            if (File.Exists(configPath))
            {
                baseUrl = File.ReadAllText(configPath).Trim();
            }
            else
            {
                baseUrl = "http://localhost/eczanesyp/API.php";
                try
                {
                    File.WriteAllText(configPath, baseUrl);
                }
                catch { }
            }
        }

        public async Task<List<Ilac>> GetIlaclarAsync()
        {
            var response = await client.GetAsync($"{baseUrl}/ilac");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Ilac>>(content);
        }

        public async Task<Ilac> GetIlacByIdAsync(int id)
        {
            var response = await client.GetAsync($"{baseUrl}/ilac/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound) return null;
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Ilac>(content);
        }

        public async Task<bool> AddIlacAsync(Ilac ilac)
        {
            var json = JsonConvert.SerializeObject(ilac);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{baseUrl}/ilac", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateIlacAsync(int id, Ilac ilac)
        {
            var json = JsonConvert.SerializeObject(ilac);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{baseUrl}/ilac/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteIlacAsync(int id)
        {
            var response = await client.DeleteAsync($"{baseUrl}/ilac/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<Hasta>> GetHastalarAsync()
        {
            var response = await client.GetAsync($"{baseUrl}/hasta");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Hasta>>(content);
        }

        public async Task<bool> AddHastaAsync(Hasta hasta)
        {
            var json = JsonConvert.SerializeObject(hasta);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{baseUrl}/hasta", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<dynamic>> GetSatislarAsync()
        {
            var response = await client.GetAsync($"{baseUrl}/satis");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<dynamic>>(content);
        }

        public async Task<bool> AddSatisAsync(object satisData)
        {
            var json = JsonConvert.SerializeObject(satisData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{baseUrl}/satis", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<dynamic>> GetSatisDetaylarAsync()
        {
            var response = await client.GetAsync($"{baseUrl}/satisdetay");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<dynamic>>(content);
        }

        public async Task<Kullanici> LoginAsync(string username, string password)
        {
            var response = await client.GetAsync($"{baseUrl}/user/login?username={username}&password={password}");
            if (!response.IsSuccessStatusCode) return null;
            
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<dynamic>(content);
            return JsonConvert.DeserializeObject<Kullanici>(result.user.ToString());
        }

        public async Task<List<Kullanici>> GetKullanicilarAsync()
        {
            var response = await client.GetAsync($"{baseUrl}/user");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Kullanici>>(content);
        }

        public async Task<bool> AddKullaniciAsync(Kullanici user)
        {
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{baseUrl}/user", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateKullaniciAsync(int id, Kullanici user)
        {
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{baseUrl}/user/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteKullaniciAsync(int id)
        {
            var response = await client.DeleteAsync($"{baseUrl}/user/{id}");
            return response.IsSuccessStatusCode;
        }
    }

    public class Ilac
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int? KategoriId { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
        public string Aciklama { get; set; }
    }

    public class Hasta
    {
        public int Id { get; set; }
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
    }
}
