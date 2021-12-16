using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            //ViewResult view = new ViewResult();
            //view.ViewName = "Index";
            //return view;
            //return Content("Many Problems");
            return View();
        }

        //about abouts olaraq deyisdirdim error vermedi cunku cshtml file adinda abouts.cshtml olaraq deyisdirdim
        public ActionResult Abouts()
        {
            return View();
        }
        
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }
    }
}
