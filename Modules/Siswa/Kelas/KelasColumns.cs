using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SeAdminSiswa.Siswa.Columns
{
    [ColumnsScript("Siswa.Kelas")]
    [BasedOnRow(typeof(KelasRow), CheckNames = true)]
    public class KelasColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string NamaKelas { get; set; }
        public int Tingkat { get; set; }
        public String IdJurusanNamaJurusan { get; set; }
    }
}