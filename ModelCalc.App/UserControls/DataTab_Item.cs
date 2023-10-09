using Masuit.Tools;
using ModelCalc.App.EnumDir;
using ModelCalc.App.ViewModels;
using ModelCalc.DataAccess;
using ModelCalc.Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelCalc.App.UserControls
{
    public partial class DataTab_Item : UIUserControl
    {
        private List<Info_Equipment> equ_list;
        private int base_id;
        BLL_Equipment bll_equipment = new BLL_Equipment();
        BLL_Person bll_person = new BLL_Person();
        BLL_SingleEquipment bLL_singleequipment = new BLL_SingleEquipment();
        BLL_SingleEquipment_Use bLL_singleequipment_use = new BLL_SingleEquipment_Use();
        IniFile config = new IniFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini"), Encoding.UTF8);
        Info_Person person_1 = null;
        Info_Person person_2 = null;
        public DataTab_Item(int base_id, List<Info_Equipment> equ_list = null)
        {
            InitializeComponent();
            this.equ_list = equ_list;
            this.base_id = base_id;
        }

        private void DataTab_Item_Load(object sender, EventArgs e)
        {
            InitRowHead();
            if (equ_list != null && equ_list.Count > 0)
            {
                foreach (var item in equ_list)
                {
                    InsertData(item);
                }
            }
            InitPerson();
            ReadPerson();
            CalcSum();
            CalcDamage();
        }

        private void ReadPerson()
        {
            cbx_isfei_1.Text = person_1.IsFei;
            txt_shulian_1.IntValue = person_1.ShuLian;
            txt_level_1.IntValue = person_1.Level;
            txt_wuxing_1.IntValue = person_1.Wuxing;
            txt_ling_1.IntValue = person_1.Lingxing;
            txt_zhongzu_1.Text = person_1.Zhongzu;
            txt_kangxing_1.DoubleValue = person_1.EnemyKang;
            txt_wuxing_enemy_1.IntValue = person_1.EnemyWuXing;

            cbx_isfei_2.Text = person_2.IsFei;
            txt_shulian_2.IntValue = person_2.ShuLian;
            txt_level_2.IntValue = person_2.Level;
            txt_wuxing_2.IntValue = person_2.Wuxing;
            txt_ling_2.IntValue = person_2.Lingxing;
            txt_zhongzu_2.Text = person_2.Zhongzu;

            txt_kangxing_2.DoubleValue = person_2.EnemyKang;
            txt_wuxing_enemy_2.IntValue = person_2.EnemyWuXing;
        }

        private void UpdatePerson()
        {
            if (person_1 != null)
            {
                person_1.IsFei = cbx_isfei_1.Text;
                person_1.ShuLian = txt_shulian_1.IntValue;
                person_1.Level = txt_level_1.IntValue;
                person_1.Wuxing = txt_wuxing_1.IntValue;
                person_1.Lingxing = txt_ling_1.IntValue;
                person_1.Zhongzu = txt_zhongzu_1.Text;
                person_1.EnemyKang = txt_kangxing_1.DoubleValue;
                person_1.EnemyWuXing = txt_wuxing_enemy_1.IntValue;
                bll_person.Update(person_1);
            }

            if (person_2 != null)
            {
                person_2.IsFei = cbx_isfei_2.Text;
                person_2.ShuLian = txt_shulian_2.IntValue;
                person_2.Level = txt_level_2.IntValue;
                person_2.Wuxing = txt_wuxing_2.IntValue;
                person_2.Lingxing = txt_ling_2.IntValue;
                person_2.Zhongzu = txt_zhongzu_2.Text;
                person_2.EnemyKang = txt_kangxing_2.DoubleValue;
                person_2.EnemyWuXing = txt_wuxing_enemy_2.IntValue;
                bll_person.Update(person_2);
            }

        }

        private void InitPerson()
        {
            var person_list = bll_person.Query().Where(d => d.BaseId == base_id).ToList();
            if (person_list.Count != 2)
            {
                bll_person.Delete(d => d.BaseId == base_id);

                Info_Person person_1 = new Info_Person();
                person_1.BaseId = base_id;
                person_1.IsFei = config.ReadString("Person_1", "IsFei", "飞升");
                person_1.ShuLian = config.ReadInt("Person_1", "ShuLian", 25000);
                person_1.Level = config.ReadInt("Person_1", "Level", 140);
                person_1.Wuxing = config.ReadInt("Person_1", "Wuxing", 25000);
                person_1.Lingxing = config.ReadInt("Person_1", "Lingxing", 25000);
                person_1.Zhongzu = config.ReadString("Person_1", "Zhongzu", "仙族");
                person_1.EnemyKang = config.ReadDouble("Person_1", "EnemyKang", 20);
                person_1.EnemyWuXing = config.ReadInt("Person_1", "EnemyWuXing", 50);

                Info_Person person_2 = new Info_Person();
                person_2.BaseId = base_id;
                person_2.IsFei = config.ReadString("Person_2", "IsFei", "飞升");
                person_2.ShuLian = config.ReadInt("Person_2", "ShuLian", 25000);
                person_2.Level = config.ReadInt("Person_2", "Level", 140);
                person_2.Wuxing = config.ReadInt("Person_2", "Wuxing", 25000);
                person_2.Lingxing = config.ReadInt("Person_2", "Lingxing", 25000);
                person_2.Zhongzu = config.ReadString("Person_2", "Zhongzu", "仙族");
                person_2.EnemyKang = config.ReadDouble("Person_2", "EnemyKang", 20);
                person_2.EnemyWuXing = config.ReadInt("Person_2", "EnemyWuXing", 50);

                bll_person.Insert(new List<Info_Person>() { person_1, person_2 });

                this.person_1 = person_1;
                this.person_2 = person_2;
            }

            else
            {
                this.person_1 = person_list[0];
                this.person_2 = person_list[1];
            }
        }

        private void InitRowHead()
        {
            dgv_data.AddRow("武器");
            dgv_data.AddRow("星卡");
            dgv_data.AddRow("护身符");
            dgv_data.AddRow("项链");
            dgv_data.AddRow("帽子");
            dgv_data.AddRow("衣服");
            dgv_data.AddRow("石头");
            dgv_data.AddRow("鞋");
            dgv_data.AddRow("套装");
            dgv_data.AddRow("其他");
            dgv_data.AddRow("总和");
        }

        private void InsertData(Info_Equipment equipment)
        {
            int row_inx = GetRowInxOfEuqipment((EquipmentEnum)equipment.EquipmentType);
            if (row_inx == -1)
            {
                return;
            }
            dgv_data.Rows[row_inx].Tag = equipment.Id;

            var reduce_col = 1;
            var enhance_col = 2;
            var restrict_col = 3;
            var rate_col = 4;
            var degree_col = 5;

            dgv_data.Rows[row_inx].Cells[reduce_col].Value = equipment.Reduce;
            dgv_data.Rows[row_inx].Cells[enhance_col].Value = equipment.Enhance;
            dgv_data.Rows[row_inx].Cells[restrict_col].Value = equipment.Restrict;
            dgv_data.Rows[row_inx].Cells[rate_col].Value = equipment.CriticalRate;
            dgv_data.Rows[row_inx].Cells[degree_col].Value = equipment.CriticalDegree;
        }
        private int GetRowInxOfEuqipment(EquipmentEnum equipmentEnum)
        {
            int row_id = -1;
            switch (equipmentEnum)
            {
                case EquipmentEnum.武器:
                    row_id = 0;

                    break;
                case EquipmentEnum.星卡:
                    row_id = 1;
                    break;
                case EquipmentEnum.护身符:
                    row_id = 2;
                    break;
                case EquipmentEnum.项链:
                    row_id = 3;
                    break;
                case EquipmentEnum.帽子:
                    row_id = 4;
                    break;
                case EquipmentEnum.衣服:
                    row_id = 5;
                    break;
                case EquipmentEnum.石头:
                    row_id = 6;
                    break;
                case EquipmentEnum.鞋:
                    row_id = 7;
                    break;
                case EquipmentEnum.套装:
                    row_id = 8;
                    break;
                case EquipmentEnum.其他:
                    row_id = 9;
                    break;
            }
            return row_id;
        }

        public void DeleteEquipment(int single_id)
        {
            var single = bLL_singleequipment.Query().Where(d => d.Id == single_id).First();
            if (single == null)
            {
                return;
            }

            var equ_type = (EquipmentEnum)single.EquipmentType;
            var row_inx = GetRowInxOfEuqipment(equ_type);

            if (bLL_singleequipment_use.Query().Any(d => d.SingleId == single_id && d.BaseId == base_id))
            {
                var reduce_col = 1;
                var enhance_col = 2;
                var restrict_col = 3;
                var rate_col = 4;
                var degree_col = 5;

                dgv_data.Rows[row_inx].Cells[reduce_col].Value = 0;
                dgv_data.Rows[row_inx].Cells[enhance_col].Value = 0;
                dgv_data.Rows[row_inx].Cells[restrict_col].Value = 0;
                dgv_data.Rows[row_inx].Cells[rate_col].Value = 0;
                dgv_data.Rows[row_inx].Cells[degree_col].Value = 0;
            }

            

            int? equipment_id = dgv_data.Rows[row_inx].Tag?.ToString().ToInt32();
            if (equipment_id != null)
            {
                var equipment = bll_equipment.Query().Where(d => d.Id == equipment_id).First();
                UpdateEquipment(equipment, row_inx);
            }
            bLL_singleequipment.Delete(single);
            CalcSum();
            CalcDamage();
        }

        private void dgv_data_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcSum();

            int? equipment_id = dgv_data.Rows[e.RowIndex].Tag?.ToString().ToInt32();
            if (equipment_id != null)
            {
                var equipment_model = bll_equipment.Query().Where(d => d.Id == equipment_id).First();
                UpdateEquipment(equipment_model, e.RowIndex);
            }
            CalcDamage();
        }
        private void UpdateEquipment(Info_Equipment equipment_model, int row_inx)
        {

            var reduce_col = 1;
            var enhance_col = 2;
            var restrict_col = 3;
            var rate_col = 4;
            var degree_col = 5;

            if (equipment_model != null)
            {
                double? reduce = dgv_data.Rows[row_inx].Cells[reduce_col].Value?.ChangeTypeTo<double>();
                double? enhance = dgv_data.Rows[row_inx].Cells[enhance_col].Value?.ChangeTypeTo<double>();
                double? restrict = dgv_data.Rows[row_inx].Cells[restrict_col].Value?.ChangeTypeTo<double>();
                double? rate = dgv_data.Rows[row_inx].Cells[rate_col].Value?.ChangeTypeTo<double>();
                double? degree = dgv_data.Rows[row_inx].Cells[degree_col].Value?.ChangeTypeTo<double>();

                equipment_model.Reduce = reduce ?? 0;
                equipment_model.Enhance = enhance ?? 0;
                equipment_model.Restrict = restrict ?? 0;
                equipment_model.CriticalRate = rate ?? 0;
                equipment_model.CriticalDegree = degree ?? 0;
                bll_equipment.Update(equipment_model);
            }

        }

        private void CalcDamage()
        {
            Info_Equipment equipment = new Info_Equipment();
            equipment.Reduce = dgv_data.Rows[10].Cells[1].Value?.ChangeTypeTo<double>() ?? 0;
            equipment.Enhance = dgv_data.Rows[10].Cells[2].Value?.ChangeTypeTo<double>() ?? 0;
            equipment.Restrict = dgv_data.Rows[10].Cells[3].Value?.ChangeTypeTo<double>() ?? 0;
            equipment.CriticalRate = dgv_data.Rows[10].Cells[4].Value?.ChangeTypeTo<double>() ?? 0;
            equipment.CriticalDegree = dgv_data.Rows[10].Cells[5].Value?.ChangeTypeTo<double>() ?? 0;

            // No.1
            var damage_1 = GetCalcDamage(cbx_isfei_1.SelectedText == "飞升", txt_level_1.IntValue, txt_shulian_1.IntValue, txt_wuxing_1.IntValue, txt_zhongzu_1.SelectedText, txt_kangxing_1.IntValue, txt_wuxing_enemy_1.IntValue, equipment);

            // No.2
            var damage_2 = GetCalcDamage(cbx_isfei_2.SelectedText == "飞升", txt_level_2.IntValue, txt_shulian_2.IntValue, txt_wuxing_2.IntValue, txt_zhongzu_2.SelectedText, txt_kangxing_2.IntValue, txt_wuxing_enemy_2.IntValue, equipment);
            lbl_damage_1.Text = $"平秒: {damage_1.Normal.ToString("0.00")}";
            lbl_damage_pro_1.Text = $"狂暴: {damage_1.Pro.ToString("0.00")}";
            lbl_avg_1.Text = $"平均: {GetAvgDamage(damage_1, equipment.CriticalRate)}";

            lbl_damage_2.Text = $"平秒: {damage_2.Normal.ToString("0.00")}";
            lbl_damage_pro_2.Text = $"狂暴: {damage_2.Pro.ToString("0.00")}";
            lbl_avg_2.Text = $"平均: {GetAvgDamage(damage_2, equipment.CriticalRate)}";
        }
        private string GetAvgDamage(DamageModel damage, double rate)
        {
            rate = rate / 100;
            return (damage.Normal * (1 - rate) + damage.Pro * rate).ToString("0.00");
        }

        private DamageModel GetCalcDamage(bool isfei, int level, int shulian, int wuxing, string zhongzu, double enemy_kangxing, int enemy_wuxing, Info_Equipment equipment)
        {
            if (isfei)
            {
                level = level < 180 ? 180 : level;
            }
            double damage_base = GetBaseDamage(level, shulian);
            if (zhongzu == "鬼族")
            {
                damage_base = damage_base * 0.7;
            }
            double ratio_ke = equipment.Restrict / 100 * (enemy_wuxing / 100.0) + 1;
            double ratio_qiang = equipment.Enhance / 100 + 1;
            double ratio_wuxing = (wuxing / 100.0) * (enemy_wuxing / 100.0) * 0.4 + 1;
            double ratio_hu = (equipment.Reduce - enemy_kangxing) / 100 + 1;

            double ratio = ratio_ke * ratio_qiang * ratio_wuxing * ratio_hu;


            DamageModel damage = new DamageModel();
            damage.Normal = damage_base * ratio;
            damage.Pro = damage_base * ratio * (1.5 + equipment.CriticalDegree / 100);
            return damage;
        }

        private double GetBaseDamage(int level, double shulian)
        {
            double xishu = Math.Pow(shulian, 0.005) - 1;
            xishu = xishu <= 0 ? 0 : xishu;
            return level / 100.0 * (Math.Pow(shulian, 0.4) - xishu) * 173.276 + level * 60;
        }
        private void CalcSum()
        {
            for (int i = 1; i < dgv_data.ColumnCount; i++)
            {
                double? row0 = dgv_data.Rows[0].Cells[i].Value?.ChangeTypeTo<double>();
                double? row1 = dgv_data.Rows[1].Cells[i].Value?.ChangeTypeTo<double>();
                double? row2 = dgv_data.Rows[2].Cells[i].Value?.ChangeTypeTo<double>();
                double? row3 = dgv_data.Rows[3].Cells[i].Value?.ChangeTypeTo<double>();
                double? row4 = dgv_data.Rows[4].Cells[i].Value?.ChangeTypeTo<double>();
                double? row5 = dgv_data.Rows[5].Cells[i].Value?.ChangeTypeTo<double>();
                double? row6 = dgv_data.Rows[6].Cells[i].Value?.ChangeTypeTo<double>();
                double? row7 = dgv_data.Rows[7].Cells[i].Value?.ChangeTypeTo<double>();
                double? row8 = dgv_data.Rows[8].Cells[i].Value?.ChangeTypeTo<double>();
                double? row9 = dgv_data.Rows[9].Cells[i].Value?.ChangeTypeTo<double>();

                double res = (row0 ?? 0)
                    + (row1 ?? 0)
                    + (row2 ?? 0)
                    + (row3 ?? 0)
                    + (row4 ?? 0)
                    + (row5 ?? 0)
                    + (row6 ?? 0)
                    + (row7 ?? 0)
                    + (row8 ?? 0)
                    + (row9 ?? 0);
                dgv_data.Rows[10].Cells[i].Style.Font = new Font(dgv_data.DefaultCellStyle.Font.FontFamily, 15, FontStyle.Bold);
                dgv_data.Rows[10].Cells[i].Value = res;
            }
        }

        public void ChangeEquipment(int single_id)
        {
            var single = bLL_singleequipment.Query().Where(d => d.Id == single_id).First();
            if (single == null)
            {
                return;
            }
            var equ_type = (EquipmentEnum)single.EquipmentType;
            var row_inx = GetRowInxOfEuqipment(equ_type);
            var reduce_col = 1;
            var enhance_col = 2;
            var restrict_col = 3;
            var rate_col = 4;
            var degree_col = 5;

            dgv_data.Rows[row_inx].Cells[reduce_col].Value = single.Reduce;
            dgv_data.Rows[row_inx].Cells[enhance_col].Value = single.Enhance;
            dgv_data.Rows[row_inx].Cells[restrict_col].Value = single.Restrict;
            dgv_data.Rows[row_inx].Cells[rate_col].Value = single.CriticalRate;
            dgv_data.Rows[row_inx].Cells[degree_col].Value = single.CriticalDegree;

            int? equipment_id = dgv_data.Rows[row_inx].Tag?.ToString().ToInt32();
            if (equipment_id != null)
            {
                var equipment = bll_equipment.Query().Where(d => d.Id == equipment_id).First();

                UpdateEquipment(equipment, row_inx);

                bLL_singleequipment_use.Delete(d => d.BaseId == base_id && d.EquipmentTypeId == single.EquipmentType);
                bLL_singleequipment_use.Insert(new Info_SingleEquipment_Use
                {
                    BaseId = base_id,
                    EquipmentTypeId = single.EquipmentType,
                    SingleId = single.Id
                });

            }
            CalcSum();
            CalcDamage();

        }

        #region change_person
        private void cbx_isfei_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }
        private void txt_shulian_1_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_level_1_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_wuxing_1_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_ling_1_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_zhongzu_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }
        private void cbx_isfei_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }
        private void txt_shulian_2_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_level_2_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_wuxing_2_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_ling_2_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_zhongzu_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_kangxing_1_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_wuxing_enemy_1_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_kangxing_2_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }

        private void txt_wuxing_enemy_2_TextChanged(object sender, EventArgs e)
        {
            UpdatePerson();
            CalcDamage();
        }
        #endregion
    }
}
