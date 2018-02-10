using System.Web.Mvc;
using Models;

namespace ItAcademy.Controllers
{
    

    public class HomeController : Controller
    {

        QuestionContext context = new QuestionContext();

        public ActionResult Index()
        {
            var que = context.questions;

            ViewBag.questions = que;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}