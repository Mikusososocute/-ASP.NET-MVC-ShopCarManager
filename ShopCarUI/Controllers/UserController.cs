using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopCarModel;
using ShopCarBLL;

namespace ShopCarUI.Controllers
{
    public class UserController : BaseController
    {
        OrderInfoBLL orderInfoBLL=new OrderInfoBLL();
        CarInfoBLL carInfoBLL=new CarInfoBLL();

        // GET: User
        public ActionResult Index()
        {
            ViewData.Model = orderInfoBLL.GetAllModelList(o => o.UId == BaseUserInfo.UId);
            return View();
        }

        public ActionResult UpdateOrder(int id)
        {
            OrderInfo order = orderInfoBLL.GetAllModelList(o => o.OId == id)[0];
            List <CarInfo> list = carInfoBLL.GetAllModelList(c => true);
            ViewBag.CId = new SelectList(list,"CId","CName",order.CId);
            ViewData.Model =order;
            return View();
        }

        public string SubUpdateOrder(OrderInfo orderInfo)
        {
            orderInfo.UId = BaseUserInfo.UId;
            if(orderInfoBLL.UpdateOrder(orderInfo))
            {
                return "ok";
            }
            return "";
        }

        public string DeleteOrder(int id)
        {
            if (orderInfoBLL.DeleteOrder(id))
            {
                return "ok";
            }
            return "";
        }

        public ActionResult AddOrder( )
        {
            List<CarInfo> list = carInfoBLL.GetAllModelList(c => true);
            ViewBag.CId = new SelectList(list, "CId", "CName");
            return View();
        }

        [HttpPost]
        public string SubAddOrder(OrderInfo orderInfo)
        {
            orderInfo.UId = BaseUserInfo.UId;
            if (orderInfoBLL.AddOrder(orderInfo))
            {
                return "ok";
            }
            return "";
        }
    }
}