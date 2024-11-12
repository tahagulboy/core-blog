using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
	public class WriterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}