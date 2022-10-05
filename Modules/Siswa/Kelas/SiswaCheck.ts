
namespace SeAdminSiswa.Siswa {

    export interface SiswaPickerOptions {
        hideSiswa?: number[];
    }

    @Serenity.Decorators.registerClass()
    export class SiswaCheckGrid extends Serenity.EntityGrid<SiswaRow, SiswaPickerOptions> {
        protected getColumnsKey() { return SiswaColumns.columnsKey; }
        protected getDialogType() { return SiswaDialog; }
        protected getIdProperty() { return SiswaRow.idProperty; }
        protected getLocalTextPrefix() { return SiswaRow.localTextPrefix; }
        protected getService() { return SiswaService.baseUrl; }

        private rowSelection: Serenity.GridRowSelectionMixin;

        constructor(container: JQuery, options: SiswaPickerOptions) {
            super(container, options);

            this.rowSelection = new Serenity.GridRowSelectionMixin(this);
        }

        protected getColumns() {
            var columns = super.getColumns();
            columns.splice(0, 0, Serenity.GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
            return columns;
        }

        protected usePager() {
            return false;
        }

        protected getInitialTitle() {
            return null;
        }

        protected getButtons() {
            var buttons = super.getButtons();
            buttons = buttons.filter(x => x.cssClass != 'add-button');
            return buttons;
        }

        get selectedItems() {
            return this.rowSelection.getSelectedAsInt32().map(x => this.view.getItemById(x));
        }

        onViewSubmit() {
            if (!super.onViewSubmit())
                return false;

            var request = this.view.params as Serenity.ListRequest;
            if (this.options.hideSiswa && this.options.hideSiswa.length)
                request.Criteria = Serenity.Criteria.and(request.Criteria,
                    [[SiswaRow.Fields.Id], 'not in', [this.options.hideSiswa]]);

            return true;
        }
    }
}