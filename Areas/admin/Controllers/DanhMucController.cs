﻿using Microsoft.AspNetCore.Mvc;
using ShopV1.Core.Repository;
using ShopV1.Core.UnitOfWork;
using ShopV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopV1.viewModel;
using System.Dynamic;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RestSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ShopV1.Areas.admin.Controllers
{
    public class DanhMucController : Controller
    {
        ShopDatabaseContext db = new ShopDatabaseContext();
        private readonly IEfRepository<DanhMuc> _danhMucRepository;
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Khởi tạo
        /// </summary>
        /// <param name="danhMucRepository"></param>
        /// <param name="unitOfWork"></param>
        public DanhMucController(IEfRepository<DanhMuc> danhMucRepository, IUnitOfWork unitOfWork)
        {
            _danhMucRepository = danhMucRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// View
        /// </summary>
        /// <returns></returns>
        [Area("admin")]
        public IActionResult Index()
        {
            var listCon = _danhMucRepository.TableNoTracking.Where(m => m.IdParent != 0).ToList();
            ViewBag.con = listCon;

            return View();
        }
        [Area("admin")]
        public ActionResult Create()
        {
            List<DanhMuc> dmcon = db.DanhMuc.Where(m => m.IdParent == 0).ToList();
            SelectList dm = new SelectList(dmcon, "Id","Ten");
            ViewBag.lstPR = dm;
            return View();
        }
        /// <summary>
        /// Hàm thêm mới 1 danh mục, truyền vào model danh mục
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Area("admin")]
        [HttpPost]
        public ActionResult Create(DanhMuc dm)
        {

            if (ModelState.IsValid)
            {
                var checkVali = _danhMucRepository.TableNoTracking.Where(m => m.Ten == dm.Ten);
                if (checkVali.Count() > 0 )
                {
                    return Content("Trùng cmnrr");

                }
                else
                {
                    var model = new DanhMuc();
                    {
                        model.IdParent = dm.IdParent;
                        model.Ten = dm.Ten;
                    }
                    _danhMucRepository.Insert(model);
                    _unitOfWork.SaveChange();
                    return RedirectToAction("Index", "Home");
                }
            }
               
            return View(dm);
        }
            

        /// <summary>
        /// Hàm lấy dữ liệu tất cả bản ghi danh mục
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var listDanhmuc = _danhMucRepository.TableNoTracking.ToList();

            if (!listDanhmuc.Any())
                return NoContent();

            return View(listDanhmuc);
        }

        /// <summary>
        /// Hàm lấy dữ liệu tất cả bản ghi danh mục
        /// </summary>
        /// <returns></returns>
        [HttpGet("id")]
        [Area("admin")]
        public IActionResult GetById([FromQuery] int id)
        {
            id = 1;
            var selectedModel = _danhMucRepository.TableNoTracking.Where(a => a.Id == id).FirstOrDefault();

            return View(selectedModel);
        }

        /// <summary>
        /// Hàm cập nhật dữ liệu bản ghi danh mục theo Id
        /// </summary>
        /// <returns></returns>
        [Area("admin")] 
        public ActionResult Update()
        {
            return View();
        }

        [Area("admin")]
        [HttpPost]
        public ActionResult Update(DanhMuc model)
        {
            var selectedModel = _danhMucRepository.TableNoTracking.Where(a => a.Id == model.Id).FirstOrDefault();

            if (selectedModel == null)
                return BadRequest("Danh mục không tồn tại !");

            selectedModel.Ten = model.Ten;

            _danhMucRepository.Update(model);
            _unitOfWork.SaveChange();

            return RedirectToAction("Index","Home");
        }

        /// <summary>
        /// Hàm cập xóa bản ghi danh mục theo Id
        /// </summary> 
        /// <returns></returns>
        [Area("admin")]
        public ActionResult Delete(int? id)
        {
            var data = _danhMucRepository.TableNoTracking.Where(m => m.Id == id).ToList();
            return View(data);
        }
        [Area("admin")]
        [HttpPost]
        public ActionResult Delete( int Id)
        {
            var selectedModel = _danhMucRepository.TableNoTracking.Where(a => a.Id == Id).FirstOrDefault();

            if (selectedModel == null)
                return BadRequest("Danh mục không tồn tại !");

            _danhMucRepository.Delete(selectedModel);
            _unitOfWork.SaveChange();

            return RedirectToAction("Index","Home");
        }
    }
}
