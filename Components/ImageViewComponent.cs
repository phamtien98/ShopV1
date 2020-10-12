using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopV1.Core.Repository;
using ShopV1.Core.UnitOfWork;
using ShopV1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShopV1.Components
{
    public class ImageViewComponent :ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEfRepository<AnhSanPham> _imageReoposity;
        private IHostingEnvironment _environment;
        public ImageViewComponent (IEfRepository<AnhSanPham> repos , IUnitOfWork unit , IHostingEnvironment environment )
        {
            _imageReoposity = repos;
            _unitOfWork = unit;
            _environment = environment; 
        }
        [HttpPost]
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }

    }
}
