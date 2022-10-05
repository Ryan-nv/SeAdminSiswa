namespace SeAdminSiswa.Siswa {
    @Serenity.Decorators.registerClass()
    export class SiswaPickerDialog extends Serenity.TemplatedDialog<SiswaPickerOptions> {

        private checkGrid: SiswaCheckGrid;

        constructor(opt: SiswaPickerOptions) {
            super(opt);

            this.checkGrid = new SiswaCheckGrid(this.byId("CheckGrid"), opt);
            this.dialogTitle = "Select Siswa";
        }

        protected getTemplate() {
            return `<div id="~_CheckGrid"></div>`;
        }

        protected getDialogButtons() {
            return [
                {
                    text: Q.text("Dialogs.OkButton"),
                    click: () => {
                        var selected = this.checkGrid.selectedItems;
                        if (!selected.length) {
                            Q.notifyWarning("Please Select Siswa!");
                            return;
                        }

                        if (!this.onSuccess || this.onSuccess(selected))
                            this.dialogClose();
                    }
                },
                {
                    text: Q.text("Dialogs.CancelButton"),
                    click: () => {
                        this.dialogClose();
                    }
                }
            ];
        }

        get selectedItems() {
            return this.checkGrid.selectedItems;
        }

        public onSuccess: (selected: SiswaRow[]) => boolean;
    }
}