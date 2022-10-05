namespace SeAdminSiswa.Siswa {
    export interface KelasRow {
        Id?: number;
        NamaKelas?: string;
        Tingkat?: number;
        IdJurusan?: number;
        IdJurusanNamaJurusan?: string;
        SiswaDetailList?: KelassiswaRow[];
    }

    export namespace KelasRow {
        export const idProperty = 'Id';
        export const nameProperty = 'NamaKelas';
        export const localTextPrefix = 'Siswa.Kelas';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            NamaKelas = "NamaKelas",
            Tingkat = "Tingkat",
            IdJurusan = "IdJurusan",
            IdJurusanNamaJurusan = "IdJurusanNamaJurusan",
            SiswaDetailList = "SiswaDetailList"
        }
    }
}
