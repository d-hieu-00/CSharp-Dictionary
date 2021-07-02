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

namespace Dictionary.Forms.Search
{
    public partial class WordForm : Form
    {
        Word word;
        int indDic, val;
        string key;
        public WordForm(int _indDic)
        {
            InitializeComponent();
            indDic = _indDic;
        }
        public WordForm(int _indDic, string _key, int _val)
        {
            InitializeComponent();
            var w = Resources.Resources.dics[_indDic].GetWord(_key, _val);
            word = w;
            indDic = _indDic;
            val = _val;
            key = _key;
            lb_Title.Text = "Sửa từ vựng - " + w.Vocabulary;
            lb_Write.Text = "Sửa từ vựng - " + w.Vocabulary;
            rTbox_Write.Text = String.Join("\n", Classes.Utility.WriteWord(w));
        }
        private void WordForm_Load(object sender, EventArgs e)
        {
            Classes.Utility.LoadRuleWord(rTbox_Rule);
            Classes.Utility.LoadWordForView(rTbox_View, rTbox_Write.Text);
            Classes.Utility.RoundedControl(lb_View);
            Classes.Utility.RoundedControl(lb_Write);
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_View_Click(object sender, EventArgs e)
        {
            Classes.Utility.LoadWordForView(rTbox_View, rTbox_Write.Text);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (word != null)
            {
                Resources.Resources.dics[indDic].Update(key, val,
                    Classes.Utility.ReadWord(new List<string>(rTbox_Write.Text.Split('\n'))));
                Resources.Resources.main.searchForm._needReload = true;
            }
            else
            {
                if(!Resources.Resources.dics[indDic].AddWord(new List<string>(rTbox_Write.Text.Split('\n'))))
                {
                    MessageBox.Show("Từ đã tồn tại", "Lỗi thêm từ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Resources.Resources.main.searchForm._needSave = true;
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
    }
}
