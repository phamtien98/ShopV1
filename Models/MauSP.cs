using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopV1.Models
{
    [Table("MauSP")]
    public partial class MauSP
    {
        public int Id { get; set; }
        public String IdSanpahm { get; set; }
        public string color { get; set; }
    }
}

