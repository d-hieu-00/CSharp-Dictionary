using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms.Search
{
    public partial class TranslateForm : Form
    {
        private SettingApi settingApi;
        public TranslateForm()
        {
            InitializeComponent();
            Classes.Utility.RoundedControl(lb_Ori);
            Classes.Utility.RoundedControl(lb_Trans);
            btn_Trans.PerformClick();
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_SpeechOri_Click(object sender, EventArgs e)
        {
            lb_Ori.Focus();
            Classes.Utility.SpeechString(rTbox_Ori.Text);
        }

        private void btn_SpeechTrans_Click(object sender, EventArgs e)
        {
            lb_Ori.Focus();
            Classes.Utility.SpeechString(rTbox_Trans.Text);
        }

        private void btn_Trans_Click(object sender, EventArgs e)
        {
            lb_Ori.Focus();
            rTbox_Ori.Cursor = Cursors.WaitCursor;
            btn_Trans.Cursor = Cursors.WaitCursor;
            var _t = Classes.Utility.TranslateString(rTbox_Ori.Text);
            rTbox_Ori.Cursor = Cursors.Default;
            btn_Trans.Cursor = Cursors.Default;
            if (_t != null)
                rTbox_Trans.Text = _t;
            else
                MessageBox.Show(
                    "Có lỗi về Api:\n- Kết nối mạng\n- Sửa key api trong cấu hình", 
                    "Lỗi api", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_SettingApi_Click(object sender, EventArgs e)
        {
            lb_Ori.Focus();
            if (settingApi == null || settingApi.IsDisposed)
                settingApi = new SettingApi();
            settingApi.Show();
            settingApi.Activate();
        }
    }
}
