using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SeAdminSiswa.Siswa.JurusanRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SeAdminSiswa.Siswa.JurusanRow;

namespace SeAdminSiswa.Siswa
{
    public interface IJurusanSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class JurusanSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IJurusanSaveHandler
    {
        public JurusanSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}