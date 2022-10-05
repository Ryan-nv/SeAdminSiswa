using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace SeAdminSiswa.Siswa
{
    [ConnectionKey("Siswa"), Module("Siswa"), TableName("kelas")]
    [DisplayName("Kelas"), InstanceName("Kelas")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class KelasRow : Row<KelasRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Nama Kelas"), Size(100), NotNull, QuickSearch, NameProperty]
        public string NamaKelas
        {
            get => fields.NamaKelas[this];
            set => fields.NamaKelas[this] = value;
        }

        [DisplayName("Tingkat")]
        public int? Tingkat
        {
            get => fields.Tingkat[this];
            set => fields.Tingkat[this] = value;
        }

        [DisplayName("Id Jurusan"), ForeignKey("jurusan", "Id"), LeftJoin("jIdJurusan"), TextualField("IdJurusanNamaJurusan")]
        [LookupEditor(typeof(JurusanRow), InplaceAdd = true)]
        public int? IdJurusan
        {
            get => fields.IdJurusan[this];
            set => fields.IdJurusan[this] = value;
        }

        [DisplayName("Jurusan"), Expression("jIdJurusan.[NamaJurusan]")]
        public string IdJurusanNamaJurusan
        {
            get => fields.IdJurusanNamaJurusan[this];
            set => fields.IdJurusanNamaJurusan[this] = value;
        }
        [MasterDetailRelation(foreignKey: "KelasId", IncludeColumns = "SiswaNama, SiswaNis, SiswaAlamat, SiswaJenisKelamin, SiswaTanggalLahir")]
        [DisplayName("List Siswa"), NotMapped]
        public List<KelassiswaRow> SiswaDetailList 
        {
            get => fields.SiswaDetailList[this];
            set => fields.SiswaDetailList[this] = value;
        }

        public KelasRow()
            : base()
        {
        }

        public KelasRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase //TODO ADD NEW ROWLIST FIELD
        {
            public Int32Field Id;
            public StringField NamaKelas;
            public Int32Field Tingkat;
            public Int32Field IdJurusan;
            public StringField IdJurusanNamaJurusan;
            public RowListField<KelassiswaRow> SiswaDetailList;
        }
    }
}
