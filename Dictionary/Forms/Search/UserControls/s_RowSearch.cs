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
    public partial class s_RowSearch : UserControl
    {
        public string val { get; }
        public int indVal { get; }
        public int indDic { get; }
        public s_RowSearch()
        {
            InitializeComponent();
        }
        public s_RowSearch(string _val, int _indxVal, string _dic, int _indxDic)
        {
            InitializeComponent();
            lb_value.Text = _val;
            lb_dics.Text = _dic;

            val = _val;
            indVal = _indxVal;
            indDic = _indxDic;
        }
        private void s_RowSearch_Click(object sender, EventArgs e)
        {
            Tag = 1;
            Resources.Resources.main.searchForm._clickSearch = true;
            Resources.Resources.main.searchForm._addHistory = true;
            Task.Run(() =>
            {
                Resources.Resources.user.AddUpdateHistory(indDic, val, indVal);
                Resources.Resources.user.Save();
            });
        }
    }
}
