using Microsoft.AspNetCore.Mvc;

namespace VendorTracker.Controllers
{
	public class VendorsController : Controller
	{

		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}
		
	}
}