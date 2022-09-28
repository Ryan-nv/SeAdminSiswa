using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SeAdminSiswa.Siswa.Columns
{
    [ColumnsScript("Siswa.Siswa")]
    [BasedOnRow(typeof(SiswaRow), CheckNames = true)]
    public class SiswaColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Width(15)]
        public int Id { get; set; }
        [EditLink, Width(100)] public string Nis { get; set; }
        [EditLink, Width(600)] public string Nama { get; set; }
        [Width(160)]public DateTime TanggalLahir { get; set; }
        [Width(160), JenisKelaminFormatter ,QuickFilter]public JenKel JenisKelamin { get; set; }
        [ Width(160), QuickFilter]public string NamaKota { get; set; }
        [Width(300)]public string Alamat { get; set; }
    }
}