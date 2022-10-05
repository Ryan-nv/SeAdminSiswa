namespace SeAdminSiswa.Siswa {
    export interface JurusanForm {
        NamaJurusan: Serenity.StringEditor;
    }

    export class JurusanForm extends Serenity.PrefixedContext {
        static formKey = 'Siswa.Jurusan';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!JurusanForm.init)  {
                JurusanForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(JurusanForm, [
                    'NamaJurusan', w0
                ]);
            }
        }
    }
}
