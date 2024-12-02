﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		public IActionResult Index()
		{
			return View();
		}

		[AllowAnonymous]
		public IActionResult Test() { 
		return View();
		}

        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial() 
		{
			return new PartialViewResult();
		}

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
		{
			return new PartialViewResult();
		}

		[AllowAnonymous]
		[HttpGet]
		public IActionResult WriterEditProfile() 
		{
			var writervalues = wm.TGetById(1);
			return View(writervalues);
		}
        [AllowAnonymous]
        [HttpPost]
		public IActionResult WriterEditProfile(Writer p) 
		{
			WriterValidator wl = new WriterValidator();
			ValidationResult results = wl.Validate(p);
			if (results.IsValid)
			{
				wm.TUpdate(p);
				return RedirectToAction("Index", "Dashboard");
			}
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
				}
				return View();
			}
		}
	}
}