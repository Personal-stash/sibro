# SI BRO - Sistem Monitoring Ayam Broiler

Aplikasi C# Windows Forms (.NET Framework 4.8) dengan database MySQL.
Semua fitur Orang 1 sampai Orang 4 sudah digabung dalam satu project.

## Cara menjalankan

1. Install **Visual Studio 2022** dengan workload **.NET desktop development**.
2. Install **XAMPP**, lalu Start **MySQL** di XAMPP Control Panel.
3. Buka phpMyAdmin (`http://localhost/phpmyadmin`), pilih tab **Import**, lalu impor:
   - `Database/sibro_db.sql` (wajib)
   - `Database/sibro_contoh_data.sql` (opsional, data contoh untuk demo, cukup sekali)
4. Buka `SIBRO.sln` di Visual Studio, lalu tekan **F5**. Paket `MySql.Data` terunduh otomatis saat build pertama.
5. Login dengan username `admin` dan password `sibro2024`.

Jika MySQL Anda memakai password, ubah `Uid` dan `Pwd` di `SIBRO/Data/DatabaseHelper.cs`.

## Struktur project

| Folder | Isi | Penanggung jawab |
| --- | --- | --- |
| `Database/` | Script SQL gabungan dan data contoh | Semua |
| `SIBRO/Models/` | Kandang, Ayam, Monitoring, Penyakit, HasilDeteksi, RekomendasiSuhu | Semua |
| `SIBRO/Data/` | DatabaseHelper dan semua Repository | Orang 1, 2, 3, 4 |
| `SIBRO/Services/` | IDeteksi, RuleEngine, RekomendasiEngine, LaporanService | Orang 3, 4 |
| `SIBRO/Forms/` | Semua form, tampilannya bisa diedit lewat Form Designer | Semua |

## Konsep OOP yang dipakai

| Konsep | Contoh di kode |
| --- | --- |
| Encapsulation | Property model, `Ayam.UmurSekarang` yang hanya bisa dibaca |
| Inheritance | `Kandang : BaseEntity`, `KandangRepository : BaseRepository`, `FormKandang : BaseForm` |
| Polymorphism | Override `Validasi()`, `MuatData()`, dan `ToString()` |
| Interface | `RuleEngine : IDeteksi`, form hanya mengenal `IDeteksi` |

## Koreksi terhadap dokumen prompt

**Kesalahan yang diperbaiki**

1. **Urutan halaman pertama bertentangan.** FormDashboard disebut "muncul pertama", padahal FormLogin membuka Dashboard setelah login. Yang dipakai: Login lebih dulu, lalu Dashboard sebagai halaman utama.
2. **Umur ayam akan salah setelah beberapa hari.** `umur_hari` hanya disimpan sekali, sehingga rekomendasi suhu lama-kelamaan keliru. Kolom ini kini berarti umur saat masuk, dan umur hari ini dihitung otomatis dari `tanggal_masuk` (`Ayam.UmurSekarang`).
3. **Aturan Gumboro kekurangan data.** Aturan butuh "berat normal menurut umur", tetapi datanya tidak ada dan `Analisis(Monitoring)` tidak menerima umur. Ditambahkan `StandarBerat.cs`, dan umur diambil dari data ayam di kandang.
4. **Laporan Bulanan tidak punya method.** FormLaporan meminta laporan bulanan, tetapi LaporanService hanya punya harian dan mingguan. Ditambahkan `GetDataLaporanBulanan`.
5. **FormRiwayatMonitoring tidak bisa dibuka.** Menu navigasi hanya punya satu tombol Monitoring. Ditambahkan tombol "Riwayat dan Filter" di FormInputMonitoring.
6. **Tidak ada aturan umur 0 hari.** Anak ayam (DOC) yang baru tiba bisa berumur 0 hari, sedangkan aturan mulai dari 1 hari. Umur 0 kini mengikuti aturan 1-7 hari.

**Penyesuaian yang perlu Anda tahu**

- ProgressBar per penyakit digambar di dalam sel DataGridView, karena DataGridView tidak punya kolom ProgressBar bawaan.
- Script SQL digabung jadi satu file, dengan urutan tabel yang benar untuk FOREIGN KEY.
- Ditambahkan `BaseEntity`, `BaseRepository`, dan `BaseForm` agar syarat inheritance terpenuhi dan kode tidak berulang.
- Ditambahkan validasi kapasitas kandang, pencegahan hasil deteksi tersimpan ganda, dan pesan error yang mudah dipahami.

**Hal yang sebaiknya disebut saat presentasi**

- Akun login masih ditulis di kode karena memang diminta tugas. Untuk aplikasi sungguhan, simpan akun di database dengan password yang di-hash.
- Angka pada aturan penyakit dan `StandarBerat` berasal dari dokumen tugas atau perkiraan umum, bukan data yang tervalidasi. Hasilnya hanya perkiraan awal, bukan diagnosis dokter hewan.
- Jika file CSV tampil dalam satu kolom di Excel, gunakan menu **Data > Text to Columns** dengan pemisah koma.
