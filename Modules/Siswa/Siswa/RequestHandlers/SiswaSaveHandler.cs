using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SeAdminSiswa.Siswa.SiswaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SeAdminSiswa.Siswa.SiswaRow;

namespace SeAdminSiswa.Siswa
{
    public interface ISiswaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SiswaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISiswaSaveHandler
    {
        public SiswaSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}