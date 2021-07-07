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
        public p_Play()
        {
            InitializeComponent();
            Classes.Utility.RoundedControl(lb_DetailResult);

            cBox_SoTu.MouseWheel += new MouseEventHandler(combobox_MouseWheel);
            cBox_Dic.MouseWheel += new MouseEventHandler(combobox_MouseWheel);
            cBox_Topic.MouseWheel += new MouseEventHandler(combobox_MouseWheel);

        }
        #region load data, combobox
        public void LoadAll()
        {
            LoadComboBox();
        }
        void combobox_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
        public void LoadSoTu()
        {
            cBox_SoTu.Items.Clear();
            if (rdBtn_Topic.Checked)
            {
                var ind = cBox_Topic.SelectedIndex;
                if (ind < 0)
                    return;
                var count = Resources.Resources.dataPractice.Topics[ind].Count;
                for (var i = 1; i <= count; i++)
                    cBox_SoTu.Items.Add(i);
            }
            else
            {
                var ind = cBox_Dic.SelectedIndex;
                if (ind < 0)
                    return;
                var count = 0;
                foreach (var i in Resources.Resources.dics[ind].Maps)
                    count += i.Count;
                count = (count > 100) ? 100 : count;
                for (var i = 1; i <= count; i++)
                    cBox_SoTu.Items.Add(i);
            }
        }
        private void cBox_Dic_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSoTu();
        }
        private void rdBtn_Topic_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn_Topic.Checked)
            {
                cBox_Dic.Enabled = false;
                cBox_Topic.Enabled = true;
            }
            else
            {
                cBox_Dic.Enabled = true;
                cBox_Topic.Enabled = false;
            }
            LoadSoTu();
        }
        public void LoadComboBox()
        {
            cBox_Topic.Items.Clear();
            foreach (var i in Resources.Resources.dataPractice.Topics)
                cBox_Topic.Items.Add(i.Name);
            cBox_Dic.Items.Clear();
            foreach (var i in Resources.Resources.dics)
                cBox_Dic.Items.Add(i.Name);
            rdBtn_Topic.Checked = true;
            cBox_Dic.Enabled = false;
            cBox_Topic.Enabled = true;
            LoadSoTu();
        }
        public void LoadResult()
        {
            var result = Resources.Resources.dataPractice.Results[i_form - 1];
            if (result == null)
                return;
            flw_Result.Controls.Clear();
            flw_DetailResult.Controls.Clear();
            for (var i = 0; i < result.Results.Count; i++)
                flw_Result.Controls.Add(new p_t_RowResult(i, result.Results[i]));
        }
        public void SetDetailResult(int ind)
        {

        }
        public void SetDataMeanForm()
        {
            i_form = 1;
            LoadResult();
        }
        public void SetDataWordForm()
        {
            i_form = 2;
            LoadResult();
        }
        public void SetDataPronounceForm()
        {
            i_form = 3;
            LoadResult();
        }
        #endregion

        private void llb_Guild_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
