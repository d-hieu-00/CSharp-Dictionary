using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Resources.Model
{
    class Mean
    {
        public string TypeWord { get; set; }
        public List<string> Meanings { get; set; }
        public Dictionary<int, List<string>> Examples { get; set; }

        public Mean()
        {
            TypeWord = null;
            Meanings = new List<string>();
            Examples = new Dictionary<int, List<string>>();
        }
        public Mean(Mean mean)
        {
            TypeWord = mean.TypeWord;
            Meanings = (List<string>)Classes.Utility.CloneList(mean.Meanings);
            Examples = Classes.Utility.CloneDictionaryCloningValues(mean.Examples);
        }
        public Mean Clone()
        {
            return new Mean(this);
        }
    }
}
