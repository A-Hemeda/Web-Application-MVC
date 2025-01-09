using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {

        public IActionResult GetId(int[] array)
        {
            return Content($"Movie with id ");

        }
        //public IActionResult GetId(int id ,string name ,Employee employee) 
        //{
        //    return Content($"Movie with id :{id} ,Name : {name} ,EmployeeData {employee}");

        //}
        //1.form
        //2.segment
        //3.Query string
        //4.file

        public IActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.ContentType = "text/html";
            //result.Content = "Hello From Index";
            //result.StatusCode = 200;

            // return result;

            return Content("Hello From Index", "text/html");
        }

        public IActionResult Test() 
        {
            //RedirectResult redirect = new RedirectResult("https://localhost:44348/Movies/Index");

            //return redirect;
            //  return RedirectToAction(nameof(Index)); //redirect to action direct  buz url will has problem when you using in production
            //  buz you will deals with server
            return RedirectToRoute(new { controller ="Movies" ,action ="Index"});
        
        }

        public IActionResult viewResult() 
        {
        
            return Content("Hello From ViewResult" , "text/html"); // helper methods for ContentResult type

        }



    }
}
