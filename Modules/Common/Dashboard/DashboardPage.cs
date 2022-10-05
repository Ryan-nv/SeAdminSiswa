using Microsoft.AspNetCore.Mvc;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Web;
using System;

namespace SeAdminSiswa.Common.Pages
{
    [Route("Dashboard/[action]")]
    public class DashboardController : Controller
    {
        [PageAuthorize, HttpGet, Route("~/")]
        public ActionResult Index(
        	//<if:Northwind>
        	[FromServices] ITwoLevelCache cache,
        	[FromServices] ISqlConnections sqlConnections
        	//</if:Northwind>
        	)
        {
            //<if:Northwind>
            if (cache is null)
            	throw new ArgumentNullException(nameof(cache));

            if (sqlConnections is null)
            	throw new ArgumentNullException(nameof(sqlConnections));

            var o = SeAdminSiswa.Siswa.SiswaRow.Fields;
            var i = SeAdminSiswa.Siswa.KotaRow.Fields;
            
            var cachedModel = cache.GetLocalStoreOnly("DashboardPageModel", TimeSpan.FromMinutes(5),
                o.GenerationKey, () =>
                {
                    var model = new DashboardPageModel();
                    using (var connection = sqlConnections.NewFor<SeAdminSiswa.Siswa.SiswaRow>())
                    {
                        model.Murid = connection.Count<SeAdminSiswa.Siswa.SiswaRow>(); 
                        model.MuridLk = connection.Count<SeAdminSiswa.Siswa.SiswaRow>(o.JenisKelamin == (int)SeAdminSiswa.Siswa.JenKel.LakiLaki );
                        model.MuridPr = connection.Count<SeAdminSiswa.Siswa.SiswaRow>(o.JenisKelamin == (int)SeAdminSiswa.Siswa.JenKel.Perempuan ); 
                    }
                    return model;
                });
            return View(MVC.Views.Common.Dashboard.DashboardIndex, cachedModel);
            //<else>
            //return View(MVC.Views.Common.Dashboard.DashboardIndex, new DashboardPageModel());
            //</if:Northwind>
        }
    }
}
