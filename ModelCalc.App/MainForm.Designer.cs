
namespace ModelCalc.App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("武器", 0, 0);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("星卡", 1, 1);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("护身符", 4, 4);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("项链", 7, 7);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("帽子", 5, 5);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("衣服", 3, 3);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("石头", 2, 2);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("鞋", 8, 8);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu_add = new Sunny.UI.UIContextMenuStrip();
            this.tool_add = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.tab_container = new Sunny.UI.UITabControl();
            this.nav_zhuangbei = new Sunny.UI.UINavMenu();
            this.img_nav = new System.Windows.Forms.ImageList(this.components);
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_update = new Sunny.UI.UIContextMenuStrip();
            this.tool_use = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_update = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_del = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_new_tab = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.menu_add.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.menu_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_add
            // 
            this.menu_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.menu_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.menu_add.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_add.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_add});
            this.menu_add.Name = "menu_add";
            this.menu_add.Size = new System.Drawing.Size(119, 28);
            this.menu_add.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.menu_add.StyleCustomMode = true;
            // 
            // tool_add
            // 
            this.tool_add.Name = "tool_add";
            this.tool_add.Size = new System.Drawing.Size(118, 24);
            this.tool_add.Text = "添加";
            this.tool_add.Click += new System.EventHandler(this.tool_add_Click);
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Controls.Add(this.tab_container, 1, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.nav_zhuangbei, 0, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(2, 36);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 1;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1443, 962);
            this.uiTableLayoutPanel1.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.uiTableLayoutPanel1.TabIndex = 0;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // tab_container
            // 
            this.tab_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_container.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tab_container.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tab_container.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_container.ItemSize = new System.Drawing.Size(150, 40);
            this.tab_container.Location = new System.Drawing.Point(353, 3);
            this.tab_container.MainPage = "";
            this.tab_container.MenuStyle = Sunny.UI.UIMenuStyle.White;
            this.tab_container.Name = "tab_container";
            this.tab_container.SelectedIndex = 0;
            this.tab_container.ShowCloseButton = true;
            this.tab_container.Size = new System.Drawing.Size(1087, 956);
            this.tab_container.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_container.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.tab_container.StyleCustomMode = true;
            this.tab_container.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tab_container.TabIndex = 0;
            this.tab_container.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tab_container.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tab_container.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tab_container.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tab_container.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_container.BeforeRemoveTabPage += new Sunny.UI.UITabControl.OnBeforeRemoveTabPage(this.tab_container_BeforeRemoveTabPage);
            this.tab_container.SelectedIndexChanged += new System.EventHandler(this.tab_container_SelectedIndexChanged);
            // 
            // nav_zhuangbei
            // 
            this.nav_zhuangbei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nav_zhuangbei.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nav_zhuangbei.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nav_zhuangbei.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.nav_zhuangbei.ExpandSelectFirst = false;
            this.nav_zhuangbei.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nav_zhuangbei.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nav_zhuangbei.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.nav_zhuangbei.FullRowSelect = true;
            this.nav_zhuangbei.HideSelection = false;
            this.nav_zhuangbei.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.nav_zhuangbei.ImageIndex = 0;
            this.nav_zhuangbei.ImageList = this.img_nav;
            this.nav_zhuangbei.ItemHeight = 50;
            this.nav_zhuangbei.Location = new System.Drawing.Point(3, 3);
            this.nav_zhuangbei.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.nav_zhuangbei.Name = "nav_zhuangbei";
            treeNode9.ContextMenuStrip = this.menu_add;
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "node_sword";
            treeNode9.SelectedImageIndex = 0;
            treeNode9.Text = "武器";
            treeNode10.ContextMenuStrip = this.menu_add;
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "node_card";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "星卡";
            treeNode11.ContextMenuStrip = this.menu_add;
            treeNode11.ImageIndex = 4;
            treeNode11.Name = "node_amulet";
            treeNode11.SelectedImageIndex = 4;
            treeNode11.Text = "护身符";
            treeNode12.ContextMenuStrip = this.menu_add;
            treeNode12.ImageIndex = 7;
            treeNode12.Name = "node_necklace";
            treeNode12.SelectedImageIndex = 7;
            treeNode12.Text = "项链";
            treeNode13.ContextMenuStrip = this.menu_add;
            treeNode13.ImageIndex = 5;
            treeNode13.Name = "node_hat";
            treeNode13.SelectedImageIndex = 5;
            treeNode13.Text = "帽子";
            treeNode14.ContextMenuStrip = this.menu_add;
            treeNode14.ImageIndex = 3;
            treeNode14.Name = "node_clothing";
            treeNode14.SelectedImageIndex = 3;
            treeNode14.Text = "衣服";
            treeNode15.ContextMenuStrip = this.menu_add;
            treeNode15.ImageIndex = 2;
            treeNode15.Name = "node_stone";
            treeNode15.SelectedImageIndex = 2;
            treeNode15.Text = "石头";
            treeNode16.ContextMenuStrip = this.menu_add;
            treeNode16.ImageIndex = 8;
            treeNode16.Name = "node_shoot";
            treeNode16.SelectedImageIndex = 8;
            treeNode16.Text = "鞋";
            this.nav_zhuangbei.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.nav_zhuangbei.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.nav_zhuangbei.ScrollBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.nav_zhuangbei.ScrollBarPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.nav_zhuangbei.ScrollFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.nav_zhuangbei.SecondBackColor = System.Drawing.Color.WhiteSmoke;
            this.nav_zhuangbei.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nav_zhuangbei.SelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nav_zhuangbei.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.nav_zhuangbei.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.nav_zhuangbei.SelectedImageIndex = 0;
            this.nav_zhuangbei.ShowLines = false;
            this.nav_zhuangbei.ShowSecondBackColor = true;
            this.nav_zhuangbei.ShowTips = true;
            this.nav_zhuangbei.Size = new System.Drawing.Size(344, 956);
            this.nav_zhuangbei.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.nav_zhuangbei.StyleCustomMode = true;
            this.nav_zhuangbei.TabIndex = 1;
            this.nav_zhuangbei.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nav_zhuangbei.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.nav_zhuangbei_MenuItemClick);
            this.nav_zhuangbei.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.nav_zhuangbei_NodeMouseClick);
            // 
            // img_nav
            // 
            this.img_nav.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_nav.ImageStream")));
            this.img_nav.TransparentColor = System.Drawing.Color.Transparent;
            this.img_nav.Images.SetKeyName(0, "sword.png");
            this.img_nav.Images.SetKeyName(1, "ka.png");
            this.img_nav.Images.SetKeyName(2, "icon-influxDb.png");
            this.img_nav.Images.SetKeyName(3, "吊带.png");
            this.img_nav.Images.SetKeyName(4, "和田玉.png");
            this.img_nav.Images.SetKeyName(5, "帽子.png");
            this.img_nav.Images.SetKeyName(6, "拖鞋.png");
            this.img_nav.Images.SetKeyName(7, "项链.png");
            this.img_nav.Images.SetKeyName(8, "高跟鞋.png");
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.ColumnCount = 1;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 2;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(1436, 853);
            this.uiTableLayoutPanel2.Style = Sunny.UI.UIStyle.Gray;
            this.uiTableLayoutPanel2.TabIndex = 1;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToAddRows = false;
            this.uiDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.uiDataGridView1.RowTemplate.Height = 27;
            this.uiDataGridView1.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.uiDataGridView1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.uiDataGridView1.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(1430, 497);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.uiDataGridView1.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.uiDataGridView1.StyleCustomMode = true;
            this.uiDataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "标题";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "武器";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "星卡";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "护身符";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "项链";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "帽子";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "衣服";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "石头";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "鞋";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "套装";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "其他";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // menu_update
            // 
            this.menu_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.menu_update.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.menu_update.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_update.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_use,
            this.tool_update,
            this.tool_del});
            this.menu_update.Name = "menu_add";
            this.menu_update.Size = new System.Drawing.Size(119, 76);
            this.menu_update.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.menu_update.StyleCustomMode = true;
            // 
            // tool_use
            // 
            this.tool_use.Name = "tool_use";
            this.tool_use.Size = new System.Drawing.Size(118, 24);
            this.tool_use.Text = "装备";
            this.tool_use.Click += new System.EventHandler(this.tool_use_Click);
            // 
            // tool_update
            // 
            this.tool_update.Name = "tool_update";
            this.tool_update.Size = new System.Drawing.Size(118, 24);
            this.tool_update.Text = "编辑";
            this.tool_update.Click += new System.EventHandler(this.tool_update_Click);
            // 
            // tool_del
            // 
            this.tool_del.Name = "tool_del";
            this.tool_del.Size = new System.Drawing.Size(118, 24);
            this.tool_del.Text = "删除";
            this.tool_del.Click += new System.EventHandler(this.tool_del_Click);
            // 
            // btn_new_tab
            // 
            this.btn_new_tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_tab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_new_tab.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_new_tab.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btn_new_tab.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_new_tab.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_new_tab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_new_tab.Location = new System.Drawing.Point(120, 8);
            this.btn_new_tab.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_new_tab.Name = "btn_new_tab";
            this.btn_new_tab.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btn_new_tab.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_new_tab.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btn_new_tab.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_new_tab.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_new_tab.Size = new System.Drawing.Size(99, 25);
            this.btn_new_tab.Style = Sunny.UI.UIStyle.Orange;
            this.btn_new_tab.StyleCustomMode = true;
            this.btn_new_tab.TabIndex = 2;
            this.btn_new_tab.Text = "新建标签";
            this.btn_new_tab.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_new_tab.Click += new System.EventHandler(this.btn_new_tab_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(5, 7);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(109, 28);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "伤害计算";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AllowAddControlOnTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1447, 1000);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btn_new_tab);
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 36, 2, 2);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.StyleCustomMode = true;
            this.Text = "";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu_add.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.menu_update.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UITabControl tab_container;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private Sunny.UI.UINavMenu nav_zhuangbei;
        private System.Windows.Forms.ImageList img_nav;
        private Sunny.UI.UIContextMenuStrip menu_add;
        private System.Windows.Forms.ToolStripMenuItem tool_add;
        private Sunny.UI.UIContextMenuStrip menu_update;
        private System.Windows.Forms.ToolStripMenuItem tool_use;
        private System.Windows.Forms.ToolStripMenuItem tool_update;
        private System.Windows.Forms.ToolStripMenuItem tool_del;
        private Sunny.UI.UIButton btn_new_tab;
        private Sunny.UI.UILabel uiLabel1;
    }
}