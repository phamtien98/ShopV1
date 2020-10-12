using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopV1.Models;
using ShopV1.Core;
using ShopV1.Core.Repository;
using ShopV1.Core.UnitOfWork;
using ShopV1.viewModel;
using Microsoft.AspNetCore.Http;
using System.Dynamic;

namespace ShopV1.Controllers
{
    public class CartController : Controller
    {
        private readonly IEfRepository<SanPham> _sanPham;
        private readonly IEfRepository<GioHang> _repos;
        private readonly IUnitOfWork _unitOfWork;
        List<GioHang> lstSP = new List<GioHang>();

        public CartController(IEfRepository<GioHang> repos, IUnitOfWork unitOfWork , IEfRepository<SanPham> sanpham)
        {
            _repos = repos;
            _unitOfWork = unitOfWork;
            _sanPham = sanpham;
        }

        private const String CartSession = "cartSession";
        public IActionResult Index()
        {
            int id = HttpContext.Session.GetInt32("id").Value;

            if (id != null)
            {
               var data  = (IList<GioHang>)lstSP;
               return View(data);
            }
            return Content("Ban phai dang nhap");

        }

        [HttpPost]
        public ActionResult AddItem(int? id, String IdsanPham , int soluong)
        {
            var lstSP = new List<GioHang>();
            if (id == null)
            {
                
                GioHang model = new GioHang();
                {
                    model.IdUser = (int)id;
                    model.IdSanpham = IdsanPham;
                    model.SoLuong = soluong;

                }
                lstSP.Add(model);
                _repos.Insert(model);
                _unitOfWork.SaveChange();

            }
            else
            {
                var lst = (List<GioHang>)lstSP;
                if (lst.Exists(m=>m.IdSanpham == IdsanPham))
                {
                    foreach (var item in lst)
                    {
                        if (item.IdSanpham == IdsanPham)
                        {
                            item.SoLuong += soluong;
                        }
                    }
                }
                else
                {
                    GioHang model = new GioHang();
                    {
                        model.IdUser = (int)id;
                        model.IdSanpham = IdsanPham;
                        model.SoLuong = soluong;
                    }
                    lstSP.Add(model);
                    _repos.Insert(model);
                    _unitOfWork.SaveChange();
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult Update (GioHang model)
        {
            var _item = _repos.TableNoTracking.Where(m => m.Id == model.Id);
            if (_item != null)
            {
                GioHang gh = new GioHang();
                {
                    gh.IdSanpham = model.IdSanpham;
                    gh.IdUser = model.IdUser;
                    gh.SoLuong = model.SoLuong;
                }
                _repos.Update(gh);
                _unitOfWork.SaveChange();
                return View(model);
            }
            else
            {
                _item.FirstOrDefault().SoLuong += 1;
                return View(model);
            }
        }
        public ActionResult Delete (int id)
        {
            var _id = _repos.TableNoTracking.Where(m => m.Id == id).FirstOrDefault();
            if (_id == null)
            {
                return View("Index");
            }
            else
            {
                _repos.Delete(_id);
                _unitOfWork.SaveChange();
                return RedirectToAction("Index", "Cart");
            }
        }
    }
}
