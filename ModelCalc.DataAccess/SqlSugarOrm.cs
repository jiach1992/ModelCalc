using ModelCalc.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCalc.DataAccess
{
    public class SqlSugarOrm
    {
        private static string ConnStr = $"DataSource={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", ConfigurationManager.ConnectionStrings["SqlStr"].ConnectionString)}";
        public static SqlSugarScope Db = new SqlSugarScope(new ConnectionConfig
        {
            ConnectionString = ConnStr,
            DbType = DbType.Sqlite,
            IsAutoCloseConnection = true
        });


        static SqlSugarOrm()
        {
            Type[] types = typeof(Info_TabBase).Assembly.GetTypes()
            .Where(it => it.FullName.Contains("ModelCalc.Model.") && !it.FullName.Contains(".View_"))//命名空间过滤，当然你也可以写其他条件过滤
            .ToArray();
            Db.CodeFirst.SetStringDefaultLength(255).InitTables(types);//根据types创建表
        }
    }
}
