using Masuit.Tools;
using ModelCalc.App.Common;
using ModelCalc.App.EnumDir;
using ModelCalc.App.FormDir;
using ModelCalc.App.UserControls;
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

namespace ModelCalc.App
{
    public partial class MainForm : UIForm
    {
        BLL_TabBase bll_Tab = new BLL_TabBase();
        BLL_Equipment bll_equipment = new BLL_Equipment();
        BLL_SingleEquipment bLL_single_equipment = new BLL_SingleEquipment();
        BLL_SingleEquipment_Use bLL_singleequipment_use = new BLL_SingleEquipment_Use();
        Dictionary<int, DataTab_Item> dic_datatabs = new Dictionary<int, DataTab_Item>();
        int curr_tab_id = 0;

        TipProForm tip_form;
        public MainForm()
        {
            InitializeComponent();
            tip_form = TipProForm.GetInstance();
        }

        private void ShowTip(string txt)
        {
            
            tip_form.ShowTip(txt, Control.MousePosition.X, Control.MousePosition.Y);
        }
        private void HideTip()
        {
            tip_form.Hide();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadOthTab();
            LoadEquiment();
        }

        private void LoadOthTab()
        {
            var tab_list = bll_Tab.Query().Where(d => true).ToList();
            if (tab_list == null || tab_list.Count == 0)
            {
                return;
            }
            curr_tab_id = tab_list[0].Id;
            foreach (var tab in tab_list)
            {
                var equipment_list = bll_equipment.Query().Where(d => d.BaseId == tab.Id).ToList();
                if (equipment_list == null || equipment_list.Count == 0)
                {
                    continue;
                }
                var tab_con = new DataTab_Item(tab.Id, equipment_list)
                {
                    Dock = DockStyle.Fill
                };

                TabPage page = new TabPage(tab.BaseName);
                page.Tag = tab.Id;
                page.Controls.Add(tab_con);
                tab_container.TabPages.Add(page);

                dic_datatabs.Add(tab.Id, tab_con);
            }
        }

        private List<Info_Equipment> InitEquipment(int baseid)
        {
            List<Info_Equipment> equipment_list = new List<Info_Equipment>();
            foreach (var typeval in StaticHelper.GetEnumValList(typeof(EquipmentEnum)))
            {
                equipment_list.Add(new Info_Equipment
                {
                    EquipmentType = typeval,
                    BaseId = baseid
                });
            }

            bll_equipment.Insert(equipment_list);
            return bll_equipment.Query().Where(d => d.BaseId == baseid).ToList();
        }

        private void tool_add_Click(object sender, EventArgs e)
        {
            string sel = nav_zhuangbei.SelectedNode.Text;

            AddEquipmentForm addForm = new AddEquipmentForm(sel, 0);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadEquiment();
            }
        }

        private void LoadEquiment()
        {
            nav_zhuangbei.Nodes["node_sword"].Nodes.Clear();
            nav_zhuangbei.Nodes["node_card"].Nodes.Clear();
            nav_zhuangbei.Nodes["node_amulet"].Nodes.Clear();
            nav_zhuangbei.Nodes["node_necklace"].Nodes.Clear();
            nav_zhuangbei.Nodes["node_hat"].Nodes.Clear();
            nav_zhuangbei.Nodes["node_clothing"].Nodes.Clear();
            nav_zhuangbei.Nodes["node_stone"].Nodes.Clear();
            nav_zhuangbei.Nodes["node_shoot"].Nodes.Clear();

            var sel_ids = bLL_singleequipment_use.Query().Where(d => d.BaseId == curr_tab_id).Select(d => d.SingleId).ToList();

            var list = bLL_single_equipment.Query().ToList();
            foreach (var item in list)
            {
                bool is_use = sel_ids.Contains(item.Id);
                string last_name = is_use ? " - 已装备" : "";
                string name = $"{item.Name}{last_name}";
                switch ((EquipmentEnum)item.EquipmentType)
                {
                    case EquipmentEnum.武器:
                        nav_zhuangbei.Nodes["node_sword"].Nodes.Add(new TreeNode()
                        {
                            Text = name,
                            Tag = item.Id,
                            ContextMenuStrip = menu_update,
                            ForeColor = is_use ? Color.Black : Color.Red
                        });
                        break;
                    case EquipmentEnum.星卡:
                        nav_zhuangbei.Nodes["node_card"].Nodes.Add(new TreeNode()
                        {
                            Text = name,
                            Tag = item.Id,
                            ContextMenuStrip = menu_update,
                            ForeColor = is_use ? Color.Black : Color.Red
                        });
                        break;
                    case EquipmentEnum.护身符:
                        nav_zhuangbei.Nodes["node_amulet"].Nodes.Add(new TreeNode()
                        {
                            Text = name,
                            Tag = item.Id,
                            ContextMenuStrip = menu_update,
                            ForeColor = is_use ? Color.Black : Color.Red
                        });
                        break;
                    case EquipmentEnum.项链:
                        nav_zhuangbei.Nodes["node_necklace"].Nodes.Add(new TreeNode()
                        {
                            Text = name,
                            Tag = item.Id,
                            ContextMenuStrip = menu_update,
                            ForeColor = is_use ? Color.Black : Color.Red
                        });
                        break;
                    case EquipmentEnum.帽子:
                        nav_zhuangbei.Nodes["node_hat"].Nodes.Add(new TreeNode()
                        {
                            Text = name,
                            Tag = item.Id,
                            ContextMenuStrip = menu_update,
                            ForeColor = is_use ? Color.Black : Color.Red
                        });
                        break;
                    case EquipmentEnum.衣服:
                        nav_zhuangbei.Nodes["node_clothing"].Nodes.Add(new TreeNode()
                        {
                            Text = name,
                            Tag = item.Id,
                            ContextMenuStrip = menu_update,
                            ForeColor = is_use ? Color.Black : Color.Red
                        });
                        break;
                    case EquipmentEnum.石头:
                        nav_zhuangbei.Nodes["node_stone"].Nodes.Add(new TreeNode()
                        {
                            Text = name,
                            Tag = item.Id,
                            ContextMenuStrip = menu_update,
                            ForeColor = is_use ? Color.Black : Color.Red
                        });
                        break;
                    case EquipmentEnum.鞋:
                        nav_zhuangbei.Nodes["node_shoot"].Nodes.Add(new TreeNode()
                        {
                            Text = name,
                            Tag = item.Id,
                            ContextMenuStrip = menu_update,
                            ForeColor = is_use ? Color.Black : Color.Red
                        });
                        break;
                }
            }
            nav_zhuangbei.ExpandAll();
        }

        private void tool_use_Click(object sender, EventArgs e)
        {
            if(dic_datatabs.Count > 0 && curr_tab_id != 0)
            {
                int id = nav_zhuangbei.SelectedNode.Tag.ChangeTypeTo<int>();

                dic_datatabs[curr_tab_id].ChangeEquipment(id);
                LoadEquiment();
            }
        }

        private void tool_update_Click(object sender, EventArgs e)
        {
            string sel = nav_zhuangbei.SelectedNode.Parent.Text;
            int id = nav_zhuangbei.SelectedNode.Tag.ChangeTypeTo<int>();
            AddEquipmentForm addForm = new AddEquipmentForm(sel, id);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadEquiment();
            }
        }

        private void tool_del_Click(object sender, EventArgs e)
        {
            if (ShowAskDialog("提示", "确定删除此装备?", UIStyle.LayuiGreen, true))
            {
                int id = nav_zhuangbei.SelectedNode.Tag.ChangeTypeTo<int>();
                dic_datatabs[curr_tab_id].DeleteEquipment(id);
                LoadEquiment();
            }
        }

        private void btn_new_tab_Click(object sender, EventArgs e)
        {
            AddMenuTab tab = new AddMenuTab();
            if (!(tab.ShowDialog() == DialogResult.OK))
            {
                return;
            }
            var tab_model = bll_Tab.Query().Where(d => d.Id == tab.tab_id).First();
            if (tab_model == null)
            {
                return;
            }

            var list = InitEquipment(tab_model.Id);

            var tab_con = new DataTab_Item(tab.tab_id, list)
            {
                Dock = DockStyle.Fill
            };

            TabPage page = new TabPage(tab_model.BaseName);
            page.Tag = tab_model.Id;
            page.Controls.Add(tab_con);
            tab_container.TabPages.Add(page);
            tab_container.SelectedTab = page;

            dic_datatabs.Add(tab_model.Id, tab_con);
            curr_tab_id = tab_model.Id;
        }

        private void tab_container_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curr_page = tab_container.SelectedTab;
            if(curr_page == null)
            {
                curr_tab_id = 0;
            }
            else
            {
                curr_tab_id = curr_page.Tag.ChangeTypeTo<int>();
            }
            LoadEquiment();

        }

        private bool tab_container_BeforeRemoveTabPage(object sender, int index)
        {
            if(!ShowAskDialog("提示", "确定删除此标签页?", UIStyle.LayuiGreen))
            {
                return false;
            }
            bll_Tab.Delete(d => d.Id == curr_tab_id);
            dic_datatabs.Remove(curr_tab_id);


            return true;
        }

        private void nav_zhuangbei_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           if( e.Button != MouseButtons.Left)
            {
                return;
            }

            if (e.Node.Parent == null)
            {
                return;
            }
            int id = e.Node.Tag.ChangeTypeTo<int>();
            var equ = bLL_single_equipment.Query().Where(d => d.Id == id).First();
            if (equ != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("属性:\r\n");
                if (equ.Reduce != 0)
                {
                    sb.Append($"  忽视: {equ.Reduce}\r\n\r\n");
                }
                if (equ.Enhance != 0)
                {
                    sb.Append($"  强法: {equ.Enhance}\r\n\r\n");
                }
                if (equ.Restrict != 0)
                {
                    sb.Append($"  强克: {equ.Restrict}\r\n\r\n");
                }
                if (equ.CriticalRate != 0)
                {
                    sb.Append($"  狂暴几率: {equ.CriticalRate}\r\n\r\n");
                }
                if (equ.CriticalDegree != 0)
                {
                    sb.Append($"  狂暴程度: {equ.CriticalDegree} \r\n\r\n");
                }

                ShowTip(sb.ToString());
            }
        }

        private void nav_zhuangbei_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {
            
        }
    }
}
