using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGeneration;
using ShopV1.Core.Repository;
using ShopV1.Core.UnitOfWork;
using ShopV1.Models;
using ShopV1.viewModel;

namespace ShopV1.Areas.admin.Controllers
{
    public class SanPhamController : Controller
    {
        ShopDatabaseContext db = new ShopDatabaseContext();
        private readonly IEfRepository<AnhSanPham> _imageRepository;
        private readonly IEfRepository<SanPham> _sanPhamRepository;
        private readonly IEfRepository<MauSP> _mauRepositoty;
        private readonly IEfRepository<SizeSP> _sizeRepositoty;
        private IHostingEnvironment _environment;
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Khởi tạo
        /// </summary>
        /// <param name="sanPhamRepository"></param>
        /// <param name="unitOfWork"></param>
        public SanPhamController(IEfRepository<SanPham> sanPhamRepository, IUnitOfWork unitOfWork, IEfRepository<AnhSanPham> image ,  IEfRepository<MauSP> mau , IEfRepository<SizeSP> size , IHostingEnvironment evn )
        {
            _sanPhamRepository = sanPhamRepository;
            _unitOfWork = unitOfWork;
            _imageRepository = image;
            _mauRepositoty = mau;
            _sizeRepositoty = size;
            _environment = evn;
        }
        // GET: SanPhamController
        [Area("admin")]
        public ActionResult Index()
        {
           
            var data = _sanPhamRepository.TableNoTracking.ToList();
            ViewBag.sanpham = data;
            if (!data.Any())
                return NoContent();
            return View(data);
        }
        // GET: SanPhamController/Create
        [Area("admin")]
        public ActionResult Create()
        {
            List<DanhMuc> dm = db.DanhMuc.ToList();
            SelectList danhmuc = new SelectList(dm, "Id", "Ten");
            ViewBag.ID = danhmuc;
            return View();
        }

        // POST: SanPhamController/Create
        [Area("admin")]
        [HttpPost]
        public ActionResult Create(ProductViewModel model , IFormFile[] files) 
        {
            if (ModelState.IsValid)
            {
                SanPham sp = new SanPham();
                {
                    sp.MaSanphan = model.MaSanphan;
                    sp.TenSanpham = model.TenSanpham;
                    sp.GiaSanpham = model.GiaSanpham;
                    sp.GiaKm = model.GiaKm;
                    sp.Mota = model.Mota;
                    sp.IdDanhmuc = model.IdDanhmuc;
                    sp.SoLuong = model.SoLuong;
                }
                _sanPhamRepository.Insert(sp);
                _unitOfWork.SaveChange();

                MauSP color = new MauSP();
                {
                    color.IdSanpahm = model.MaSanphan;
                    color.color = model.color;
                }
                _mauRepositoty.Insert(color);
                _unitOfWork.SaveChange();

                SizeSP s = new SizeSP();
                {
                    s.IdSanpahm = model.MaSanphan;
                    s.size = model.size;

                }
                _sizeRepositoty.Insert(s);
                _unitOfWork.SaveChange();

                AnhSanPham img = new AnhSanPham();
                {

                

                }
                _imageRepository.Insert(img);
                _unitOfWork.SaveChange();
                
                if (files !=null)
                {
                    AnhSanPham anh = new AnhSanPham();
                    foreach (var photo in files)
                    {
                        var path = Path.Combine(_environment.WebRootPath, "Images",photo.FileName);
                        var stream = new FileStream(path, FileMode.Create);
                        photo.CopyToAsync(stream);
                        anh.IdSanpahm = model.MaSanphan;
                        anh.Url = path;
                        _imageRepository.Insert(anh);
                        _unitOfWork.SaveChange();
                    }
                }

                var uploads = Path.Combine(_environment.WebRootPath, "Images");
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                    }

                }
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        // GET: SanPhamController/Edit/5
        [Area("admin")]
        public ActionResult Update()
        {
            return View();
        }
        // POST: SanPhamController/Edit/5
        [Area("admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(ProductViewModel model)
        {
            var selectedModel = _sanPhamRepository.TableNoTracking.Where(a => a.Id == model.Id).FirstOrDefault();

            if (selectedModel == null)
                return BadRequest("Danh mục không tồn tại !");
            
            selectedModel.MaSanphan = model.MaSanphan;
            selectedModel.TenSanpham = model.TenSanpham;
            selectedModel.Mota = model.Mota;
            selectedModel.GiaSanpham = model.GiaSanpham;
            selectedModel.GiaKm = model.GiaKm;
            selectedModel.IdDanhmuc = model.IdDanhmuc;
            selectedModel.SoLuong = model.SoLuong;
            _unitOfWork.SaveChange();

            return RedirectToAction("Index","Home");
        }

        //GET: SanPhamController/Delete/5
        [Area("admin")]
        public ActionResult Delete(int? id)
        {
            var data = _sanPhamRepository.TableNoTracking.Where(m => m.Id == id).ToList();
            return View(data);
        }

        // POST: SanPhamController/Delete/5
        [Area("admin")]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var selectedModel = _sanPhamRepository.TableNoTracking.Where(a => a.Id == id).FirstOrDefault();

            if (selectedModel == null)
                return BadRequest("Sản phẩm không tồn tại !");

            _sanPhamRepository.Delete(selectedModel);
            _unitOfWork.SaveChange();

            return RedirectToAction("Index","Home");
        }

        [Area("admin")]
        [HttpPost]
        public async Task<IActionResult> Upload (ICollection<IFormFile> files)
        {

            var uploads = Path.Combine(_environment.WebRootPath, "Images");
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                }
               
             }
            return null;
        }

    }
}
