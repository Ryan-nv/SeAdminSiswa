namespace SeAdminSiswa.Siswa {
    export interface KotaForm {
        NamaKota: Serenity.StringEditor;
    }

    export class KotaForm extends Serenity.PrefixedContext {
        static formKey = 'Siswa.Kota';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!KotaForm.init)  {
                KotaForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(KotaForm, [
                    'NamaKota', w0
                ]);
            }
        }
    }
}
