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
    public partial class s_RowMaskWord : UserControl
    {
        public string val { get; }
        public int indVal { get; }
        public int indDic { get; }
        public s_RowMaskWord()
        {
            InitializeComponent();
        }
        public s_RowMaskWord(string _val, int _indxVal, string _dic, int _indxDic)
        {
            InitializeComponent();
            lb_value.Text = _val;
            lb_dics.Text = _dic;

            val = _val;
            indVal = _indxVal;
            indDic = _indxDic;
        }

        private void s_RowMaskWord_Click(object sender, EventArgs e)
        {
            Tag = 1;
            Resources.Resources.main.searchForm._clickFavorite = true;
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resources.Resources.user.RemoveFavorite(indDic, val);
            Resources.Resources.user.Save();
            Tag = 2;
            Resources.Resources.main.searchForm._delFacvorite = true;
        }
    }
}
