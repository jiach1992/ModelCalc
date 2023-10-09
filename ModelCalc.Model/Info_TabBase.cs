using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCalc.Model
{
    public class Info_TabBase
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string BaseName { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
