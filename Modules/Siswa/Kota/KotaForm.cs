using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SeAdminSiswa.Siswa.Forms
{
    [FormScript("Siswa.Kota")]
    [BasedOnRow(typeof(KotaRow), CheckNames = true)]
    public class KotaForm
    {
        public string NamaKota { get; set; }
    }
}