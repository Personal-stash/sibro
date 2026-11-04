-- OPSIONAL: data contoh untuk demo. Jalankan SETELAH sibro_db.sql, cukup sekali.
-- Tanggal dibuat relatif terhadap hari ini supaya grafik dashboard selalu terisi.
USE sibro_db;

INSERT INTO tbl_kandang (nama_kandang, kapasitas, lokasi, status) VALUES
('Kandang A', 5000, 'Blok Utara', 'Aktif'),
('Kandang B', 4000, 'Blok Selatan', 'Aktif'),
('Kandang C', 3000, 'Blok Timur', 'Nonaktif');

SET @a = (SELECT id_kandang FROM tbl_kandang WHERE nama_kandang = 'Kandang A' ORDER BY id_kandang DESC LIMIT 1);
SET @b = (SELECT id_kandang FROM tbl_kandang WHERE nama_kandang = 'Kandang B' ORDER BY id_kandang DESC LIMIT 1);

INSERT INTO tbl_ayam (id_kandang, jumlah_ayam, umur_hari, jenis_ayam, tanggal_masuk) VALUES
(@a, 4500, 1, 'Cobb 500', CURDATE() - INTERVAL 17 DAY),
(@b, 3500, 1, 'Ross 308', CURDATE() - INTERVAL 30 DAY);

INSERT INTO tbl_monitoring (id_kandang, suhu, kelembaban, berat_rata2, kondisi_umum, catatan, tanggal_input, waktu_input) VALUES
(@a, 28.5, 62, 560, 'Normal',      'Kondisi baik',            CURDATE() - INTERVAL 6 DAY, '07:30:00'),
(@a, 28.0, 60, 640, 'Normal',      NULL,                      CURDATE() - INTERVAL 5 DAY, '07:30:00'),
(@a, 28.8, 63, 700, 'Normal',      NULL,                      CURDATE() - INTERVAL 4 DAY, '07:30:00'),
(@a, 29.0, 66, 770, 'Normal',      'Tambah ventilasi',        CURDATE() - INTERVAL 3 DAY, '07:30:00'),
(@a, 29.5, 72, 820, 'Kurang Baik', 'Litter mulai lembap',     CURDATE() - INTERVAL 2 DAY, '07:30:00'),
(@a, 30.0, 82, 860, 'Kurang Baik', 'Sebagian ayam lesu',      CURDATE() - INTERVAL 1 DAY, '07:30:00'),
(@a, 30.5, 84, 880, 'Kurang Baik', 'Kotoran perlu diperiksa', CURDATE(),                  '07:30:00'),
(@b, 23.0, 58, 1500, 'Normal',     NULL,                      CURDATE() - INTERVAL 6 DAY, '08:00:00'),
(@b, 22.5, 57, 1590, 'Normal',     NULL,                      CURDATE() - INTERVAL 5 DAY, '08:00:00'),
(@b, 23.5, 60, 1670, 'Normal',     NULL,                      CURDATE() - INTERVAL 4 DAY, '08:00:00'),
(@b, 26.0, 70, 1720, 'Normal',     'Cuaca panas',             CURDATE() - INTERVAL 3 DAY, '08:00:00'),
(@b, 34.0, 78, 1750, 'Kurang Baik','Kipas rusak',             CURDATE() - INTERVAL 2 DAY, '08:00:00'),
(@b, 38.5, 83, 1760, 'Kurang Baik','Ayam terengah-engah',     CURDATE() - INTERVAL 1 DAY, '08:00:00'),
(@b, 40.5, 86, 1770, 'Kritis',     'Kematian meningkat',      CURDATE(),                  '08:00:00');
