using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SeAdminSiswa.Siswa.Forms
{
    [FormScript("Siswa.Siswa")]
    [BasedOnRow(typeof(SiswaRow), CheckNames = true)]
    public class SiswaForm
    {
        [QuarterWidth]
        public string Nis { get; set; }
        [ThreeQuarterWidth]
        public string Nama { get; set; }
        public DateTime TanggalLahir { get; set; }
        public JenKel JenisKelamin { get; set; }
        [HalfWidth]
        public int KotaId { get; set; }
        [HalfWidth]
        public string Alamat { get; set; }
    }
}