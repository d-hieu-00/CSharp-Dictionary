
namespace Dictionary.Forms.Practice.UserControls
{
    partial class p_Play
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_DelAllHistory = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.btn_Play = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.lb_DetailResult = new System.Windows.Forms.Label();
            this.lb_NumWord = new System.Windows.Forms.Label();
            this.cBox_SoTu = new System.Windows.Forms.ComboBox();
            this.cBox_Dic = new System.Windows.Forms.ComboBox();
            this.flw_DetailResult = new System.Windows.Forms.FlowLayoutPanel();
            this.rdBtn_Dic = new System.Windows.Forms.RadioButton();
            this.rdBtn_Topic = new System.Windows.Forms.RadioButton();
            this.cBox_Topic = new System.Windows.Forms.ComboBox();
            this.flw_Result = new System.Windows.Forms.FlowLayoutPanel();
            this.pic_Icon = new System.Windows.Forms.PictureBox();
            this.timer_ResultClick = new System.Windows.Forms.Timer(this.components);
            this.llb_Guild = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DelAllHistory
            // 
            this.btn_DelAllHistory.BackColor = System.Drawing.Color.DarkGray;
            this.btn_DelAllHistory.FlatAppearance.BorderSize = 0;
            this.btn_DelAllHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DelAllHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DelAllHistory.ForeColor = System.Drawing.Color.White;
            this.btn_DelAllHistory.Location = new System.Drawing.Point(9, 380);
            this.btn_DelAllHistory.Name = "btn_DelAllHistory";
            this.btn_DelAllHistory.Size = new System.Drawing.Size(204, 33);
            this.btn_DelAllHistory.TabIndex = 26;
            this.btn_DelAllHistory.Text = "Xóa tất cả lịch sử";
            this.btn_DelAllHistory.UseVisualStyleBackColor = false;
            this.btn_DelAllHistory.Click += new System.EventHandler(this.btn_DelAllHistory_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.White;
            this.btn_Play.Location = new System.Drawing.Point(542, 312);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(158, 62);
            this.btn_Play.TabIndex = 24;
            this.btn_Play.Text = "Chơi";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // lb_DetailResult
            // 
            this.lb_DetailResult.BackColor = System.Drawing.Color.DarkGray;
            this.lb_DetailResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DetailResult.ForeColor = System.Drawing.Color.White;
            this.lb_DetailResult.Location = new System.Drawing.Point(219, 7);
            this.lb_DetailResult.Name = "lb_DetailResult";
            this.lb_DetailResult.Size = new System.Drawing.Size(268, 32);
            this.lb_DetailResult.TabIndex = 23;
            this.lb_DetailResult.Text = "Kết quả chi tiết";
            this.lb_DetailResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_NumWord
            // 
            this.lb_NumWord.AutoSize = true;
            this.lb_NumWord.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumWord.Location = new System.Drawing.Point(523, 248);
            this.lb_NumWord.Name = "lb_NumWord";
            this.lb_NumWord.Size = new System.Drawing.Size(75, 17);
            this.lb_NumWord.TabIndex = 22;
            this.lb_NumWord.Text = "Chọn số từ";
            // 
            // cBox_SoTu
            // 
            this.cBox_SoTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_SoTu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_SoTu.FormattingEnabled = true;
            this.cBox_SoTu.Location = new System.Drawing.Point(612, 243);
            this.cBox_SoTu.Name = "cBox_SoTu";
            this.cBox_SoTu.Size = new System.Drawing.Size(121, 25);
            this.cBox_SoTu.TabIndex = 21;
            // 
            // cBox_Dic
            // 
            this.cBox_Dic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Dic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Dic.FormattingEnabled = true;
            this.cBox_Dic.Location = new System.Drawing.Point(612, 200);
            this.cBox_Dic.Name = "cBox_Dic";
            this.cBox_Dic.Size = new System.Drawing.Size(121, 25);
            this.cBox_Dic.TabIndex = 20;
            this.cBox_Dic.SelectedIndexChanged += new System.EventHandler(this.cBox_Dic_SelectedIndexChanged);
            // 
            // flw_DetailResult
            // 
            this.flw_DetailResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flw_DetailResult.Location = new System.Drawing.Point(219, 45);
            this.flw_DetailResult.Name = "flw_DetailResult";
            this.flw_DetailResult.Padding = new System.Windows.Forms.Padding(3);
            this.flw_DetailResult.Size = new System.Drawing.Size(268, 368);
            this.flw_DetailResult.TabIndex = 19;
            // 
            // rdBtn_Dic
            // 
            this.rdBtn_Dic.AutoSize = true;
            this.rdBtn_Dic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Dic.Location = new System.Drawing.Point(493, 203);
            this.rdBtn_Dic.Name = "rdBtn_Dic";
            this.rdBtn_Dic.Size = new System.Drawing.Size(105, 21);
            this.rdBtn_Dic.TabIndex = 18;
            this.rdBtn_Dic.Text = "Chọn từ điển";
            this.rdBtn_Dic.UseVisualStyleBackColor = true;
            this.rdBtn_Dic.CheckedChanged += new System.EventHandler(this.rdBtn_Topic_CheckedChanged);
            // 
            // rdBtn_Topic
            // 
            this.rdBtn_Topic.AutoSize = true;
            this.rdBtn_Topic.Checked = true;
            this.rdBtn_Topic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Topic.Location = new System.Drawing.Point(493, 156);
            this.rdBtn_Topic.Name = "rdBtn_Topic";
            this.rdBtn_Topic.Size = new System.Drawing.Size(103, 21);
            this.rdBtn_Topic.TabIndex = 17;
            this.rdBtn_Topic.TabStop = true;
            this.rdBtn_Topic.Text = "Chọn chủ đề";
            this.rdBtn_Topic.UseVisualStyleBackColor = true;
            this.rdBtn_Topic.CheckedChanged += new System.EventHandler(this.rdBtn_Topic_CheckedChanged);
            // 
            // cBox_Topic
            // 
            this.cBox_Topic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Topic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Topic.FormattingEnabled = true;
            this.cBox_Topic.Location = new System.Drawing.Point(612, 156);
            this.cBox_Topic.Name = "cBox_Topic";
            this.cBox_Topic.Size = new System.Drawing.Size(121, 25);
            this.cBox_Topic.TabIndex = 16;
            this.cBox_Topic.SelectedIndexChanged += new System.EventHandler(this.cBox_Dic_SelectedIndexChanged);
            // 
            // flw_Result
            // 
            this.flw_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flw_Result.Location = new System.Drawing.Point(9, 7);
            this.flw_Result.Name = "flw_Result";
            this.flw_Result.Padding = new System.Windows.Forms.Padding(3);
            this.flw_Result.Size = new System.Drawing.Size(204, 367);
            this.flw_Result.TabIndex = 15;
            // 
            // pic_Icon
            // 
            this.pic_Icon.Image = global::Dictionary.Properties.Resources.Cat_roll;
            this.pic_Icon.Location = new System.Drawing.Point(542, 3);
            this.pic_Icon.Name = "pic_Icon";
            this.pic_Icon.Size = new System.Drawing.Size(158, 131);
            this.pic_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Icon.TabIndex = 25;
            this.pic_Icon.TabStop = false;
            // 
            // timer_ResultClick
            // 
            this.timer_ResultClick.Enabled = true;
            this.timer_ResultClick.Tick += new System.EventHandler(this.timer_ResultClick_Tick);
            // 
            // llb_Guild
            // 
            this.llb_Guild.AutoSize = true;
            this.llb_Guild.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_Guild.LinkColor = System.Drawing.Color.DarkCyan;
            this.llb_Guild.Location = new System.Drawing.Point(637, 396);
            this.llb_Guild.Name = "llb_Guild";
            this.llb_Guild.Size = new System.Drawing.Size(93, 15);
            this.llb_Guild.TabIndex = 27;
            this.llb_Guild.TabStop = true;
            this.llb_Guild.Text = "Hướng dẫn chơi";
            this.llb_Guild.Visible = false;
            this.llb_Guild.VisitedLinkColor = System.Drawing.Color.DarkMagenta;
            this.llb_Guild.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Guild_LinkClicked);
            // 
            // p_Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.llb_Guild);
            this.Controls.Add(this.btn_DelAllHistory);
            this.Controls.Add(this.pic_Icon);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.lb_DetailResult);
            this.Controls.Add(this.lb_NumWord);
            this.Controls.Add(this.cBox_SoTu);
            this.Controls.Add(this.cBox_Dic);
            this.Controls.Add(this.flw_DetailResult);
            this.Controls.Add(this.rdBtn_Dic);
            this.Controls.Add(this.rdBtn_Topic);
            this.Controls.Add(this.cBox_Topic);
            this.Controls.Add(this.flw_Result);
            this.Name = "p_Play";
            this.Size = new System.Drawing.Size(736, 420);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Search.UserControls.s_ButtonRound btn_DelAllHistory;
        private System.Windows.Forms.PictureBox pic_Icon;
        private Search.UserControls.s_ButtonRound btn_Play;
        private System.Windows.Forms.Label lb_DetailResult;
        private System.Windows.Forms.Label lb_NumWord;
        private System.Windows.Forms.ComboBox cBox_SoTu;
        private System.Windows.Forms.ComboBox cBox_Dic;
        private System.Windows.Forms.FlowLayoutPanel flw_DetailResult;
        private System.Windows.Forms.RadioButton rdBtn_Dic;
        private System.Windows.Forms.RadioButton rdBtn_Topic;
        private System.Windows.Forms.ComboBox cBox_Topic;
        private System.Windows.Forms.FlowLayoutPanel flw_Result;
        private System.Windows.Forms.Timer timer_ResultClick;
        private System.Windows.Forms.LinkLabel llb_Guild;
    }
}
