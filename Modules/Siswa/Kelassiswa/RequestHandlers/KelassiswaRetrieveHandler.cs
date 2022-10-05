using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SeAdminSiswa.Siswa.KelassiswaRow>;
using MyRow = SeAdminSiswa.Siswa.KelassiswaRow;

namespace SeAdminSiswa.Siswa
{
    public interface IKelassiswaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class KelassiswaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IKelassiswaRetrieveHandler
    {
        public KelassiswaRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}