using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SeAdminSiswa.Siswa.KelassiswaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SeAdminSiswa.Siswa.KelassiswaRow;

namespace SeAdminSiswa.Siswa
{
    public interface IKelassiswaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class KelassiswaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IKelassiswaSaveHandler
    {
        public KelassiswaSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}