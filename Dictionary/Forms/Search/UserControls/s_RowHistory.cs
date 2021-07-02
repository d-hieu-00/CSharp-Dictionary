using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms.Search.UserControls
{
    public partial class s_RowHistory : UserControl
    {
        public string val { get; }
        public int indVal { get; }
        public int indDic { get; }
        public s_RowHistory()
        {
            InitializeComponent();
        }
        public s_RowHistory(string _val, int _indxVal, string _dic, int _indxDic)
        {
            InitializeComponent();
            lb_value.Text = _val;
            lb_dics.Text = _dic;

            val = _val;
            indVal = _indxVal;
            indDic = _indxDic;
        }

        private void s_RowHistory_Click(object sender, EventArgs e)
        {
            Tag = 1;
            Resources.Resources.main.searchForm._clickHistory = true;
        }

        private void Del_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resources.Resources.user.RemoveHistory(indDic, val);
            Resources.Resources.user.Save();
            Tag = 2;
            Resources.Resources.main.searchForm._delHistory = true;
        }
    }
}
