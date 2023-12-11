using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}
        //[HttpPost]
        //public IActionResult Verify(string username, string password)
        //{
        //    string username_txt = username;
        //    string password_txt = password;
        //    return View();
        //}
    }
}
