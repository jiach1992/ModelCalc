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
    public partial class TipProForm : UIForm
    {
        private static TipProForm Instance;
        public static TipProForm GetInstance()
        {
            if(Instance == null || Instance.IsDisposed)
            {
                Instance = new TipProForm();
            }
            Instance.TopMost = true;
            return Instance;
        }

        public void ShowTip(string txt, int pos_x, int pox_y)
        {
            this.lbl_con.Text = txt;
            this.Location = (new Point(pos_x - 10, pox_y - 10));
            this.Show();
        }
        

        private TipProForm()
        {
            InitializeComponent();
        }

        private void TipProForm_Load(object sender, EventArgs e)
        {
        }

        private void TipProForm_MouseLeave(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
