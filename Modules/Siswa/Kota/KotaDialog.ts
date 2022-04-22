
namespace SeAdminSiswa.Siswa {
    
    @Serenity.Decorators.registerClass()
    export class KotaDialog extends Serenity.EntityDialog<KotaRow, any> {
        protected getFormKey() { return KotaForm.formKey; }
        protected getIdProperty() { return KotaRow.idProperty; }
        protected getLocalTextPrefix() { return KotaRow.localTextPrefix; }
        protected getNameProperty() { return KotaRow.nameProperty; }
        protected getService() { return KotaService.baseUrl; }
        protected getDeletePermission() { return KotaRow.deletePermission; }
        protected getInsertPermission() { return KotaRow.insertPermission; }
        protected getUpdatePermission() { return KotaRow.updatePermission; }

        protected form = new KotaForm(this.idPrefix);

    }
}