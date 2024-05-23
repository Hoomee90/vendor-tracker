using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
	public class VendorsController : Controller
	{

		[HttpGet("/vendors")]
		public ActionResult Index()
		{
			List<Vendor> vendors = Vendor.GetAll();
			return View(vendors);
		}
		
		[HttpGet("/vendors/new")]
		public ActionResult New()
		{
			return View();
		}
		
		[HttpPost("/vendors")]
		public ActionResult Create(string name, string description)
		{
			Vendor _ = new(name, description);
			return RedirectToAction("Index");
		}
		
		[HttpGet("/vendors/{id}")]
		public ActionResult Show(int id)
		{
			Vendor selectedVendor = Vendor.Find(id);
			return View(selectedVendor);
		}
		
		[HttpPost("/vendors/{id}/orders")]
		public ActionResult Create(int id, string title, string description, string date, double price)
		{
			Vendor selectedVendor = Vendor.Find(id);
			Order newOrder = new(title, description, date, price);
			selectedVendor.AddOrder(newOrder);
			return View("Show", selectedVendor);
		}
		
	}
}