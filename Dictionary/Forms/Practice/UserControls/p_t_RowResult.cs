using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms.Practice.UserControls
{
    public partial class p_t_RowResult : UserControl
    {
        public int ind;
        public bool haveClick = false;
        public p_t_RowResult(int _ind, string _rs)
        {
            InitializeComponent();
            ind = _ind;
            Tag = 0;
            LoadData(_rs);
        }
        public void LoadData(string _rs)
        {
            var s = _rs.Split('\t');
            lb_No.Text = s[0];
            lb_Result.Text = s[1];
            lb_Time.Text = s[2];

            if (s[1].Split('/')[0] == s[1].Split('/')[1])
                lb_Result.ForeColor = Color.MediumSeaGreen;
        }

        private void lb_No_Click(object sender, EventArgs e)
        {
            haveClick = true;
            Tag = 1;
        }
    }
}
