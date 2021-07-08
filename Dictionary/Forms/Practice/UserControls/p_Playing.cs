using Dictionary.Resources.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms.Practice.UserControls
{
    public partial class p_Playing : UserControl
    {
        private int _time;
        private int _ind, _indPlaying, _correct, _incorrect, _indRight;
        private Topic _t;
        private string _rs;
        // "01\thello\tcorrect"
        private List<string> _drs;
        public p_Playing()
        {
            InitializeComponent();
            Classes.Utility.RoundedControl(lb_time);
            Classes.Utility.RoundedControl(lb_Title);
            _drs = new List<string>();
        }
        private string GetTime()
        {
            var _s = (_time % 60).ToString();
            if (_s.Length == 1)
                _s = "0" + _s;
            var _m = ((int)(_time / 60)).ToString();
            if (_m.Length == 1)
                _m = "0" + _m;
            return _m + ":" + _s;
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Classes.Utility.SpeechString(_t.Words[_indPlaying].Vocabulary);
            Cursor = Cursors.Default;
        }

        private void StartTime()
        {
            lb_time.Text = "00:00";
            _time = 0;
            timer_StartTime.Enabled = true;
        }
        private void timer_StartTime_Tick(object sender, EventArgs e)
        {
            _time++;
            lb_time.Text = GetTime();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            var w = _t.Words[_indPlaying];
            _indPlaying++;
            var c = 0;
            if (rdbtn_option_1.Checked)
                c = 1;
            if (rdbtn_option_2.Checked)
                c = 2;
            if (rdbtn_option_3.Checked)
                c = 3;
            if (rdbtn_option_4.Checked)
                c = 4;
            if (c == _indRight)
            {
                var i = _indPlaying.ToString();
                if (i.Length == 1)
                    i = "0" + i;
                _drs.Add(i + '\t' + w.Vocabulary + "\tcorrect");
                _correct++;
                Classes.Utility.PlayMp3Correct();
            }
            else
            {
                var i = _indPlaying.ToString();
                if (i.Length == 1)
                    i = "0" + i;
                _drs.Add(i + '\t' + w.Vocabulary + "\tincorrect");
                _incorrect++;
                Classes.Utility.PlayMp3InCorrect();
            }
            if (_indPlaying >= _t.Count)
            {
                btn_quite.PerformClick();
            }
            else
                LoadWord();
        }
        public void PerformQuiteClick()
        {
            btn_quite.PerformClick();
        }
        private void btn_quite_Click(object sender, EventArgs e)
        {
            if (_indPlaying < _t.Count - 1)
            {
                var r = MessageBox.Show("Kết thúc ôn bài", "Kết thúc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    for (var i = _indPlaying; i < _t.Count; i++)
                    {
                        var w = _t.Words[i];
                        var _i = _indPlaying.ToString();
                        if (_i.Length == 1)
                            _i = "0" + _i;
                        _drs.Add(_i + '\t' + w.Vocabulary + "\tundefined");
                    }
                }
                else
                    return;
            }
            timer_StartTime.Enabled = false;
            int No;
            switch (_ind)
            {
                case 1:
                    No = Resources.Resources.dataPractice.Results[0].Results.Count;
                    _rs = No + "\t" + _correct + "/" + _t.Count + "\t" + lb_time.Text;
                    Resources.Resources.dataPractice.Results[0].Results.Add(_rs);
                    Resources.Resources.dataPractice.Results[0].DetailResult.Add(_drs);
                    Resources.Resources.dataPractice.Save();
                    break;
                case 2:
                    No = Resources.Resources.dataPractice.Results[1].Results.Count;
                    _rs = No + "\t" + _correct + "/" + _t.Count + "\t" + lb_time.Text;
                    Resources.Resources.dataPractice.Results[1].Results.Add(_rs);
                    Resources.Resources.dataPractice.Results[1].DetailResult.Add(_drs);
                    Resources.Resources.dataPractice.Save();
                    break;
                case 3:
                    No = Resources.Resources.dataPractice.Results[2].Results.Count;
                    _rs = No + "\t" + _correct + "/" + _t.Count + "\t" + lb_time.Text;
                    Resources.Resources.dataPractice.Results[2].Results.Add(_rs);
                    Resources.Resources.dataPractice.Results[2].DetailResult.Add(_drs);
                    Resources.Resources.dataPractice.Save();
                    break;
            }
            Resources.Resources.main.practiceForm._isPlaying = false;
        }

        public List<string> GetAnswer()
        {
            var w = _t.Words[_indPlaying];
            List<string> l = new List<string>();
            var rnd = new Random();
            var randomNumbers = Enumerable.Range(0, _t.Count)
                .OrderBy(x => rnd.Next()).Take(3).ToList();
            var ck = true;
            while (ck)
            {
                ck = false;
                for (var i = 0; i < 3; i++)
                    if (randomNumbers[i] == _indPlaying)
                    {
                        ck = true;
                        randomNumbers[i] = new Random().Next(0, _t.Count);
                    }
                if (randomNumbers[0] == randomNumbers[1])
                {
                    ck = true;
                    randomNumbers[0] = new Random().Next(0, _t.Count);
                }
                if (randomNumbers[1] == randomNumbers[2])
                {
                    ck = true;
                    randomNumbers[1] = new Random().Next(0, _t.Count);
                }
            }
            var _i = 0;
            switch (_ind)
            {
            case 1:
                for (var i=1; i<5; i++)
                {
                    if (i == _indRight)
                    {
                        if (w.Means.Count > 0 && w.Means[0].Meanings.Count > 0)
                            l.Add(w.Means[0].Meanings[0]);
                        else
                            l.Add("Lỗi từ không có nghĩa !! kiểm tra lại: " + _t.Name);
                    }
                    else
                    {
                        var _w = _t.Words[randomNumbers[_i++]];
                        if (_w.Means.Count > 0 && _w.Means[0].Meanings.Count > 0)
                            l.Add(_w.Means[0].Meanings[0]);
                        else
                            l.Add("Lỗi từ không có nghĩa !! kiểm tra lại: " + _t.Name);
                    }
                }
                break;
            case 2:
                for (var i = 1; i < 5; i++)
                {
                    if (i == _indRight)
                    {
                        l.Add(w.Vocabulary);
                    }
                    else
                    {
                        var _w = _t.Words[randomNumbers[_i++]];
                        l.Add(_w.Vocabulary);
                    }
                }
                break;
            case 3:
                for (var i = 1; i < 5; i++)
                {
                    if (i == _indRight)
                    {
                        l.Add(w.Pronounce);
                    }
                    else
                    {
                        var _w = _t.Words[randomNumbers[_i++]];
                        l.Add(_w.Pronounce);
                    }
                }
                break;
            }
            return l;
        }
        public void LoadAnswer()
        {
            _indRight = new Random().Next(1, 5);
            var l = GetAnswer();
            rdbtn_option_1.Text = l[0];
            rdbtn_option_2.Text = l[1];
            rdbtn_option_3.Text = l[2];
            rdbtn_option_4.Text = l[3];
        }
        public string GetLetter(string s)
        {
            var _ls = new List<string>();
            foreach (var i in s)
                _ls.Add(i.ToString());
            _ls.Sort();
            var _s = "";
            foreach (var i in _ls)
                _s += " " + i.ToString().ToUpper();
            return _s;
        }
        public void LoadWord()
        {
            var w = _t.Words[_indPlaying];
            lb_No.Text = "Câu: " + (_indPlaying + 1).ToString() + "/" + _t.Count;
            lb_corecct.Text = "Câu đúng: " + _correct;
            lb_fail.Text = "Câu sai: " + _incorrect;
            if (File.Exists(_t.Pics[_indPlaying]))
                pic_Word.Image = Image.FromFile(_t.Pics[_indPlaying]);
            else
                pic_Word.Image = Properties.Resources.Cat_roll;
            switch (_ind)
            {
                case 1:
                    lb_require.Text = "Tìm nghĩa đúng của từ: " + w.Vocabulary;
                    lb_recommend_1.Text = "Phát âm: " + w.Pronounce;
                    lb_recommend_2.Text = "";
                    break;
                case 2:
                    lb_require.Text = "Tìm từ đúng ";
                    lb_recommend_1.Text = "Phát âm: " + w.Pronounce;
                    if (w.Means.Count > 0 && w.Means[0].Meanings.Count > 0)
                        lb_recommend_2.Text = "Nghĩa: " + w.Means[0].Meanings[0];
                    else
                        lb_recommend_2.Text = "Lỗi từ không có nghĩa !! kiểm tra lại: " + _t.Name;
                    break;
                case 3:
                    lb_require.Text = "Tìm phát âm đúng của từ: " + w.Vocabulary;
                    if (w.Means.Count > 0 && w.Means[0].Meanings.Count > 0)
                        lb_recommend_1.Text = "Nghĩa: " + w.Means[0].Meanings[0];
                    else
                        lb_recommend_1.Text = "Lỗi từ không có nghĩa !! kiểm tra lại: " + _t.Name;
                    lb_recommend_2.Text = "";
                    break;
            }
            LoadAnswer();
        }
        public void SetData(int ind, Topic t)
        {
            _ind = ind;
            _t = t.Clone();
            _indPlaying = 0;
            _correct = 0;
            _incorrect = 0;
            lb_Title.Text = _t.Name;
            _drs.Clear();
            LoadWord();
            StartTime();
        }
    }
}
