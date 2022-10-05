using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SeAdminSiswa.Siswa.Pages
{

    [PageAuthorize(typeof(KelassiswaRow))]
    public class KelassiswaController : Controller
    {
        [Route("Siswa/Kelassiswa")]
        public ActionResult Index()
        {
            return View("~/Modules/Siswa/Kelassiswa/KelassiswaIndex.cshtml");
        }
    }
}