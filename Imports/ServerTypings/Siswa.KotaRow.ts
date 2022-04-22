namespace SeAdminSiswa.Siswa {
    export interface KotaRow {
        IdKota?: number;
        NamaKota?: string;
    }

    export namespace KotaRow {
        export const idProperty = 'IdKota';
        export const nameProperty = 'NamaKota';
        export const localTextPrefix = 'Siswa.Kota';
        export const lookupKey = 'Siswa.Kota';

        export function getLookup(): Q.Lookup<KotaRow> {
            return Q.getLookup<KotaRow>('Siswa.Kota');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            IdKota = "IdKota",
            NamaKota = "NamaKota"
        }
    }
}
