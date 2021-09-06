
namespace Dictionary.Forms.Practice.UserControls
{
    partial class p_Playing
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
            this.panel_left = new System.Windows.Forms.Panel();
            this.lb_recommend_2 = new System.Windows.Forms.Label();
            this.lb_require = new System.Windows.Forms.Label();
            this.lb_recommend_1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_corecct = new System.Windows.Forms.Label();
            this.lb_fail = new System.Windows.Forms.Label();
            this.rdbtn_option_4 = new System.Windows.Forms.RadioButton();
            this.rdbtn_option_3 = new System.Windows.Forms.RadioButton();
            this.lb_No = new System.Windows.Forms.Label();
            this.lb_anwser = new System.Windows.Forms.Label();
            this.rdbtn_option_2 = new System.Windows.Forms.RadioButton();
            this.rdbtn_option_1 = new System.Windows.Forms.RadioButton();
            this.timer_StartTime = new System.Windows.Forms.Timer(this.components);
            this.btn_quite = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.btn_listen = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.btn_next = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.lb_time = new System.Windows.Forms.Label();
            this.pic_Word = new System.Windows.Forms.PictureBox();
            this.panel_left.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Word)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_left.Controls.Add(this.lb_recommend_2);
            this.panel_left.Controls.Add(this.pic_Word);
            this.panel_left.Controls.Add(this.lb_require);
            this.panel_left.Controls.Add(this.lb_recommend_1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(265, 420);
            this.panel_left.TabIndex = 0;
            // 
            // lb_recommend_2
            // 
            this.lb_recommend_2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_recommend_2.Location = new System.Drawing.Point(13, 341);
            this.lb_recommend_2.Name = "lb_recommend_2";
            this.lb_recommend_2.Size = new System.Drawing.Size(245, 75);
            this.lb_recommend_2.TabIndex = 2;
            this.lb_recommend_2.Text = "Gợi ý 2:";
            // 
            // lb_require
            // 
            this.lb_require.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_require.Location = new System.Drawing.Point(3, 221);
            this.lb_require.Name = "lb_require";
            this.lb_require.Size = new System.Drawing.Size(255, 42);
            this.lb_require.TabIndex = 0;
            this.lb_require.Text = "Yêu cầu đề";
            // 
            // lb_recommend_1
            // 
            this.lb_recommend_1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_recommend_1.Location = new System.Drawing.Point(13, 263);
            this.lb_recommend_1.Name = "lb_recommend_1";
            this.lb_recommend_1.Size = new System.Drawing.Size(245, 78);
            this.lb_recommend_1.TabIndex = 1;
            this.lb_recommend_1.Text = "Gợi ý 1:";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.lb_Title);
            this.panel_main.Controls.Add(this.lb_corecct);
            this.panel_main.Controls.Add(this.lb_fail);
            this.panel_main.Controls.Add(this.rdbtn_option_4);
            this.panel_main.Controls.Add(this.rdbtn_option_3);
            this.panel_main.Controls.Add(this.btn_quite);
            this.panel_main.Controls.Add(this.btn_listen);
            this.panel_main.Controls.Add(this.btn_next);
            this.panel_main.Controls.Add(this.lb_No);
            this.panel_main.Controls.Add(this.lb_time);
            this.panel_main.Controls.Add(this.lb_anwser);
            this.panel_main.Controls.Add(this.rdbtn_option_2);
            this.panel_main.Controls.Add(this.rdbtn_option_1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(265, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(471, 420);
            this.panel_main.TabIndex = 1;
            // 
            // lb_Title
            // 
            this.lb_Title.BackColor = System.Drawing.Color.Teal;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(9, 167);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(451, 43);
            this.lb_Title.TabIndex = 14;
            this.lb_Title.Text = "Animal";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_corecct
            // 
            this.lb_corecct.AutoSize = true;
            this.lb_corecct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_corecct.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lb_corecct.Location = new System.Drawing.Point(6, 58);
            this.lb_corecct.Name = "lb_corecct";
            this.lb_corecct.Size = new System.Drawing.Size(109, 21);
            this.lb_corecct.TabIndex = 13;
            this.lb_corecct.Text = "Câu đúng: 10";
            // 
            // lb_fail
            // 
            this.lb_fail.AutoSize = true;
            this.lb_fail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fail.ForeColor = System.Drawing.Color.Red;
            this.lb_fail.Location = new System.Drawing.Point(6, 112);
            this.lb_fail.Name = "lb_fail";
            this.lb_fail.Size = new System.Drawing.Size(81, 21);
            this.lb_fail.TabIndex = 12;
            this.lb_fail.Text = "Câu sai: 9";
            // 
            // rdbtn_option_4
            // 
            this.rdbtn_option_4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_option_4.Location = new System.Drawing.Point(46, 373);
            this.rdbtn_option_4.Name = "rdbtn_option_4";
            this.rdbtn_option_4.Size = new System.Drawing.Size(414, 38);
            this.rdbtn_option_4.TabIndex = 11;
            this.rdbtn_option_4.TabStop = true;
            this.rdbtn_option_4.Text = "option 4";
            this.rdbtn_option_4.UseVisualStyleBackColor = true;
            // 
            // rdbtn_option_3
            // 
            this.rdbtn_option_3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_option_3.Location = new System.Drawing.Point(46, 331);
            this.rdbtn_option_3.Name = "rdbtn_option_3";
            this.rdbtn_option_3.Size = new System.Drawing.Size(414, 38);
            this.rdbtn_option_3.TabIndex = 10;
            this.rdbtn_option_3.TabStop = true;
            this.rdbtn_option_3.Text = "option 3";
            this.rdbtn_option_3.UseVisualStyleBackColor = true;
            // 
            // lb_No
            // 
            this.lb_No.AutoSize = true;
            this.lb_No.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_No.Location = new System.Drawing.Point(6, 4);
            this.lb_No.Name = "lb_No";
            this.lb_No.Size = new System.Drawing.Size(90, 21);
            this.lb_No.TabIndex = 6;
            this.lb_No.Text = "Câu: 19/45";
            // 
            // lb_anwser
            // 
            this.lb_anwser.AutoSize = true;
            this.lb_anwser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_anwser.Location = new System.Drawing.Point(6, 221);
            this.lb_anwser.Name = "lb_anwser";
            this.lb_anwser.Size = new System.Drawing.Size(58, 20);
            this.lb_anwser.TabIndex = 4;
            this.lb_anwser.Text = "Đáp án";
            // 
            // rdbtn_option_2
            // 
            this.rdbtn_option_2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_option_2.Location = new System.Drawing.Point(46, 291);
            this.rdbtn_option_2.Name = "rdbtn_option_2";
            this.rdbtn_option_2.Size = new System.Drawing.Size(414, 38);
            this.rdbtn_option_2.TabIndex = 1;
            this.rdbtn_option_2.TabStop = true;
            this.rdbtn_option_2.Text = "option 2";
            this.rdbtn_option_2.UseVisualStyleBackColor = true;
            // 
            // rdbtn_option_1
            // 
            this.rdbtn_option_1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_option_1.Location = new System.Drawing.Point(46, 251);
            this.rdbtn_option_1.Name = "rdbtn_option_1";
            this.rdbtn_option_1.Size = new System.Drawing.Size(414, 38);
            this.rdbtn_option_1.TabIndex = 0;
            this.rdbtn_option_1.TabStop = true;
            this.rdbtn_option_1.Text = "option 1";
            this.rdbtn_option_1.UseVisualStyleBackColor = true;
            // 
            // timer_StartTime
            // 
            this.timer_StartTime.Interval = 1000;
            this.timer_StartTime.Tick += new System.EventHandler(this.timer_StartTime_Tick);
            // 
            // btn_quite
            // 
            this.btn_quite.BackColor = System.Drawing.Color.IndianRed;
            this.btn_quite.FlatAppearance.BorderSize = 0;
            this.btn_quite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quite.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quite.ForeColor = System.Drawing.Color.White;
            this.btn_quite.Image = global::Dictionary.Properties.Resources.icons8_chequered_flag_48px;
            this.btn_quite.Location = new System.Drawing.Point(351, 58);
            this.btn_quite.Name = "btn_quite";
            this.btn_quite.Size = new System.Drawing.Size(109, 44);
            this.btn_quite.TabIndex = 9;
            this.btn_quite.UseVisualStyleBackColor = false;
            this.btn_quite.Click += new System.EventHandler(this.btn_quite_Click);
            // 
            // btn_listen
            // 
            this.btn_listen.BackColor = System.Drawing.Color.Turquoise;
            this.btn_listen.FlatAppearance.BorderSize = 0;
            this.btn_listen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listen.Image = global::Dictionary.Properties.Resources.icons8_audio_50px;
            this.btn_listen.Location = new System.Drawing.Point(351, 108);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(109, 46);
            this.btn_listen.TabIndex = 8;
            this.btn_listen.UseVisualStyleBackColor = false;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Image = global::Dictionary.Properties.Resources.icons8_forward_button_48px;
            this.btn_next.Location = new System.Drawing.Point(351, 4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(109, 48);
            this.btn_next.TabIndex = 7;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lb_time
            // 
            this.lb_time.BackColor = System.Drawing.Color.DimGray;
            this.lb_time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.Color.White;
            this.lb_time.Image = global::Dictionary.Properties.Resources.icons8_clock_100px;
            this.lb_time.Location = new System.Drawing.Point(148, 4);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(169, 150);
            this.lb_time.TabIndex = 5;
            this.lb_time.Text = "Thời gian";
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pic_Word
            // 
            this.pic_Word.Image = global::Dictionary.Properties.Resources.Cat_roll;
            this.pic_Word.Location = new System.Drawing.Point(3, 3);
            this.pic_Word.Name = "pic_Word";
            this.pic_Word.Size = new System.Drawing.Size(259, 206);
            this.pic_Word.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Word.TabIndex = 0;
            this.pic_Word.TabStop = false;
            // 
            // p_Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_left);
            this.Name = "p_Playing";
            this.Size = new System.Drawing.Size(736, 420);
            this.panel_left.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Word)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Label lb_recommend_2;
        private System.Windows.Forms.PictureBox pic_Word;
        private System.Windows.Forms.Label lb_require;
        private System.Windows.Forms.Label lb_recommend_1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label lb_anwser;
        private System.Windows.Forms.RadioButton rdbtn_option_2;
        private System.Windows.Forms.RadioButton rdbtn_option_1;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_No;
        private System.Windows.Forms.Label lb_corecct;
        private System.Windows.Forms.Label lb_fail;
        private System.Windows.Forms.RadioButton rdbtn_option_4;
        private System.Windows.Forms.RadioButton rdbtn_option_3;
        private Search.UserControls.s_ButtonRound btn_quite;
        private Search.UserControls.s_ButtonRound btn_listen;
        private Search.UserControls.s_ButtonRound btn_next;
        private System.Windows.Forms.Timer timer_StartTime;
        private System.Windows.Forms.Label lb_Title;
    }
}
