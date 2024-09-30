using Microsoft.AspNetCore.Mvc;

namespace EmptyProject
{
    public class ProductController: Controller
    {
        //attribute routing
        [Route("product/info")]
        [Route("product/special-info")]
        public ContentResult Info()//action for content result
        {
            return Content("This is the product controller");
        }

        //Action for viewresult
        public ViewResult Details()
        {
            return View();
        }
    }
}