using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SeAdminSiswa.Siswa.Columns
{
    [ColumnsScript("Siswa.Kota")]
    [BasedOnRow(typeof(KotaRow), CheckNames = true)]
    public class KotaColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int IdKota { get; set; }
        [EditLink]
        public string NamaKota { get; set; }
    }
}