using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SeAdminSiswa.Siswa.KotaRow>;
using MyRow = SeAdminSiswa.Siswa.KotaRow;

namespace SeAdminSiswa.Siswa
{
    public interface IKotaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class KotaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IKotaRetrieveHandler
    {
        public KotaRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}