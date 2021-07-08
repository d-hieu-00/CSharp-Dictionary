using Dictionary.Resources.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms.Practice
{
    public partial class InfoWord : Form
    {
        private Word word;
        public InfoWord(Word w)
        {
            InitializeComponent();
            rTbox_View.ScrollBars = RichTextBoxScrollBars.Vertical;
            word = w.Clone();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
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

        private void InfoWord_Activated(object sender, EventArgs e)
        {
            Classes.Utility.LoadWordForView(rTbox_View, word);
        }
    }
}
