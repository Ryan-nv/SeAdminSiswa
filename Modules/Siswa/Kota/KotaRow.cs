using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SeAdminSiswa.Siswa
{
    [ConnectionKey("Siswa"), Module("Siswa"), TableName("kota")]
    [DisplayName("Kota"), InstanceName("Kota")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Siswa.Kota")]
    public sealed class KotaRow : Row<KotaRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id Kota"), Identity, IdProperty]
        public int? IdKota
        {
            get => fields.IdKota[this];
            set => fields.IdKota[this] = value;
        }

        [DisplayName("Nama Kota"), Size(50), NotNull, QuickSearch, NameProperty]
        public string NamaKota
        {
            get => fields.NamaKota[this];
            set => fields.NamaKota[this] = value;
        }

        public KotaRow()
            : base()
        {
        }

        public KotaRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdKota;
            public StringField NamaKota;
        }
    }
}
