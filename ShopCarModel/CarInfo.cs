using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ShopCarModel
{
    public class CarInfo
    {
        [Key]
        public int CId { get; set; }
        [Required]
        [StringLength(100)]
        public string CName { get; set; }
        [Required]
        public double Cprice { get; set; }
    }
}
