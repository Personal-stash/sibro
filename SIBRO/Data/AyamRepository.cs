using System;
using System.Collections.Generic;
using System.Data;
using SIBRO.Models;

namespace SIBRO.Data
{
    /// <summary>Operasi database untuk tbl_ayam.</summary>
    public class AyamRepository : BaseRepository
    {
        private const string SELECT_AYAM =
            "SELECT a.*, k.nama_kandang FROM tbl_ayam a " +
            "INNER JOIN tbl_kandang k ON k.id_kandang = a.id_kandang ";

        private Ayam MapAyam(IDataRecord r)
        {
            return new Ayam
            {
                IdAyam = Convert.ToInt32(r["id_ayam"]),
                IdKandang = Convert.ToInt32(r["id_kandang"]),
                JumlahAyam = Convert.ToInt32(r["jumlah_ayam"]),
                UmurHari = Convert.ToInt32(r["umur_hari"]),
                JenisAyam = Convert.ToString(r["jenis_ayam"]),
                TanggalMasuk = Convert.ToDateTime(r["tanggal_masuk"]),
                NamaKandang = Convert.ToString(r["nama_kandang"])
            };
        }

        public List<Ayam> GetAllAyam()
        {
            return AmbilBanyak(SELECT_AYAM + "ORDER BY a.tanggal_masuk DESC, a.id_ayam DESC", MapAyam);
        }

        public List<Ayam> GetAyamByKandang(int idKandang)
        {
            return AmbilBanyak(SELECT_AYAM + "WHERE a.id_kandang = @id ORDER BY a.tanggal_masuk DESC, a.id_ayam DESC",
                MapAyam, P("@id", idKandang));
        }

        /// <summary>Kelompok ayam paling baru di kandang, dipakai untuk menentukan umur. Null jika kosong.</summary>
        public Ayam GetAyamTerbaruByKandang(int idKandang)
        {
            return AmbilSatu(SELECT_AYAM + "WHERE a.id_kandang = @id ORDER BY a.tanggal_masuk DESC, a.id_ayam DESC LIMIT 1",
                MapAyam, P("@id", idKandang));
        }

        /// <summary>Total ayam dalam kandang, tanpa menghitung satu data tertentu (dipakai saat edit).</summary>
        public int GetTotalAyamByKandang(int idKandang, int kecualiIdAyam)
        {
            return KeInt(AmbilNilai(
                "SELECT COALESCE(SUM(jumlah_ayam), 0) FROM tbl_ayam WHERE id_kandang = @id AND id_ayam <> @kecuali",
                P("@id", idKandang), P("@kecuali", kecualiIdAyam)));
        }

        public bool InsertAyam(Ayam a)
        {
            return Jalankan(
                "INSERT INTO tbl_ayam (id_kandang, jumlah_ayam, umur_hari, jenis_ayam, tanggal_masuk) " +
                "VALUES (@kandang, @jumlah, @umur, @jenis, @tanggal)",
                P("@kandang", a.IdKandang), P("@jumlah", a.JumlahAyam), P("@umur", a.UmurHari),
                P("@jenis", a.JenisAyam), P("@tanggal", a.TanggalMasuk.Date)) > 0;
        }

        public bool UpdateAyam(Ayam a)
        {
            return Jalankan(
                "UPDATE tbl_ayam SET id_kandang = @kandang, jumlah_ayam = @jumlah, umur_hari = @umur, " +
                "jenis_ayam = @jenis, tanggal_masuk = @tanggal WHERE id_ayam = @id",
                P("@kandang", a.IdKandang), P("@jumlah", a.JumlahAyam), P("@umur", a.UmurHari),
                P("@jenis", a.JenisAyam), P("@tanggal", a.TanggalMasuk.Date), P("@id", a.IdAyam)) > 0;
        }

        public bool DeleteAyam(int id)
        {
            return Jalankan("DELETE FROM tbl_ayam WHERE id_ayam = @id", P("@id", id)) > 0;
        }
    }
}
