using Masuit.Tools.Systems;
using ModelCalc.App.EnumDir;
using ModelCalc.DataAccess;
using ModelCalc.Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelCalc.App.FormDir
{
    public partial class AddEquipmentForm : UIForm
    {
        private readonly string name;
        private readonly int id;
        BLL_SingleEquipment bll_single_equipment = new BLL_SingleEquipment();
        Info_SingleEquipment model = null;
        int equipment_enum_val;
        public AddEquipmentForm(string name, int id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            if (id == 0)
            {
                this.Text = $"添加 - {name}";
            }
            else
            {
                this.Text = $"编辑 - {name}";
            }
            equipment_enum_val = (int)(EquipmentEnum)Enum.Parse(typeof(EquipmentEnum), name);
        }

        private void AddEquipmentForm_Load(object sender, EventArgs e)
        {
            model = bll_single_equipment.Query().Where(d => d.Id == id).First();
            if (model != null)
            {
                txt_name.Text = model.Name;
                txt_hu.DoubleValue = model.Reduce;
                txt_qiang.DoubleValue = model.Enhance;
                txt_ke.DoubleValue = model.Restrict;
                txt_rate.DoubleValue = model.CriticalRate;
                txt_chengdu.DoubleValue = model.CriticalDegree;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_name.Text))
            {
                ShowErrorTip(txt_name, "名称不能为空");
                return;
            }

            model = model == null ? new Info_SingleEquipment() { Id = 0 } : model;

            model.Name = txt_name.Text;
            model.EquipmentType = equipment_enum_val;
            model.Reduce = txt_hu.DoubleValue;
            model.Enhance = txt_qiang.DoubleValue;
            model.Restrict = txt_ke.DoubleValue;
            model.CriticalRate = txt_rate.DoubleValue;
            model.CriticalDegree = txt_chengdu.DoubleValue;

            if (model.Id == 0)
            {
                bll_single_equipment.Insert(model);
            }
            else
            {
                bll_single_equipment.Update(model);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
