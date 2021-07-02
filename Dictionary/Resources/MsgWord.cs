using Dictionary.Resources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Resources
{
    class MsgWord
    {
        // 0:A, 1:B, 2:C, ... 25:Z, 26:Orther
        public string Path { get; set; }
        public string Name { get; set; }
        public List<List<Word>> WordsAlphabet { get; }
        public List<Dictionary<string, int>> Maps { get; }
        public MsgWord()
        {
            WordsAlphabet = new List<List<Word>>();
            Maps = new List<Dictionary<string, int>>();
            for (var i=0; i<27; i++)
            {
                List<Word> tmp = new List<Word>();
                Dictionary<string, int> tmpDic = new Dictionary<string, int>();
                WordsAlphabet.Add(tmp);
                Maps.Add(tmpDic);
            }
        }

        #region function load data
        public bool LoadData()
        {
            /*try
            {*/
                string[] dataLines = System.IO.File.ReadAllLines(@Path);
                List<string> word = null;
                foreach (string line in dataLines)
                {
                    if (line != "")
                    {
                        if (line[0] == '@')
                        {
                            if (word != null)
                            {
                                var w = Classes.Utility.CloneList(word);
                                AddWord((List<string>)w);
                            }
                            word = new List<string>();
                        }
                        if (word == null)
                            break;
                        word.Add(line);
                    }
                }
                return true;
            /*}
            catch (Exception)
            {
                return false;
            }*/
        }
        public bool Reload()
        {
            WordsAlphabet.Clear();
            Maps.Clear();
            for (var i = 0; i < 27; i++)
            {
                List<Word> tmp = new List<Word>();
                Dictionary<string, int> tmpDic = new Dictionary<string, int>();
                WordsAlphabet.Add(tmp);
                Maps.Add(tmpDic);
            }
            return LoadData();
        }
        public string[] ExportString()
        {
            List<string> tmp = new List<string>();
            foreach (var i in WordsAlphabet)
                foreach (var w in i)
                    tmp.AddRange(Classes.Utility.WriteWord(w));
            return tmp.ToArray();
        }
        #endregion

        #region search
        public Dictionary<string, int> SearchByFristString(string q)
        {
            q = q.ToLower();
            int c = 0;
            Dictionary<string, int> search = new Dictionary<string, int>();
            if (q == null || q == "")
                return search;
            int letter = q[0];
            if (letter - 97 < 0 || letter - 97 > 25)
            {
                foreach(var i in Maps[26])
                {
                    if (i.Key.ToLower().StartsWith(q))
                    {
                        search.Add(i.Key, i.Value);
                        if (++c >= Classes.Config.DefaultShowSearch)
                            break;
                    }
                }
            }
            else
            {
                foreach (var i in Maps[letter - 97])
                {
                    if (i.Key.ToLower().StartsWith(q))
                    {
                        search.Add(i.Key, i.Value);
                        if (++c >= Classes.Config.DefaultShowSearch)
                            break;
                    }
                }
            }
            return search;
        }
        public Dictionary<string, int> SearchByString(string q)
        {
            q = q.ToLower();
            int c = 0;
            Dictionary<string, int> search = new Dictionary<string, int>();
            int ind = q[0] - 97;
            if (ind < 0 || ind > 25)
                ind = 26;
            for (int i=0; i<27; i++)
            {
                if (i != ind)
                    foreach (var k in Maps[i])
                    {
                        if (k.Key.ToLower().Contains(q))
                        {
                            if (++c >= Classes.Config.DefaultShowSearch)
                                break;
                            search.Add(k.Key, k.Value);
                        }
                    }
            }
            return search;
        }
        #endregion

        #region add, get, remove, update word
        public bool AddWord(List<string> word)
        {
            Word w = Classes.Utility.ReadWord(word);
            bool ck = true;
            if (w.Vocabulary == "" || w.Vocabulary == null)
                return false;
            int letter = w.Vocabulary.ToLower()[0];
            if (letter - 97 < 0 || letter - 97 > 25)
            {
                if (!Maps[26].ContainsKey(w.Vocabulary))
                {
                    WordsAlphabet[26].Add(w);
                    Maps[26].Add(w.Vocabulary, WordsAlphabet[26].Count - 1);
                }
                else
                    ck = false;
            }
            else
            {
                if (!Maps[letter - 97].ContainsKey(w.Vocabulary))
                {
                    WordsAlphabet[letter - 97].Add(w);
                    Maps[letter - 97].Add(w.Vocabulary, WordsAlphabet[letter - 97].Count - 1);
                }
                else
                    ck = false;
            }
            return ck;
        }
        public Word GetWord(string key, int val)
        {
            int ind = key.ToLower()[0] - 97;
            if (ind < 0 || ind > 25)
                ind = 26;
            return WordsAlphabet[ind][val];
        }
        public void Remove(string key, int val)
        {
            int ind = key.ToLower()[0] - 97;
            if (ind < 0 || ind > 25)
                ind = 26;
            var w = WordsAlphabet[ind][val];
            WordsAlphabet[ind].Remove(w);
            Maps[ind].Remove(key);
        }
        public void Update(string key, int val, Word w)
        {
            int ind = key.ToLower()[0] - 97;
            if (ind < 0 || ind > 25)
                ind = 26;
            WordsAlphabet[ind][val] = w;
        }
        #endregion
    }
}
