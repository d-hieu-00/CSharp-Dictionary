
namespace Dictionary.Forms.Search
{
    partial class SettingApi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingApi));
            this.panel_Main = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_OpenWeb = new System.Windows.Forms.Button();
            this.lb_KeyApi = new System.Windows.Forms.Label();
            this.tBox_KeyApi = new System.Windows.Forms.TextBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.btn_Close = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.panel_Main.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Main.Controls.Add(this.btn_save);
            this.panel_Main.Controls.Add(this.btn_OpenWeb);
            this.panel_Main.Controls.Add(this.lb_KeyApi);
            this.panel_Main.Controls.Add(this.tBox_KeyApi);
            this.panel_Main.Controls.Add(this.panel_Top);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(374, 124);
            this.panel_Main.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(262, 85);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Lưu thay đổi";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_OpenWeb
            // 
            this.btn_OpenWeb.BackColor = System.Drawing.Color.Gray;
            this.btn_OpenWeb.FlatAppearance.BorderSize = 0;
            this.btn_OpenWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenWeb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenWeb.ForeColor = System.Drawing.Color.White;
            this.btn_OpenWeb.Location = new System.Drawing.Point(108, 85);
            this.btn_OpenWeb.Name = "btn_OpenWeb";
            this.btn_OpenWeb.Size = new System.Drawing.Size(148, 23);
            this.btn_OpenWeb.TabIndex = 6;
            this.btn_OpenWeb.Text = "Lấy key từ rapidapi.com";
            this.btn_OpenWeb.UseVisualStyleBackColor = false;
            this.btn_OpenWeb.Click += new System.EventHandler(this.btn_OpenWeb_Click);
            // 
            // lb_KeyApi
            // 
            this.lb_KeyApi.AutoSize = true;
            this.lb_KeyApi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KeyApi.Location = new System.Drawing.Point(6, 48);
            this.lb_KeyApi.Name = "lb_KeyApi";
            this.lb_KeyApi.Size = new System.Drawing.Size(96, 15);
            this.lb_KeyApi.TabIndex = 4;
            this.lb_KeyApi.Text = "X-RapidAPI-Key";
            // 
            // tBox_KeyApi
            // 
            this.tBox_KeyApi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_KeyApi.Location = new System.Drawing.Point(108, 45);
            this.tBox_KeyApi.Name = "tBox_KeyApi";
            this.tBox_KeyApi.Size = new System.Drawing.Size(258, 23);
            this.tBox_KeyApi.TabIndex = 2;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Top.Controls.Add(this.lb_Title);
            this.panel_Top.Controls.Add(this.btn_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(372, 29);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(6, 5);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(84, 17);
            this.lb_Title.TabIndex = 2;
            this.lb_Title.Text = "Cấu hình api";
            this.lb_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.lb_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.lb_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(344, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // SettingApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 124);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingApi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingApi";
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_OpenWeb;
        private System.Windows.Forms.Label lb_KeyApi;
        private System.Windows.Forms.TextBox tBox_KeyApi;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label lb_Title;
        private UserControls.s_ButtonRound btn_Close;
    }
}