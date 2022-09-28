using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SeAdminSiswa.Siswa
{
    public partial class JenisKelaminFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "SeAdminSiswa.Siswa.JenisKelaminFormatter";

        public JenisKelaminFormatterAttribute()
            : base(Key)
        {
        }
    }
}
