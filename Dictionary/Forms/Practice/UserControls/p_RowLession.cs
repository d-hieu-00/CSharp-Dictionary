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
    public partial class p_RowLession : UserControl
    {
        int ind;
        public p_RowLession()
        {
            InitializeComponent();
            Classes.Utility.RoundedControl(this);
            Size = new Size(180, 65);
            Tag = 0;
        }
        public void SetData(int No, string Name, int Count)
        {
            ind = No - 1;
            lb_TitleTopic.Text = "Chủ đề " + No + ": " + Name;
            lb_InfoTopic.Text = "Số từ vựng: " + Count;
        }

        private void lb_InfoTopic_Click(object sender, EventArgs e)
        {
            Tag = 1;
            Resources.Resources.main.practiceForm._changeTopic = true;
        }
    }
}
