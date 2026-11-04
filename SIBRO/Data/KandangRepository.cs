using System;
using System.Collections.Generic;
using System.Data;
using SIBRO.Models;

namespace SIBRO.Data
{
    /// <summary>Operasi database untuk tbl_kandang.</summary>
    public class KandangRepository : BaseRepository
    {
        private Kandang MapKandang(IDataRecord r)
        {
            return new Kandang
            {
                IdKandang = Convert.ToInt32(r["id_kandang"]),
                NamaKandang = Convert.ToString(r["nama_kandang"]),
                Kapasitas = Convert.ToInt32(r["kapasitas"]),
                Lokasi = Convert.ToString(r["lokasi"]),
                Status = Convert.ToString(r["status"]),
                CreatedAt = Convert.ToDateTime(r["created_at"])
            };
        }

        public List<Kandang> GetAllKandang()
        {
            return AmbilBanyak("SELECT * FROM tbl_kandang ORDER BY nama_kandang", MapKandang);
        }

        public Kandang GetKandangById(int id)
        {
            return AmbilSatu("SELECT * FROM tbl_kandang WHERE id_kandang = @id", MapKandang, P("@id", id));
        }

        public bool InsertKandang(Kandang k)
        {
            return Jalankan(
                "INSERT INTO tbl_kandang (nama_kandang, kapasitas, lokasi, status) VALUES (@nama, @kapasitas, @lokasi, @status)",
                P("@nama", k.NamaKandang), P("@kapasitas", k.Kapasitas), P("@lokasi", k.Lokasi), P("@status", k.Status)) > 0;
        }

        public bool UpdateKandang(Kandang k)
        {
            return Jalankan(
                "UPDATE tbl_kandang SET nama_kandang = @nama, kapasitas = @kapasitas, lokasi = @lokasi, status = @status WHERE id_kandang = @id",
                P("@nama", k.NamaKandang), P("@kapasitas", k.Kapasitas), P("@lokasi", k.Lokasi), P("@status", k.Status), P("@id", k.IdKandang)) > 0;
        }

        public bool DeleteKandang(int id)
        {
            return Jalankan("DELETE FROM tbl_kandang WHERE id_kandang = @id", P("@id", id)) > 0;
        }
    }
}
