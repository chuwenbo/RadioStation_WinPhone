using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chu.RadioStation.IsolatedStorage
{
    public class BaseService<T> where T : class
    {
        public void Add(T entity)
        {
            using (RadioContext context = new RadioContext())
            {
                context.GetTable<T>().InsertOnSubmit(entity);
                context.SubmitChanges(); 
            }
        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
            using (RadioContext context = new RadioContext())
            {
                return context.GetTable<T>().FirstOrDefault(predicate);
            }
        }

        public List<T> FindAll(Expression<Func<T, bool>> predicate)
        {
            using (RadioContext context = new RadioContext())
            {
                return context.GetTable<T>().Where(predicate).ToList();
            }
        }

        public void DeleteAll(Expression<Func<T, bool>> predicate)
        {
            using (RadioContext context = new RadioContext())
            {
                var entitys = context.GetTable<T>().Where(predicate).ToList();

                if(entitys != null && entitys.Count>0)
                {
                    context.GetTable<T>().DeleteAllOnSubmit(entitys);
                    context.SubmitChanges();
                } 
            }
        }
    }
}
