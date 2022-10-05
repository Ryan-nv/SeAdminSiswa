using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SeAdminSiswa.Siswa.KelasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SeAdminSiswa.Siswa.KelasRow;

namespace SeAdminSiswa.Siswa
{
    public interface IKelasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class KelasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IKelasSaveHandler
    {
        public KelasSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}