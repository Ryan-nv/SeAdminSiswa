namespace SeAdminSiswa.Siswa {
    export interface JurusanRow {
        Id?: number;
        NamaJurusan?: string;
    }

    export namespace JurusanRow {
        export const idProperty = 'Id';
        export const nameProperty = 'NamaJurusan';
        export const localTextPrefix = 'Siswa.Jurusan';
        export const lookupKey = 'Siswa.Jurusan';

        export function getLookup(): Q.Lookup<JurusanRow> {
            return Q.getLookup<JurusanRow>('Siswa.Jurusan');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            NamaJurusan = "NamaJurusan"
        }
    }
}
