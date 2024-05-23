using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
	public class OrdersController : Controller
	{

		[HttpGet("/vendors/{id}/orders/new")]
		public ActionResult New(int id)
		{
			Vendor selectedVendor = Vendor.Find(id);
			return View(selectedVendor);
		}
		
	}
}