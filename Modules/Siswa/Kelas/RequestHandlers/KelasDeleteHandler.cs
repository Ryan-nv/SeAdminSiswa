using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SeAdminSiswa.Siswa.KelasRow;

namespace SeAdminSiswa.Siswa
{
    public interface IKelasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class KelasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IKelasDeleteHandler
    {
        public KelasDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}