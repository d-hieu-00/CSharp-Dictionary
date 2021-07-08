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
        private void timer_ResultClick_Tick(object sender, EventArgs e)
        {
            for(var i=0; i<flw_Result.Controls.Count; i++)
            {
                var r = flw_Result.Controls[i] as p_t_RowResult;
                if (r.haveClick)
                {
                    SetDetailResult(r.ind);
                    foreach (var _r in flw_Result.Controls)
                        if ((_r as Control).BackColor == Color.LightGray)
                            (_r as Control).BackColor = Color.White;
                    r.BackColor = Color.LightGray;
                    r.haveClick = false;
                }
            }
        }
        public void SetDetailResult(int ind)
        {
            var result = Resources.Resources.dataPractice.Results[i_form - 1];
            flw_DetailResult.Controls.Clear();
            foreach (var i in result.DetailResult[ind])
            {
                var s = i.Split('\t');
                var r = new p_t_RowDetailResult(Convert.ToInt32(s[0]), s[1], s[2]);
                flw_DetailResult.Controls.Add(r);
            }
        }
        #endregion

        #region for each form
        public void SetDataForm(int form)
        {
            i_form = form;
            LoadResult();
            switch (i_form)
            {
                case 1:
                    
                    break;
                case 2:
                    //word form
                    break;
                case 3:
                    //pronounce
                    break;
            }
        }

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

        private Topic GetTopic()
        {
            Topic t = new Topic();
            if (rdBtn_Topic.Checked)
            {
                var ind = cBox_Topic.SelectedIndex;
                if (ind < 0)
                {
                    MessageBox.Show("Chọn chủ đề", "Lỗi bắt đầu ôn bài", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                var num = Convert.ToInt32(cBox_SoTu.SelectedItem);
                var topic = Resources.Resources.dataPractice.Topics[ind];
                if (num <= 0)
                {
                    MessageBox.Show("Chọn số từ", "Lỗi bắt đầu ôn bài",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                var rnd = new Random();
                var randomNumbers = Enumerable.Range(0, Resources.Resources.dataPractice.Topics[ind].Count)
                    .OrderBy(x => rnd.Next()).Take(num).ToList();
                foreach(var i in randomNumbers)
                {
                    t.Words.Add(topic.Words[i].Clone());
                    t.Pics.Add((string)topic.Pics[i].Clone());
                }
                t.Count = t.Words.Count;
                t.Name = "Chủ đề: " + topic.Name;
            }
            else
            {
                var ind = cBox_Dic.SelectedIndex;
                if (ind < 0)
                {
                    MessageBox.Show("Chọn từ điển", "Lỗi bắt đầu ôn bài",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                var num = Convert.ToInt32(cBox_SoTu.SelectedItem);
                var dic = Resources.Resources.dics[ind];
                if (num <= 0)
                {
                    MessageBox.Show("Chọn số từ", "Lỗi bắt đầu ôn bài",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                var count = 0;
                foreach (var i in Resources.Resources.dics[ind].Maps)
                    count += i.Count;
                var rnd = new Random();
                var randomNumbers = Enumerable.Range(0, count)
                    .OrderBy(x => rnd.Next()).Take(num).ToList();

                foreach (var i in randomNumbers)
                {
                    t.Words.Add(dic.GetWord(i).Clone());
                    t.Pics.Add("#");
                }
                t.Count = t.Words.Count;
                t.Name = "Từ điển: " + dic.Name;
            }
            return t;
        }
        private void btn_Play_Click(object sender, EventArgs e)
        {
            Topic t = GetTopic();
            if (t == null)
                return;
            Resources.Resources.main.practiceForm.ShowPlaying(i_form, t);
        }
        #endregion

    }
}
