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

namespace Dictionary.Forms.Practice.UserControls
{
    public partial class p_t_RowDetailResult : UserControl
    {
        int ind;
        string rs, asw;
        public p_t_RowDetailResult(int _ind, string _rs, string _asw)
        {
            InitializeComponent();
            ind = _ind;
            rs = _rs;
            asw = _asw;
            SetData();
        }
        public void SetData()
        {
            lb_No.Text = ind.ToString();
            lb_Result.Text = rs;
            lb_asw.Text = asw;
            if (asw == "correct")
                lb_asw.ForeColor = Color.MediumSeaGreen;
            else if (asw == "incorrect")
                lb_asw.ForeColor = Color.Firebrick;
            else
                lb_asw.ForeColor = Color.Gainsboro;
        }
    }
}
