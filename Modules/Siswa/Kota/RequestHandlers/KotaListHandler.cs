using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SeAdminSiswa.Siswa.KotaRow>;
using MyRow = SeAdminSiswa.Siswa.KotaRow;

namespace SeAdminSiswa.Siswa
{
    public interface IKotaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class KotaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IKotaListHandler
    {
        public KotaListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}