using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SeAdminSiswa.Siswa.KelassiswaRow;

namespace SeAdminSiswa.Siswa
{
    public interface IKelassiswaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class KelassiswaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IKelassiswaDeleteHandler
    {
        public KelassiswaDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}