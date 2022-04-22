using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SeAdminSiswa.Siswa.Pages
{

    [PageAuthorize(typeof(KotaRow))]
    public class KotaController : Controller
    {
        [Route("Data Siswa/Kota")]
        public ActionResult Index()
        {
            return View("~/Modules/Siswa/Kota/KotaIndex.cshtml");
        }
    }
}