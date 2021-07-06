
namespace Dictionary.Forms.Search
{
    partial class TranslateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslateForm));
            this.panel_Main = new System.Windows.Forms.Panel();
            this.btn_SettingApi = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.btn_SpeechTrans = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_Trans = new System.Windows.Forms.Label();
            this.lb_Ori = new System.Windows.Forms.Label();
            this.btn_SpeechOri = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.panel_Trans = new System.Windows.Forms.Panel();
            this.rTbox_Trans = new System.Windows.Forms.RichTextBox();
            this.panel_Ori = new System.Windows.Forms.Panel();
            this.rTbox_Ori = new System.Windows.Forms.RichTextBox();
            this.btn_Trans = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.panel_Main.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.panel_Trans.SuspendLayout();
            this.panel_Ori.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Main.Controls.Add(this.btn_SettingApi);
            this.panel_Main.Controls.Add(this.btn_SpeechTrans);
            this.panel_Main.Controls.Add(this.panel_Top);
            this.panel_Main.Controls.Add(this.lb_Trans);
            this.panel_Main.Controls.Add(this.lb_Ori);
            this.panel_Main.Controls.Add(this.btn_SpeechOri);
            this.panel_Main.Controls.Add(this.panel_Trans);
            this.panel_Main.Controls.Add(this.panel_Ori);
            this.panel_Main.Controls.Add(this.btn_Trans);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(797, 398);
            this.panel_Main.TabIndex = 2;
            // 
            // btn_SettingApi
            // 
            this.btn_SettingApi.BackColor = System.Drawing.Color.DimGray;
            this.btn_SettingApi.FlatAppearance.BorderSize = 0;
            this.btn_SettingApi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SettingApi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SettingApi.ForeColor = System.Drawing.Color.White;
            this.btn_SettingApi.Location = new System.Drawing.Point(4, 174);
            this.btn_SettingApi.Name = "btn_SettingApi";
            this.btn_SettingApi.Size = new System.Drawing.Size(95, 29);
            this.btn_SettingApi.TabIndex = 13;
            this.btn_SettingApi.Text = "Cấu hình api";
            this.btn_SettingApi.UseVisualStyleBackColor = false;
            this.btn_SettingApi.Click += new System.EventHandler(this.btn_SettingApi_Click);
            // 
            // btn_SpeechTrans
            // 
            this.btn_SpeechTrans.BackColor = System.Drawing.Color.DimGray;
            this.btn_SpeechTrans.FlatAppearance.BorderSize = 0;
            this.btn_SpeechTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SpeechTrans.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SpeechTrans.ForeColor = System.Drawing.Color.White;
            this.btn_SpeechTrans.Location = new System.Drawing.Point(4, 139);
            this.btn_SpeechTrans.Name = "btn_SpeechTrans";
            this.btn_SpeechTrans.Size = new System.Drawing.Size(95, 29);
            this.btn_SpeechTrans.TabIndex = 12;
            this.btn_SpeechTrans.Text = "Nghe bản dịch";
            this.btn_SpeechTrans.UseVisualStyleBackColor = false;
            this.btn_SpeechTrans.Click += new System.EventHandler(this.btn_SpeechTrans_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Top.Controls.Add(this.btn_Close);
            this.panel_Top.Controls.Add(this.lb_Title);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(795, 29);
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
            this.btn_Close.Location = new System.Drawing.Point(761, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(29, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(3, 7);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(177, 15);
            this.lb_Title.TabIndex = 3;
            this.lb_Title.Text = "Dịch bằng api (translate google)";
            // 
            // lb_Trans
            // 
            this.lb_Trans.BackColor = System.Drawing.Color.DarkCyan;
            this.lb_Trans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Trans.ForeColor = System.Drawing.Color.Transparent;
            this.lb_Trans.Location = new System.Drawing.Point(455, 33);
            this.lb_Trans.Name = "lb_Trans";
            this.lb_Trans.Size = new System.Drawing.Size(330, 32);
            this.lb_Trans.TabIndex = 10;
            this.lb_Trans.Text = "Bản dịch";
            this.lb_Trans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Ori
            // 
            this.lb_Ori.BackColor = System.Drawing.Color.DarkCyan;
            this.lb_Ori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ori.ForeColor = System.Drawing.Color.Transparent;
            this.lb_Ori.Location = new System.Drawing.Point(115, 33);
            this.lb_Ori.Name = "lb_Ori";
            this.lb_Ori.Size = new System.Drawing.Size(324, 32);
            this.lb_Ori.TabIndex = 9;
            this.lb_Ori.Text = "Bản gốc";
            this.lb_Ori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SpeechOri
            // 
            this.btn_SpeechOri.BackColor = System.Drawing.Color.DimGray;
            this.btn_SpeechOri.FlatAppearance.BorderSize = 0;
            this.btn_SpeechOri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SpeechOri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SpeechOri.ForeColor = System.Drawing.Color.White;
            this.btn_SpeechOri.Location = new System.Drawing.Point(4, 104);
            this.btn_SpeechOri.Name = "btn_SpeechOri";
            this.btn_SpeechOri.Size = new System.Drawing.Size(95, 29);
            this.btn_SpeechOri.TabIndex = 7;
            this.btn_SpeechOri.Text = "Nghe bản gốc";
            this.btn_SpeechOri.UseVisualStyleBackColor = false;
            this.btn_SpeechOri.Click += new System.EventHandler(this.btn_SpeechOri_Click);
            // 
            // panel_Trans
            // 
            this.panel_Trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Trans.Controls.Add(this.rTbox_Trans);
            this.panel_Trans.Location = new System.Drawing.Point(450, 68);
            this.panel_Trans.Name = "panel_Trans";
            this.panel_Trans.Padding = new System.Windows.Forms.Padding(4);
            this.panel_Trans.Size = new System.Drawing.Size(340, 321);
            this.panel_Trans.TabIndex = 6;
            // 
            // rTbox_Trans
            // 
            this.rTbox_Trans.BackColor = System.Drawing.Color.White;
            this.rTbox_Trans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTbox_Trans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTbox_Trans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTbox_Trans.Location = new System.Drawing.Point(4, 4);
            this.rTbox_Trans.Name = "rTbox_Trans";
            this.rTbox_Trans.ReadOnly = true;
            this.rTbox_Trans.Size = new System.Drawing.Size(330, 311);
            this.rTbox_Trans.TabIndex = 0;
            this.rTbox_Trans.Text = "Chào mọi người";
            // 
            // panel_Ori
            // 
            this.panel_Ori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Ori.Controls.Add(this.rTbox_Ori);
            this.panel_Ori.Location = new System.Drawing.Point(104, 68);
            this.panel_Ori.Name = "panel_Ori";
            this.panel_Ori.Padding = new System.Windows.Forms.Padding(4);
            this.panel_Ori.Size = new System.Drawing.Size(340, 321);
            this.panel_Ori.TabIndex = 3;
            // 
            // rTbox_Ori
            // 
            this.rTbox_Ori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTbox_Ori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTbox_Ori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTbox_Ori.Location = new System.Drawing.Point(4, 4);
            this.rTbox_Ori.Name = "rTbox_Ori";
            this.rTbox_Ori.Size = new System.Drawing.Size(330, 311);
            this.rTbox_Ori.TabIndex = 2;
            this.rTbox_Ori.Text = "Hello everyone";
            // 
            // btn_Trans
            // 
            this.btn_Trans.BackColor = System.Drawing.Color.Green;
            this.btn_Trans.FlatAppearance.BorderSize = 0;
            this.btn_Trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Trans.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trans.ForeColor = System.Drawing.Color.White;
            this.btn_Trans.Location = new System.Drawing.Point(4, 69);
            this.btn_Trans.Name = "btn_Trans";
            this.btn_Trans.Size = new System.Drawing.Size(95, 29);
            this.btn_Trans.TabIndex = 1;
            this.btn_Trans.Text = "Dịch";
            this.btn_Trans.UseVisualStyleBackColor = false;
            this.btn_Trans.Click += new System.EventHandler(this.btn_Trans_Click);
            // 
            // TranslateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 398);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TranslateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TranslateForm";
            this.panel_Main.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Trans.ResumeLayout(false);
            this.panel_Ori.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_Top;
        private UserControls.s_ButtonRound btn_Close;
        private System.Windows.Forms.Label lb_Trans;
        private System.Windows.Forms.Label lb_Ori;
        private System.Windows.Forms.Panel panel_Trans;
        private System.Windows.Forms.Panel panel_Ori;
        private System.Windows.Forms.RichTextBox rTbox_Ori;
        private UserControls.s_ButtonRound btn_Trans;
        private UserControls.s_ButtonRound btn_SpeechTrans;
        private UserControls.s_ButtonRound btn_SpeechOri;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.RichTextBox rTbox_Trans;
        private UserControls.s_ButtonRound btn_SettingApi;
    }
}