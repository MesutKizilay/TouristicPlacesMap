using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TouristicPlacesMap.Controllers
{
    public class TouristicPlaceController : Controller
    {
        ITouristicPlaceService _touristicPlaceService;

        public TouristicPlaceController(ITouristicPlaceService touristicPlaceService)
        {
            _touristicPlaceService = touristicPlaceService;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            ViewBag.Deger = _touristicPlaceService.GetAllByCityId(id);
            return View();
        }

        [HttpPost]
        public IActionResult GetPlace(int id)
        {
            var place = _touristicPlaceService.GetById(id);
            return Json(place);
        }
    }
}