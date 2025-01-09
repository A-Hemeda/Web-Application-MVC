using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()  
        {
            //Master Page [Return type view Result--> Razor page (HTML page can write in this code c#)]
            return View();// return view with same name of action
        }

        public IActionResult AboutUs()
        {
            return View();// return view with same name of action
        }

        public IActionResult ContactUs()
        {
            return View();// return view with same name of action
        }

        public IActionResult Privacy()
        {
            return View();// return view with same name of action
        }


    }
}
