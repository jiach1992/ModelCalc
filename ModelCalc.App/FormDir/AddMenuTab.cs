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
    public partial class AddMenuTab : UIForm
    {
        BLL_TabBase bll_tab = new BLL_TabBase();
        Info_TabBase tab_model = new Info_TabBase();
        public int tab_id;
        public AddMenuTab(int id = 0)
        {
            InitializeComponent();

            tab_model = bll_tab.Query().Where(d => d.Id == id).First();
            if(tab_model != null)
            {
                txt_name.Text = tab_model.BaseName;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_name.Text) || txt_name.Text == "默认")
            {
                ShowErrorTip(txt_name, "名称格式错误");
                return;
            }

            if(tab_model == null)
            {
                tab_model = new Info_TabBase();
                tab_model.BaseName = txt_name.Text;
                tab_model.CreateTime = DateTime.Now;
                tab_id = bll_tab.Insert(tab_model);
            }
            else
            {
                tab_model.BaseName = txt_name.Text;
                tab_id = tab_model.Id;
                bll_tab.Update(tab_model);
            }

            this.DialogResult = DialogResult.OK;

        }
    }
}
