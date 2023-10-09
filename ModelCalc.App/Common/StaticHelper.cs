using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCalc.App.Common
{
    public class StaticHelper
    {
        public static List<int> GetEnumValList(Type type)
        {
            List<int> list = new List<int>();
            foreach (var item in Enum.GetValues(type))
            {
                list.Add(Convert.ToInt32(item));
            }
            return list;
        }
    }
}
