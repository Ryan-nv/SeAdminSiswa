using Serenity.ComponentModel;
using System.ComponentModel; 


namespace SeAdminSiswa.Siswa 
{
    [EnumKey("Siswa.JenisKelamin")]
    public enum JenKel
    {
        [Description("Laki Laki")] LakiLaki = 1,
        [Description("Perempuan")] Perempuan = 2
    }
}