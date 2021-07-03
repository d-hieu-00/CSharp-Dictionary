
namespace Dictionary.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lb_Load = new System.Windows.Forms.Label();
            this.timer_EffectLoad = new System.Windows.Forms.Timer(this.components);
            this.panel_Main = new System.Windows.Forms.Panel();
            this.lb_Name = new System.Windows.Forms.Label();
            this.timer_Load = new System.Windows.Forms.Timer(this.components);
            this.timer_RsLoad = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Close = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Load
            // 
            this.lb_Load.AutoSize = true;
            this.lb_Load.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Load.ForeColor = System.Drawing.Color.DimGray;
            this.lb_Load.Location = new System.Drawing.Point(121, 95);
            this.lb_Load.Name = "lb_Load";
            this.lb_Load.Size = new System.Drawing.Size(106, 17);
            this.lb_Load.TabIndex = 0;
            this.lb_Load.Text = "Đang tải dữ liệu";
            this.lb_Load.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.lb_Load.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.lb_Load.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // timer_EffectLoad
            // 
            this.timer_EffectLoad.Enabled = true;
            this.timer_EffectLoad.Interval = 700;
            this.timer_EffectLoad.Tick += new System.EventHandler(this.timer_EffectLoad_Tick);
            // 
            // panel_Main
            // 
            this.panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Main.Controls.Add(this.label1);
            this.panel_Main.Controls.Add(this.pictureBox1);
            this.panel_Main.Controls.Add(this.lb_Name);
            this.panel_Main.Controls.Add(this.lb_Load);
            this.panel_Main.Controls.Add(this.btn_Close);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(316, 117);
            this.panel_Main.TabIndex = 2;
            this.panel_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(11, 6);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(78, 20);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "Từ Điển - ";
            this.lb_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.lb_Name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.lb_Name.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // timer_Load
            // 
            this.timer_Load.Enabled = true;
            this.timer_Load.Tick += new System.EventHandler(this.timer_Load_Tick);
            // 
            // timer_RsLoad
            // 
            this.timer_RsLoad.Enabled = true;
            this.timer_RsLoad.Tick += new System.EventHandler(this.timer_RsLoad_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dictionary.Properties.Resources.Cat_roll;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Close.Location = new System.Drawing.Point(275, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 26);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(121, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thực hiện bởi:\r\n        Nguyễn Giao Ban - 18520481\r\n        Nguyễn Duy Hiệu - 185" +
    "20746";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 117);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Load;
        private Search.UserControls.s_ButtonRound btn_Close;
        private System.Windows.Forms.Timer timer_EffectLoad;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Timer timer_Load;
        private System.Windows.Forms.Timer timer_RsLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}