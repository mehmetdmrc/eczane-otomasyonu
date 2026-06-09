<?php
header("Content-Type: application/json; charset=UTF-8");
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: GET, POST, PUT, DELETE, OPTIONS");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");

if ($_SERVER['REQUEST_METHOD'] == 'OPTIONS') {
    http_response_code(200);
    exit();
}

$host = "localhost";
$username = "root";
$password = "";
$dbname = "eczane_db";

$conn = mysqli_connect($host, $username, $password, $dbname);

if (!$conn) {
    http_response_code(500);
    echo json_encode(["message" => "Veritabanı bağlantı hatası: " . mysqli_connect_error()]);
    exit();
}
mysqli_set_charset($conn, "utf8mb4");

$path = isset($_SERVER['PATH_INFO']) ? $_SERVER['PATH_INFO'] : '';
if (empty($path) && isset($_SERVER['REQUEST_URI'])) {
    $uri = parse_url($_SERVER['REQUEST_URI'], PHP_URL_PATH);
    $apiPos = strpos($uri, 'API.php');
    if ($apiPos !== false) {
        $path = substr($uri, $apiPos + strlen('API.php'));
    }
}

$parts = array_values(array_filter(explode('/', $path)));
$resource = strtolower($parts[0] ?? '');
$id = isset($parts[1]) && is_numeric($parts[1]) ? intval($parts[1]) : null;
$action = isset($parts[1]) && !is_numeric($parts[1]) ? strtolower($parts[1]) : null;
$method = $_SERVER['REQUEST_METHOD'];

try {
    // ---------------------------------------------
    // USERS (KULLANICILAR VE GİRİŞ)
    // ---------------------------------------------
    if ($resource === 'user') {
        if ($action === 'login' && $method === 'GET') {
            $username = mysqli_real_escape_string($conn, $_GET['username'] ?? '');
            $password = mysqli_real_escape_string($conn, $_GET['password'] ?? '');
            $sql = "SELECT id as Id, kullanici_adi as KullaniciAdi, isim as Isim, soyisim as Soyisim, sifre as Sifre, rol as Rol FROM kullanicilar WHERE kullanici_adi = '$username' AND sifre = '$password'";
            $result = mysqli_query($conn, $sql);
            $user = mysqli_fetch_assoc($result);
            if ($user) {
                $user['Id'] = intval($user['Id']);
                echo json_encode(["message" => "Login successful", "user" => $user]);
            } else {
                http_response_code(401);
                echo json_encode(["message" => "Geçersiz kullanıcı adı veya şifre"]);
            }
            exit();
        }
        if ($method === 'GET') {
            $sql = "SELECT id as Id, kullanici_adi as KullaniciAdi, isim as Isim, soyisim as Soyisim, sifre as Sifre, rol as Rol FROM kullanicilar";
            $result = mysqli_query($conn, $sql);
            $users = [];
            while ($row = mysqli_fetch_assoc($result)) {
                $row['Id'] = intval($row['Id']);
                $users[] = $row;
            }
            echo json_encode($users);
            exit();
        }
        if ($method === 'POST') {
            $input = json_decode(file_get_contents('php://input'), true);
            $kAdi = mysqli_real_escape_string($conn, $input['KullaniciAdi'] ?? $input['kullaniciAdi'] ?? '');
            $isim = mysqli_real_escape_string($conn, $input['Isim'] ?? $input['isim'] ?? '');
            $soyisim = mysqli_real_escape_string($conn, $input['Soyisim'] ?? $input['soyisim'] ?? '');
            $sifre = mysqli_real_escape_string($conn, $input['Sifre'] ?? $input['sifre'] ?? '');
            $rol = mysqli_real_escape_string($conn, $input['Rol'] ?? $input['rol'] ?? 'Personel');
            $sql = "INSERT INTO kullanicilar (kullanici_adi, isim, soyisim, sifre, rol) VALUES ('$kAdi', '$isim', '$soyisim', '$sifre', '$rol')";
            mysqli_query($conn, $sql);
            echo json_encode(["success" => true]);
            exit();
        }
        if ($method === 'PUT' && $id !== null) {
            $input = json_decode(file_get_contents('php://input'), true);
            $kAdi = mysqli_real_escape_string($conn, $input['KullaniciAdi'] ?? $input['kullaniciAdi'] ?? '');
            $isim = mysqli_real_escape_string($conn, $input['Isim'] ?? $input['isim'] ?? '');
            $soyisim = mysqli_real_escape_string($conn, $input['Soyisim'] ?? $input['soyisim'] ?? '');
            $sifre = mysqli_real_escape_string($conn, $input['Sifre'] ?? $input['sifre'] ?? '');
            $rol = mysqli_real_escape_string($conn, $input['Rol'] ?? $input['rol'] ?? 'Personel');
            $safeId = intval($id);
            $sql = "UPDATE kullanicilar SET kullanici_adi = '$kAdi', isim = '$isim', soyisim = '$soyisim', sifre = '$sifre', rol = '$rol' WHERE id = $safeId";
            mysqli_query($conn, $sql);
            echo json_encode(["success" => true]);
            exit();
        }
        if ($method === 'DELETE' && $id !== null) {
            $safeId = intval($id);
            $sql = "DELETE FROM kullanicilar WHERE id = $safeId";
            mysqli_query($conn, $sql);
            echo json_encode(["success" => true]);
            exit();
        }
    }

    // ---------------------------------------------
    // MEDICINES (İLAÇLAR)
    // ---------------------------------------------
    if ($resource === 'ilac') {
        if ($method === 'GET') {
            if ($id !== null) {
                $safeId = intval($id);
                $sql = "SELECT id as Id, ad as Ad, kategori_id as KategoriId, stok as Stok, fiyat as Fiyat, aciklama as Aciklama FROM ilaclar WHERE id = $safeId";
                $result = mysqli_query($conn, $sql);
                $ilac = mysqli_fetch_assoc($result);
                if ($ilac) {
                    $ilac['Id'] = intval($ilac['Id']);
                    $ilac['KategoriId'] = $ilac['KategoriId'] !== null ? intval($ilac['KategoriId']) : null;
                    $ilac['Stok'] = intval($ilac['Stok']);
                    $ilac['Fiyat'] = floatval($ilac['Fiyat']);
                    echo json_encode($ilac);
                } else {
                    http_response_code(404);
                    echo json_encode(["message" => "Bulunamadı"]);
                }
                exit();
            } else {
                $sql = "SELECT id as Id, ad as Ad, kategori_id as KategoriId, stok as Stok, fiyat as Fiyat, aciklama as Aciklama FROM ilaclar";
                $result = mysqli_query($conn, $sql);
                $ilaclar = [];
                while ($row = mysqli_fetch_assoc($result)) {
                    $row['Id'] = intval($row['Id']);
                    $row['KategoriId'] = $row['KategoriId'] !== null ? intval($row['KategoriId']) : null;
                    $row['Stok'] = intval($row['Stok']);
                    $row['Fiyat'] = floatval($row['Fiyat']);
                    $ilaclar[] = $row;
                }
                echo json_encode($ilaclar);
                exit();
            }
        }
        if ($method === 'POST') {
            $input = json_decode(file_get_contents('php://input'), true);
            $ad = mysqli_real_escape_string($conn, $input['Ad'] ?? $input['ad'] ?? '');
            $kategoriId = ($input['KategoriId'] ?? $input['kategoriId'] ?? null);
            $kategoriIdSql = $kategoriId !== null ? intval($kategoriId) : "NULL";
            $stok = intval($input['Stok'] ?? $input['stok'] ?? 0);
            $fiyat = floatval($input['Fiyat'] ?? $input['fiyat'] ?? 0);
            $aciklama = mysqli_real_escape_string($conn, $input['Aciklama'] ?? $input['aciklama'] ?? '');

            $sql = "INSERT INTO ilaclar (ad, kategori_id, stok, fiyat, aciklama) VALUES ('$ad', $kategoriIdSql, $stok, $fiyat, '$aciklama')";
            mysqli_query($conn, $sql);
            $newId = intval(mysqli_insert_id($conn));
            $input['Id'] = $newId;
            http_response_code(201);
            echo json_encode($input);
            exit();
        }
        if ($method === 'PUT' && $id !== null) {
            $input = json_decode(file_get_contents('php://input'), true);
            $ad = mysqli_real_escape_string($conn, $input['Ad'] ?? $input['ad'] ?? '');
            $kategoriId = ($input['KategoriId'] ?? $input['kategoriId'] ?? null);
            $kategoriIdSql = $kategoriId !== null ? intval($kategoriId) : "NULL";
            $stok = intval($input['Stok'] ?? $input['stok'] ?? 0);
            $fiyat = floatval($input['Fiyat'] ?? $input['fiyat'] ?? 0);
            $aciklama = mysqli_real_escape_string($conn, $input['Aciklama'] ?? $input['aciklama'] ?? '');
            $safeId = intval($id);

            $sql = "UPDATE ilaclar SET ad = '$ad', kategori_id = $kategoriIdSql, stok = $stok, fiyat = $fiyat, aciklama = '$aciklama' WHERE id = $safeId";
            mysqli_query($conn, $sql);
            http_response_code(204);
            exit();
        }
        if ($method === 'DELETE' && $id !== null) {
            $safeId = intval($id);
            $sql = "DELETE FROM ilaclar WHERE id = $safeId";
            mysqli_query($conn, $sql);
            http_response_code(204);
            exit();
        }
    }

    // ---------------------------------------------
    // PATIENTS (HASTALAR)
    // ---------------------------------------------
    if ($resource === 'hasta') {
        if ($method === 'GET') {
            if ($id !== null) {
                $safeId = intval($id);
                $sql = "SELECT id as Id, tc as Tc, ad as Ad, soyad as Soyad, telefon as Telefon, adres as Adres FROM hastalar WHERE id = $safeId";
                $result = mysqli_query($conn, $sql);
                $hasta = mysqli_fetch_assoc($result);
                if ($hasta) {
                    $hasta['Id'] = intval($hasta['Id']);
                    echo json_encode($hasta);
                } else {
                    http_response_code(404);
                    echo json_encode(["message" => "Bulunamadı"]);
                }
                exit();
            } else {
                $sql = "SELECT id as Id, tc as Tc, ad as Ad, soyad as Soyad, telefon as Telefon, adres as Adres FROM hastalar";
                $result = mysqli_query($conn, $sql);
                $hastalar = [];
                while ($row = mysqli_fetch_assoc($result)) {
                    $row['Id'] = intval($row['Id']);
                    $hastalar[] = $row;
                }
                echo json_encode($hastalar);
                exit();
            }
        }
        if ($method === 'POST') {
            $input = json_decode(file_get_contents('php://input'), true);
            $tc = mysqli_real_escape_string($conn, $input['Tc'] ?? $input['tc'] ?? '');
            $ad = mysqli_real_escape_string($conn, $input['Ad'] ?? $input['ad'] ?? '');
            $soyad = mysqli_real_escape_string($conn, $input['Soyad'] ?? $input['soyad'] ?? '');
            $telefon = mysqli_real_escape_string($conn, $input['Telefon'] ?? $input['telefon'] ?? '');
            $adres = mysqli_real_escape_string($conn, $input['Adres'] ?? $input['adres'] ?? '');

            $sql = "INSERT INTO hastalar (tc, ad, soyad, telefon, adres) VALUES ('$tc', '$ad', '$soyad', '$telefon', '$adres')";
            mysqli_query($conn, $sql);
            $newId = intval(mysqli_insert_id($conn));
            echo json_encode(["id" => $newId]);
            exit();
        }
    }

    // ---------------------------------------------
    // SALES (SATIŞLAR)
    // ---------------------------------------------
    if ($resource === 'satis') {
        if ($method === 'GET') {
            $sql = "SELECT s.id as id, s.tarih as tarih, s.kullanici_id as kullanici_id, s.hasta_id as hasta_id, s.toplam_tutar as toplam_tutar, h.ad as HastaAd, h.soyad as HastaSoyad 
                    FROM satislar s 
                    LEFT JOIN hastalar h ON s.hasta_id = h.id ORDER BY s.id DESC";
            $result = mysqli_query($conn, $sql);
            $satislar = [];
            while ($row = mysqli_fetch_assoc($result)) {
                $row['id'] = intval($row['id']);
                $row['kullanici_id'] = intval($row['kullanici_id']);
                $row['hasta_id'] = intval($row['hasta_id']);
                $row['toplam_tutar'] = floatval($row['toplam_tutar']);
                $satislar[] = $row;
            }
            echo json_encode($satislar);
            exit();
        }
        if ($method === 'POST') {
            $input = json_decode(file_get_contents('php://input'), true);
            $kullaniciId = intval($input['KullaniciId'] ?? $input['kullaniciId'] ?? 1);
            $hastaId = intval($input['HastaId'] ?? $input['hastaId'] ?? 0);
            $toplamTutar = floatval($input['ToplamTutar'] ?? $input['toplamTutar'] ?? 0);
            $detaylar = $input['Detaylar'] ?? $input['detaylar'] ?? [];

            mysqli_begin_transaction($conn);
            try {
                $sqlSatis = "INSERT INTO satislar (kullanici_id, hasta_id, toplam_tutar) VALUES ($kullaniciId, $hastaId, $toplamTutar)";
                if (!mysqli_query($conn, $sqlSatis)) {
                    throw new Exception("Satış eklenemedi: " . mysqli_error($conn));
                }
                $satisId = intval(mysqli_insert_id($conn));

                foreach ($detaylar as $detay) {
                    $ilacId = intval($detay['IlacId'] ?? $detay['ilacId'] ?? 0);
                    $adet = intval($detay['Adet'] ?? $detay['adet'] ?? 0);
                    $birimFiyat = floatval($detay['BirimFiyat'] ?? $detay['birimFiyat'] ?? 0);

                    $sqlDetay = "INSERT INTO satis_detay (satis_id, ilac_id, adet, birim_fiyat) VALUES ($satisId, $ilacId, $adet, $birimFiyat)";
                    if (!mysqli_query($conn, $sqlDetay)) {
                        throw new Exception("Satış detayı eklenemedi: " . mysqli_error($conn));
                    }

                    $sqlStok = "UPDATE ilaclar SET stok = stok - $adet WHERE id = $ilacId";
                    if (!mysqli_query($conn, $sqlStok)) {
                        throw new Exception("Stok güncellenemedi: " . mysqli_error($conn));
                    }
                }

                mysqli_commit($conn);
                echo json_encode(["SatisId" => $satisId]);
            } catch (Exception $e) {
                mysqli_rollback($conn);
                http_response_code(400);
                echo json_encode(["message" => $e->getMessage()]);
            }
            exit();
        }
    }

    // ---------------------------------------------
    // SALE DETAILS (SATIŞ DETAYLARI)
    // ---------------------------------------------
    if ($resource === 'satisdetay') {
        if ($method === 'GET') {
            $sql = "SELECT sd.id as id, sd.satis_id as satis_id, sd.ilac_id as ilac_id, sd.adet as adet, sd.birim_fiyat as birim_fiyat, i.ad as IlacAd 
                    FROM satis_detay sd 
                    JOIN ilaclar i ON sd.ilac_id = i.id";
            $result = mysqli_query($conn, $sql);
            $detaylar = [];
            while ($row = mysqli_fetch_assoc($result)) {
                $row['id'] = intval($row['id']);
                $row['satis_id'] = intval($row['satis_id']);
                $row['ilac_id'] = intval($row['ilac_id']);
                $row['adet'] = intval($row['adet']);
                $row['birim_fiyat'] = floatval($row['birim_fiyat']);
                $detaylar[] = $row;
            }
            echo json_encode($detaylar);
            exit();
        }
    }

    http_response_code(404);
    echo json_encode(["message" => "Endpoint bulunamadı: " . htmlspecialchars($resource)]);
} catch (Exception $e) {
    http_response_code(500);
    echo json_encode(["message" => "Sunucu hatası: " . $e->getMessage()]);
}

