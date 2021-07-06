using Dictionary.Resources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Resources
{
    class MsgGames
    {
        public List<string> Topic { get; }
        public Dictionary<string, List<Word>> ArrWord { get; set; }

        public void abc()
        {
            var l = ArrWord[Topic[0]];
        }
    }
}
