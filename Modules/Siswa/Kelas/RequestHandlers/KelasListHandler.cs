using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SeAdminSiswa.Siswa.KelasRow>;
using MyRow = SeAdminSiswa.Siswa.KelasRow;

namespace SeAdminSiswa.Siswa
{
    public interface IKelasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class KelasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IKelasListHandler
    {
        public KelasListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}