using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SeAdminSiswa.Siswa.Columns
{
    [ColumnsScript("Siswa.Kelassiswa")]
    [BasedOnRow(typeof(KelassiswaRow), CheckNames = true)]
    public class KelassiswaColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Hidden]
        public int Id { get; set; }
        [EditLink, Width(25)]
        public int SiswaId { get; set; }
        [EditLink, Width(100)]
        public int SiswaNis { get; set; }
        [EditLink]
        public string SiswaNama { get; set; }
        [JenisKelaminFormatter, Width(150)]
        public int SiswaJenisKelamin { get; set; }
        public string SiswaAlamat { get; set; }
        public DateTime SiswaTanggalLahir { get; set; }
    }
}