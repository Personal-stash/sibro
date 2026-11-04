-- =====================================================================
-- SI BRO - Sistem Monitoring Kondisi Ayam Broiler
-- Script database lengkap (gabungan bagian Orang 1, 2, 3, dan 4).
-- Urutan tabel penting karena ada FOREIGN KEY: tabel induk dibuat dulu.
-- =====================================================================

CREATE DATABASE IF NOT EXISTS sibro_db
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_general_ci;

USE sibro_db;

-- ---------------------------------------------------------------------
-- ORANG 1: Kandang & Ayam
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS tbl_kandang (
    id_kandang   INT AUTO_INCREMENT PRIMARY KEY,
    nama_kandang VARCHAR(100) NOT NULL,
    kapasitas    INT NOT NULL,
    lokasi       VARCHAR(150) NOT NULL,
    status       ENUM('Aktif','Nonaktif') NOT NULL DEFAULT 'Aktif',
    created_at   TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

-- umur_hari = umur ayam SAAT MASUK kandang.
-- Umur hari ini dihitung otomatis: umur_hari + selisih hari sejak tanggal_masuk.
CREATE TABLE IF NOT EXISTS tbl_ayam (
    id_ayam       INT AUTO_INCREMENT PRIMARY KEY,
    id_kandang    INT NOT NULL,
    jumlah_ayam   INT NOT NULL,
    umur_hari     INT NOT NULL,
    jenis_ayam    VARCHAR(100) NOT NULL,
    tanggal_masuk DATE NOT NULL,
    CONSTRAINT fk_ayam_kandang FOREIGN KEY (id_kandang)
        REFERENCES tbl_kandang (id_kandang) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;

-- ---------------------------------------------------------------------
-- ORANG 2: Monitoring harian
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS tbl_monitoring (
    id_monitoring INT AUTO_INCREMENT PRIMARY KEY,
    id_kandang    INT NOT NULL,
    suhu          DECIMAL(4,1) NOT NULL,
    kelembaban    DECIMAL(4,1) NOT NULL,
    berat_rata2   DECIMAL(6,1) NOT NULL DEFAULT 0,
    kondisi_umum  ENUM('Normal','Kurang Baik','Kritis') NOT NULL DEFAULT 'Normal',
    catatan       TEXT NULL,
    tanggal_input DATE NOT NULL,
    waktu_input   TIME NOT NULL,
    INDEX idx_monitoring_tanggal (tanggal_input),
    CONSTRAINT fk_monitoring_kandang FOREIGN KEY (id_kandang)
        REFERENCES tbl_kandang (id_kandang) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;

-- ---------------------------------------------------------------------
-- ORANG 3: Penyakit & hasil deteksi
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS tbl_penyakit (
    id_penyakit    INT AUTO_INCREMENT PRIMARY KEY,
    nama_penyakit  VARCHAR(100) NOT NULL UNIQUE,
    deskripsi      TEXT NOT NULL,
    gejala         TEXT NOT NULL,
    penanganan     TEXT NOT NULL,
    tingkat_bahaya ENUM('Rendah','Sedang','Tinggi','Sangat Tinggi') NOT NULL
) ENGINE=InnoDB;

-- UNIQUE mencegah penyakit yang sama tersimpan dua kali untuk satu data monitoring.
CREATE TABLE IF NOT EXISTS tbl_hasil_deteksi (
    id_deteksi             INT AUTO_INCREMENT PRIMARY KEY,
    id_kandang             INT NOT NULL,
    id_monitoring          INT NOT NULL,
    id_penyakit            INT NOT NULL,
    persentase_kemungkinan DECIMAL(5,2) NOT NULL,
    tanggal_deteksi        DATETIME NOT NULL,
    status_penanganan      ENUM('Belum Ditangani','Dalam Penanganan','Selesai') NOT NULL DEFAULT 'Belum Ditangani',
    UNIQUE KEY uq_monitoring_penyakit (id_monitoring, id_penyakit),
    CONSTRAINT fk_deteksi_kandang FOREIGN KEY (id_kandang)
        REFERENCES tbl_kandang (id_kandang) ON DELETE RESTRICT ON UPDATE CASCADE,
    CONSTRAINT fk_deteksi_monitoring FOREIGN KEY (id_monitoring)
        REFERENCES tbl_monitoring (id_monitoring) ON DELETE RESTRICT ON UPDATE CASCADE,
    CONSTRAINT fk_deteksi_penyakit FOREIGN KEY (id_penyakit)
        REFERENCES tbl_penyakit (id_penyakit) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;

-- INSERT IGNORE: aman jika script ini dijalankan lebih dari sekali.
-- Nama penyakit harus sama persis dengan konstanta di Services/RuleEngine.cs.
INSERT IGNORE INTO tbl_penyakit (nama_penyakit, deskripsi, gejala, penanganan, tingkat_bahaya) VALUES
('Newcastle Disease',
 'Penyakit virus (tetelo) yang sangat menular dan menyerang saluran pernapasan, pencernaan, serta saraf.',
 'Sesak napas, ngorok, diare kehijauan, leher terpuntir (tortikolis), kelumpuhan, kematian mendadak.',
 'Belum ada obat khusus untuk virusnya. Pisahkan ayam sakit, perketat biosekuriti, berikan vitamin dan elektrolit, lakukan vaksinasi ND sesuai program, dan hubungi dokter hewan.',
 'Sangat Tinggi'),
('Chronic Respiratory Disease (CRD)',
 'Penyakit pernapasan kronis akibat Mycoplasma gallisepticum, sering dipicu stres, udara dingin, dan amonia tinggi.',
 'Ngorok, bersin, keluar lendir dari hidung, mata berair, nafsu makan turun, pertumbuhan lambat.',
 'Perbaiki ventilasi dan kurangi amonia, jaga litter tetap kering, stabilkan suhu kandang, dan gunakan antibiotik sesuai anjuran dokter hewan.',
 'Sedang'),
('Gumboro (IBD)',
 'Penyakit virus yang merusak bursa Fabricius sehingga menurunkan kekebalan tubuh ayam muda.',
 'Lesu, bulu kusam dan berdiri, diare putih encer, ayam duduk bergerombol, berat badan turun.',
 'Belum ada obat khusus untuk virusnya. Berikan air gula atau elektrolit dan vitamin, jaga kebersihan kandang, serta lakukan vaksinasi Gumboro sesuai program.',
 'Tinggi'),
('Coccidiosis',
 'Penyakit parasit Eimeria pada usus yang berkembang cepat pada litter lembap.',
 'Kotoran berdarah, ayam pucat dan lesu, bulu kusam, nafsu makan turun, berat badan turun.',
 'Berikan koksidiostat sesuai anjuran dokter hewan, ganti litter yang basah, perbaiki tempat minum yang bocor, dan tambahkan vitamin A serta K.',
 'Sedang'),
('Avian Influenza (ringan)',
 'Flu burung, penyakit virus yang dapat menular ke manusia sehingga kasus terduga wajib ditangani secara serius.',
 'Demam, jengger dan pial kebiruan, bengkak pada kepala, napas berat, produksi turun, kematian meningkat.',
 'Segera isolasi kandang, gunakan alat pelindung diri, batasi lalu lintas orang dan ayam, lakukan disinfeksi, dan laporkan ke dokter hewan atau dinas peternakan setempat.',
 'Sangat Tinggi');

-- ---------------------------------------------------------------------
-- ORANG 4: Rekomendasi suhu
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS tbl_rekomendasi_suhu (
    id_rekomendasi       INT AUTO_INCREMENT PRIMARY KEY,
    umur_hari_min        INT NOT NULL UNIQUE,
    umur_hari_max        INT NOT NULL,
    suhu_ideal_min       DECIMAL(4,1) NOT NULL,
    suhu_ideal_max       DECIMAL(4,1) NOT NULL,
    kelembaban_ideal_min DECIMAL(4,1) NOT NULL,
    kelembaban_ideal_max DECIMAL(4,1) NOT NULL,
    keterangan           VARCHAR(150) NOT NULL
) ENGINE=InnoDB;

-- umur_hari_max = 9999 mewakili "29 hari ke atas".
INSERT IGNORE INTO tbl_rekomendasi_suhu
    (umur_hari_min, umur_hari_max, suhu_ideal_min, suhu_ideal_max, kelembaban_ideal_min, kelembaban_ideal_max, keterangan) VALUES
(1,  7,    33, 35, 60, 70, 'Fase brooding minggu pertama'),
(8,  14,   30, 32, 60, 70, 'Fase brooding minggu kedua'),
(15, 21,   27, 29, 55, 65, 'Fase grower awal'),
(22, 28,   24, 26, 50, 65, 'Fase grower akhir'),
(29, 9999, 21, 23, 50, 60, 'Fase finisher');
