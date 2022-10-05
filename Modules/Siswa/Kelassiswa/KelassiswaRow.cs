using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SeAdminSiswa.Siswa
{
    [ConnectionKey("Siswa"), Module("Siswa"), TableName("kelassiswa")]
    [DisplayName("Kelassiswa"), InstanceName("Kelassiswa")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class KelassiswaRow : Row<KelassiswaRow.RowFields>, IIdRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Id"), NotNull, ForeignKey("siswa", "Id"), LeftJoin("jSiswa"), TextualField("SiswaNis")]
        [LookupEditor(typeof(SiswaRow))]
        public int? SiswaId
        {
            get => fields.SiswaId[this];
            set => fields.SiswaId[this] = value;
        }

        [DisplayName("Kelas"), NotNull, ForeignKey("kelas", "Id"), LeftJoin("jKelas"), TextualField("KelasNamaKelas")]
        public int? KelasId
        {
            get => fields.KelasId[this];
            set => fields.KelasId[this] = value;
        }

        [DisplayName("Nis"), Expression("jSiswa.[NIS]")]
        public string SiswaNis
        {
            get => fields.SiswaNis[this];
            set => fields.SiswaNis[this] = value;
        }

        [DisplayName("Nama"), Expression("jSiswa.[Nama]")]
        public string SiswaNama
        {
            get => fields.SiswaNama[this];
            set => fields.SiswaNama[this] = value;
        }

        [DisplayName("Tanggal Lahir"), Expression("jSiswa.[TanggalLahir]")]
        public DateTime? SiswaTanggalLahir
        {
            get => fields.SiswaTanggalLahir[this];
            set => fields.SiswaTanggalLahir[this] = value;
        }

        [DisplayName("Jenis Kelamin"), Expression("jSiswa.[JenisKelamin]")]
        public int? SiswaJenisKelamin
        {
            get => fields.SiswaJenisKelamin[this];
            set => fields.SiswaJenisKelamin[this] = value;
        }

        [DisplayName("Kota Id"), Expression("jSiswa.[KotaId]")]
        public int? SiswaKotaId
        {
            get => fields.SiswaKotaId[this];
            set => fields.SiswaKotaId[this] = value;
        }

        [DisplayName("Alamat"), Expression("jSiswa.[Alamat]")]
        public string SiswaAlamat
        {
            get => fields.SiswaAlamat[this];
            set => fields.SiswaAlamat[this] = value;
        }

        [DisplayName("Kelas"), Expression("jKelas.[NamaKelas]")]
        public string KelasNamaKelas
        {
            get => fields.KelasNamaKelas[this];
            set => fields.KelasNamaKelas[this] = value;
        }

        [DisplayName("Tingkat"), Expression("jKelas.[Tingkat]")]
        public int? KelasTingkat
        {
            get => fields.KelasTingkat[this];
            set => fields.KelasTingkat[this] = value;
        }

        [DisplayName("Kelas Id Jurusan"), Expression("jKelas.[IdJurusan]")]
        public int? KelasIdJurusan
        {
            get => fields.KelasIdJurusan[this];
            set => fields.KelasIdJurusan[this] = value;
        }

        public KelassiswaRow()
            : base()
        {
        }

        public KelassiswaRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field SiswaId;
            public Int32Field KelasId;

            public StringField SiswaNis;
            public StringField SiswaNama;
            public DateTimeField SiswaTanggalLahir;
            public Int32Field SiswaJenisKelamin;
            public Int32Field SiswaKotaId;
            public StringField SiswaAlamat;

            public StringField KelasNamaKelas;
            public Int32Field KelasTingkat;
            public Int32Field KelasIdJurusan;
        }
    }
}
