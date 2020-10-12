using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopV1.viewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string MaSanphan { get; set; }
        public string TenSanpham { get; set; }
        public string Mota { get; set; }
        public double? GiaSanpham { get; set; }
        public double? GiaKm { get; set; }
        public int? IdDanhmuc { get; set; }
        public int? SoLuong { get; set; }
        public String color { get; set; }
        public String size { get; set; }
        public ICollection<IFormFile> Url { set; get; }
    }
}
