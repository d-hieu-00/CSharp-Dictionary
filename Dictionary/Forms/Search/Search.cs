using Dictionary.Forms.Search.UserControls;
using Dictionary.Resources.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dictionary.Classes;
using Dictionary.Resources;

namespace Dictionary.Forms.Search
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            flwLayout_Search.AutoScroll = true;
            flwLayout_Search.HorizontalScroll.Enabled = false;
            flwLayout_HistorySearch.AutoScroll = true;
            flwLayout_HistorySearch.HorizontalScroll.Enabled = false;
            flwLayout_MaskWord.AutoScroll = true;
            flwLayout_MaskWord.HorizontalScroll.Enabled = false;

            rTBox_Word.ScrollBars = RichTextBoxScrollBars.Vertical;
        }

        #region loading combobox
        public void LoadInit()
        {
            LoadComboBoxDics();
            LoadHistory();
            LoadFacvorite();
            LoadCBoxSize();
        }
        public void LoadComboBoxDics()
        {
            cBox_Dics.Items.Clear();
            
            foreach (var i in Resources.Resources.dics)
            {
                cBox_Dics.Items.Add(i.Name);
            }
            if (cBox_Dics.Items.Count > 0)
                cBox_Dics.SelectedIndex = 0;
            if (rBtn_SelDic.Checked)
                cBox_Dics.Enabled = true;
            else
                cBox_Dics.Enabled = false;
        }

        public void LoadHistory()
        {
            var s = flwLayout_HistorySearch;
            s.Controls.Clear();
            s.SuspendLayout();
            foreach (var i in Resources.Resources.user.History)
            {
                var idic = i.Key;
                var nameDic = Resources.Resources.dics[idic].Name;
                foreach (var _i in i.Value)
                {
                    var r = new s_RowHistory(_i.Key, _i.Value, nameDic, idic);
                    s.Controls.Add(r);
                    s.Controls.SetChildIndex(r, 0);
                }
            }
            s.ResumeLayout();
        }

        public void LoadFacvorite()
        {
            var s = flwLayout_MaskWord;
            s.Controls.Clear();
            s.SuspendLayout();
            foreach (var i in Resources.Resources.user.Favorite)
            {
                var idic = i.Key;
                var nameDic = Resources.Resources.dics[idic].Name;
                foreach (var _i in i.Value)
                {
                    var r = new s_RowMaskWord(_i.Key, _i.Value, nameDic, idic);
                    s.Controls.Add(r);
                }
            }
            s.ResumeLayout();
        }

        public void LoadCBoxSize()
        {
            cbox_SizeSearch.SelectedItem = Config.DefaultShowSearch.ToString();
        }

        private void rBtn_SelDic_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_SelDic.Checked)
                cBox_Dics.Enabled = true;
            else
                cBox_Dics.Enabled = false;
        }
        #endregion

        #region  handle FormDagging
        private bool dragging = false;
        private Point startPoint;
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        #region make shadow from
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000;
                return cp;
            }
        }
        #endregion

        #region button close, minimize, open form
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btn_Practice_Click(object sender, EventArgs e)
        {
            Resources.Resources.main.practiceForm.Show();
        }

        private void btn_Game_Click(object sender, EventArgs e)
        {
            Resources.Resources.main.gamesForm.Show();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region panel search
        public bool _clickSearch = false;
        private void timerCheckClickSearch_Tick(object sender, EventArgs e)
        {
            if (_clickSearch)
            {
                _clickSearch = false;
                var s = flwLayout_Search;
                foreach (var i in s.Controls)
                {
                    var t = (i as Control);
                    if (t != null && t.Tag != null && (int)t.Tag == 1)
                    {
                        var info = (i as s_RowSearch);
                        info.BackColor = Color.Gainsboro;
                        t.Tag = 0;
                        Task.Run(() =>
                        {
                            Utility.LoadWord(info.val, info.indVal, info.indDic, rTBox_Word);
                        });
                    }
                    else if (t != null)
                        (i as Control).BackColor = Color.White;
                }
            }
        }
        #endregion

        #region panel history
        public bool _addHistory = false;
        public bool _clickHistory = false;
        public bool _delHistory = false;
        private void timerCheckHistory_Tick(object sender, EventArgs e)
        {
            if (_addHistory)
            {
                _addHistory = false;
                LoadHistory();
            }
            if (_clickHistory)
            {
                _clickHistory = false;
                var s = flwLayout_HistorySearch;
                foreach (var i in s.Controls)
                {
                    var t = (i as Control);
                    if (t != null && t.Tag != null && (int)t.Tag == 1)
                    {
                        var info = (i as s_RowHistory);
                        info.BackColor = Color.Gainsboro;
                        t.Tag = 0;
                        Task.Run(() =>
                        {
                            Utility.LoadWord(info.val, info.indVal, info.indDic, rTBox_Word);
                        });
                    }
                    else if (t != null)
                        (i as Control).BackColor = Color.White;
                }
            }
            if (_delHistory)
            {
                _delHistory = false;
                var s = flwLayout_HistorySearch;
                for (var i=0; i<s.Controls.Count; i++)
                {
                    var t = (s.Controls[i] as Control);
                    if (t != null && t.Tag != null && (int)t.Tag == 2)
                    {
                        t.Tag = 0;
                        s.Controls.Remove(s.Controls[i]);
                    }
                    else if (t != null)
                        (s.Controls[i] as Control).BackColor = Color.White;
                }
            }
        }
        #endregion

        #region panel mask word
        public bool _addFavorite = false;
        public bool _clickFavorite = false;
        public bool _delFacvorite = false;
        private void timerCheckMaskWord_Tick(object sender, EventArgs e)
        {
            if (_addFavorite)
            {
                _addFavorite = false;
                LoadFacvorite();
            }
            if (_clickFavorite)
            {
                _clickFavorite = false;
                var s = flwLayout_MaskWord;
                foreach (var i in s.Controls)
                {
                    var t = (i as Control);
                    if (t != null && t.Tag != null && (int)t.Tag == 1)
                    {
                        var info = (i as s_RowMaskWord);
                        info.BackColor = Color.Gainsboro;
                        t.Tag = 0;
                        Task.Run(() =>
                        {
                            Utility.LoadWord(info.val, info.indVal, info.indDic, rTBox_Word);
                        });
                    }
                    else if (t != null)
                        (i as Control).BackColor = Color.White;
                }
            }
            if (_delFacvorite)
            {
                _delFacvorite = false;
                var s = flwLayout_MaskWord;
                for (var i = 0; i < s.Controls.Count; i++)
                {
                    var t = (s.Controls[i] as Control);
                    if (t != null && t.Tag != null && (int)t.Tag == 2)
                    {
                        t.Tag = 0;
                        s.Controls.Remove(s.Controls[i]);
                    }
                    else if (t != null)
                        (s.Controls[i] as Control).BackColor = Color.White;
                }
            }
        }
        #endregion

        #region panel detail
        private void timerCheckDetailDic_Tick(object sender, EventArgs e)
        {

        }
        #endregion

        #region search, richtextbox
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            int ind = -1;
            if (rBtn_SelDic.Checked)
                ind = cBox_Dics.SelectedIndex;
            if (Resources.Resources.dics.Count == 0)
            {
                MessageBox.Show("Chưa có từ điển !!", "Lỗi tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string q = tBox_search.Text;
            var s = flwLayout_Search;
            s.Controls.Clear();
            s.SuspendLayout();
            var lb = new Label();
            lb.Text = "Kết quả tìm kiếm: ";
            lb.Font = Classes.Config.defFont;
            lb.AutoSize = false;
            lb.Size = new Size(200, 25);
            s.Controls.Add(lb);
            for (var i = 0; i < Resources.Resources.dics.Count; i++)
            {
                if (ind > 0 && ind != i)
                    continue;
                Dictionary<string, int> dic = Resources.Resources.dics[i].SearchByFristString(q);
                foreach (var _i in dic)
                {
                    var r = new s_RowSearch(_i.Key, _i.Value, Resources.Resources.dics[i].Name, i);
                    s.Controls.Add(r);
                }
            }
            s.ResumeLayout();
        }

        private void tBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Search.PerformClick();
            }
        }
        #endregion

        #region funciton word, listen
        private void btn_Listen_Click(object sender, EventArgs e)
        {
            if (rTBox_Word.Tag == null)
            {
                MessageBox.Show("Chưa chọn từ hiện thị", "Lỗi nghe từ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Word w = rTBox_Word.Tag as Word;
            /*Task.Run(() =>
            {*/
            Cursor = Cursors.WaitCursor;
            if (w.Audio == null)
                w.Audio = Utility.GetAudioByWord(w.Vocabulary);
            //MessageBox.Show(w.Audio);
            if (w.Audio != "" && w.Audio != null)
                Utility.PlayMp3FromUrl(w.Audio);
            else
                MessageBox.Show("Không có dữ liệu", "Lỗi nghe từ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Cursor = Cursors.Default;
        }

        #endregion

        #region button, cbox change
        private void btn_ReloadDics_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            for (int i = 0; i < Resources.Resources.dics.Count; i++)
                Resources.Resources.dics[i].Reload();
            _needSave = false;
            Cursor = Cursors.Default;
        }
        private void btn_Mask_Click(object sender, EventArgs e)
        {
            if (rTBox_Word.Tag == null)
            {
                MessageBox.Show("Chưa chọn từ hiện thị", "Lỗi lưu từ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var s = rTBox_Word.Name.Split('\t');
            try
            {
                Resources.Resources.user.AddUpdateFavorite(Convert.ToInt32(s[2]), s[0], Convert.ToInt32(s[1]));
                Resources.Resources.user.Save();
                _addFavorite = true;
                MessageBox.Show("Lưu từ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi lưu từ", "Lỗi khi thêm từ yêu thích", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_DelAllHistory_Click(object sender, EventArgs e)
        {
            Resources.Resources.user.History = new Dictionary<int, Dictionary<string, int>>();
            Resources.Resources.user.Save();
            LoadHistory();
        }
        private void btn_AddWord_Click(object sender, EventArgs e)
        {
            var wForm = new WordForm(cBox_Dics.SelectedIndex);
            wForm.Show();
        }
        private void btn_ModifyWord_Click(object sender, EventArgs e)
        {
            if (rTBox_Word.Tag == null)
            {
                MessageBox.Show("Chưa chọn từ hiện thị", "Lỗi lưu từ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var s = rTBox_Word.Name.Split('\t');
            try
            {
                Resources.Resources.user.AddUpdateFavorite(Convert.ToInt32(s[2]), s[0], Convert.ToInt32(s[1]));
                Resources.Resources.user.Save();
                var wForm = new WordForm(Convert.ToInt32(s[2]), s[0], Convert.ToInt32(s[1]));
                wForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi lưu từ", "Lỗi khi thêm từ yêu thích", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DelWord_Click(object sender, EventArgs e)
        {
            if (rTBox_Word.Tag == null)
            {
                MessageBox.Show("Chưa chọn từ hiện thị", "Lỗi lưu từ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var s = rTBox_Word.Name.Split('\t');
            try
            {
                var r = MessageBox.Show("Muốn xóa từ '" + s[0] + "' trong từ điển - " +
                    Resources.Resources.dics[Convert.ToInt32(s[2])].Name, "Xác nhận xóa", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    Resources.Resources.dics[Convert.ToInt32(s[2])].Remove(s[0], Convert.ToInt32(s[1]));
                    _needSave = true;
                    rTBox_Word.Text = "";
                    rTBox_Word.Tag = null;
                    if (Resources.Resources.user.RemoveFavorite(Convert.ToInt32(s[2]), s[0]))
                        LoadFacvorite();
                    if (Resources.Resources.user.RemoveHistory(Convert.ToInt32(s[2]), s[0]))
                        LoadHistory();
                    Btn_Search.PerformClick();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi xóa từ", "Lỗi khi xóa từ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbox_SizeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.DefaultShowSearch = Convert.ToInt32(cbox_SizeSearch.SelectedItem);
            Btn_Search.PerformClick();
        }
        #endregion

        #region save
        public bool _needSave = false;
        public bool _needReload = false;
        private void timer_CheckSave_Tick(object sender, EventArgs e)
        {
            if (_needSave != btn_SaveDics.Enabled)
                btn_SaveDics.Enabled = _needSave;
            if (_needReload)
            {
                _needReload = false;
                var s = rTBox_Word.Name.Split('\t');
                Utility.LoadWord(s[0], Convert.ToInt32(s[1]), Convert.ToInt32(s[2]), rTBox_Word);
            }
        }
        #endregion

        private void btn_ResotreSetting_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Resources.Resources.user = new User();
            Resources.Resources.user.Save();
            MessageBox.Show("Mở lại ứng dụng để có hiệu lực", "Khôi phục ứng dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
            Application.Exit();
            Cursor = Cursors.Default;
        }

        private void btn_ExportDic_Click(object sender, EventArgs e)
        {
            var indDic = cBox_Dics.SelectedIndex;
            Utility.ExportFileDic(indDic);
        }

        private void btn_AddDics_Click(object sender, EventArgs e)
        {
            var op = new OpenFileDialog();
            op.Filter = "txt|*.txt";
            op.Title = "Đường dẫn đấn tệp từ điển";
            var r = op.ShowDialog();
            if (r == DialogResult.OK)
            {
                var name = op.SafeFileName.Replace(".txt", "").TrimEnd();
                if (!Resources.Resources.user.AddUpdatePathDics(name, op.FileName))
                {
                    name += " - 01";
                    Resources.Resources.user.AddUpdatePathDics(name, op.FileName);
                }
                MsgWord _mw = new MsgWord();
                _mw.Path = op.FileName;
                _mw.Name = name;

                if (!_mw.LoadData())
                {
                    MessageBox.Show("Tệp từ điển không hợp lý", "Lỗi đọc dữ liệu", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Resources.Resources.user.RemovePathDics(name);
                    return;
                }
                Resources.Resources.dics.Add(_mw);
                Resources.Resources.user.Save();
                LoadComboBoxDics();
            }
        }
    }
}
