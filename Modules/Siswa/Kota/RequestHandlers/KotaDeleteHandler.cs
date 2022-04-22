using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SeAdminSiswa.Siswa.KotaRow;

namespace SeAdminSiswa.Siswa
{
    public interface IKotaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class KotaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IKotaDeleteHandler
    {
        public KotaDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}