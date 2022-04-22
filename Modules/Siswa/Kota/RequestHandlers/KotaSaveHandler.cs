using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SeAdminSiswa.Siswa.KotaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SeAdminSiswa.Siswa.KotaRow;

namespace SeAdminSiswa.Siswa
{
    public interface IKotaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class KotaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IKotaSaveHandler
    {
        public KotaSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}