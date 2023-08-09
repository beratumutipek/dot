using Microsoft.AspNetCore.Mvc;
using Basics.Models;
namespace Basics.Controllers


{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hi. {DateTime.Now.ToString()}";
            return View("Index1", message);
        }


        public ViewResult Index2()
        {
            var names = new String[]{
                "Ali","veli","mehmet"

            };
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1, FirstName="Ahmet", LastName="Can", Age=20},
                new Employee(){Id=2, FirstName="asda", LastName="asda", Age=123},
                new Employee(){Id=3, FirstName="asddsf213a", LastName="aa", Age=12},

            };
            return View("Index3", list);
        }
    }
} 