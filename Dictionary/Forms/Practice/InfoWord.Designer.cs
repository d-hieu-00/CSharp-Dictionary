
namespace Dictionary.Forms.Practice
{
    partial class InfoWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoWord));
            this.panel_View = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.rTbox_View = new Dictionary.Forms.Search.UserControls.s_RichTextBoxOnlyView();
            this.panel_View.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_View
            // 
            this.panel_View.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_View.Controls.Add(this.rTbox_View);
            this.panel_View.Location = new System.Drawing.Point(6, 35);
            this.panel_View.Name = "panel_View";
            this.panel_View.Padding = new System.Windows.Forms.Padding(4);
            this.panel_View.Size = new System.Drawing.Size(389, 293);
            this.panel_View.TabIndex = 7;
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panel_Top);
            this.panel_Main.Controls.Add(this.panel_View);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(400, 334);
            this.panel_Main.TabIndex = 8;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(3, 7);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(58, 15);
            this.lb_Title.TabIndex = 3;
            this.lb_Title.Text = "Chi tiết từ";
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Top.Controls.Add(this.btn_Close);
            this.panel_Top.Controls.Add(this.lb_Title);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(400, 29);
            this.panel_Top.TabIndex = 12;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Close.Location = new System.Drawing.Point(366, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(29, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // rTbox_View
            // 
            this.rTbox_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTbox_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTbox_View.Location = new System.Drawing.Point(4, 4);
            this.rTbox_View.Name = "rTbox_View";
            this.rTbox_View.Size = new System.Drawing.Size(379, 283);
            this.rTbox_View.TabIndex = 0;
            this.rTbox_View.Text = "@Vocabulary /Pronouce/\n*Type\n-Mean\n+SubMean\n=Example+Mean example\n!Another Vocabu" +
    "lary \n*Type\n-Mean\n+SubMean\n=Example+Mean exanple\n";
            // 
            // InfoWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 334);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoWord";
            this.Activated += new System.EventHandler(this.InfoWord_Activated);
            this.panel_View.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_View;
        private Search.UserControls.s_RichTextBoxOnlyView rTbox_View;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_Top;
        private Search.UserControls.s_ButtonRound btn_Close;
        private System.Windows.Forms.Label lb_Title;
    }
}