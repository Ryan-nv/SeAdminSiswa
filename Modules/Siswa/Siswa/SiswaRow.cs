using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;

namespace SeAdminSiswa.Siswa
{
    [ConnectionKey("Siswa"), Module("Siswa"), TableName("siswa")]
    [DisplayName("Siswa"), InstanceName("Siswa")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class SiswaRow : Row<SiswaRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Nis"), Column("NIS"), Size(10), QuickSearch]
        public string Nis
        {
            get => fields.Nis[this];
            set => fields.Nis[this] = value;
        }

        [DisplayName("Nama"), Size(50), QuickSearch, NameProperty]
        public string Nama
        {
            get => fields.Nama[this];
            set => fields.Nama[this] = value;
        }

        [DisplayName("Tanggal Lahir"),DisplayFormat("dd-MM-yyyy")]
        public DateTime? TanggalLahir
        {
            get => fields.TanggalLahir[this];
            set => fields.TanggalLahir[this] = value;
        }

        [DisplayName("Jenis Kelamin")]
        public JenKel JenisKelamin
        {
            get => (JenKel)fields.JenisKelamin[this];
            set => fields.JenisKelamin[this] = (Int32)value;
        }

        [DisplayName("Kota"), ForeignKey("kota", "IdKota"), LeftJoin("jKota"), TextualField("NamaKota")]
        [LookupEditor(typeof(KotaRow), InplaceAdd = true)]
        public int? KotaId
        {
            get => fields.KotaId[this];
            set => fields.KotaId[this] = value;
        }

        [DisplayName("Alamat"), Size(100)]
        public string Alamat
        {
            get => fields.Alamat[this];
            set => fields.Alamat[this] = value;
        }

        [DisplayName("Kota"), Expression("jKota.[NamaKota]")]
        public string NamaKota
        {
            get => fields.NamaKota[this];
            set => fields.NamaKota[this] = value;
        }

        public SiswaRow()
            : base()
        {
        }

        public SiswaRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Nis;
            public StringField Nama;
            public DateTimeField TanggalLahir;
            public Int32Field JenisKelamin;
            public Int32Field KotaId;
            public StringField Alamat;

            public StringField NamaKota;
        }
    }
}
