using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCalc.Model
{
    public class Info_Person
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public int BaseId { get; set; }
        [SugarColumn(IsNullable = true)]
        public string IsFei { get; set; }
        [SugarColumn(IsNullable = true)]
        public int ShuLian { get; set; }
        [SugarColumn(IsNullable = true)]
        public int Level { get; set; }
        [SugarColumn(IsNullable = true)]
        public int Wuxing { get; set; }
        [SugarColumn(IsNullable = true)]
        public int Lingxing { get; set; }
        [SugarColumn(IsNullable = true)]
        public string Zhongzu { get; set; }
        [SugarColumn(IsNullable = true)]
        public double EnemyKang { get; set; }
        [SugarColumn(IsNullable = true)]
        public int EnemyWuXing { get; set; }

    }
}
