using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Resources.Model
{
    public class Topic
    {
        public List<string> Pics { get; }
        public List<Word> Words { get; }
        public string Path { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        
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
        public bool LoadData()
        {
            Name = Path.Split('/')[Path.Split('/').Length - 1];
            var dirWord = Path + "/Words.txt";
            if (!File.Exists(dirWord))
                return false;
            string[] dataLines = File.ReadAllLines(dirWord);
            List<string> word = null;
            foreach (string line in dataLines)
            {
                if (line != "")
                {
                    if (line[0] == '@')
                    {
                        if (word != null)
                        {
                            var _w = Classes.Utility.ReadWord((List<string>)Classes.Utility.CloneList(word));
                            Words.Add(_w);
                            Pics.Add(Path + "/Pics/" + _w.Vocabulary.ToLower() + ".jpg");
                        }
                        word = new List<string>();
                    }
                    if (word == null)
                        break;
                    word.Add(line);
                }
            }
            Count = Words.Count;
            return true;
        }
        public Topic Clone()
        {
            return new Topic(this);
        }
    }
}
