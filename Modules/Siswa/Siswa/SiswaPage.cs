using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SeAdminSiswa.Siswa.Pages
{

    [PageAuthorize(typeof(SiswaRow))]
    public class SiswaController : Controller
    {
        [Route("Data Siswa/Siswa")]
        public ActionResult Index()
        {
            return View("~/Modules/Siswa/Siswa/SiswaIndex.cshtml");
        }
    }
}