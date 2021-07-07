using Dictionary.Resources.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms.Practice.UserControls
{
    public partial class p_RowWord : UserControl
    {
        public Word word;
        private InfoWord info;
        public p_RowWord()
        {
            InitializeComponent();
            Size = new Size(500, 110);
            Classes.Utility.RoundedControl(this);
            Classes.Utility.RoundedControl(btn_Listen);
            Classes.Utility.RoundedControl(btn_Detail);
        }
        public void SetData(Word w, string pathPic)
        {
            word = w.Clone();
            lb_Vocabulary.Text = w.Vocabulary;
            lb_Pronounce.Text = w.Pronounce;
            if (w.Means.Count > 0 && w.Means[0].Meanings.Count > 0)
                lb_Mean.Text = w.Means[0].Meanings[0];
            if (File.Exists(pathPic))
                pic_Img.Image = Image.FromFile(pathPic);
            info = new InfoWord(word);
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Classes.Utility.SpeechString(word.Vocabulary);
            Cursor = Cursors.Default;
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            info.Show();
            info.Activate();
        }
    }
}
