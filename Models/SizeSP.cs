using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopV1.Models
{
    [Table("SizeSP")]
    public  partial class SizeSP
    {
        public int Id { get; set; }
        public String IdSanpahm { get; set; }
        public string size { get; set; }
    }
}
