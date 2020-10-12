using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopV1.Core.Repository;
using ShopV1.Core.UnitOfWork;
using ShopV1.Models;
namespace ShopV1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IEfRepository<TaiKhoan> _danhMucRepository;
        private readonly IUnitOfWork _unitOfWork;
        // GET: CustomerController
        public CustomerController (IEfRepository<TaiKhoan> repos , IUnitOfWork unit)
        {
            _danhMucRepository = repos;
            _unitOfWork = unit;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerController/Details/5
        [HttpPost]
      public ActionResult Login(TaiKhoan model )
        {
            var _cus = _danhMucRepository.TableNoTracking.Where(m => m.Email == model.Email && m.Matkhau == model.Matkhau).ToList();
            if (_cus.Count > 0)
            {
                HttpContext.Session.SetString("ten_khachhang", _cus.FirstOrDefault().TenKhachhang);
                HttpContext.Session.SetInt32("id", _cus.FirstOrDefault().Id);
                return RedirectToAction("Index", "Index");
            }
            return View("Index", "Home");
           
        }
    }
}
