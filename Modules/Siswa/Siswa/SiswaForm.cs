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
        public string Nis { get; set; }
        public string Nama { get; set; }
        public DateTime TanggalLahir { get; set; }
        public JenKel JenisKelamin { get; set; }
        public int KotaId { get; set; }
        public string Alamat { get; set; }
    }
}