﻿using System;
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
    public partial class p_RowLession : UserControl
    {
        public p_RowLession()
        {
            InitializeComponent();
            Classes.Utility.RoundedControl(this);
            Size = new Size(180, 65);
        }
    }
}