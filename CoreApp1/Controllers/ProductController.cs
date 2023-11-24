using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CoreApp1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.empnames = new List<string>() {"Amit","Suresh","Sumit" };

            
            HttpContext.Session.SetString("mydata", "Welcome");
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.data = "Hello";
            string? value=HttpContext.Session.GetString("mydata");
            ViewData["data1"] = value;
            return View();
        }
    }
}
