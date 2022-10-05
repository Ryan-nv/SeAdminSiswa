using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SeAdminSiswa.Siswa
{
    [ConnectionKey("Siswa"), Module("Siswa"), TableName("jurusan")]
    [DisplayName("Jurusan"), InstanceName("Jurusan")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class JurusanRow : Row<JurusanRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Nama Jurusan"), Size(100), QuickSearch, NameProperty]
        public string NamaJurusan
        {
            get => fields.NamaJurusan[this];
            set => fields.NamaJurusan[this] = value;
        }

        public JurusanRow()
            : base()
        {
        }

        public JurusanRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField NamaJurusan;
        }
    }
}
