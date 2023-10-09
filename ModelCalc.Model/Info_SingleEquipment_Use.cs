using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCalc.Model
{
    public class Info_SingleEquipment_Use
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public int SingleId { get; set; }
        [SugarColumn(IsNullable = true)]
        public int EquipmentTypeId { get; set; }
        public int BaseId { get; set; }

    }
}
