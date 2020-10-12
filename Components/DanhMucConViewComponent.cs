using Microsoft.AspNetCore.Mvc;
using ShopV1.Core.Repository;
using ShopV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopV1.Components
{
    public class DanhMucConViewComponent : ViewComponent 
    {
        private readonly IEfRepository<DanhMuc> _danhMucRepository;
        public DanhMucConViewComponent (IEfRepository<DanhMuc> repository)
        {
            _danhMucRepository = repository;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var data = _danhMucRepository.TableNoTracking.Where(m => m.IdParent == id);
            
            return View(data);
        }
    }
}
