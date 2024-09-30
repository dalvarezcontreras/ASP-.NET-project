using Microsoft.AspNetCore.Mvc;

namespace EmptyProject.Controllers
{
    public class HomeController: Controller
    {
        public ContentResult Index()
        {
            return Content("This the the homecontroller");
        }
        public ViewResult About()
        {
            return View();//returning the corresponding view 
        }
    }
}