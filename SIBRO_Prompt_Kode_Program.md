# SI BRO — Prompt Kode Program Lengkap
**Sistem Monitoring Kondisi Ayam Broiler**  
Mata Kuliah: Pemrograman Berorientasi Objek (PBO) | Semester 3  
Tools: C# Windows Forms | Visual Studio | MySQL

---

> ⚠️ **PENTING SEBELUM MULAI:**  
> Kerjakan **Orang 1 terlebih dahulu** karena file `DatabaseHelper.cs` dan script SQL digunakan oleh semua anggota kelompok. Setelah selesai, bagikan file tersebut ke Orang 2, 3, dan 4 sebelum mereka mulai mengerjakan.

---

## 🔴 ORANG 1 — Manajemen Data Kandang & Ayam

```
Buatkan kode program lengkap C# Windows Forms di Visual Studio untuk aplikasi 
"SI BRO: Sistem Monitoring Ayam Broiler" bagian FITUR 1: Manajemen Data Kandang & Ayam.

KETENTUAN WAJIB:
- Bahasa: C# Windows Forms (.NET Framework)
- Database: MySQL, nama database = "sibro_db"
- Gunakan konsep OOP: class, encapsulation, inheritance
- Sertakan komentar kode Bahasa Indonesia
- Koneksi DB pakai MySql.Data (NuGet)

YANG HARUS DIBUAT (berikan semua file/class lengkap, jangan dipotong):

1. Script SQL untuk buat tabel:
   - tbl_kandang (id_kandang, nama_kandang, kapasitas, lokasi, status, created_at)
   - tbl_ayam (id_ayam, id_kandang, jumlah_ayam, umur_hari, jenis_ayam, tanggal_masuk)

2. Class Model (Models/Kandang.cs):
   - Property sesuai kolom tabel
   - Constructor, getter, setter

3. Class Model (Models/Ayam.cs):
   - Property sesuai kolom tabel
   - Constructor, getter, setter

4. Class DatabaseHelper.cs:
   - Method GetConnection() untuk koneksi MySQL
   - Connection string siap pakai

5. Class KandangRepository.cs:
   - GetAllKandang()
   - GetKandangById(int id)
   - InsertKandang(Kandang k)
   - UpdateKandang(Kandang k)
   - DeleteKandang(int id)

6. Class AyamRepository.cs:
   - GetAllAyam()
   - GetAyamByKandang(int idKandang)
   - InsertAyam(Ayam a)
   - UpdateAyam(Ayam a)
   - DeleteAyam(int id)

7. Form FormKandang.cs (desain + logic):
   - DataGridView tampilkan data kandang
   - TextBox: nama_kandang, kapasitas, lokasi
   - ComboBox: status (Aktif/Nonaktif)
   - Tombol: Tambah, Edit, Hapus, Refresh, Clear
   - Validasi input tidak boleh kosong
   - Pesan konfirmasi sebelum hapus

8. Form FormAyam.cs (desain + logic):
   - DataGridView tampilkan data ayam
   - ComboBox: pilih kandang (load dari DB)
   - TextBox: jumlah_ayam, umur_hari, jenis_ayam
   - DateTimePicker: tanggal_masuk
   - Tombol: Tambah, Edit, Hapus, Refresh, Clear
   - Validasi input

Berikan SEMUA kode lengkap dari awal sampai akhir setiap file. 
Jangan gunakan placeholder seperti "// kode lainnya" atau "...". 
Tulis kode yang benar-benar bisa langsung dijalankan.
```

---

## 🟠 ORANG 2 — Input & Monitoring Kondisi Harian

```
Buatkan kode program lengkap C# Windows Forms di Visual Studio untuk aplikasi 
"SI BRO: Sistem Monitoring Ayam Broiler" bagian FITUR 2: Input & Monitoring Kondisi Harian.

KETENTUAN WAJIB:
- Bahasa: C# Windows Forms (.NET Framework)
- Database: MySQL, nama database = "sibro_db"
- Gunakan konsep OOP: class, encapsulation, inheritance
- Sertakan komentar kode Bahasa Indonesia
- Koneksi DB pakai MySql.Data (NuGet)
- Gunakan DatabaseHelper.cs yang sudah ada (Method GetConnection())

YANG HARUS DIBUAT (berikan semua file/class lengkap, jangan dipotong):

1. Script SQL untuk buat tabel:
   - tbl_monitoring (id_monitoring, id_kandang, suhu, kelembaban, 
     berat_rata2, kondisi_umum, catatan, tanggal_input, waktu_input)

2. Class Model (Models/Monitoring.cs):
   - Property sesuai kolom tabel
   - Constructor, getter, setter
   - Method ToString() override

3. Class MonitoringRepository.cs:
   - GetAllMonitoring()
   - GetMonitoringByKandang(int idKandang)
   - GetMonitoringByTanggal(DateTime tgl)
   - InsertMonitoring(Monitoring m)
   - UpdateMonitoring(Monitoring m)
   - DeleteMonitoring(int id)
   - GetMonitoringTerbaru(int idKandang) — ambil data terbaru 1 record

4. Form FormInputMonitoring.cs (desain + logic):
   - ComboBox: pilih kandang (load dari DB tbl_kandang)
   - NumericUpDown: suhu (15.0 - 45.0 °C, increment 0.1)
   - NumericUpDown: kelembaban (0 - 100 %)
   - NumericUpDown: berat_rata2 (gram, 0 - 5000)
   - ComboBox: kondisi_umum (Normal, Kurang Baik, Kritis)
   - TextBox multiline: catatan
   - DateTimePicker: tanggal_input
   - Label tampilkan waktu real-time (Timer setiap detik)
   - Tombol: Simpan, Edit, Hapus, Clear, Refresh
   - Validasi: suhu dan kelembaban wajib diisi
   - DataGridView: tampilkan riwayat input
   - Warna baris DataGridView berdasarkan kondisi:
     Hijau = Normal, Kuning = Kurang Baik, Merah = Kritis

5. Form FormRiwayatMonitoring.cs (desain + logic):
   - Filter data by: ComboBox kandang + DateTimePicker rentang tanggal
   - Tombol: Filter, Reset Filter, Export ke CSV
   - DataGridView dengan semua kolom monitoring
   - Label summary: Total Record, Rata-rata Suhu, Rata-rata Kelembaban
   - Fungsi Export CSV simpan ke folder Documents

Berikan SEMUA kode lengkap dari awal sampai akhir setiap file. 
Jangan gunakan placeholder seperti "// kode lainnya" atau "...". 
Tulis kode yang benar-benar bisa langsung dijalankan.
```

---

## 🟡 ORANG 3 — Deteksi Penyakit (Rule-Based AI)

```
Buatkan kode program lengkap C# Windows Forms di Visual Studio untuk aplikasi 
"SI BRO: Sistem Monitoring Ayam Broiler" bagian FITUR 3: Deteksi Penyakit Berbasis 
Aturan (Rule-Based Expert System / AI Sederhana).

KETENTUAN WAJIB:
- Bahasa: C# Windows Forms (.NET Framework)
- Database: MySQL, nama database = "sibro_db"
- Gunakan konsep OOP: class, encapsulation, polymorphism, interface
- Sertakan komentar kode Bahasa Indonesia
- Koneksi DB pakai MySql.Data (NuGet)
- Gunakan DatabaseHelper.cs yang sudah ada

YANG HARUS DIBUAT (berikan semua file/class lengkap, jangan dipotong):

1. Script SQL untuk buat tabel:
   - tbl_penyakit (id_penyakit, nama_penyakit, deskripsi, gejala, penanganan, tingkat_bahaya)
   - tbl_hasil_deteksi (id_deteksi, id_kandang, id_monitoring, id_penyakit, 
     persentase_kemungkinan, tanggal_deteksi, status_penanganan)

2. Script SQL INSERT data penyakit (isi minimal 5 penyakit):
   - Newcastle Disease
   - Chronic Respiratory Disease (CRD)
   - Gumboro (IBD)
   - Coccidiosis
   - Avian Influenza (ringan)

3. Interface IDeteksi.cs:
   - Method Analisis(Monitoring data) : List<HasilDeteksi>
   - Method GetRekomendasiPenanganan(string namaPenyakit) : string

4. Class Model (Models/Penyakit.cs dan Models/HasilDeteksi.cs):
   - Semua property lengkap dengan getter setter

5. Class RuleEngine.cs (implements IDeteksi):
   RULES DETEKSI (implementasikan sebagai method terpisah setiap penyakit):
   
   - DeteksiNewcastle(Monitoring m):
     Suhu > 39°C DAN kelembaban > 80% DAN kondisi = Kritis → 85%
     Suhu > 38°C DAN kondisi = Kurang Baik → 60%
   
   - DeteksiCRD(Monitoring m):
     Suhu < 20°C DAN kelembaban > 75% → 75%
     Suhu < 22°C DAN kondisi != Normal → 50%
   
   - DeteksiGumboro(Monitoring m):
     Kelembaban > 85% DAN berat_rata2 turun > 10% dari normal umur → 70%
     Kondisi = Kritis DAN kelembaban > 80% → 65%
   
   - DeteksiCoccidiosis(Monitoring m):
     Kelembaban > 80% DAN suhu 25-32°C DAN kondisi != Normal → 70%
   
   - DeteksiAvianInfluenza(Monitoring m):
     Suhu > 40°C DAN kondisi = Kritis → 90%
     Suhu > 39°C DAN kelembaban > 85% → 70%
   
   - Method Analisis(): jalankan semua deteksi, return list yang persentase > 30%
   - Sort hasil berdasarkan persentase tertinggi

6. Class PenyakitRepository.cs:
   - GetAllPenyakit()
   - GetPenyakitByNama(string nama)
   - SaveHasilDeteksi(HasilDeteksi h)
   - GetRiwayatDeteksi(int idKandang)

7. Form FormDeteksiPenyakit.cs (desain + logic):
   - ComboBox: pilih kandang
   - Setelah pilih kandang: auto-load data monitoring terbaru ke label
     (tampilkan: Suhu, Kelembaban, Berat, Kondisi, Tanggal Input)
   - Tombol "ANALISIS SEKARANG" (besar, mencolok)
   - Panel hasil analisis:
     - Jika tidak ada penyakit terdeteksi: tampilkan pesan hijau "Kondisi Normal"
     - Jika ada: tampilkan DataGridView dengan kolom:
       Nama Penyakit | Kemungkinan (%) | Tingkat Bahaya | Status
     - ProgressBar untuk setiap persentase kemungkinan
     - RichTextBox: tampilkan detail gejala + penanganan penyakit teratas
   - Tombol "Simpan Hasil Deteksi" → simpan ke tbl_hasil_deteksi
   - Tombol "Lihat Riwayat Deteksi" → buka Form riwayat
   - Warna background panel: Hijau jika aman, Kuning jika waspada, Merah jika kritis

8. Form FormRiwayatDeteksi.cs:
   - DataGridView riwayat semua deteksi
   - Filter by kandang dan tanggal
   - ComboBox update status penanganan (Belum Ditangani / Dalam Penanganan / Selesai)

Berikan SEMUA kode lengkap dari awal sampai akhir setiap file. 
Jangan gunakan placeholder seperti "// kode lainnya" atau "...". 
Tulis kode yang benar-benar bisa langsung dijalankan.
```

---

## 🟢 ORANG 4 — Rekomendasi Suhu + Dashboard & Laporan

```
Buatkan kode program lengkap C# Windows Forms di Visual Studio untuk aplikasi 
"SI BRO: Sistem Monitoring Ayam Broiler" bagian FITUR 4: Rekomendasi Suhu Otomatis, 
Dashboard, dan Laporan.

KETENTUAN WAJIB:
- Bahasa: C# Windows Forms (.NET Framework)
- Database: MySQL, nama database = "sibro_db"
- Gunakan konsep OOP: class, encapsulation, inheritance, polymorphism
- Sertakan komentar kode Bahasa Indonesia
- Koneksi DB pakai MySql.Data (NuGet)
- Chart/Grafik menggunakan Windows Forms Chart Control (System.Windows.Forms.DataVisualization)
- Gunakan DatabaseHelper.cs yang sudah ada

YANG HARUS DIBUAT (berikan semua file/class lengkap, jangan dipotong):

1. Script SQL untuk buat tabel:
   - tbl_rekomendasi_suhu (id_rekomendasi, umur_hari_min, umur_hari_max, 
     suhu_ideal_min, suhu_ideal_max, kelembaban_ideal_min, kelembaban_ideal_max, keterangan)
   - Script INSERT data rekomendasi berdasarkan umur ayam broiler:
     Umur 1-7 hari: suhu 33-35°C, kelembaban 60-70%
     Umur 8-14 hari: suhu 30-32°C, kelembaban 60-70%
     Umur 15-21 hari: suhu 27-29°C, kelembaban 55-65%
     Umur 22-28 hari: suhu 24-26°C, kelembaban 50-65%
     Umur 29+ hari: suhu 21-23°C, kelembaban 50-60%

2. Class Model (Models/RekomendasiSuhu.cs):
   - Semua property lengkap
   - Method CekStatusSuhu(double suhuAktual) : string → return "Optimal/Terlalu Panas/Terlalu Dingin"
   - Method CekStatusKelembaban(double kelembabanAktual) : string

3. Class RekomendasiEngine.cs:
   - GetRekomendasiByUmur(int umurHari) : RekomendasiSuhu
   - HitungSelisihSuhu(double suhuAktual, RekomendasiSuhu rek) : double
   - GeneratePesanRekomendasi(double suhuAktual, double kelembaban, int umurHari) : string
     → Pesan harus spesifik: "Suhu terlalu tinggi X°C dari ideal, turunkan ke Y-Z°C"

4. Class LaporanService.cs:
   - GetDataLaporanHarian(int idKandang, DateTime tanggal) : DataTable
   - GetDataLaporanMingguan(int idKandang, DateTime mingguAwal) : DataTable
   - GetSummaryStatistik(int idKandang) : Dictionary<string, object>
     (isi: rata2 suhu, rata2 kelembaban, total monitoring, total deteksi penyakit)
   - ExportLaporanCSV(DataTable dt, string filePath) : bool
   - ExportLaporanTXT(int idKandang, DateTime dari, DateTime sampai, string filePath) : bool

5. Form FormRekomendasi.cs (desain + logic):
   - ComboBox: pilih kandang
   - Setelah pilih: auto tampilkan data terbaru (suhu aktual, kelembaban, umur ayam)
   - Panel Rekomendasi:
     - Label besar: Suhu Ideal "XX - XX °C"
     - Label besar: Kelembaban Ideal "XX - XX %"
     - Label status suhu (warna merah/hijau/biru)
     - RichTextBox: pesan rekomendasi detail
     - ProgressBar: indikator suhu aktual vs ideal (0-100%)
   - Tombol "Refresh Data"
   - Timer auto-refresh setiap 30 detik

6. Form FormDashboard.cs (FORM UTAMA, desain + logic):
   - Ini adalah halaman utama yang muncul pertama
   - Panel atas: Label judul "SI BRO - Sistem Monitoring Ayam Broiler"
   - 4 Panel kartu statistik (berwarna):
     * Total Kandang Aktif (biru)
     * Total Ayam Terpantau (hijau)
     * Kandang dengan Status Kritis Hari Ini (merah)
     * Total Deteksi Penyakit Bulan Ini (oranye)
   - Chart 1 (Line Chart): Grafik tren suhu 7 hari terakhir per kandang
   - Chart 2 (Bar Chart): Perbandingan kondisi kandang (Normal/Kurang Baik/Kritis)
   - DataGridView: 5 monitoring terbaru dari semua kandang
   - Panel navigasi kiri: tombol ke semua fitur
     (Dashboard | Data Kandang | Data Ayam | Monitoring | Deteksi Penyakit | 
      Rekomendasi Suhu | Laporan | Keluar)
   - Timer refresh otomatis setiap 60 detik
   - Load semua data saat form dibuka

7. Form FormLaporan.cs (desain + logic):
   - ComboBox: pilih kandang
   - RadioButton: Laporan Harian / Mingguan / Bulanan
   - DateTimePicker: pilih tanggal/periode
   - Tombol "Generate Laporan"
   - DataGridView: tampilkan hasil laporan
   - Panel statistik: Rata-rata Suhu, Rata-rata Kelembaban, Kondisi Dominan
   - Tombol "Export CSV" → simpan ke My Documents
   - Tombol "Export TXT" → laporan teks formal dengan header institusi
   - Tombol "Print Preview" → PrintDocument sederhana

8. Form FormLogin.cs (desain + logic):
   - TextBox: Username dan Password
   - Hardcode 1 akun: username="admin" password="sibro2024"
   - Jika berhasil → buka FormDashboard
   - Jika gagal 3x → tampilkan pesan dan tutup aplikasi
   - Desain menarik dengan logo/judul sistem

Berikan SEMUA kode lengkap dari awal sampai akhir setiap file. 
Jangan gunakan placeholder seperti "// kode lainnya" atau "...". 
Tulis kode yang benar-benar bisa langsung dijalankan.
```

---

## 📋 Cara Penggunaan

1. **Copy satu prompt** sesuai bagian masing-masing → paste ke ChatGPT (GPT-4o) atau Claude
2. Jika kode **terpotong**, ketik: *"lanjutkan kode dari bagian [nama class yang terpotong]"*
3. Kerjakan **Orang 1 dulu** — bagikan `DatabaseHelper.cs` dan script SQL ke semua anggota sebelum lanjut
4. Setiap orang mengintegrasikan kode ke dalam **1 project Visual Studio yang sama**

---

*SI BRO — Proyek Akhir PBO Semester 3 | Program Studi Informatika*
