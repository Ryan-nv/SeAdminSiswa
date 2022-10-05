namespace SeAdminSiswa.Siswa {
    export interface KelassiswaForm {
        SiswaId: Serenity.LookupEditor;
        KelasId: Serenity.IntegerEditor;
    }

    export class KelassiswaForm extends Serenity.PrefixedContext {
        static formKey = 'Siswa.Kelassiswa';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!KelassiswaForm.init)  {
                KelassiswaForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(KelassiswaForm, [
                    'SiswaId', w0,
                    'KelasId', w1
                ]);
            }
        }
    }
}
