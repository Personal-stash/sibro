using System.Collections.Generic;
using SIBRO.Models;

namespace SIBRO.Services
{
    /// <summary>
    /// Kontrak mesin deteksi. Form hanya mengenal interface ini, sehingga
    /// mesin lain bisa dipasang tanpa mengubah form (konsep polymorphism).
    /// </summary>
    public interface IDeteksi
    {
        List<HasilDeteksi> Analisis(Monitoring data);
        string GetRekomendasiPenanganan(string namaPenyakit);
    }
}
