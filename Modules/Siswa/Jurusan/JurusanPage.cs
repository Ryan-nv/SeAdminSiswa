using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SeAdminSiswa.Siswa.Pages
{

    [PageAuthorize(typeof(JurusanRow))]
    public class JurusanController : Controller
    {
        [Route("Siswa/Jurusan")]
        public ActionResult Index()
        {
            return View("~/Modules/Siswa/Jurusan/JurusanIndex.cshtml");
        }
    }
}