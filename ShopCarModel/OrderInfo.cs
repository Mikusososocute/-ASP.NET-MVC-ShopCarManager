using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopCarModel
{
    public class OrderInfo
    {
        [Key]
        public int OId { get; set; }
        [ForeignKey("CarInfo")]
        [Required]
        public int CId { get; set; }
        [Required]
        public int UId { get; set; }
        [Required]
        public int ONumber { get; set; }
        [Required]
        public double OPrice { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        
        [StringLength(200)]
        public string ORemark { get; set; }
        [Required]
        public int OState { get; set; }//0为已下单，1为已完成

        public virtual CarInfo CarInfo { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
