using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopCarModel;
using ShopCarDAL;
using System.Linq.Expressions;

namespace ShopCarBLL
{
    public class OrderInfoBLL
    {
        OrderInfoDAL orderInfoDAL = new OrderInfoDAL();
        CarInfoDAL carInfoDAL=new CarInfoDAL();

        public  bool UpdateOrder(OrderInfo orderInfo)
        {
            orderInfo.DateTime = DateTime.Now;
            orderInfo.OState = 0;
            double cPrice = carInfoDAL.GetEntitys(c=>c.CId==orderInfo.CId).First().Cprice;
            orderInfo.OPrice = cPrice*orderInfo.ONumber;
            return orderInfoDAL.Update(orderInfo)>0;
        }

        public bool DoworkOrder(int id)
        {
            OrderInfo order = orderInfoDAL.GetEntitys(o=>o.OId==id).FirstOrDefault();
            order.OState = 1;
            return orderInfoDAL.Update(order) > 0;

        }

        public List<OrderInfo> GetAllModelList(Expression<Func<OrderInfo,bool>> lambdaWhere)
        {
            try
            {
                var res = orderInfoDAL.GetEntitys(lambdaWhere).ToList();
                return res;
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                string b = ex.StackTrace;
                return null;
            }
        
        }

        public bool DeleteOrder(int id)
        {
            return orderInfoDAL.Delete(id)>0;
        }

        public bool AddOrder(OrderInfo orderInfo)
        {
            orderInfo.DateTime = DateTime.Now;
            orderInfo.OState = 0;
            double cPrice = carInfoDAL.GetEntitys(c => c.CId == orderInfo.CId).First().Cprice;
            orderInfo.OPrice = cPrice * orderInfo.ONumber;
            return orderInfoDAL.Add(orderInfo) > 0;
        }
    }
}
