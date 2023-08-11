using Microsoft.AspNetCore.Mvc;
using Akademi.Models;
namespace Akademi.Controllers
{
    public class CourseController : Controller 
    {
        public IActionResult Index(){
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidate model){
            Repository.Add(model);
            return View("Feedback", model);
        }






    }



}