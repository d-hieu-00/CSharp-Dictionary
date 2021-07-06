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
    public partial class p_RowWord : UserControl
    {
        public p_RowWord()
        {
            InitializeComponent();
            Size = new Size(500, 110);
            Classes.Utility.RoundedControl(this);
            Classes.Utility.RoundedControl(btn_Listen);
            Classes.Utility.RoundedControl(btn_Detail);
        }
    }
}
