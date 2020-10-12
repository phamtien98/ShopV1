using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopV1.Core.Repository;
using ShopV1.Core.UnitOfWork;
using ShopV1.Models;

namespace ShopV1.Controllers
{
    public class HomeController : Controller
    {


        private readonly IEfRepository<DanhMuc> _danhMucRepository;
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Khởi tạo
        /// </summary>
        /// <param name="danhMucRepository"></param>
        /// <param name="unitOfWork"></param>

        public HomeController(IEfRepository<DanhMuc> dm , IUnitOfWork unitOfWork)
        {
            _danhMucRepository = dm;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var menuCha = _danhMucRepository.TableNoTracking.Where(m=>m.IdParent == 0).ToList();
            ViewBag.Cha = menuCha;
            ViewBag.Titel = menuCha.FirstOrDefault().Ten;
            return View();
        }
    }
}
