using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopV1.Core.Repository;
using ShopV1.Core.UnitOfWork;
using ShopV1.Models;

namespace ShopV1.Areas.admin.Controllers
{
    public class OrderController : Controller
    {
        private readonly IEfRepository<DonHang> _orderRepository;
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IEfRepository<DonHang> order , IUnitOfWork unitOfWork )
        {
            _orderRepository = order;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
