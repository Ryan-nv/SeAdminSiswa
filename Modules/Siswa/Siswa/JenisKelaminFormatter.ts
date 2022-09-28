namespace SeAdminSiswa.Siswa {
    @Serenity.Decorators.registerFormatter()
    export class JenisKelaminFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
            console.log(ctx.value); 
            var jk = parseInt(ctx.value);
            var jkEnum = JenKel;

            if(jk == jkEnum.LakiLaki)
            {
                return '<div><i class="fa fa-male" style="color:blue;"></i> Laki Laki</div>';
            }
            else 
            {
                return '<div><i class="fa fa-female" style="color:red;"></i> Perempuan</div>';
            }
        }
    }
}