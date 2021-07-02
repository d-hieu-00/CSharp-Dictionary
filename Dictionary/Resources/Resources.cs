using Dictionary.Resources.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Resources
{
    class Resources
    {
        public static MainRes main;
        public static User user;
        public static List<MsgWord> dics;
        static public bool InitRes()
        {
            user = new User();
            if (!user.LoadUser())
                return false;
            main = new MainRes();
            dics = new List<MsgWord>();
            return true;
        }
        static public bool LoadDics()
        {
            var ck = true;
            var op = new OpenFileDialog();
            op.Filter = "txt|*.txt;";
            foreach (var i in user.PathDics)
            {
                if (!File.Exists(i.Value))
                {
                    op.Title = "Chọn đường dẫn cho từ điển: " + i.Key;
                    var r = op.ShowDialog();
                    if (r == DialogResult.OK)
                    {
                        user.PathDics[i.Key] = op.FileName;
                    }
                }
                MsgWord _mw = new MsgWord();
                _mw.Path = user.PathDics[i.Key];
                _mw.Name = i.Key;

                if (!_mw.LoadData())
                {
                    ck = false;
                    break;
                }
                dics.Add(_mw);
            }

            return ck;
        }
    }
}
