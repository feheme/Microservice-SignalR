using Inveon.Web.Hubs;
using Inveon.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Inveon.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YoneticiController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Git()
        {
            return View();
        }
        public IActionResult AdminLogout()
        {
            return SignOut("Cookies", "oidc");
        }




    }
}
