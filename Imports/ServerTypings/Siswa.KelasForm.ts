namespace SeAdminSiswa.Siswa {
    export interface KelasForm {
        NamaKelas: Serenity.StringEditor;
        Tingkat: Serenity.IntegerEditor;
        IdJurusan: Serenity.LookupEditor;
        SiswaDetailList: SiswaDetailEditor;
    }

    export class KelasForm extends Serenity.PrefixedContext {
        static formKey = 'Siswa.Kelas';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!KelasForm.init)  {
                KelasForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.LookupEditor;
                var w3 = SiswaDetailEditor;

                Q.initFormType(KelasForm, [
                    'NamaKelas', w0,
                    'Tingkat', w1,
                    'IdJurusan', w2,
                    'SiswaDetailList', w3
                ]);
            }
        }
    }
}
