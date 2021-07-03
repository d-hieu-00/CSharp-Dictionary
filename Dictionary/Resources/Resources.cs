using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Resources
{
    class Resources
    {
        public static MainRes main;
        public static List<MsgWord> Dics;
        static public void InitRes()
        {
            main = new MainRes();
            Dics = new List<MsgWord>();
        }
    }
}
