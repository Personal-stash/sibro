using System.Drawing;
using System.Windows.Forms;
using SIBRO.Models;

namespace SIBRO.Forms
{
    /// <summary>Fungsi bantu untuk DataGridView dan warna kondisi.</summary>
    public static class GridHelper
    {
        public static readonly Color WARNA_NORMAL = Color.FromArgb(198, 239, 206);
        public static readonly Color WARNA_KURANG_BAIK = Color.FromArgb(255, 235, 156);
        public static readonly Color WARNA_KRITIS = Color.FromArgb(255, 199, 206);

        /// <summary>
        /// Menampilkan data dan hanya memunculkan kolom yang disebut.
        /// Format tiap kolom: "NamaProperty|Judul Kolom" atau "NamaProperty|Judul Kolom|FormatTampilan".
        /// </summary>
        public static void Tampilkan(DataGridView grid, object data, params string[] kolom)
        {
            grid.DataSource = null;
            grid.DataSource = data;

            foreach (DataGridViewColumn c in grid.Columns)
            {
                c.Visible = false;
            }

            for (int i = 0; i < kolom.Length; i++)
            {
                string[] bagian = kolom[i].Split('|');
                DataGridViewColumn c = grid.Columns[bagian[0]];
                c.Visible = true;
                c.HeaderText = bagian[1];
                c.DisplayIndex = i;
                if (bagian.Length > 2) c.DefaultCellStyle.Format = bagian[2];
            }
        }

        public static Color WarnaKondisi(string kondisi)
        {
            if (kondisi == Monitoring.KONDISI_KRITIS) return WARNA_KRITIS;
            if (kondisi == Monitoring.KONDISI_KURANG_BAIK) return WARNA_KURANG_BAIK;
            return WARNA_NORMAL;
        }

        /// <summary>Dipanggil dari event CellFormatting: Hijau = Normal, Kuning = Kurang Baik, Merah = Kritis.</summary>
        public static void WarnaiBarisMonitoring(DataGridView grid, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count) return;
            Monitoring m = grid.Rows[e.RowIndex].DataBoundItem as Monitoring;
            if (m != null) e.CellStyle.BackColor = WarnaKondisi(m.KondisiUmum);
        }
    }
}
