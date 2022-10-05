using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SeAdminSiswa.Siswa.Forms
{
    [FormScript("Siswa.Kelassiswa")]
    [BasedOnRow(typeof(KelassiswaRow), CheckNames = true)]
    public class KelassiswaForm
    {
        public int SiswaId { get; set; }
        public int KelasId { get; set; }
    }
}