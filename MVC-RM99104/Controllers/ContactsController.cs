using Microsoft.AspNetCore.Mvc;

namespace MVC_RM99104.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
