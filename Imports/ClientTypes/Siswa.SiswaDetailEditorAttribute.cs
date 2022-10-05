using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SeAdminSiswa.Siswa
{
    public partial class SiswaDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SeAdminSiswa.Siswa.SiswaDetailEditor";

        public SiswaDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}
