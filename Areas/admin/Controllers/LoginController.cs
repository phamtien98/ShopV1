using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using ShopV1.Core.Repository;
using ShopV1.Core.UnitOfWork;
using ShopV1.Models;
using ShopV1.viewModel;
using System.Web;
using Microsoft.AspNetCore.Http;
namespace ShopV1.Areas.admin.Controllers
{

    public class LoginController : Controller
    {
        ShopDatabaseContext db = new ShopDatabaseContext();
        private readonly IEfRepository<AdminAccount> _adminRepos;
        private readonly IUnitOfWork _unitOfWork;
        public LoginController (IEfRepository<AdminAccount> adminRepos)
        {
            _adminRepos = adminRepos;
        }
        [Area("admin")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("fullname") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [Area("admin")]
        [HttpPost]
        public ActionResult Login(AdminViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                var _data = _adminRepos.TableNoTracking.Where(m => m.Username == model.Username && m.Password == model.Password).ToList();
                if (_data.Count >0 )
                {
                    HttpContext.Session.SetString("fullname", _data.FirstOrDefault().Fullname);
                    HttpContext.Session.SetInt32("id", _data.FirstOrDefault().Id);
                    return RedirectToAction("Index");

                }
            }
            return View("Index");

        }
        [Area("admin")]
        public ActionResult Logout ()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
    }
}
