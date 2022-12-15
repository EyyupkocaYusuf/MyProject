using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var values = _addressService.TGetListAll();
            return View(values);
        }


        [HttpGet]
        public IActionResult UpdateAddress(int id)
        {
            var values = _addressService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAddress(Address adress)
        {
            _addressService.TUpdate(adress);
            return RedirectToAction("Index");
        
        }

    }
}
