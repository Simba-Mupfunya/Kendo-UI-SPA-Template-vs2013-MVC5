using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /

        public ActionResult Index()
        {
            return View();
        }

    }
}
