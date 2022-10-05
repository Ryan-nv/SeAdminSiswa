namespace SeAdminSiswa.Siswa {
    @Serenity.Decorators.registerEditor()
    export class SiswaDetailEditor extends Serenity.Extensions.GridEditorBase<KelassiswaRow> {
        protected getColumnsKey() { return KelassiswaColumns.columnsKey; }
        protected getDialogType() { return KelassiswaEditDialog; }
        protected getLocalTextPrefix() { return KelassiswaRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        validateEntity(row: KelassiswaRow, id) {
            row.Id = Q.toId(row.Id);

            var siswa = Q.tryFirst(this.view.getItems(), x => x.Id === row.Id); // Get siswa with corresponding id
            if (siswa && this.id(siswa) !== id) {
                Q.alert('Siswa Sudah ada Di Kelas!');
                return false;
            }

            row.SiswaNama = SiswaRow.getLookup().itemById[row.SiswaId].Nama;
            row.SiswaNis = SiswaRow.getLookup().itemById[row.SiswaId].Nis;
            row.SiswaJenisKelamin = SiswaRow.getLookup().itemById[row.SiswaId].JenisKelamin;
            row.SiswaAlamat = SiswaRow.getLookup().itemById[row.SiswaId].Alamat;
            row.SiswaTanggalLahir = SiswaRow.getLookup().itemById[row.SiswaId].TanggalLahir;
            row.SiswaNama = SiswaRow.getLookup().itemById[row.SiswaId].Nama;
            return true;
        }

        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.push({
                title: "Select Siswa",
                cssClass: "add-button",
                onClick: () => {
                    var dlg = new SiswaPickerDialog({
                        hideSiswa: this.view.getItems().map(x => x.SiswaId)
                    });
                    dlg.onSuccess = (selected: SiswaRow[]) => {
                        // filter siswa yang sudah ada
                        selected = selected.filter(x => !Q.any(this.view.getItems(), y => y.Id == x.Id));

                        for (var sel of selected) {
                            var item = <KelassiswaRow>{
                                SiswaId: sel.Id,
                                SiswaAlamat: sel.Alamat,
                                SiswaJenisKelamin: sel.JenisKelamin,
                                SiswaNis: sel.Nis,
                                SiswaNama: sel.Nama,
                                SiswaTanggalLahir: sel.TanggalLahir,
                            };

                            var id = this.getNextId();
                            item[this.getIdProperty()] = id;
                            this.view.addItem(item);
                        }

                        return true;
                    };
                    dlg.dialogOpen();
                }
            });

            return buttons;
        }
    }
}