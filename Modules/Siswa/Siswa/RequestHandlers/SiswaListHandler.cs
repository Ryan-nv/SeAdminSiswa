using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SeAdminSiswa.Siswa.SiswaRow>;
using MyRow = SeAdminSiswa.Siswa.SiswaRow;

namespace SeAdminSiswa.Siswa
{
    public interface ISiswaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SiswaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISiswaListHandler
    {
        public SiswaListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}