using ShopCarModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopCarUI.Controllers
{
    public class BaseController : Controller
    {
        public bool IsCheckLogin = true;

        public static UserInfo BaseUserInfo { get; set; }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);

            if (IsCheckLogin)
            {
                if (BaseUserInfo == null)
                {
                    filterContext.HttpContext.Response.Redirect("/Login/Index");
                }
            }
        }


        // GET: Base
        //    public ActionResult Index()
        //    {
        //        return View();
        //    }

    }
}