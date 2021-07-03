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
    public partial class DicForm : Form
    {
        private int indDic;
        public DicForm(int _indDic)
        {
            InitializeComponent();
            indDic = _indDic;
            lb_Title.Text += Resources.Resources.dics[indDic].Name;
            tBox_name.Text = Resources.Resources.dics[indDic].Name;
            tBox_path.Text = @Resources.Resources.dics[indDic].Path;
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

        private void btn_path_Click(object sender, EventArgs e)
        {
            var op = new OpenFileDialog();
            op.Filter = "txt|*.txt";
            var r = op.ShowDialog();
            if (r == DialogResult.OK)
            {
                tBox_path.Text = @op.FileName;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var count = Resources.Resources.user.PathDics.Count;
            if (tBox_name.Text != Resources.Resources.dics[indDic].Name ||
                tBox_path.Text != Resources.Resources.dics[indDic].Path)
            {
                var ck = tBox_path.Text != Resources.Resources.dics[indDic].Path;
                Resources.Resources.dics[indDic].Name = tBox_name.Text;
                Resources.Resources.dics[indDic].Path = tBox_path.Text;

                if (Resources.Resources.user.PathDics.ContainsKey(tBox_name.Text))
                    Resources.Resources.user.PathDics[tBox_name.Text] = tBox_path.Text;
                else
                {
                    Resources.Resources.user.PathDics.Clear();
                    for (int i = 0; i < count; i++)
                        Resources.Resources.user.PathDics.Add(
                            Resources.Resources.dics[i].Name,
                            Resources.Resources.dics[i].Path);
                }
                Cursor = Cursors.WaitCursor;
                Resources.Resources.main.searchForm.Invoke(new MethodInvoker(delegate ()
                {
                    Resources.Resources.main.searchForm.Cursor = Cursors.WaitCursor;
                }));
                if (ck)
                    if (!Resources.Resources.LoadDics())
                    {
                        MessageBox.Show("Lỗi tải dữ liệu từ điển", "Lỗi đọc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return;
                    }

                Cursor = Cursors.Default;
                Resources.Resources.main.searchForm.Invoke(new MethodInvoker(delegate ()
                {
                    Resources.Resources.main.searchForm.Cursor = Cursors.Default;
                }));
                Resources.Resources.main.searchForm.LoadComboBoxDics();
                Resources.Resources.user.Save();
                Close();
            }
            else
                Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Xác nhận xóa từ điển: " + Resources.Resources.dics[indDic].Name,
                "Xóa từ điển", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                Resources.Resources.main.searchForm.Invoke(new MethodInvoker(delegate ()
                {
                    Resources.Resources.main.searchForm.Cursor = Cursors.WaitCursor;
                }));
                var key = Resources.Resources.dics[indDic].Name;
                var maps = new Dictionary<int, int>();
                var fav = new Dictionary<int, Dictionary<string, int>>();
                var his = new Dictionary<int, Dictionary<string, int>>();
                for (int i=0; i<Resources.Resources.dics.Count; i++)
                {
                    if (i < indDic)
                        maps.Add(i, i);
                    else if (i == indDic)
                        maps.Add(i, -1);
                    else
                        maps.Add(i, i - 1);
                }
                Resources.Resources.dics.RemoveAt(indDic);
                Resources.Resources.user.PathDics.Remove(key);

                foreach (var i in Resources.Resources.user.History)
                {
                    if (maps[i.Key] >= 0)
                        his.Add(maps[i.Key], Classes.Utility.CloneDictionaryCloningValues(i.Value));
                }
                Resources.Resources.user.History.Clear();
                foreach (var i in his)
                    Resources.Resources.user.History.Add(i.Key, i.Value);

                foreach (var i in Resources.Resources.user.Favorite)
                {
                    if (maps[i.Key] >= 0)
                        fav.Add(maps[i.Key], Classes.Utility.CloneDictionaryCloningValues(i.Value));
                }
                Resources.Resources.user.Favorite.Clear();
                foreach (var i in fav)
                    Resources.Resources.user.Favorite.Add(i.Key, i.Value);


                Cursor = Cursors.Default;
                Resources.Resources.main.searchForm.Invoke(new MethodInvoker(delegate ()
                {
                    Resources.Resources.main.searchForm.Cursor = Cursors.Default;
                }));

                Resources.Resources.main.searchForm.LoadComboBoxDics();
                Resources.Resources.main.searchForm.LoadFacvorite();
                Resources.Resources.main.searchForm.LoadHistory();
                Resources.Resources.user.Save();
                Close();
            }
        }
    }
}
