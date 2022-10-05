using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SeAdminSiswa.Siswa.Forms
{
    [FormScript("Siswa.Kelas")]
    [BasedOnRow(typeof(KelasRow), CheckNames = false)]
    public class KelasForm
    {
        [ThreeQuarterWidth]
        public string NamaKelas { get; set; }
        [QuarterWidth]
        public int Tingkat { get; set; }
        public int IdJurusan { get; set; }
        [SiswaDetailEditor]
        public List<KelassiswaRow> SiswaDetailList { get; set; }
    }
}