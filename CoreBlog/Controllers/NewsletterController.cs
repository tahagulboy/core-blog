﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
	public class NewsletterController : Controller
	{
		NewsletterManager nm = new NewsletterManager(new EfNewsletterRepository());
		
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult SubscribeMail(Newsletter p)
		{
			p.MailStatus = true;
			nm.AddNewsletter(p);
			Response.Redirect("/Blog/Index/");
			return PartialView();
		}
	}
}
