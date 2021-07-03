using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Resources.Model
{
    class Word
    {
        public string Vocabulary { get; set; }
        public string Pronounce { get; set; }
        public string Audio { get; set; }
        public List<Mean> Means { get; set; }
        public List<Word> SubWords { get; set; }
        public Word()
        {
            Vocabulary = null;
            Pronounce = null;
            Audio = null;
            Means = new List<Mean>();
            SubWords = new List<Word>();
        }
        public Word(Word word)
        {
            Vocabulary = word.Vocabulary;
            Pronounce = word.Pronounce;
            Audio = word.Audio;
            Means = new List<Mean>();
            SubWords = new List<Word>();
            foreach (var i in word.Means)
                Means.Add(i.Clone());
            foreach (var i in word.SubWords)
                SubWords.Add(i.Clone());
        }
        public Word Clone()
        {
            return new Word(this);
        }
    }
}
