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

		[AllowAnonymous]
		public IActionResult Test() { 
		return View();
		}

        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial() {
			return new PartialViewResult();
		}

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
		{
			return new PartialViewResult();
		}
	}
}