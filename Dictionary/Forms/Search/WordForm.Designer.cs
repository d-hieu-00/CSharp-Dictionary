
namespace Dictionary.Forms.Search
{
    partial class WordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordForm));
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.lb_View = new System.Windows.Forms.Label();
            this.lb_Write = new System.Windows.Forms.Label();
            this.panel_Rule = new System.Windows.Forms.Panel();
            this.rTbox_Rule = new Dictionary.Forms.Search.UserControls.s_RichTextBoxOnlyView();
            this.btn_View = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.panel_View = new System.Windows.Forms.Panel();
            this.rTbox_View = new Dictionary.Forms.Search.UserControls.s_RichTextBoxOnlyView();
            this.panel_Write = new System.Windows.Forms.Panel();
            this.rTbox_Write = new System.Windows.Forms.RichTextBox();
            this.btn_Save = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.panel_Main.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.panel_Rule.SuspendLayout();
            this.panel_View.SuspendLayout();
            this.panel_Write.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(3, 7);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(76, 15);
            this.lb_Title.TabIndex = 3;
            this.lb_Title.Text = "Thêm từ mới";
            // 
            // panel_Main
            // 
            this.panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Main.Controls.Add(this.panel_Top);
            this.panel_Main.Controls.Add(this.lb_View);
            this.panel_Main.Controls.Add(this.lb_Write);
            this.panel_Main.Controls.Add(this.panel_Rule);
            this.panel_Main.Controls.Add(this.btn_View);
            this.panel_Main.Controls.Add(this.panel_View);
            this.panel_Main.Controls.Add(this.panel_Write);
            this.panel_Main.Controls.Add(this.btn_Save);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(795, 397);
            this.panel_Main.TabIndex = 1;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Top.Controls.Add(this.btn_Close);
            this.panel_Top.Controls.Add(this.lb_Title);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(793, 29);
            this.panel_Top.TabIndex = 11;
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
            this.btn_Close.Location = new System.Drawing.Point(759, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(29, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lb_View
            // 
            this.lb_View.BackColor = System.Drawing.Color.DarkCyan;
            this.lb_View.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_View.ForeColor = System.Drawing.Color.Transparent;
            this.lb_View.Location = new System.Drawing.Point(519, 33);
            this.lb_View.Name = "lb_View";
            this.lb_View.Size = new System.Drawing.Size(263, 32);
            this.lb_View.TabIndex = 10;
            this.lb_View.Text = "Hiện thị";
            this.lb_View.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Write
            // 
            this.lb_Write.BackColor = System.Drawing.Color.DarkCyan;
            this.lb_Write.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Write.ForeColor = System.Drawing.Color.Transparent;
            this.lb_Write.Location = new System.Drawing.Point(240, 33);
            this.lb_Write.Name = "lb_Write";
            this.lb_Write.Size = new System.Drawing.Size(263, 32);
            this.lb_Write.TabIndex = 9;
            this.lb_Write.Text = "Viết từ mới";
            this.lb_Write.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Rule
            // 
            this.panel_Rule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Rule.Controls.Add(this.rTbox_Rule);
            this.panel_Rule.Location = new System.Drawing.Point(6, 35);
            this.panel_Rule.Name = "panel_Rule";
            this.panel_Rule.Padding = new System.Windows.Forms.Padding(4);
            this.panel_Rule.Size = new System.Drawing.Size(223, 319);
            this.panel_Rule.TabIndex = 8;
            // 
            // rTbox_Rule
            // 
            this.rTbox_Rule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTbox_Rule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTbox_Rule.Location = new System.Drawing.Point(4, 4);
            this.rTbox_Rule.Name = "rTbox_Rule";
            this.rTbox_Rule.Size = new System.Drawing.Size(213, 309);
            this.rTbox_Rule.TabIndex = 1;
            this.rTbox_Rule.Text = resources.GetString("rTbox_Rule.Text");
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.DimGray;
            this.btn_View.FlatAppearance.BorderSize = 0;
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.Color.White;
            this.btn_View.Location = new System.Drawing.Point(128, 360);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(95, 29);
            this.btn_View.TabIndex = 7;
            this.btn_View.Text = "Xem trước";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // panel_View
            // 
            this.panel_View.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_View.Controls.Add(this.rTbox_View);
            this.panel_View.Location = new System.Drawing.Point(514, 68);
            this.panel_View.Name = "panel_View";
            this.panel_View.Padding = new System.Windows.Forms.Padding(4);
            this.panel_View.Size = new System.Drawing.Size(273, 321);
            this.panel_View.TabIndex = 6;
            // 
            // rTbox_View
            // 
            this.rTbox_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTbox_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTbox_View.Location = new System.Drawing.Point(4, 4);
            this.rTbox_View.Name = "rTbox_View";
            this.rTbox_View.Size = new System.Drawing.Size(263, 311);
            this.rTbox_View.TabIndex = 0;
            this.rTbox_View.Text = "@Vocabulary /Pronouce/\n*Type\n-Mean\n+SubMean\n=Example+Mean example\n!Another Vocabu" +
    "lary \n*Type\n-Mean\n+SubMean\n=Example+Mean exanple\n";
            // 
            // panel_Write
            // 
            this.panel_Write.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Write.Controls.Add(this.rTbox_Write);
            this.panel_Write.Location = new System.Drawing.Point(235, 68);
            this.panel_Write.Name = "panel_Write";
            this.panel_Write.Padding = new System.Windows.Forms.Padding(4);
            this.panel_Write.Size = new System.Drawing.Size(273, 321);
            this.panel_Write.TabIndex = 3;
            // 
            // rTbox_Write
            // 
            this.rTbox_Write.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTbox_Write.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTbox_Write.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTbox_Write.Location = new System.Drawing.Point(4, 4);
            this.rTbox_Write.Name = "rTbox_Write";
            this.rTbox_Write.Size = new System.Drawing.Size(263, 311);
            this.rTbox_Write.TabIndex = 2;
            this.rTbox_Write.Text = "@Vocabulary /Pronouce/\n*Type\n-Mean\n+SubMean\n=Example+Mean example\n!Another Vocabu" +
    "lary \n*Type\n-Mean\n+SubMean\n=Example+Mean exanple";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Green;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(11, 360);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(81, 29);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 397);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordForm";
            this.Load += new System.EventHandler(this.WordForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.panel_Main.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Rule.ResumeLayout(false);
            this.panel_View.ResumeLayout(false);
            this.panel_Write.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.s_ButtonRound btn_Close;
        private UserControls.s_ButtonRound btn_Save;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_Write;
        private System.Windows.Forms.RichTextBox rTbox_Write;
        private UserControls.s_ButtonRound btn_View;
        private System.Windows.Forms.Panel panel_View;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel_Rule;
        private UserControls.s_RichTextBoxOnlyView rTbox_Rule;
        private UserControls.s_RichTextBoxOnlyView rTbox_View;
        private System.Windows.Forms.Label lb_View;
        private System.Windows.Forms.Label lb_Write;
        private System.Windows.Forms.Panel panel_Top;
    }
}