using Dictionary.Forms.Practice.UserControls;
using Dictionary.Resources.Model;
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
        private int i_tab = 0;
        
        public bool _isPlaying = false;
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
            Classes.Config.AllVolume = 1.0F;
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
            if (Classes.Config.AllVolume != 0.0F)
            {
                Classes.Config.AllVolume = 0.0F;
                btn_Sound.BackColor = Color.Firebrick;
            }
            else
            {
                Classes.Config.AllVolume = 1.0F;
                btn_Sound.BackColor = Color.MediumSeaGreen;
            }
            trackBar_Volume.Value = (int)(Classes.Config.AllVolume * 100);
        }
        private void btn_SoundBackground_Click(object sender, EventArgs e)
        {
            if (Classes.Config.BackgroundVolume == 0.0F)
            {
                Classes.Config.BackgroundVolume = 0.2F;
                btn_SoundBackground.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                Classes.Config.BackgroundVolume = 0.0F;
                btn_SoundBackground.BackColor = Color.Firebrick;
            }
            trackBar_VolumeBackground.Value = (int)(Classes.Config.BackgroundVolume * 100);
        }
        private void btn_SoundGame_Click(object sender, EventArgs e)
        {
            if (Classes.Config.GameSound)
            {
                Classes.Config.GameSound = false;
                btn_SoundGame.BackColor = Color.Firebrick;
            }
            else
            {
                Classes.Config.GameSound = true;
                btn_SoundGame.BackColor = Color.MediumSeaGreen;
            }
        }
        private void PracticeForm_Activated(object sender, EventArgs e)
        {
            if (_t == null)
               LoadBackground();
        }
        #endregion

        #region tabs
        public void ShowPlaying(int ind, Topic t)
        {
            _isPlaying = true;
            tabControl_Main.SelectedIndex = 5;
            p_Playing.SetData(ind, t);
        }
        private void timer_CheckPlaying_Tick(object sender, EventArgs e)
        {
            if (!_isPlaying && tabControl_Main.SelectedIndex != i_tab)
            {
                tabControl_Main.SelectedIndex = i_tab;
                switch (i_tab)
                {
                    case 1:
                        p_PlayFindMean.LoadAll();
                        p_PlayFindMean.SetDataForm(1);
                        break;
                    case 2:
                        p_PlayFindWord.LoadAll();
                        p_PlayFindWord.SetDataForm(2);
                        break;
                    case 3:
                        p_PlayPronounce.LoadAll();
                        p_PlayPronounce.SetDataForm(3);
                        break;
                }
            }
        }
        private void btn_Topic_Click(object sender, EventArgs e)
        {
            i_tab = 0;
            if (_isPlaying)
            {
                p_Playing.PerformQuiteClick();
                return;
            }
            tabControl_Main.SelectedIndex = 0;
        }
        private void btn_FindMean_Click(object sender, EventArgs e)
        {
            i_tab = 1;
            if (_isPlaying)
            {
                p_Playing.PerformQuiteClick();
                return;
            }
            tabControl_Main.SelectedIndex = 1;
            p_PlayFindMean.LoadAll();
            p_PlayFindMean.SetDataForm(1);
        }
        private void btn_FindWord_Click(object sender, EventArgs e)
        {
            i_tab = 2;
            if (_isPlaying)
            {
                p_Playing.PerformQuiteClick();
                return;
            }
            tabControl_Main.SelectedIndex = 2;
            p_PlayFindWord.LoadAll();
            p_PlayFindWord.SetDataForm(2);
        }
        private void btn_Pronounce_Click(object sender, EventArgs e)
        {
            i_tab = 3;
            if (_isPlaying)
            {
                p_Playing.PerformQuiteClick();
                return;
            }
            tabControl_Main.SelectedIndex = 3;
            p_PlayPronounce.LoadAll();
            p_PlayPronounce.SetDataForm(3);
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            i_tab = 4;
            if (_isPlaying)
            {
                p_Playing.PerformQuiteClick();
                return;
            }
            Classes.Utility.LoadGuildPractice(rTbox_Guild);
            tabControl_Main.SelectedIndex = 4;
            trackBar_Volume.Value = (int)(Classes.Config.AllVolume * 100);
            trackBar_VolumeBackground.Value = (int)(Classes.Config.BackgroundVolume * 100);
        }
        #endregion

        private void trackBar_Volume_Scroll(object sender, EventArgs e)
        {
            Classes.Config.AllVolume = (float)((trackBar_Volume.Value * 1.0) / 100);
        }

        private void trackBar_VolumeBackground_Scroll(object sender, EventArgs e)
        {
            Classes.Config.BackgroundVolume = (float)((trackBar_VolumeBackground.Value * 1.0) / 100);
        }
    }
}
