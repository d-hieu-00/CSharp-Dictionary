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
        public void AddWord(List<string> word)
        {
            Word w = new Word();
            for (var i=0; i<word.Count; i++)
            {
                if (word[i] != "")
                {
                    if (word[i][0] == '@')
                    {
                        var t = word[i].Remove(0, 1).Split('/');
                        if (t.Length > 1)
                            w.Pronounce = '/' + t[t.Length - 2] + '/';
                        w.Vocabulary = "";
                        for (int __i = 0; __i < t.Length - 3; __i++)
                            w.Vocabulary += t[__i];
                        w.Vocabulary = w.Vocabulary.Trim();
                        w.Audio = Classes.Utility.GetAudioByWord(t[0]);
                    }
                    if (word[i][0] == '*')
                    {
                        Mean _m = new Mean();
                        var j = i + 1;

                        _m.TypeWord = word[i].Remove(0, 1).Trim();

                        while (j < word.Count)
                        {
                            if (word[j] != "")
                            {
                                if (word[j][0] == '-')
                                {
                                    _m.Meanings.Add(word[j].Remove(0, 1).Trim());
                                    _m.Examples.Add(_m.Meanings.Count - 1, new List<string>());
                                }
                                else if (word[j][0] == '=')
                                {
                                    try
                                    {
                                        _m.Examples[_m.Meanings.Count - 1].Add(word[j].Remove(0, 1).Trim());
                                    }
                                    catch (Exception)
                                    {
                                        _m.Examples.Add(_m.Meanings.Count - 1, new List<string>());
                                        _m.Examples[_m.Meanings.Count - 1].Add(word[j].Remove(0, 1).Trim());
                                    }
                                }
                                else
                                    break;
                            }
                            j++;
                        }
                        w.Means.Add(_m);
                        i = j - 1;
                    }
                    if (word[i][0] == '!')
                    {
                        Word _w = new Word();
                        Mean _m = new Mean();
                        var j = i + 1;
                        _w.Vocabulary = word[i].Remove(0, 1).Trim();

                        while (j < word.Count)
                        {
                            if (word[j] != "")
                            {
                                if (word[j][0] == '-')
                                {
                                    _m.Meanings.Add(word[j].Remove(0, 1).Trim());
                                    _m.Examples.Add(_m.Meanings.Count - 1, new List<string>());
                                }
                                else if (word[j][0] == '=')
                                {
                                    try
                                    {
                                        _m.Examples[_m.Meanings.Count - 1].Add(word[j].Remove(0, 1).Trim());
                                    }
                                    catch (Exception)
                                    {
                                        _m.Examples.Add(_m.Meanings.Count - 1, new List<string>());
                                        _m.Examples[_m.Meanings.Count - 1].Add(word[j].Remove(0, 1).Trim());
                                    }
                                }
                                else
                                    break;
                            }
                            j++;
                        }
                        _w.Means.Add(_m);
                        w.SubWords.Add(_w);
                        i = j - 1;
                    }
                }
            }

            if (w.Vocabulary == "" || w.Vocabulary == null)
                return;
            int letter = w.Vocabulary.ToLower()[0];
            if (letter - 97 < 0 || letter - 97 > 25)
            {
                WordsAlphabet[26].Add(w);
                Maps[26].Add(w.Vocabulary, WordsAlphabet[26].Count - 1);
            }
            else
            {
                WordsAlphabet[letter - 97].Add(w);
                Maps[letter - 97].Add(w.Vocabulary, WordsAlphabet[letter - 97].Count - 1);
            }

        }
        public bool LoadData()
        {
            try
            {
                string[] dataLines = System.IO.File.ReadAllLines(Path);
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
                        word.Add(line);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion


        #region search
        public Dictionary<string, int> SearchByFristString(string q)
        {
            q = q.ToLower();

            Dictionary<string, int> search = new Dictionary<string, int>();
            int letter = q[0];
            if (letter - 97 < 0 || letter - 97 > 25)
            {
                foreach(var i in Maps[26])
                    if (i.Key.ToLower().Contains(q))
                        search.Add(i.Key, i.Value);
            }
            else
            {
                foreach (var i in Maps[letter - 97])
                    if (i.Key.ToLower().Contains(q))
                        search.Add(i.Key, i.Value);
            }
            return search;
        }
        public Dictionary<string, int> SearchByString(string q)
        {
            q = q.ToLower();

            Dictionary<string, int> search = new Dictionary<string, int>();
            int ind = q[0] - 97;
            if (ind < 0 || ind > 25)
                ind = 26;
            for (int i=0; i<27; i++)
            {
                if (i != ind)
                    foreach (var k in Maps[i])
                        if (k.Key.ToLower().Contains(q))
                            search.Add(k.Key, k.Value);
            }
            return search;
        }
        #endregion
    }
}
