using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            var values = _adminService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            _adminService.TInsert(admin);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAdmin(int id)
        {
            var values = _adminService.TGetById(id);
            _adminService.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateAdmin(int id)
        {
            var values = _adminService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAdmin(Admin admin)
        {
            _adminService.TUpdate(admin);
            return RedirectToAction("Index");
        }

    }
}
