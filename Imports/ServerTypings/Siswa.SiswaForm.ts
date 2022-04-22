namespace SeAdminSiswa.Siswa {
    export interface SiswaForm {
        Nis: Serenity.StringEditor;
        Nama: Serenity.StringEditor;
        TanggalLahir: Serenity.DateEditor;
        JenisKelamin: Serenity.EnumEditor;
        KotaId: Serenity.LookupEditor;
        Alamat: Serenity.StringEditor;
    }

    export class SiswaForm extends Serenity.PrefixedContext {
        static formKey = 'Siswa.Siswa';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SiswaForm.init)  {
                SiswaForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.EnumEditor;
                var w3 = s.LookupEditor;

                Q.initFormType(SiswaForm, [
                    'Nis', w0,
                    'Nama', w0,
                    'TanggalLahir', w1,
                    'JenisKelamin', w2,
                    'KotaId', w3,
                    'Alamat', w0
                ]);
            }
        }
    }
}
