using Microsoft.AspNetCore.Mvc;

namespace ASPMVC.Controllers
{
	public class TestDataController : Controller
	{
		
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.TestKey = "yes";
			TempData["TestKey"] = "nop";
			return View();
		}
		public IActionResult TestData2()
		{
			return View("TestData2");
		}
		public IActionResult TestData3()
		{
			ViewBag.TestKey = "Dur";
			TempData["TestKey"] = "Bite";
			return RedirectToAction("TestData2");
		}
		public IActionResult TestData4()
		{
			ViewBag.TestKey = "Vraiment";
			TempData["TestKey"] = "Marrante";
			return View("Index");
		}

	}
}
