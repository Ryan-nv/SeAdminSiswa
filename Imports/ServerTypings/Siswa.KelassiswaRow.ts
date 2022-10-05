namespace SeAdminSiswa.Siswa {
    export interface KelassiswaRow {
        Id?: number;
        SiswaId?: number;
        KelasId?: number;
        SiswaNis?: string;
        SiswaNama?: string;
        SiswaTanggalLahir?: string;
        SiswaJenisKelamin?: number;
        SiswaKotaId?: number;
        SiswaAlamat?: string;
        KelasNamaKelas?: string;
        KelasTingkat?: number;
        KelasIdJurusan?: number;
    }

    export namespace KelassiswaRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'Siswa.Kelassiswa';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            SiswaId = "SiswaId",
            KelasId = "KelasId",
            SiswaNis = "SiswaNis",
            SiswaNama = "SiswaNama",
            SiswaTanggalLahir = "SiswaTanggalLahir",
            SiswaJenisKelamin = "SiswaJenisKelamin",
            SiswaKotaId = "SiswaKotaId",
            SiswaAlamat = "SiswaAlamat",
            KelasNamaKelas = "KelasNamaKelas",
            KelasTingkat = "KelasTingkat",
            KelasIdJurusan = "KelasIdJurusan"
        }
    }
}
