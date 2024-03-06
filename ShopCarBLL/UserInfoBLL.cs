using ShopCarModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopCarDAL;
using System.Linq.Expressions;



namespace ShopCarBLL
{

    public class UserInfoBLL
    {
        UserInfoDAL userInfoDAL= new UserInfoDAL();

        public bool SubAddUser(UserInfo user)
        {
            user.UIsAdmin = 1;
            return userInfoDAL.Add(user) > 0;
        }

        public  UserInfo CheckLogin(UserInfo userInfo)
        {
            return userInfoDAL.GetEntitys(u=>u.UName==userInfo.UName&&u.UPwd==userInfo.UPwd).FirstOrDefault();
        }

        public List<UserInfo> GetAllModelList(Expression<Func<UserInfo,bool>> lambdaWhere) 
        {
            return userInfoDAL.GetEntitys(lambdaWhere).ToList();
        }
    }
}
