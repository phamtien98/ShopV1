using Microsoft.AspNetCore.Mvc;
using ShopV1.Core.Repository;
using ShopV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopV1.Controllers
{
    public class DanhMucViewComponent : ViewComponent 
    {
        private readonly IEfRepository<DanhMuc> _efRepository;
        public DanhMucViewComponent (IEfRepository<DanhMuc> efRepository)
        {
            _efRepository = efRepository;
        }
        public IViewComponentResult Invoke(int  id)
        {
            var data = _efRepository.TableNoTracking.Where(m => m.IdParent == id).ToList();
            ViewBag.menuCon = data;
            return View(data);
        }
    }
}
