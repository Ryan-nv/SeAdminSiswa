namespace SeAdminSiswa.Siswa {
    export interface SiswaRow {
        Id?: number;
        Nis?: string;
        Nama?: string;
        TanggalLahir?: string;
        JenisKelamin?: JenKel;
        KotaId?: number;
        Alamat?: string;
        NamaKota?: string;
    }

    export namespace SiswaRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nama';
        export const localTextPrefix = 'Siswa.Siswa';
        export const lookupKey = 'Siswa.Siswa';

        export function getLookup(): Q.Lookup<SiswaRow> {
            return Q.getLookup<SiswaRow>('Siswa.Siswa');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Nis = "Nis",
            Nama = "Nama",
            TanggalLahir = "TanggalLahir",
            JenisKelamin = "JenisKelamin",
            KotaId = "KotaId",
            Alamat = "Alamat",
            NamaKota = "NamaKota"
        }
    }
}
