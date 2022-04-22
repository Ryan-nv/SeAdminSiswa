
namespace SeAdminSiswa.Siswa {

    import fld = SiswaRow.Fields;

    @Serenity.Decorators.registerClass()
    export class SiswaGrid extends Serenity.EntityGrid<SiswaRow, any> {
        protected getColumnsKey() { return SiswaColumns.columnsKey; }
        protected getDialogType() { return SiswaDialog; }
        protected getIdProperty() { return SiswaRow.idProperty; }
        protected getInsertPermission() { return SiswaRow.insertPermission; }
        protected getLocalTextPrefix() { return SiswaRow.localTextPrefix; }
        protected getService() { return SiswaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields() : Serenity.QuickSearchField[]
        {
            var txt = (s) => Q.text(`Db.${SiswaRow.localTextPrefix}.${s}`)

            return [
                {name: '', title : "all"},
                {name: fld.Nis, title : txt(fld.Nis)},
                {name: fld.Nama, title : txt(fld.Nama)}
            ]; 
        }

        protected getColumns()
        {
            var columns = super.getColumns();
            
            columns.push({
                field: 'Del Row',
                name: '',
                format: _ctx => '<a class="inline-action delete-row" title="delete" href="javascript:;"> <i class="fa fa-trash-o inline-action delete-row text-red"></i> </a>',
                width: 15,
                minWidth: 15,
                maxWidth: 15 
            });

            return columns;
        }

        protected onClick(e : JQueryEventObject, row:number, cell:number)
        {
            super.onClick(e, row, cell);
            
            if(e.isDefaultPrevented()) return;

            var item = this.itemAt(row);
            var target = $(e.target);

            if(target.parent().hasClass('inline-action'))
            {
                target = target.parent();
            }

            if(target.hasClass('inline-action'))
            {
                e.preventDefault();

                if(target.hasClass('delete-row'))
                {
                    Q.confirm('Hapus ' + item.Nama + ' ?', () => {
                        Siswa.SiswaService.Delete({
                            EntityId: item.Id
                        }, _res => this.refresh());
                    }); 
                }
            }

        }

        protected getButtons ()
        {
            var buttons = super.getButtons();

            buttons.push(Serenity.Extensions.ExcelExportHelper.createToolButton({
                grid: this, 
                onViewSubmit : () => this.onViewSubmit(),
                service: SiswaService.baseUrl + "/ListExcel",
                separator: true
            }));

            buttons.push(Serenity.Extensions.PdfExportHelper.createToolButton(
                {
                    grid: this, 
                    onViewSubmit : () => this.onViewSubmit()
                }
            ))

            return buttons;
        }
    }
}