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

namespace Dictionary.Forms.Search
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        #region handle FormDagging
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
    }
}
