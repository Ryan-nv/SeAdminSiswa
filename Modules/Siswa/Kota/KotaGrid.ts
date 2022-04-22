
namespace SeAdminSiswa.Siswa {

    @Serenity.Decorators.registerClass()
    export class KotaGrid extends Serenity.EntityGrid<KotaRow, any> {
        protected getColumnsKey() { return KotaColumns.columnsKey; }
        protected getDialogType() { return KotaDialog; }
        protected getIdProperty() { return KotaRow.idProperty; }
        protected getInsertPermission() { return KotaRow.insertPermission; }
        protected getLocalTextPrefix() { return KotaRow.localTextPrefix; }
        protected getService() { return KotaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}