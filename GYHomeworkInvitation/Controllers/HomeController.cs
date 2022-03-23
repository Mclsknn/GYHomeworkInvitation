using GYHomeworkInvitation.Models;
using Microsoft.AspNetCore.Mvc;

namespace GYHomeworkInvitation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Guest guest)
        {
            if (ModelState.IsValid)
            {
                if (guest.WillCome)
                {
                    ViewBag.Come = "Partimize katılacağınız için teşekkür ederiz...";  
                }
                else
                {
                    ViewBag.Come = "Partimize katılmanızı çok isterdik yinede teşekkür ederiz...";
                 
                }
                return View("LastPage");
            }

            return View();
           
        }
        public IActionResult LastPage() 
        {
            return View();
        }
    }
}
