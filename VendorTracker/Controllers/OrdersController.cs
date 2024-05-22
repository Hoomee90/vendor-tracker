using Microsoft.AspNetCore.Mvc;

namespace VendorTracker.Controllers
{
	public class OrdersController : Controller
	{

		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}
		
	}
}