
namespace Dictionary.Forms.Search
{
    partial class Search
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.cBox_Dics = new System.Windows.Forms.ComboBox();
            this.rBtn_AllDics = new System.Windows.Forms.RadioButton();
            this.rBtn_SelDic = new System.Windows.Forms.RadioButton();
            this.lb_search = new System.Windows.Forms.Label();
            this.tBox_search = new System.Windows.Forms.TextBox();
            this.panel_Word = new System.Windows.Forms.Panel();
            this.btn_DelWord = new System.Windows.Forms.Button();
            this.btn_ModifyWord = new System.Windows.Forms.Button();
            this.btn_Mask = new System.Windows.Forms.Button();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.rTBox_Word = new System.Windows.Forms.RichTextBox();
            this.tabControl_Side = new System.Windows.Forms.TabControl();
            this.tabPage_Search = new System.Windows.Forms.TabPage();
            this.flwLayout_Search = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage_HistorySearch = new System.Windows.Forms.TabPage();
            this.flwLayout_HistorySearch = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage_DetailDic = new System.Windows.Forms.TabPage();
            this.treeView_DetailDic = new System.Windows.Forms.TreeView();
            this.tabPage_Mask = new System.Windows.Forms.TabPage();
            this.tabControl_Top = new System.Windows.Forms.TabControl();
            this.tabPage_Dics = new System.Windows.Forms.TabPage();
            this.grBox_ToolDics = new System.Windows.Forms.GroupBox();
            this.btn_SaveDics = new System.Windows.Forms.Button();
            this.btn_ReloadDics = new System.Windows.Forms.Button();
            this.grBox_ModifyDics = new System.Windows.Forms.GroupBox();
            this.btn_DelDics = new System.Windows.Forms.Button();
            this.btn_AddWord = new System.Windows.Forms.Button();
            this.btn_AddDics = new System.Windows.Forms.Button();
            this.tabPage_Help = new System.Windows.Forms.TabPage();
            this.grBox_Extentions = new System.Windows.Forms.GroupBox();
            this.btn_Game = new System.Windows.Forms.Button();
            this.btn_Practice = new System.Windows.Forms.Button();
            this.grBox_Settings = new System.Windows.Forms.GroupBox();
            this.btn_ExportDic = new System.Windows.Forms.Button();
            this.btn_ResotreSetting = new System.Windows.Forms.Button();
            this.btn_Minimize = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.btn_Close = new Dictionary.Forms.Search.UserControls.s_ButtonRound();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.panel_Word.SuspendLayout();
            this.tabControl_Side.SuspendLayout();
            this.tabPage_Search.SuspendLayout();
            this.tabPage_HistorySearch.SuspendLayout();
            this.tabPage_DetailDic.SuspendLayout();
            this.tabControl_Top.SuspendLayout();
            this.tabPage_Dics.SuspendLayout();
            this.grBox_ToolDics.SuspendLayout();
            this.grBox_ModifyDics.SuspendLayout();
            this.tabPage_Help.SuspendLayout();
            this.grBox_Extentions.SuspendLayout();
            this.grBox_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Main.Controls.Add(this.btn_Minimize);
            this.panel_Main.Controls.Add(this.picBox_logo);
            this.panel_Main.Controls.Add(this.Btn_Search);
            this.panel_Main.Controls.Add(this.cBox_Dics);
            this.panel_Main.Controls.Add(this.rBtn_AllDics);
            this.panel_Main.Controls.Add(this.rBtn_SelDic);
            this.panel_Main.Controls.Add(this.lb_search);
            this.panel_Main.Controls.Add(this.tBox_search);
            this.panel_Main.Controls.Add(this.panel_Word);
            this.panel_Main.Controls.Add(this.tabControl_Side);
            this.panel_Main.Controls.Add(this.tabControl_Top);
            this.panel_Main.Controls.Add(this.btn_Close);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(950, 500);
            this.panel_Main.TabIndex = 0;
            this.panel_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // picBox_logo
            // 
            this.picBox_logo.Location = new System.Drawing.Point(833, 31);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(111, 68);
            this.picBox_logo.TabIndex = 11;
            this.picBox_logo.TabStop = false;
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.Gray;
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(145, 83);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(97, 23);
            this.Btn_Search.TabIndex = 10;
            this.Btn_Search.Text = "Tìm kiếm";
            this.Btn_Search.UseVisualStyleBackColor = false;
            // 
            // cBox_Dics
            // 
            this.cBox_Dics.FormattingEnabled = true;
            this.cBox_Dics.Location = new System.Drawing.Point(110, 54);
            this.cBox_Dics.Name = "cBox_Dics";
            this.cBox_Dics.Size = new System.Drawing.Size(132, 21);
            this.cBox_Dics.TabIndex = 9;
            // 
            // rBtn_AllDics
            // 
            this.rBtn_AllDics.AutoSize = true;
            this.rBtn_AllDics.Checked = true;
            this.rBtn_AllDics.Location = new System.Drawing.Point(11, 86);
            this.rBtn_AllDics.Name = "rBtn_AllDics";
            this.rBtn_AllDics.Size = new System.Drawing.Size(95, 17);
            this.rBtn_AllDics.TabIndex = 8;
            this.rBtn_AllDics.TabStop = true;
            this.rBtn_AllDics.Text = "Tất cả từ điển";
            this.rBtn_AllDics.UseVisualStyleBackColor = true;
            // 
            // rBtn_SelDic
            // 
            this.rBtn_SelDic.AutoSize = true;
            this.rBtn_SelDic.Location = new System.Drawing.Point(11, 55);
            this.rBtn_SelDic.Name = "rBtn_SelDic";
            this.rBtn_SelDic.Size = new System.Drawing.Size(93, 17);
            this.rBtn_SelDic.TabIndex = 7;
            this.rBtn_SelDic.TabStop = true;
            this.rBtn_SelDic.Text = "Chọn từ điển";
            this.rBtn_SelDic.UseVisualStyleBackColor = true;
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_search.Location = new System.Drawing.Point(11, 8);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(59, 15);
            this.lb_search.TabIndex = 6;
            this.lb_search.Text = "Tìm kiếm";
            // 
            // tBox_search
            // 
            this.tBox_search.Location = new System.Drawing.Point(11, 26);
            this.tBox_search.Name = "tBox_search";
            this.tBox_search.Size = new System.Drawing.Size(231, 22);
            this.tBox_search.TabIndex = 5;
            // 
            // panel_Word
            // 
            this.panel_Word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Word.BackColor = System.Drawing.Color.White;
            this.panel_Word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Word.Controls.Add(this.btn_DelWord);
            this.panel_Word.Controls.Add(this.btn_ModifyWord);
            this.panel_Word.Controls.Add(this.btn_Mask);
            this.panel_Word.Controls.Add(this.btn_Listen);
            this.panel_Word.Controls.Add(this.rTBox_Word);
            this.panel_Word.Location = new System.Drawing.Point(255, 112);
            this.panel_Word.Name = "panel_Word";
            this.panel_Word.Size = new System.Drawing.Size(690, 379);
            this.panel_Word.TabIndex = 4;
            this.panel_Word.TabStop = true;
            // 
            // btn_DelWord
            // 
            this.btn_DelWord.BackColor = System.Drawing.Color.Gray;
            this.btn_DelWord.FlatAppearance.BorderSize = 0;
            this.btn_DelWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DelWord.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DelWord.ForeColor = System.Drawing.Color.White;
            this.btn_DelWord.Location = new System.Drawing.Point(3, 94);
            this.btn_DelWord.Name = "btn_DelWord";
            this.btn_DelWord.Size = new System.Drawing.Size(75, 25);
            this.btn_DelWord.TabIndex = 7;
            this.btn_DelWord.Text = "Xóa từ";
            this.btn_DelWord.UseVisualStyleBackColor = false;
            // 
            // btn_ModifyWord
            // 
            this.btn_ModifyWord.BackColor = System.Drawing.Color.Gray;
            this.btn_ModifyWord.FlatAppearance.BorderSize = 0;
            this.btn_ModifyWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModifyWord.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModifyWord.ForeColor = System.Drawing.Color.White;
            this.btn_ModifyWord.Location = new System.Drawing.Point(3, 63);
            this.btn_ModifyWord.Name = "btn_ModifyWord";
            this.btn_ModifyWord.Size = new System.Drawing.Size(75, 25);
            this.btn_ModifyWord.TabIndex = 6;
            this.btn_ModifyWord.Text = "Sửa từ";
            this.btn_ModifyWord.UseVisualStyleBackColor = false;
            // 
            // btn_Mask
            // 
            this.btn_Mask.BackColor = System.Drawing.Color.Gray;
            this.btn_Mask.FlatAppearance.BorderSize = 0;
            this.btn_Mask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mask.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mask.ForeColor = System.Drawing.Color.White;
            this.btn_Mask.Location = new System.Drawing.Point(3, 32);
            this.btn_Mask.Name = "btn_Mask";
            this.btn_Mask.Size = new System.Drawing.Size(75, 25);
            this.btn_Mask.TabIndex = 5;
            this.btn_Mask.Text = "Đánh dấu";
            this.btn_Mask.UseVisualStyleBackColor = false;
            // 
            // btn_Listen
            // 
            this.btn_Listen.BackColor = System.Drawing.Color.Gray;
            this.btn_Listen.FlatAppearance.BorderSize = 0;
            this.btn_Listen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listen.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listen.ForeColor = System.Drawing.Color.White;
            this.btn_Listen.Location = new System.Drawing.Point(3, 3);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(75, 23);
            this.btn_Listen.TabIndex = 4;
            this.btn_Listen.Text = "Nghe";
            this.btn_Listen.UseVisualStyleBackColor = false;
            // 
            // rTBox_Word
            // 
            this.rTBox_Word.BackColor = System.Drawing.Color.White;
            this.rTBox_Word.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBox_Word.Cursor = System.Windows.Forms.Cursors.Default;
            this.rTBox_Word.Dock = System.Windows.Forms.DockStyle.Right;
            this.rTBox_Word.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBox_Word.Location = new System.Drawing.Point(84, 0);
            this.rTBox_Word.Name = "rTBox_Word";
            this.rTBox_Word.ReadOnly = true;
            this.rTBox_Word.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTBox_Word.Size = new System.Drawing.Size(604, 377);
            this.rTBox_Word.TabIndex = 3;
            this.rTBox_Word.Text = "ddsadsa\ndas\nd\nsad\n\nasdsadsa\nd\nsad\n\nasd\nas\nd\nas\nd\nasd\nasda";
            // 
            // tabControl_Side
            // 
            this.tabControl_Side.Controls.Add(this.tabPage_Search);
            this.tabControl_Side.Controls.Add(this.tabPage_HistorySearch);
            this.tabControl_Side.Controls.Add(this.tabPage_DetailDic);
            this.tabControl_Side.Controls.Add(this.tabPage_Mask);
            this.tabControl_Side.Location = new System.Drawing.Point(11, 112);
            this.tabControl_Side.Name = "tabControl_Side";
            this.tabControl_Side.SelectedIndex = 0;
            this.tabControl_Side.Size = new System.Drawing.Size(238, 383);
            this.tabControl_Side.TabIndex = 2;
            // 
            // tabPage_Search
            // 
            this.tabPage_Search.Controls.Add(this.flwLayout_Search);
            this.tabPage_Search.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Search.Name = "tabPage_Search";
            this.tabPage_Search.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Search.Size = new System.Drawing.Size(230, 357);
            this.tabPage_Search.TabIndex = 0;
            this.tabPage_Search.Text = "Tìm kiếm";
            this.tabPage_Search.UseVisualStyleBackColor = true;
            // 
            // flwLayout_Search
            // 
            this.flwLayout_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwLayout_Search.Location = new System.Drawing.Point(3, 3);
            this.flwLayout_Search.Name = "flwLayout_Search";
            this.flwLayout_Search.Size = new System.Drawing.Size(224, 351);
            this.flwLayout_Search.TabIndex = 0;
            // 
            // tabPage_HistorySearch
            // 
            this.tabPage_HistorySearch.Controls.Add(this.flwLayout_HistorySearch);
            this.tabPage_HistorySearch.Location = new System.Drawing.Point(4, 22);
            this.tabPage_HistorySearch.Name = "tabPage_HistorySearch";
            this.tabPage_HistorySearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HistorySearch.Size = new System.Drawing.Size(230, 357);
            this.tabPage_HistorySearch.TabIndex = 1;
            this.tabPage_HistorySearch.Text = "Lịch sử";
            this.tabPage_HistorySearch.UseVisualStyleBackColor = true;
            // 
            // flwLayout_HistorySearch
            // 
            this.flwLayout_HistorySearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwLayout_HistorySearch.Location = new System.Drawing.Point(3, 3);
            this.flwLayout_HistorySearch.Name = "flwLayout_HistorySearch";
            this.flwLayout_HistorySearch.Size = new System.Drawing.Size(224, 351);
            this.flwLayout_HistorySearch.TabIndex = 0;
            // 
            // tabPage_DetailDic
            // 
            this.tabPage_DetailDic.BackColor = System.Drawing.Color.White;
            this.tabPage_DetailDic.Controls.Add(this.treeView_DetailDic);
            this.tabPage_DetailDic.ForeColor = System.Drawing.Color.Goldenrod;
            this.tabPage_DetailDic.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DetailDic.Name = "tabPage_DetailDic";
            this.tabPage_DetailDic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DetailDic.Size = new System.Drawing.Size(230, 357);
            this.tabPage_DetailDic.TabIndex = 2;
            this.tabPage_DetailDic.Text = "Chi tiết TĐ";
            // 
            // treeView_DetailDic
            // 
            this.treeView_DetailDic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_DetailDic.Location = new System.Drawing.Point(3, 3);
            this.treeView_DetailDic.Name = "treeView_DetailDic";
            this.treeView_DetailDic.Size = new System.Drawing.Size(224, 351);
            this.treeView_DetailDic.TabIndex = 4;
            // 
            // tabPage_Mask
            // 
            this.tabPage_Mask.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Mask.Name = "tabPage_Mask";
            this.tabPage_Mask.Size = new System.Drawing.Size(230, 357);
            this.tabPage_Mask.TabIndex = 3;
            this.tabPage_Mask.Text = "Đánh dấu";
            this.tabPage_Mask.UseVisualStyleBackColor = true;
            // 
            // tabControl_Top
            // 
            this.tabControl_Top.Controls.Add(this.tabPage_Dics);
            this.tabControl_Top.Controls.Add(this.tabPage_Help);
            this.tabControl_Top.Location = new System.Drawing.Point(255, 3);
            this.tabControl_Top.Name = "tabControl_Top";
            this.tabControl_Top.SelectedIndex = 0;
            this.tabControl_Top.Size = new System.Drawing.Size(576, 100);
            this.tabControl_Top.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Top.TabIndex = 1;
            // 
            // tabPage_Dics
            // 
            this.tabPage_Dics.Controls.Add(this.grBox_ToolDics);
            this.tabPage_Dics.Controls.Add(this.grBox_ModifyDics);
            this.tabPage_Dics.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Dics.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Dics.Name = "tabPage_Dics";
            this.tabPage_Dics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dics.Size = new System.Drawing.Size(568, 74);
            this.tabPage_Dics.TabIndex = 0;
            this.tabPage_Dics.Text = "Từ điển";
            this.tabPage_Dics.UseVisualStyleBackColor = true;
            // 
            // grBox_ToolDics
            // 
            this.grBox_ToolDics.Controls.Add(this.btn_SaveDics);
            this.grBox_ToolDics.Controls.Add(this.btn_ReloadDics);
            this.grBox_ToolDics.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox_ToolDics.Location = new System.Drawing.Point(6, 6);
            this.grBox_ToolDics.Name = "grBox_ToolDics";
            this.grBox_ToolDics.Size = new System.Drawing.Size(201, 62);
            this.grBox_ToolDics.TabIndex = 16;
            this.grBox_ToolDics.TabStop = false;
            this.grBox_ToolDics.Text = "Công cụ";
            // 
            // btn_SaveDics
            // 
            this.btn_SaveDics.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_SaveDics.FlatAppearance.BorderSize = 0;
            this.btn_SaveDics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveDics.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveDics.ForeColor = System.Drawing.Color.White;
            this.btn_SaveDics.Location = new System.Drawing.Point(6, 23);
            this.btn_SaveDics.Name = "btn_SaveDics";
            this.btn_SaveDics.Size = new System.Drawing.Size(90, 28);
            this.btn_SaveDics.TabIndex = 12;
            this.btn_SaveDics.Text = "Lưu thay đổi";
            this.btn_SaveDics.UseVisualStyleBackColor = false;
            // 
            // btn_ReloadDics
            // 
            this.btn_ReloadDics.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ReloadDics.FlatAppearance.BorderSize = 0;
            this.btn_ReloadDics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReloadDics.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReloadDics.ForeColor = System.Drawing.Color.White;
            this.btn_ReloadDics.Location = new System.Drawing.Point(102, 23);
            this.btn_ReloadDics.Name = "btn_ReloadDics";
            this.btn_ReloadDics.Size = new System.Drawing.Size(90, 28);
            this.btn_ReloadDics.TabIndex = 11;
            this.btn_ReloadDics.Text = "Tải lại từ điển";
            this.btn_ReloadDics.UseVisualStyleBackColor = false;
            // 
            // grBox_ModifyDics
            // 
            this.grBox_ModifyDics.Controls.Add(this.btn_DelDics);
            this.grBox_ModifyDics.Controls.Add(this.btn_AddWord);
            this.grBox_ModifyDics.Controls.Add(this.btn_AddDics);
            this.grBox_ModifyDics.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox_ModifyDics.Location = new System.Drawing.Point(213, 6);
            this.grBox_ModifyDics.Name = "grBox_ModifyDics";
            this.grBox_ModifyDics.Size = new System.Drawing.Size(349, 62);
            this.grBox_ModifyDics.TabIndex = 15;
            this.grBox_ModifyDics.TabStop = false;
            this.grBox_ModifyDics.Text = "Thêm - xóa";
            // 
            // btn_DelDics
            // 
            this.btn_DelDics.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_DelDics.FlatAppearance.BorderSize = 0;
            this.btn_DelDics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DelDics.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DelDics.ForeColor = System.Drawing.Color.White;
            this.btn_DelDics.Location = new System.Drawing.Point(6, 23);
            this.btn_DelDics.Name = "btn_DelDics";
            this.btn_DelDics.Size = new System.Drawing.Size(90, 28);
            this.btn_DelDics.TabIndex = 15;
            this.btn_DelDics.Text = "Xóa từ điển";
            this.btn_DelDics.UseVisualStyleBackColor = false;
            // 
            // btn_AddWord
            // 
            this.btn_AddWord.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_AddWord.FlatAppearance.BorderSize = 0;
            this.btn_AddWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddWord.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddWord.ForeColor = System.Drawing.Color.White;
            this.btn_AddWord.Location = new System.Drawing.Point(198, 23);
            this.btn_AddWord.Name = "btn_AddWord";
            this.btn_AddWord.Size = new System.Drawing.Size(141, 28);
            this.btn_AddWord.TabIndex = 14;
            this.btn_AddWord.Text = "Thêm từ vựng mới";
            this.btn_AddWord.UseVisualStyleBackColor = false;
            // 
            // btn_AddDics
            // 
            this.btn_AddDics.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_AddDics.FlatAppearance.BorderSize = 0;
            this.btn_AddDics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDics.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddDics.ForeColor = System.Drawing.Color.White;
            this.btn_AddDics.Location = new System.Drawing.Point(102, 23);
            this.btn_AddDics.Name = "btn_AddDics";
            this.btn_AddDics.Size = new System.Drawing.Size(90, 28);
            this.btn_AddDics.TabIndex = 13;
            this.btn_AddDics.Text = "Thêm từ điển";
            this.btn_AddDics.UseVisualStyleBackColor = false;
            // 
            // tabPage_Help
            // 
            this.tabPage_Help.Controls.Add(this.grBox_Extentions);
            this.tabPage_Help.Controls.Add(this.grBox_Settings);
            this.tabPage_Help.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Help.Name = "tabPage_Help";
            this.tabPage_Help.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Help.Size = new System.Drawing.Size(568, 74);
            this.tabPage_Help.TabIndex = 1;
            this.tabPage_Help.Text = "Trợ giúp";
            this.tabPage_Help.UseVisualStyleBackColor = true;
            // 
            // grBox_Extentions
            // 
            this.grBox_Extentions.Controls.Add(this.btn_Game);
            this.grBox_Extentions.Controls.Add(this.btn_Practice);
            this.grBox_Extentions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox_Extentions.Location = new System.Drawing.Point(6, 6);
            this.grBox_Extentions.Name = "grBox_Extentions";
            this.grBox_Extentions.Size = new System.Drawing.Size(201, 62);
            this.grBox_Extentions.TabIndex = 1;
            this.grBox_Extentions.TabStop = false;
            this.grBox_Extentions.Text = "Tiện ích";
            // 
            // btn_Game
            // 
            this.btn_Game.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Game.FlatAppearance.BorderSize = 0;
            this.btn_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Game.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Game.ForeColor = System.Drawing.Color.White;
            this.btn_Game.Location = new System.Drawing.Point(102, 23);
            this.btn_Game.Name = "btn_Game";
            this.btn_Game.Size = new System.Drawing.Size(90, 28);
            this.btn_Game.TabIndex = 14;
            this.btn_Game.Text = "Trò chơi";
            this.btn_Game.UseVisualStyleBackColor = false;
            this.btn_Game.Click += new System.EventHandler(this.btn_Game_Click);
            // 
            // btn_Practice
            // 
            this.btn_Practice.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Practice.FlatAppearance.BorderSize = 0;
            this.btn_Practice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Practice.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Practice.ForeColor = System.Drawing.Color.White;
            this.btn_Practice.Location = new System.Drawing.Point(6, 23);
            this.btn_Practice.Name = "btn_Practice";
            this.btn_Practice.Size = new System.Drawing.Size(90, 28);
            this.btn_Practice.TabIndex = 13;
            this.btn_Practice.Text = "Luyện tập";
            this.btn_Practice.UseVisualStyleBackColor = false;
            this.btn_Practice.Click += new System.EventHandler(this.btn_Practice_Click);
            // 
            // grBox_Settings
            // 
            this.grBox_Settings.Controls.Add(this.btn_ExportDic);
            this.grBox_Settings.Controls.Add(this.btn_ResotreSetting);
            this.grBox_Settings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox_Settings.Location = new System.Drawing.Point(213, 6);
            this.grBox_Settings.Name = "grBox_Settings";
            this.grBox_Settings.Size = new System.Drawing.Size(349, 62);
            this.grBox_Settings.TabIndex = 0;
            this.grBox_Settings.TabStop = false;
            this.grBox_Settings.Text = "Cài đặt";
            // 
            // btn_ExportDic
            // 
            this.btn_ExportDic.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ExportDic.FlatAppearance.BorderSize = 0;
            this.btn_ExportDic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportDic.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportDic.ForeColor = System.Drawing.Color.White;
            this.btn_ExportDic.Location = new System.Drawing.Point(142, 23);
            this.btn_ExportDic.Name = "btn_ExportDic";
            this.btn_ExportDic.Size = new System.Drawing.Size(113, 28);
            this.btn_ExportDic.TabIndex = 16;
            this.btn_ExportDic.Text = "Xuất từ điển";
            this.btn_ExportDic.UseVisualStyleBackColor = false;
            // 
            // btn_ResotreSetting
            // 
            this.btn_ResotreSetting.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ResotreSetting.FlatAppearance.BorderSize = 0;
            this.btn_ResotreSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResotreSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResotreSetting.ForeColor = System.Drawing.Color.White;
            this.btn_ResotreSetting.Location = new System.Drawing.Point(6, 23);
            this.btn_ResotreSetting.Name = "btn_ResotreSetting";
            this.btn_ResotreSetting.Size = new System.Drawing.Size(130, 28);
            this.btn_ResotreSetting.TabIndex = 15;
            this.btn_ResotreSetting.Text = "Khôi phục ứng dụng";
            this.btn_ResotreSetting.UseVisualStyleBackColor = false;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Minimize.Location = new System.Drawing.Point(875, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(31, 22);
            this.btn_Minimize.TabIndex = 12;
            this.btn_Minimize.Text = "-";
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Close.Location = new System.Drawing.Point(909, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 22);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.panel_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.panel_Word.ResumeLayout(false);
            this.tabControl_Side.ResumeLayout(false);
            this.tabPage_Search.ResumeLayout(false);
            this.tabPage_HistorySearch.ResumeLayout(false);
            this.tabPage_DetailDic.ResumeLayout(false);
            this.tabControl_Top.ResumeLayout(false);
            this.tabPage_Dics.ResumeLayout(false);
            this.grBox_ToolDics.ResumeLayout(false);
            this.grBox_ModifyDics.ResumeLayout(false);
            this.tabPage_Help.ResumeLayout(false);
            this.grBox_Extentions.ResumeLayout(false);
            this.grBox_Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private UserControls.s_ButtonRound btn_Close;
        private System.Windows.Forms.RichTextBox rTBox_Word;
        private System.Windows.Forms.TabControl tabControl_Side;
        private System.Windows.Forms.TabPage tabPage_Search;
        private System.Windows.Forms.TabPage tabPage_HistorySearch;
        private System.Windows.Forms.TabControl tabControl_Top;
        private System.Windows.Forms.TabPage tabPage_Dics;
        private System.Windows.Forms.TabPage tabPage_Help;
        private System.Windows.Forms.Panel panel_Word;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.TextBox tBox_search;
        private System.Windows.Forms.RadioButton rBtn_AllDics;
        private System.Windows.Forms.RadioButton rBtn_SelDic;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.ComboBox cBox_Dics;
        private System.Windows.Forms.TabPage tabPage_DetailDic;
        private System.Windows.Forms.FlowLayoutPanel flwLayout_Search;
        private System.Windows.Forms.FlowLayoutPanel flwLayout_HistorySearch;
        private System.Windows.Forms.TreeView treeView_DetailDic;
        private System.Windows.Forms.Button btn_Mask;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.TabPage tabPage_Mask;
        private System.Windows.Forms.Button btn_SaveDics;
        private System.Windows.Forms.Button btn_ReloadDics;
        private System.Windows.Forms.Button btn_ModifyWord;
        private System.Windows.Forms.Button btn_AddDics;
        private System.Windows.Forms.Button btn_AddWord;
        private System.Windows.Forms.GroupBox grBox_ToolDics;
        private System.Windows.Forms.GroupBox grBox_ModifyDics;
        private System.Windows.Forms.Button btn_DelDics;
        private System.Windows.Forms.Button btn_DelWord;
        private System.Windows.Forms.GroupBox grBox_Extentions;
        private System.Windows.Forms.Button btn_Game;
        private System.Windows.Forms.Button btn_Practice;
        private System.Windows.Forms.GroupBox grBox_Settings;
        private System.Windows.Forms.Button btn_ResotreSetting;
        private System.Windows.Forms.Button btn_ExportDic;
        private System.Windows.Forms.PictureBox picBox_logo;
        private UserControls.s_ButtonRound btn_Minimize;
    }
}