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
    public partial class p_Play : UserControl
    {
        private int i_form = 0;
        private Result result;
        public p_Play()
        {
            InitializeComponent();
            Classes.Utility.RoundedControl(lb_DetailResult);
            LoadComboBox();
        }
        #region load data, combobox
        public void LoadComboBox()
        {

        }
        public void LoadResult()
        {

        }
        public void SetDataMeanForm()
        {
            i_form = 1;
        }
        public void SetDataWordForm()
        {
            i_form = 2;
        }
        public void SetDataPronounceForm()
        {
            i_form = 3;
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (i_form)
            {
                case 1:
                    // mean form
                    break;
                case 2:
                    //word form
                    break;
                case 3:
                    //pronounce
                    break;
            }
        }
    }
}
