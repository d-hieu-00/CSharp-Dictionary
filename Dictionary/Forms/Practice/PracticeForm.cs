using Dictionary.Forms.Practice.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms.Practice
{
    public partial class PracticeForm : Form
    {
        private Thread _t;
        private bool isMute = false;
        private bool isPlaying = false;
        public PracticeForm()
        {
            InitializeComponent();
            LoadTopic();
        }
        public void LoadTopic()
        {
            flwLayout_Lession.Controls.Clear();
            for (var i=0; i<Resources.Resources.dataPractice.Topics.Count; i++)
            {
                var t = Resources.Resources.dataPractice.Topics[i];
                var r = new p_RowLession();
                r.SetData(i + 1, t.Name, t.Count);
                flwLayout_Lession.Controls.Add(r);
            }
            flwLayout_Words.Controls.Clear();
            if (flwLayout_Lession.Controls.Count > 0)
            {
                flwLayout_Lession.Controls[0].BackColor = Color.LightSalmon;
                LoadDetailTopic(0);
            }
        }
        public void LoadDetailTopic(int ind)
        {
            var t = Resources.Resources.dataPractice.Topics[ind];
            flwLayout_Words.Controls.Clear();
            for (var i=0; i<t.Count; i++)
            {
                var r = new p_RowWord();
                r.SetData(t.Words[i], t.Pics[i]);
                flwLayout_Words.Controls.Add(r);
            }
        }
        public bool _changeTopic = false;
        private void timer_CheckLessionClick_Tick(object sender, EventArgs e)
        {
            if (_changeTopic)
            {
                _changeTopic = false;
                for (var i = 0; i < flwLayout_Lession.Controls.Count; i++)
                {
                    var r = flwLayout_Lession.Controls[i];
                    if ((int)r.Tag == 1)
                    {
                        r.Tag = 0;
                        r.BackColor = Color.LightSalmon;
                        LoadDetailTopic(i);
                    }
                    else if (r.BackColor != Color.Bisque)
                        r.BackColor = Color.Bisque;
                }
            }
        }

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

        #region background, close, mute,..
        private void PracticeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Resources.Resources.main.practiceForm = new PracticeForm();
            if (_t != null && _t.IsAlive)
                _t.Abort();
            Classes.Utility.UnMute();
        }
        private void LoadBackground()
        {
            if (!File.Exists(Classes.Config.BackgroundMp3))
            {
                MessageBox.Show("Không tìm thấy tệp" +
                    "\n" + Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Data\\background.mp3"
                    , "Lỗi mở tiện ích", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            _t = Classes.Utility.PlayMp3BackgroundFromUrl(@Classes.Config.BackgroundMp3);
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
            _t.Abort();
        }

        private void btn_Sound_Click(object sender, EventArgs e)
        {
            if (isMute)
            {
                isMute = false;
                Classes.Utility.UnMute();
            }
            else
            {
                isMute = true;
                Classes.Utility.Mute();
            }
        }

        private void PracticeForm_Activated(object sender, EventArgs e)
        {
            if (_t == null)
                LoadBackground();
            p_PlayFindMean.LoadAll();
            p_PlayFindWord.LoadAll();
            p_PlayPronounce.LoadAll();
        }
        #endregion

        public void ShowPlaying()
        {
            isPlaying = true;
            tabControl_Main.SelectedIndex = 5;
        }
        private void btn_Topic_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectedIndex = 0;
        }
        private void btn_FindMean_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectedIndex = 1;
        }
        private void btn_FindWord_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectedIndex = 2;
        }
        private void btn_Pronounce_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectedIndex = 3;
        }
        private void btn_Settings_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectedIndex = 4;
        }
    }
}
