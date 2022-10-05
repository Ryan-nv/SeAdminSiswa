using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SeAdminSiswa.Siswa.Forms
{
    [FormScript("Siswa.Jurusan")]
    [BasedOnRow(typeof(JurusanRow), CheckNames = true)]
    public class JurusanForm
    {
        public string NamaJurusan { get; set; }
    }
}