using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SeAdminSiswa.Siswa.JurusanRow>;
using MyRow = SeAdminSiswa.Siswa.JurusanRow;

namespace SeAdminSiswa.Siswa
{
    public interface IJurusanListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class JurusanListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IJurusanListHandler
    {
        public JurusanListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}