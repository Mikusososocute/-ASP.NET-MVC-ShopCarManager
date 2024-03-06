using ShopCarModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace ShopCarDAL
{
    public class BaseDAL<T> where T : class
    {
        CarContext carContext = new CarContext();

        public IQueryable<T> GetEntitys(Expression<Func<T,bool>> lambdaWhere) 
        {
            return carContext.Set<T>().Where(lambdaWhere);
        }

        public int Add(T entity)        
        {
            carContext.Set<T>().Add(entity);
            return carContext.SaveChanges();
        }

        public int Delete(int id)
        {
            T entity =carContext.Set<T>().Find(id);
            carContext.Set<T>().Remove(entity);
            return carContext.SaveChanges();
        }

        public int Update(T entity)
        {
            carContext.Entry(entity).State=System.Data.Entity.EntityState.Modified;
            return carContext.SaveChanges();
        }
    }
}
