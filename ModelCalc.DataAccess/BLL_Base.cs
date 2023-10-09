using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ModelCalc.DataAccess
{
    public class BLL_Base<T> where T : class, new()
    {
        public static SqlSugarScope Db = SqlSugarOrm.Db;


        public int Insert(T t)
        {
            return Db.Insertable(t).ExecuteReturnIdentity();
        }

        public int Insert(List<T> t)
        {
            return Db.Insertable(t).ExecuteReturnIdentity();
        }
        public ISugarQueryable<T> Query()
        {
            return Db.Queryable<T>();
        }

        public int Delete(T t)
        {
            return Db.Deleteable(t).ExecuteCommand();
        }

        public int Delete(Expression<Func<T, bool>> expression)
        {
            return Db.Deleteable<T>(expression).ExecuteCommand();
        }

        public int Update(T t)
        {
            return Db.Updateable(t).ExecuteCommand();
        }

        public IUpdateable<T> Updateable()
        {
            return Db.Updateable<T>();
        }
    }
}
