using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ShopCarModel
{
    public class UserInfo
    {
        [Key]
        public int UId { get; set; }
        [Required(ErrorMessage ="不能为空！")]
        [StringLength(100)]
        public string UName { get; set; }
        [Required(ErrorMessage = "不能为空！")]
        [StringLength(100)]
        public string UPwd { get; set; }
        [Required(ErrorMessage = "不能为空！")]
        [StringLength(100)]
        public string URealName { get; set; }
        [Required(ErrorMessage = "不能为空！")]
        public int UIsAdmin { get; set; }//0位管理人

    }
}
