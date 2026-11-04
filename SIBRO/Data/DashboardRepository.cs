using System.Data;

namespace SIBRO.Data
{
    /// <summary>Query ringkasan untuk kartu statistik dan grafik di dashboard.</summary>
    public class DashboardRepository : BaseRepository
    {
        public int GetTotalKandangAktif()
        {
            return KeInt(AmbilNilai("SELECT COUNT(*) FROM tbl_kandang WHERE status = 'Aktif'"));
        }

        public int GetTotalAyamTerpantau()
        {
            return KeInt(AmbilNilai(
                "SELECT COALESCE(SUM(a.jumlah_ayam), 0) FROM tbl_ayam a " +
                "INNER JOIN tbl_kandang k ON k.id_kandang = a.id_kandang WHERE k.status = 'Aktif'"));
        }

        public int GetKandangKritisHariIni()
        {
            return KeInt(AmbilNilai(
                "SELECT COUNT(DISTINCT id_kandang) FROM tbl_monitoring " +
                "WHERE tanggal_input = CURDATE() AND kondisi_umum = 'Kritis'"));
        }

        public int GetDeteksiBulanIni()
        {
            return KeInt(AmbilNilai(
                "SELECT COUNT(*) FROM tbl_hasil_deteksi " +
                "WHERE YEAR(tanggal_deteksi) = YEAR(CURDATE()) AND MONTH(tanggal_deteksi) = MONTH(CURDATE())"));
        }

        /// <summary>Rata-rata suhu harian per kandang selama 7 hari terakhir.</summary>
        public DataTable GetTrenSuhu7Hari()
        {
            return AmbilTabel(
                "SELECT k.nama_kandang, m.tanggal_input, AVG(m.suhu) AS rata_suhu FROM tbl_monitoring m " +
                "INNER JOIN tbl_kandang k ON k.id_kandang = m.id_kandang " +
                "WHERE m.tanggal_input BETWEEN CURDATE() - INTERVAL 6 DAY AND CURDATE() " +
                "GROUP BY k.nama_kandang, m.tanggal_input ORDER BY k.nama_kandang, m.tanggal_input");
        }

        /// <summary>Jumlah kandang per kondisi, memakai data monitoring terbaru tiap kandang.</summary>
        public DataTable GetPerbandinganKondisi()
        {
            return AmbilTabel(
                "SELECT m.kondisi_umum, COUNT(*) AS jumlah FROM tbl_monitoring m " +
                "WHERE m.id_monitoring = (SELECT m2.id_monitoring FROM tbl_monitoring m2 " +
                "    WHERE m2.id_kandang = m.id_kandang " +
                "    ORDER BY m2.tanggal_input DESC, m2.waktu_input DESC, m2.id_monitoring DESC LIMIT 1) " +
                "GROUP BY m.kondisi_umum");
        }
    }
}
