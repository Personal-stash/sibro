using System;
using System.Collections.Generic;
using System.Data;
using SIBRO.Models;

namespace SIBRO.Data
{
    /// <summary>Operasi database untuk tbl_penyakit dan tbl_hasil_deteksi.</summary>
    public class PenyakitRepository : BaseRepository
    {
        private const string SELECT_DETEKSI =
            "SELECT d.*, k.nama_kandang, p.nama_penyakit, p.tingkat_bahaya FROM tbl_hasil_deteksi d " +
            "INNER JOIN tbl_kandang k ON k.id_kandang = d.id_kandang " +
            "INNER JOIN tbl_penyakit p ON p.id_penyakit = d.id_penyakit ";

        private Penyakit MapPenyakit(IDataRecord r)
        {
            return new Penyakit
            {
                IdPenyakit = Convert.ToInt32(r["id_penyakit"]),
                NamaPenyakit = Convert.ToString(r["nama_penyakit"]),
                Deskripsi = Convert.ToString(r["deskripsi"]),
                Gejala = Convert.ToString(r["gejala"]),
                Penanganan = Convert.ToString(r["penanganan"]),
                TingkatBahaya = Convert.ToString(r["tingkat_bahaya"])
            };
        }

        private HasilDeteksi MapDeteksi(IDataRecord r)
        {
            return new HasilDeteksi
            {
                IdDeteksi = Convert.ToInt32(r["id_deteksi"]),
                IdKandang = Convert.ToInt32(r["id_kandang"]),
                IdMonitoring = Convert.ToInt32(r["id_monitoring"]),
                IdPenyakit = Convert.ToInt32(r["id_penyakit"]),
                PersentaseKemungkinan = Convert.ToDouble(r["persentase_kemungkinan"]),
                TanggalDeteksi = Convert.ToDateTime(r["tanggal_deteksi"]),
                StatusPenanganan = Convert.ToString(r["status_penanganan"]),
                NamaKandang = Convert.ToString(r["nama_kandang"]),
                NamaPenyakit = Convert.ToString(r["nama_penyakit"]),
                TingkatBahaya = Convert.ToString(r["tingkat_bahaya"])
            };
        }

        public List<Penyakit> GetAllPenyakit()
        {
            return AmbilBanyak("SELECT * FROM tbl_penyakit ORDER BY nama_penyakit", MapPenyakit);
        }

        public Penyakit GetPenyakitByNama(string nama)
        {
            return AmbilSatu("SELECT * FROM tbl_penyakit WHERE nama_penyakit = @nama", MapPenyakit, P("@nama", nama));
        }

        /// <summary>Menyimpan hasil. Jika sudah pernah disimpan, persentasenya diperbarui (tidak dobel).</summary>
        public bool SaveHasilDeteksi(HasilDeteksi h)
        {
            return Jalankan(
                "INSERT INTO tbl_hasil_deteksi (id_kandang, id_monitoring, id_penyakit, persentase_kemungkinan, tanggal_deteksi, status_penanganan) " +
                "VALUES (@kandang, @monitoring, @penyakit, @persen, @tanggal, @status) " +
                "ON DUPLICATE KEY UPDATE persentase_kemungkinan = VALUES(persentase_kemungkinan), tanggal_deteksi = VALUES(tanggal_deteksi)",
                P("@kandang", h.IdKandang), P("@monitoring", h.IdMonitoring), P("@penyakit", h.IdPenyakit),
                P("@persen", h.PersentaseKemungkinan), P("@tanggal", h.TanggalDeteksi), P("@status", h.StatusPenanganan)) > 0;
        }

        public List<HasilDeteksi> GetRiwayatDeteksi(int idKandang)
        {
            return AmbilBanyak(SELECT_DETEKSI + "WHERE d.id_kandang = @id ORDER BY d.tanggal_deteksi DESC", MapDeteksi, P("@id", idKandang));
        }

        /// <summary>Filter riwayat. idKandang = 0 berarti semua kandang.</summary>
        public List<HasilDeteksi> GetRiwayatDeteksiFilter(int idKandang, DateTime dari, DateTime sampai)
        {
            // Batas atas memakai "< hari berikutnya" karena tanggal_deteksi menyimpan jam.
            return AmbilBanyak(
                SELECT_DETEKSI + "WHERE (@id = 0 OR d.id_kandang = @id) AND d.tanggal_deteksi >= @dari AND d.tanggal_deteksi < @sampai " +
                "ORDER BY d.tanggal_deteksi DESC",
                MapDeteksi, P("@id", idKandang), P("@dari", dari.Date), P("@sampai", sampai.Date.AddDays(1)));
        }

        public bool UpdateStatusPenanganan(int idDeteksi, string status)
        {
            return Jalankan("UPDATE tbl_hasil_deteksi SET status_penanganan = @status WHERE id_deteksi = @id",
                P("@status", status), P("@id", idDeteksi)) > 0;
        }
    }
}
