using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopV1.Core.Repository;
using ShopV1.Core.UnitOfWork;
using ShopV1.Models;

namespace ShopV1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IEfRepository<SanPham> _danhMucRepository;
        private readonly IEfRepository<AnhSanPham> _imageRepository;
        private readonly IEfRepository<MauSP> _mauRepositoty;
        private readonly IEfRepository<SizeSP> _sizeRepositoty;
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Khởi tạo
        /// </summary>
        /// <param name="danhMucRepository"></param>
        /// <param name="unitOfWork"></param>

        public ProductController(IEfRepository<SanPham> dm, IUnitOfWork unitOfWork , IEfRepository<AnhSanPham> anh , IEfRepository<MauSP> mau , IEfRepository<SizeSP> size )
        {
            _danhMucRepository = dm;
            _unitOfWork = unitOfWork;
            _imageRepository = anh;
            _mauRepositoty = mau;
            _sizeRepositoty = size;
        }
        public ActionResult Producitem (int id)
        {
            var data = _danhMucRepository.TableNoTracking.Where(m => m.IdDanhmuc == id).ToList();
            
           // ViewBag.anh = _imageRepository.TableNoTracking.Where(m => m.IdSanpahm == data.MaSanphan).Distinct();
            return View(data);
        }

        public ActionResult Detail (int id )
        {

            var detail = _danhMucRepository.TableNoTracking.Where(m => m.Id == id).ToList();
            ViewBag.detail = detail;
            var idz = detail.SingleOrDefault().MaSanphan;
            ViewBag.img = _imageRepository.TableNoTracking.Where(m => m.IdSanpahm == idz).ToList();
            ViewBag.color = _mauRepositoty.TableNoTracking.Where(m => m.IdSanpahm == idz).ToList();
            ViewBag.size = _sizeRepositoty.TableNoTracking.Where(m => m.IdSanpahm == idz).ToList();
            return View(detail);
        }

        public ActionResult  test (int id = 1114)
        {
            var data = _danhMucRepository.TableNoTracking.Where(m => m.Id == id);
            ViewBag.data = data;
            return View(data);

        }
    }
}
