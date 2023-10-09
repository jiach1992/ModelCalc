using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCalc.Model
{
    public class Info_SingleEquipment
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int EquipmentType { get; set; }
        /// <summary>
        /// ke
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public double Restrict { get; set; }
        /// <summary>
        /// qiang
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public double Enhance { get; set; }
        /// <summary>
        /// jilv
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public double CriticalRate { get; set; }
        /// <summary>
        /// chengdu
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public double CriticalDegree { get; set; }
        /// <summary>
        /// hu
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public double Reduce { get; set; }
    }
}
