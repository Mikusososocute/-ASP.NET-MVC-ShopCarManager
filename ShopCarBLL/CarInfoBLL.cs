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
    public class CarInfoBLL
    {
        CarInfoDAL carInfoDAL= new CarInfoDAL();
        public List<CarInfo> GetAllModelList(Expression<Func<CarInfo, bool>> lambdaWhere)
        {
            return carInfoDAL.GetEntitys(lambdaWhere).ToList();
        }
    }
}
