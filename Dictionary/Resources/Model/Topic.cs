using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Resources.Model
{
    class Topic
    {
        public List<string> Pics { get; }
        public List<Word> Words { get; }
        public string Path { get; }
        public string Name { get; set; }
        public int Count { get; }
        
        public Topic()
        {

        }
        public void loadData()
        {

        }
    }
}
