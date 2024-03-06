using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopCarModel;
using ShopCarBLL;

namespace ShopCarUI.Controllers
{
    public class LoginController : BaseController
    {
        public LoginController() 
        {
            IsCheckLogin = false;
        }

        UserInfoBLL userInfoBLL=new UserInfoBLL();
        // GET: Login
        public ActionResult Index()
        {
            CarContext carContext = new CarContext();
            carContext.UserInfos.ToList();
            return View();
        }

        public string CheckLogin(UserInfo userInfo)
        {
            UserInfo user = userInfoBLL.CheckLogin(userInfo);
            if (user == null)
            {
                return " ";
            }

            BaseUserInfo = user;

            return user.UIsAdmin.ToString();

        }
    }
}