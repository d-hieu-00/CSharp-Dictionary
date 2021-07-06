using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms.Search
{
    public partial class SettingApi : Form
    {
        public SettingApi()
        {
            InitializeComponent();

            var key = "key default";
            if (Resources.Resources.user.KeyApiTrans != null && Resources.Resources.user.KeyApiTrans != "")
                key = Resources.Resources.user.KeyApiTrans;
            tBox_KeyApi.Text = key;
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

        private void btn_OpenWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Classes.Config.LinkGetKeyApiTrans);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var key = "key default";
            if (tBox_KeyApi.Text == key || tBox_KeyApi.Text == "")
            {
                MessageBox.Show("Hãy nhập key api", "Key api rỗng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Resources.Resources.user.KeyApiTrans = tBox_KeyApi.Text;
            Resources.Resources.user.Save();
        }
    }
}
