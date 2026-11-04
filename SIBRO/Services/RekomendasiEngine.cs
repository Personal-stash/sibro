using System;
using System.Data;
using System.Text;
using SIBRO.Data;
using SIBRO.Models;

namespace SIBRO.Services
{
    /// <summary>Menentukan suhu dan kelembaban ideal menurut umur ayam.</summary>
    public class RekomendasiEngine : BaseRepository
    {
        private RekomendasiSuhu MapRekomendasi(IDataRecord r)
        {
            return new RekomendasiSuhu
            {
                IdRekomendasi = Convert.ToInt32(r["id_rekomendasi"]),
                UmurHariMin = Convert.ToInt32(r["umur_hari_min"]),
                UmurHariMax = Convert.ToInt32(r["umur_hari_max"]),
                SuhuIdealMin = Convert.ToDouble(r["suhu_ideal_min"]),
                SuhuIdealMax = Convert.ToDouble(r["suhu_ideal_max"]),
                KelembabanIdealMin = Convert.ToDouble(r["kelembaban_ideal_min"]),
                KelembabanIdealMax = Convert.ToDouble(r["kelembaban_ideal_max"]),
                Keterangan = Convert.ToString(r["keterangan"])
            };
        }

        public RekomendasiSuhu GetRekomendasiByUmur(int umurHari)
        {
            // DOC yang baru tiba bisa berumur 0 hari, dan mengikuti aturan umur 1-7 hari.
            int umur = Math.Max(1, umurHari);
            return AmbilSatu(
                "SELECT * FROM tbl_rekomendasi_suhu WHERE @umur BETWEEN umur_hari_min AND umur_hari_max",
                MapRekomendasi, P("@umur", umur));
        }

        /// <summary>Positif = di atas batas ideal, negatif = di bawah batas ideal, 0 = sudah ideal.</summary>
        public double HitungSelisihSuhu(double suhuAktual, RekomendasiSuhu rek)
        {
            if (suhuAktual > rek.SuhuIdealMax) return suhuAktual - rek.SuhuIdealMax;
            if (suhuAktual < rek.SuhuIdealMin) return suhuAktual - rek.SuhuIdealMin;
            return 0;
        }

        /// <summary>Indikator 0-100: 100 berarti ideal, berkurang 10 untuk setiap 1 °C penyimpangan.</summary>
        public int HitungIndikatorSuhu(double suhuAktual, RekomendasiSuhu rek)
        {
            double nilai = 100 - Math.Abs(HitungSelisihSuhu(suhuAktual, rek)) * 10;
            return (int)Math.Round(Math.Max(0, nilai));
        }

        public string GeneratePesanRekomendasi(double suhuAktual, double kelembaban, int umurHari)
        {
            RekomendasiSuhu rek = GetRekomendasiByUmur(umurHari);
            if (rek == null) return "Data rekomendasi untuk umur " + umurHari + " hari tidak ditemukan.";
            return BuatPesan(suhuAktual, kelembaban, umurHari, rek);
        }

        /// <summary>Menyusun pesan dari data rekomendasi yang sudah ada, tanpa akses database.</summary>
        public string BuatPesan(double suhuAktual, double kelembaban, int umurHari, RekomendasiSuhu rek)
        {
            StringBuilder pesan = new StringBuilder();
            pesan.AppendFormat("Umur ayam {0} hari ({1}).", umurHari, rek.Keterangan).AppendLine().AppendLine();

            double selisih = HitungSelisihSuhu(suhuAktual, rek);
            if (selisih > 0)
            {
                pesan.AppendFormat("Suhu terlalu tinggi {0:0.#}°C dari ideal, turunkan ke {1:0.#}-{2:0.#}°C. Buka ventilasi atau nyalakan kipas.",
                    selisih, rek.SuhuIdealMin, rek.SuhuIdealMax);
            }
            else if (selisih < 0)
            {
                pesan.AppendFormat("Suhu terlalu rendah {0:0.#}°C dari ideal, naikkan ke {1:0.#}-{2:0.#}°C. Periksa pemanas dan tutup tirai kandang.",
                    -selisih, rek.SuhuIdealMin, rek.SuhuIdealMax);
            }
            else
            {
                pesan.AppendFormat("Suhu {0:0.#}°C sudah sesuai rentang ideal {1:0.#}-{2:0.#}°C.",
                    suhuAktual, rek.SuhuIdealMin, rek.SuhuIdealMax);
            }
            pesan.AppendLine();

            if (kelembaban > rek.KelembabanIdealMax)
            {
                pesan.AppendFormat("Kelembaban terlalu tinggi {0:0.#}% dari ideal, turunkan ke {1:0.#}-{2:0.#}%. Perbaiki ventilasi dan ganti litter basah.",
                    kelembaban - rek.KelembabanIdealMax, rek.KelembabanIdealMin, rek.KelembabanIdealMax);
            }
            else if (kelembaban < rek.KelembabanIdealMin)
            {
                pesan.AppendFormat("Kelembaban terlalu rendah {0:0.#}% dari ideal, naikkan ke {1:0.#}-{2:0.#}%.",
                    rek.KelembabanIdealMin - kelembaban, rek.KelembabanIdealMin, rek.KelembabanIdealMax);
            }
            else
            {
                pesan.AppendFormat("Kelembaban {0:0.#}% sudah sesuai rentang ideal {1:0.#}-{2:0.#}%.",
                    kelembaban, rek.KelembabanIdealMin, rek.KelembabanIdealMax);
            }
            return pesan.ToString();
        }
    }
}
