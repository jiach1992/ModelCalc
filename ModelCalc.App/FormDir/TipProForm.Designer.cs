
namespace ModelCalc.App.FormDir
{
    partial class TipProForm
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
            this.lbl_con = new Sunny.UI.UIPanel();
            this.SuspendLayout();
            // 
            // lbl_con
            // 
            this.lbl_con.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_con.Location = new System.Drawing.Point(28, 15);
            this.lbl_con.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_con.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbl_con.Name = "lbl_con";
            this.lbl_con.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.lbl_con.Size = new System.Drawing.Size(224, 234);
            this.lbl_con.TabIndex = 0;
            this.lbl_con.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // TipProForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(261, 259);
            this.Controls.Add(this.lbl_con);
            this.Name = "TipProForm";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.ShowTitle = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TipProForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 612, 450);
            this.Load += new System.EventHandler(this.TipProForm_Load);
            this.MouseLeave += new System.EventHandler(this.TipProForm_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel lbl_con;
    }
}