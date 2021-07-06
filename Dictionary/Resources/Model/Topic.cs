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
            Pics = new List<string>();
            Words = new List<Word>();
            Path = "";
            Name = "";
            Count = 0;
        }
        public Topic(Topic topic)
        {
            Pics = (List<string>)Classes.Utility.CloneList(topic.Pics);
            Words = new List<Word>();
            foreach (var i in topic.Words)
                Words.Add(i.Clone());
            Path = topic.Path;
            Name = topic.Name;
            Count = topic.Count;
        }
        public void LoadData()
        {

        }
        public Topic Clone()
        {
            return new Topic(this);
        }
    }
}
