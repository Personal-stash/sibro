using System;

namespace SIBRO.Services
{
    /// <summary>
    /// Perkiraan berat normal broiler menurut umur, dipakai aturan Gumboro.
    /// Nilainya perkiraan umum; sesuaikan dengan panduan strain yang dipakai di kandang.
    /// </summary>
    public static class StandarBerat
    {
        private static readonly int[] UMUR = { 0, 7, 14, 21, 28, 35, 42 };
        private static readonly double[] BERAT = { 42, 185, 465, 900, 1450, 2050, 2650 };

        /// <summary>Berat normal (gram); di antara dua titik umur dihitung secara proporsional.</summary>
        public static double GetBeratNormal(int umurHari)
        {
            if (umurHari <= 0) return BERAT[0];
            if (umurHari >= UMUR[UMUR.Length - 1]) return BERAT[BERAT.Length - 1];

            int i = Array.FindIndex(UMUR, u => u >= umurHari);
            if (UMUR[i] == umurHari) return BERAT[i];

            double porsi = (double)(umurHari - UMUR[i - 1]) / (UMUR[i] - UMUR[i - 1]);
            return BERAT[i - 1] + porsi * (BERAT[i] - BERAT[i - 1]);
        }
    }
}
