
namespace SeAdminSiswa.Siswa {

    @Serenity.Decorators.registerClass()
    export class KelassiswaGrid extends Serenity.EntityGrid<KelassiswaRow, any> {
        protected getColumnsKey() { return KelassiswaColumns.columnsKey; }
        protected getDialogType() { return KelassiswaDialog; }
        protected getIdProperty() { return KelassiswaRow.idProperty; }
        protected getInsertPermission() { return KelassiswaRow.insertPermission; }
        protected getLocalTextPrefix() { return KelassiswaRow.localTextPrefix; }
        protected getService() { return KelassiswaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}