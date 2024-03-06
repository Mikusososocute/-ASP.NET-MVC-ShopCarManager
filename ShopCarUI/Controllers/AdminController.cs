using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopCarBLL;
using ShopCarModel;

namespace ShopCarUI.Controllers
{
    public class AdminController : BaseController
    {
        UserInfoBLL userInfoBLL = new UserInfoBLL();
        OrderInfoBLL orderInfoBLL = new OrderInfoBLL();
        // GET: Admin
        public ActionResult Index()
        {
            ViewData.Model = userInfoBLL.GetAllModelList(u => u.UIsAdmin == 1);
            return View();
        }

        public ActionResult AddUser() 
        {
            return View();
        }

        public string SubAddUser(UserInfo user)
        {
            if (userInfoBLL.SubAddUser(user))
            {
                return "ok";

            }
                return " ";
            
        }

        public ActionResult ShowOrder(int id)
        {
            ViewData.Model = orderInfoBLL.GetAllModelList(o => o.UId == id);
            return View();
        }

        public ActionResult DoworkOrder(int id)
        {
            if (orderInfoBLL.DoworkOrder(id))
            {
                return Content("ok");
            }
            else
            {
                return Content("");
            }
        }
    }
}