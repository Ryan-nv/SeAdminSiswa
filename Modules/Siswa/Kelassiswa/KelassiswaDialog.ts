
namespace SeAdminSiswa.Siswa {

    @Serenity.Decorators.registerClass()
    export class KelassiswaDialog extends Serenity.EntityDialog<KelassiswaRow, any> {
        protected getFormKey() { return KelassiswaForm.formKey; }
        protected getIdProperty() { return KelassiswaRow.idProperty; }
        protected getLocalTextPrefix() { return KelassiswaRow.localTextPrefix; }
        protected getService() { return KelassiswaService.baseUrl; }
        protected getDeletePermission() { return KelassiswaRow.deletePermission; }
        protected getInsertPermission() { return KelassiswaRow.insertPermission; }
        protected getUpdatePermission() { return KelassiswaRow.updatePermission; }

        protected form = new KelassiswaForm(this.idPrefix);

        constructor() {
            super();
        }
    }
}