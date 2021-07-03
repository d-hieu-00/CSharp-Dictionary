using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dictionary.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //label1.Text = "init form done!!!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (Resources.Resources.main._loadDone)
            {
                Resources.Resources.main.searchForm.Show();
                Hide();
                timer1.Enabled = false;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var oFile = new OpenFileDialog();
            oFile.Filter = " txt|*.txt";
            var r = oFile.ShowDialog();
            Resources.MsgWord msgWord = new Resources.MsgWord();
            if (r == DialogResult.OK)
            {
                msgWord.Path = oFile.FileName;
                msgWord.Name = oFile.SafeFileName.Replace(".txt", "");
                if (msgWord.LoadData())
                {
                    Hide();
                    Resources.Resources.main.searchForm.Show();
                    Resources.Resources.Dics.Add(msgWord);
                }
                else
                {
                    MessageBox.Show("Lỗi đường dẫn");
                }
            }
        }
    }
}
