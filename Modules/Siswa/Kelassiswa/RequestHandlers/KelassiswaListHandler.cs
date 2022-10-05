using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SeAdminSiswa.Siswa.KelassiswaRow>;
using MyRow = SeAdminSiswa.Siswa.KelassiswaRow;

namespace SeAdminSiswa.Siswa
{
    public interface IKelassiswaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class KelassiswaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IKelassiswaListHandler
    {
        public KelassiswaListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}