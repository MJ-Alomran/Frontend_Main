using Microsoft.AspNetCore.Mvc;

namespace FieldTrainingApp.Controllers
{
    public class StudentController : Controller
    {
      
        public IActionResult Login()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            return View();
        }
    }
}