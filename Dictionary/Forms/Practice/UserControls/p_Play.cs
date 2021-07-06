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
    public partial class p_Play : UserControl
    {
        public p_Play()
        {
            InitializeComponent();
            Classes.Utility.RoundedControl(lb_DetailResult);
        }
    }
}
