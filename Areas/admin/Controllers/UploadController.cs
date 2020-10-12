using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShopV1.Areas.admin.Controllers
{
    public class UploadController : Controller
    {
        // GET: UploadController
        [Area("admin")]
        public ActionResult Index()
        {
            return View();
        } 
    }
}
