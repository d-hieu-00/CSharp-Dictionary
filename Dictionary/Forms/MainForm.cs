using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dictionary.Forms
{
    public partial class MainForm : Form
    {
        private int Count = 5;
        private bool wait = true;
        private bool ck = true;
        public MainForm()
        {
            InitializeComponent();
            lb_Name.Text += Classes.Config.NameApp;
            lb_Load.Text = Classes.Config.Loading;
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
            Application.Exit();
        }

        private void timer_EffectLoad_Tick(object sender, EventArgs e)
        {
            if (Count-- <= 0)
            {
                Count = 5;
                lb_Load.Text = Classes.Config.Loading;
            }
            else
                lb_Load.Text += '.';
        }

        private void timer_Load_Tick(object sender, EventArgs e)
        {
            if (Resources.Resources.main.loadDone)
            {
                timer_Load.Enabled = false;
                Task.Run(() =>
                {
                    if (!Resources.Resources.LoadDics())
                        ck = false;
                    wait = false;
                });
                
            }
        }

        private void timer_RsLoad_Tick(object sender, EventArgs e)
        {
            if (wait)
                return;
            else
            {
                timer_RsLoad.Enabled = false;
                timer_EffectLoad.Enabled = false;
                if (ck)
                {
                    Resources.Resources.main.mainForm.Hide();
                    Resources.Resources.main.searchForm.SuspendLayout();
                    Resources.Resources.main.searchForm.LoadInit();
                    Resources.Resources.main.searchForm.Show();
                    Resources.Resources.main.searchForm.ResumeLayout();
                }
                else
                {
                    MessageBox.Show("Lỗi tải từ điển", "Lỗi mở ứng dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}
