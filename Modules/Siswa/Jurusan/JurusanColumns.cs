using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SeAdminSiswa.Siswa.Columns
{
    [ColumnsScript("Siswa.Jurusan")]
    [BasedOnRow(typeof(JurusanRow), CheckNames = true)]
    public class JurusanColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string NamaJurusan { get; set; }
    }
}