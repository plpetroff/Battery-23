namespace Battery_23.Controllers
{
    using Battery_23.Models.Batteries;
    using Microsoft.AspNetCore.Mvc;

    public class BatteryController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddBatteryFormModel battery)
        {
            return View();
        }

    }
}
