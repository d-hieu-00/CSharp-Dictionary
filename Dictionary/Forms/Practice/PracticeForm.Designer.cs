
namespace Dictionary.Forms.Practice
{
    partial class PracticeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeForm));
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Category = new System.Windows.Forms.TabPage();
            this.flwLayout_Words = new System.Windows.Forms.FlowLayoutPanel();
            this.flwLayout_Lession = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage_FindMean = new System.Windows.Forms.TabPage();
            this.tabPage_FindCorrect = new System.Windows.Forms.TabPage();
            this.tabPage_Pronounce = new System.Windows.Forms.TabPage();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.tabPage_Playing = new System.Windows.Forms.TabPage();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.timer_CheckLessionClick = new System.Windows.Forms.Timer(this.components);
            this.btn_Sound = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.btn_Settings = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.btn_Pronounce = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.btn_FindWord = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.btn_FindMean = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.btn_Topic = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.btn_Close = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.p_RowWord5 = new Dictionary.Forms.Practice.UserControls.p_RowWord();
            this.p_RowLession7 = new Dictionary.Forms.Practice.UserControls.p_RowLession();
            this.p_PlayFindMean = new Dictionary.Forms.Practice.UserControls.p_Play();
            this.p_PlayFindWord = new Dictionary.Forms.Practice.UserControls.p_Play();
            this.p_PlayPronounce = new Dictionary.Forms.Practice.UserControls.p_Play();
            this.p_Playing1 = new Dictionary.Forms.Practice.UserControls.p_Playing();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Category.SuspendLayout();
            this.flwLayout_Words.SuspendLayout();
            this.flwLayout_Lession.SuspendLayout();
            this.tabPage_FindMean.SuspendLayout();
            this.tabPage_FindCorrect.SuspendLayout();
            this.tabPage_Pronounce.SuspendLayout();
            this.tabPage_Playing.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Category);
            this.tabControl_Main.Controls.Add(this.tabPage_FindMean);
            this.tabControl_Main.Controls.Add(this.tabPage_FindCorrect);
            this.tabControl_Main.Controls.Add(this.tabPage_Pronounce);
            this.tabControl_Main.Controls.Add(this.tabPage_Settings);
            this.tabControl_Main.Controls.Add(this.tabPage_Playing);
            this.tabControl_Main.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Main.Location = new System.Drawing.Point(3, 42);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(749, 445);
            this.tabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_Category
            // 
            this.tabPage_Category.Controls.Add(this.flwLayout_Words);
            this.tabPage_Category.Controls.Add(this.flwLayout_Lession);
            this.tabPage_Category.Location = new System.Drawing.Point(4, 26);
            this.tabPage_Category.Name = "tabPage_Category";
            this.tabPage_Category.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Category.Size = new System.Drawing.Size(741, 415);
            this.tabPage_Category.TabIndex = 0;
            this.tabPage_Category.Text = "Chủ đề";
            this.tabPage_Category.UseVisualStyleBackColor = true;
            // 
            // flwLayout_Words
            // 
            this.flwLayout_Words.AutoScroll = true;
            this.flwLayout_Words.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwLayout_Words.Controls.Add(this.p_RowWord5);
            this.flwLayout_Words.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwLayout_Words.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flwLayout_Words.Location = new System.Drawing.Point(210, 3);
            this.flwLayout_Words.Name = "flwLayout_Words";
            this.flwLayout_Words.Size = new System.Drawing.Size(528, 409);
            this.flwLayout_Words.TabIndex = 1;
            // 
            // flwLayout_Lession
            // 
            this.flwLayout_Lession.AutoScroll = true;
            this.flwLayout_Lession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwLayout_Lession.Controls.Add(this.p_RowLession7);
            this.flwLayout_Lession.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwLayout_Lession.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flwLayout_Lession.Location = new System.Drawing.Point(3, 3);
            this.flwLayout_Lession.Name = "flwLayout_Lession";
            this.flwLayout_Lession.Size = new System.Drawing.Size(207, 409);
            this.flwLayout_Lession.TabIndex = 0;
            // 
            // tabPage_FindMean
            // 
            this.tabPage_FindMean.Controls.Add(this.p_PlayFindMean);
            this.tabPage_FindMean.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_FindMean.Location = new System.Drawing.Point(4, 26);
            this.tabPage_FindMean.Name = "tabPage_FindMean";
            this.tabPage_FindMean.Size = new System.Drawing.Size(741, 415);
            this.tabPage_FindMean.TabIndex = 1;
            this.tabPage_FindMean.Text = "Tìm nghĩa";
            this.tabPage_FindMean.UseVisualStyleBackColor = true;
            // 
            // tabPage_FindCorrect
            // 
            this.tabPage_FindCorrect.Controls.Add(this.p_PlayFindWord);
            this.tabPage_FindCorrect.Location = new System.Drawing.Point(4, 26);
            this.tabPage_FindCorrect.Name = "tabPage_FindCorrect";
            this.tabPage_FindCorrect.Size = new System.Drawing.Size(741, 415);
            this.tabPage_FindCorrect.TabIndex = 2;
            this.tabPage_FindCorrect.Text = "Tìm từ khớp";
            this.tabPage_FindCorrect.UseVisualStyleBackColor = true;
            // 
            // tabPage_Pronounce
            // 
            this.tabPage_Pronounce.Controls.Add(this.p_PlayPronounce);
            this.tabPage_Pronounce.Location = new System.Drawing.Point(4, 26);
            this.tabPage_Pronounce.Name = "tabPage_Pronounce";
            this.tabPage_Pronounce.Size = new System.Drawing.Size(741, 415);
            this.tabPage_Pronounce.TabIndex = 5;
            this.tabPage_Pronounce.Text = "Phát âm";
            this.tabPage_Pronounce.UseVisualStyleBackColor = true;
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 26);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Size = new System.Drawing.Size(741, 415);
            this.tabPage_Settings.TabIndex = 3;
            this.tabPage_Settings.Text = "Cấu hình";
            this.tabPage_Settings.UseVisualStyleBackColor = true;
            // 
            // tabPage_Playing
            // 
            this.tabPage_Playing.Controls.Add(this.p_Playing1);
            this.tabPage_Playing.Location = new System.Drawing.Point(4, 26);
            this.tabPage_Playing.Name = "tabPage_Playing";
            this.tabPage_Playing.Size = new System.Drawing.Size(741, 415);
            this.tabPage_Playing.TabIndex = 4;
            this.tabPage_Playing.Text = "Playing";
            this.tabPage_Playing.UseVisualStyleBackColor = true;
            // 
            // panel_Main
            // 
            this.panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Main.Controls.Add(this.panel_Top);
            this.panel_Main.Controls.Add(this.tabControl_Main);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(757, 492);
            this.panel_Main.TabIndex = 1;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Top.Controls.Add(this.btn_Sound);
            this.panel_Top.Controls.Add(this.btn_Settings);
            this.panel_Top.Controls.Add(this.btn_Pronounce);
            this.panel_Top.Controls.Add(this.btn_FindWord);
            this.panel_Top.Controls.Add(this.btn_FindMean);
            this.panel_Top.Controls.Add(this.btn_Topic);
            this.panel_Top.Controls.Add(this.btn_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(755, 36);
            this.panel_Top.TabIndex = 1;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // timer_CheckLessionClick
            // 
            this.timer_CheckLessionClick.Enabled = true;
            this.timer_CheckLessionClick.Tick += new System.EventHandler(this.timer_CheckLessionClick_Tick);
            // 
            // btn_Sound
            // 
            this.btn_Sound.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Sound.FlatAppearance.BorderSize = 0;
            this.btn_Sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sound.ForeColor = System.Drawing.Color.White;
            this.btn_Sound.Location = new System.Drawing.Point(641, 3);
            this.btn_Sound.Name = "btn_Sound";
            this.btn_Sound.Size = new System.Drawing.Size(72, 26);
            this.btn_Sound.TabIndex = 6;
            this.btn_Sound.Text = "Âm thanh";
            this.btn_Sound.UseVisualStyleBackColor = false;
            this.btn_Sound.Click += new System.EventHandler(this.btn_Sound_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.DimGray;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.Location = new System.Drawing.Point(427, 3);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(81, 33);
            this.btn_Settings.TabIndex = 5;
            this.btn_Settings.Text = "Cấu hình";
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Pronounce
            // 
            this.btn_Pronounce.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Pronounce.FlatAppearance.BorderSize = 0;
            this.btn_Pronounce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pronounce.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pronounce.Location = new System.Drawing.Point(287, 3);
            this.btn_Pronounce.Name = "btn_Pronounce";
            this.btn_Pronounce.Size = new System.Drawing.Size(85, 33);
            this.btn_Pronounce.TabIndex = 4;
            this.btn_Pronounce.Text = "Ôn phát âm";
            this.btn_Pronounce.UseVisualStyleBackColor = false;
            this.btn_Pronounce.Click += new System.EventHandler(this.btn_Pronounce_Click);
            // 
            // btn_FindWord
            // 
            this.btn_FindWord.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_FindWord.FlatAppearance.BorderSize = 0;
            this.btn_FindWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FindWord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindWord.Location = new System.Drawing.Point(200, 3);
            this.btn_FindWord.Name = "btn_FindWord";
            this.btn_FindWord.Size = new System.Drawing.Size(81, 33);
            this.btn_FindWord.TabIndex = 3;
            this.btn_FindWord.Text = "Ôn từ";
            this.btn_FindWord.UseVisualStyleBackColor = false;
            this.btn_FindWord.Click += new System.EventHandler(this.btn_FindWord_Click);
            // 
            // btn_FindMean
            // 
            this.btn_FindMean.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_FindMean.FlatAppearance.BorderSize = 0;
            this.btn_FindMean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FindMean.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindMean.Location = new System.Drawing.Point(113, 3);
            this.btn_FindMean.Name = "btn_FindMean";
            this.btn_FindMean.Size = new System.Drawing.Size(81, 33);
            this.btn_FindMean.TabIndex = 2;
            this.btn_FindMean.Text = "Ôn nghĩa";
            this.btn_FindMean.UseVisualStyleBackColor = false;
            this.btn_FindMean.Click += new System.EventHandler(this.btn_FindMean_Click);
            // 
            // btn_Topic
            // 
            this.btn_Topic.BackColor = System.Drawing.Color.Gold;
            this.btn_Topic.FlatAppearance.BorderSize = 0;
            this.btn_Topic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Topic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Topic.Location = new System.Drawing.Point(3, 3);
            this.btn_Topic.Name = "btn_Topic";
            this.btn_Topic.Size = new System.Drawing.Size(81, 33);
            this.btn_Topic.TabIndex = 1;
            this.btn_Topic.Text = "Chủ đề";
            this.btn_Topic.UseVisualStyleBackColor = false;
            this.btn_Topic.Click += new System.EventHandler(this.btn_Topic_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(719, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(33, 26);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // p_RowWord5
            // 
            this.p_RowWord5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p_RowWord5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_RowWord5.Location = new System.Drawing.Point(3, 3);
            this.p_RowWord5.Name = "p_RowWord5";
            this.p_RowWord5.Size = new System.Drawing.Size(500, 110);
            this.p_RowWord5.TabIndex = 4;
            // 
            // p_RowLession7
            // 
            this.p_RowLession7.BackColor = System.Drawing.Color.Bisque;
            this.p_RowLession7.ForeColor = System.Drawing.Color.Black;
            this.p_RowLession7.Location = new System.Drawing.Point(3, 9);
            this.p_RowLession7.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.p_RowLession7.Name = "p_RowLession7";
            this.p_RowLession7.Size = new System.Drawing.Size(180, 65);
            this.p_RowLession7.TabIndex = 7;
            this.p_RowLession7.Tag = 0;
            // 
            // p_PlayFindMean
            // 
            this.p_PlayFindMean.BackColor = System.Drawing.Color.White;
            this.p_PlayFindMean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_PlayFindMean.Location = new System.Drawing.Point(0, 0);
            this.p_PlayFindMean.Name = "p_PlayFindMean";
            this.p_PlayFindMean.Size = new System.Drawing.Size(741, 415);
            this.p_PlayFindMean.TabIndex = 0;
            // 
            // p_PlayFindWord
            // 
            this.p_PlayFindWord.BackColor = System.Drawing.Color.White;
            this.p_PlayFindWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_PlayFindWord.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_PlayFindWord.Location = new System.Drawing.Point(0, 0);
            this.p_PlayFindWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.p_PlayFindWord.Name = "p_PlayFindWord";
            this.p_PlayFindWord.Size = new System.Drawing.Size(741, 415);
            this.p_PlayFindWord.TabIndex = 0;
            // 
            // p_PlayPronounce
            // 
            this.p_PlayPronounce.BackColor = System.Drawing.Color.White;
            this.p_PlayPronounce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_PlayPronounce.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_PlayPronounce.Location = new System.Drawing.Point(0, 0);
            this.p_PlayPronounce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.p_PlayPronounce.Name = "p_PlayPronounce";
            this.p_PlayPronounce.Size = new System.Drawing.Size(741, 415);
            this.p_PlayPronounce.TabIndex = 0;
            // 
            // p_Playing1
            // 
            this.p_Playing1.Location = new System.Drawing.Point(226, 93);
            this.p_Playing1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.p_Playing1.Name = "p_Playing1";
            this.p_Playing1.Size = new System.Drawing.Size(150, 150);
            this.p_Playing1.TabIndex = 0;
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 492);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PracticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PracticeForm";
            this.Activated += new System.EventHandler(this.PracticeForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PracticeForm_FormClosed);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Category.ResumeLayout(false);
            this.flwLayout_Words.ResumeLayout(false);
            this.flwLayout_Lession.ResumeLayout(false);
            this.tabPage_FindMean.ResumeLayout(false);
            this.tabPage_FindCorrect.ResumeLayout(false);
            this.tabPage_Pronounce.ResumeLayout(false);
            this.tabPage_Playing.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Category;
        private System.Windows.Forms.TabPage tabPage_FindCorrect;
        private System.Windows.Forms.FlowLayoutPanel flwLayout_Words;
        private System.Windows.Forms.FlowLayoutPanel flwLayout_Lession;
        private UserControls.p_Play p_PlayFindWord;
        private System.Windows.Forms.TabPage tabPage_FindMean;
        private UserControls.p_Play p_PlayFindMean;
        private System.Windows.Forms.TabPage tabPage_Settings;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.TabPage tabPage_Playing;
        private UserControls.p_Playing p_Playing1;
        private System.Windows.Forms.TabPage tabPage_Pronounce;
        private UserControls.p_Play p_PlayPronounce;
        private Search.UserControls.s_ButtonRound btn_Close;
        private Search.UserControls.s_ButtonRound btn_Topic;
        private Search.UserControls.s_ButtonRound btn_Settings;
        private Search.UserControls.s_ButtonRound btn_Pronounce;
        private Search.UserControls.s_ButtonRound btn_FindWord;
        private Search.UserControls.s_ButtonRound btn_FindMean;
        private Search.UserControls.s_ButtonRound btn_Sound;
        private UserControls.p_RowWord p_RowWord5;
        private UserControls.p_RowLession p_RowLession7;
        private System.Windows.Forms.Timer timer_CheckLessionClick;
    }
}