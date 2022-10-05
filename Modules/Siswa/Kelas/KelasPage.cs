using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SeAdminSiswa.Siswa.Pages
{

    [PageAuthorize(typeof(KelasRow))]
    public class KelasController : Controller
    {
        [Route("Siswa/Kelas")]
        public ActionResult Index()
        {
            return View("~/Modules/Siswa/Kelas/KelasIndex.cshtml");
        }
    }
}