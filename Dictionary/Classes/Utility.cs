using Dictionary.Resources.Model;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Net.Http;
using Newtonsoft.Json;

namespace Dictionary.Classes
{
    static class Utility
    {
        #region Rounded Control
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public static void RoundedControl(Control control)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, Config.DefaultRounded, Config.DefaultRounded));
        }
        public static void RoundedControl(Control control, int r)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, r, r));
        }
        public static void RoundedControl(Control control, int x, int y, int rw, int rh)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(x, y, control.Width, control.Height, rw, rh));
        }
        #endregion
        /** add to form to make shadow
         * 
         * 
        #region make shadow from
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000;
                return cp;
            }
        }
        #endregion
        */
        #region List, Dictionary
        public static IList<T> CloneList<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
        public static Dictionary<TKey, TValue> CloneDictionaryCloningValues<TKey, TValue>
            (Dictionary<TKey, TValue> original) where TValue : ICloneable
        {
            Dictionary<TKey, TValue> ret = new Dictionary<TKey, TValue>(original.Count, original.Comparer);
            foreach (KeyValuePair<TKey, TValue> entry in original)
            {
                ret.Add(entry.Key, (TValue)entry.Value.Clone());
            }
            return ret;
        }
        public static Dictionary<string, int> CloneDictionaryCloningValues
           (Dictionary<string, int> original)
        {
            Dictionary<string, int> ret = new Dictionary<string, int>(original.Count, original.Comparer);
            foreach (KeyValuePair<string, int> entry in original)
            {
                ret.Add(entry.Key, (int)entry.Value);
            }
            return ret;
        }
        public static Dictionary<int, List<string>> CloneDictionaryCloningValues
            (Dictionary<int, List<string>> original)
        {
            Dictionary<int, List<string>> ret = new Dictionary<int, List<string>>(original.Count, original.Comparer);
            foreach (KeyValuePair<int, List<string>> entry in original)
            {
                ret.Add(entry.Key, (List<string>)CloneList(entry.Value));
            }
            return ret;
        }
        public static Dictionary<int, Dictionary<string, int>> CloneDictionaryCloningValues
            (Dictionary<int, Dictionary<string, int>> original)
        {
            Dictionary<int, Dictionary<string, int>> ret = new Dictionary<int, Dictionary<string, int>>(original.Count, original.Comparer);
            foreach (KeyValuePair<int, Dictionary<string, int>> entry in original)
            {
                ret.Add(entry.Key, CloneDictionaryCloningValues(entry.Value));
            }
            return ret;
        }
        #endregion
        #region Audio
        public static string GetAudioByWord(string w)
        {
            string audio = null; 
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string jsonString;
            try
            {
                jsonString = new WebClient().DownloadString(Config.ApiAudio + w.Trim());
            } catch (Exception)
            {
                return null;
            }

            var s = jsonString.Split(',');
            foreach (var i in s)
            {
                if (i.Contains("audio"))
                {
                    audio = "";
                    for (var _i = 9; _i < i.Length; _i++)
                        if (i[_i] == '"')
                            break;
                        else 
                            audio += i[_i];
                }
            }

            return audio;
        }
        public static void SpeechString(string q)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            
/*            var l = ss.GetInstalledVoices();
            ss.SelectVoice(l[1].VoiceInfo.Name);*/

            ss.SpeakAsync(q);
        }
        public static void PlayMp3FromUrl(string url)
        {
            using (var mf = new MediaFoundationReader(url))
            using (var wo = new WaveOutEvent())
            {
                wo.Init(mf);
                wo.Play();
                Resources.Resources.main.searchForm.Invoke(new MethodInvoker(delegate ()
                {
                    Resources.Resources.main.searchForm.Cursor = Cursors.Default;
                }));
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            }
        }
        public static void PlayMp3GameFromUrl(string url)
        {
            if (!Config.PlaySoundGame)
                return;
            using (var mf = new MediaFoundationReader(url))
            using (var wo = new WaveOutEvent())
            {
                wo.Init(mf);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }
        public static Thread PlayMp3GameFromUrlBackground(string url)
        {
            if (!Config.PlaySoundGame)
                return null;
            var _t = new Thread(() =>
            {
                using (var mf = new MediaFoundationReader(url))
                using (var wo = new WaveOutEvent())
                {
                    wo.Init(mf);
                    wo.Play();
                    while (wo.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(1000);
                    }
                }
            });
            _t.Start();
            return _t;
        }
        #endregion
        #region richTexBox, Word, Dictionary
        public static void RtboxAppendText(RichTextBox box, string text, Color color, Font f)
        {
            box.SelectionFont = f;
            box.SelectionColor = color;
            box.SelectedText = text;
        }
        public static Word ReadWord(List<string> word)
        {
            Word w = new Word();
            for (var i = 0; i < word.Count; i++)
            {
                if (word[i] != "")
                {
                    if (word[i][0] == '@')
                    {
                        var t = word[i].Remove(0, 1).Split('(')[0].Split('/');
                        if (t.Length > 1)
                        {
                            w.Pronounce = '/' + t[t.Length - 2] + '/';
                            t[t.Length - 2] = "";
                            w.Vocabulary = t[0];
                            for (var __i = 1; __i < t.Length - 2; __i++)
                            {
                                w.Vocabulary += '/' + t[__i];
                            }
                        }
                        else
                            w.Vocabulary = t[0];
                        w.Vocabulary = w.Vocabulary.Trim();
                    }
                    if (word[i][0] == '*' || word[i][0] == '-')
                    {
                        Mean _m = new Mean();
                        _m.SubMeans.Add(_m.Meanings.Count - 1, new List<string>());
                        _m.Examples.Add(_m.Meanings.Count - 1, new List<string>());
                        var j = i;
                        if (word[i][0] == '*')
                        {
                            j++;
                            _m.TypeWord = word[i].Remove(0, 1).Trim();
                        }

                        while (j < word.Count)
                        {
                            if (word[j] != "")
                            {
                                if (word[j][0] == '-')
                                {
                                    // mean
                                    _m.Meanings.Add(word[j].Remove(0, 1).Trim());
                                    _m.SubMeans.Add(_m.Meanings.Count - 1, new List<string>());
                                    _m.Examples.Add(_m.Meanings.Count - 1, new List<string>());
                                }
                                else if (word[j][0] == '+')
                                {
                                    //sub mean
                                    _m.SubMeans[_m.Meanings.Count - 1].Add(word[j].Remove(0, 1).Trim());
                                }
                                else if (word[j][0] == '=')
                                {
                                    //example
                                    _m.Examples[_m.Meanings.Count - 1].Add(word[j].Remove(0, 1).Trim());
                                }
                                else
                                    break;
                            }
                            j++;
                        }
                        w.Means.Add(_m);
                        if (j == word.Count)
                            break;
                        else
                            i = j - 1;
                    }
                    if (word[i][0] == '!')
                    {
                        Word _w = new Word();
                        var j = i + 1;
                        _w.Vocabulary = word[i].Remove(0, 1).Trim();

                        while (j < word.Count)
                        {
                            if (word[j] != "")
                            {
                                if (word[j][0] == '*' || word[j][0] == '-')
                                {
                                    Mean _m = new Mean();
                                    _m.SubMeans.Add(_m.Meanings.Count - 1, new List<string>());
                                    _m.Examples.Add(_m.Meanings.Count - 1, new List<string>());

                                    var _j = j;
                                    if (word[j][0] == '*')
                                    {
                                        _j++;
                                        _m.TypeWord = word[j].Remove(0, 1).Trim();
                                    }
                                    while (_j < word.Count)
                                    {
                                        if (word[_j] != "")
                                        {
                                            if (word[_j][0] == '-')
                                            {
                                                // mean
                                                _m.Meanings.Add(word[_j].Remove(0, 1).Trim());
                                                _m.SubMeans.Add(_m.Meanings.Count - 1, new List<string>());
                                                _m.Examples.Add(_m.Meanings.Count - 1, new List<string>());
                                            }
                                            else if (word[_j][0] == '+')
                                            {
                                                //sub mean
                                                _m.SubMeans[_m.Meanings.Count - 1].Add(word[_j].Remove(0, 1).Trim());
                                            }
                                            else if (word[_j][0] == '=')
                                            {
                                                //example
                                                _m.Examples[_m.Meanings.Count - 1].Add(word[_j].Remove(0, 1).Trim());
                                            }
                                            else
                                                break;
                                        }
                                        _j++;
                                    }
                                    _w.Means.Add(_m);
                                    j = _j - 1;
                                }
                                else
                                    break;
                            }
                            j++;
                        }
                        w.SubWords.Add(_w);
                        if (j == word.Count)
                            break;
                        else
                            i = j - 1;
                    }
                }
            }
            return w;
        }
        public static string[] WriteWord(Word word)
        {
            List<string> w = new List<string>();
            w.Add("@" + word.Vocabulary + ' ' + word.Pronounce);
            for (int i=0; i<word.Means.Count; i++)
            {
                if (word.Means[i].TypeWord != null && word.Means[i].TypeWord != "")
                    w.Add("*" + word.Means[i].TypeWord);
                var means = word.Means[i].Meanings;
                for (var _i=0; _i<means.Count; _i++)
                {
                    w.Add("-" + means[_i]);
                    var sub = word.Means[i].SubMeans[_i];
                    var exm = word.Means[i].Examples[_i];
                    foreach (var s in sub)
                        w.Add("+" + s);
                    foreach (var e in exm)
                        w.Add("=" + e);
                }
            }
            for (int i = 0; i < word.SubWords.Count; i++)
            {
                w.Add("!" + word.SubWords[i].Vocabulary);
                var _w = word.SubWords[i];
                foreach(var _m in _w.Means)
                {
                    if (_m.TypeWord != null && _m.TypeWord != "")
                        w.Add("*" + _m.TypeWord);
                    var means = _m.Meanings;
                    for (var _i = 0; _i < means.Count; _i++)
                    {
                        w.Add("-" + means[_i]);
                        var sub = _m.SubMeans[_i];
                        var exm = _m.Examples[_i];
                        foreach (var s in sub)
                            w.Add("+" + s);
                        foreach (var e in exm)
                            w.Add("=" + e);
                    }
                }
            }
            return w.ToArray();
        }
        public static void LoadWord(string val, int indVal, int indDic, RichTextBox rTBox_Word)
        {
            rTBox_Word.Invoke(new MethodInvoker(delegate ()
            {
                Word w = Resources.Resources.dics[indDic].GetWord(val, indVal);
                rTBox_Word.SuspendLayout();
                rTBox_Word.Text = "";
                rTBox_Word.Tag = w;
                rTBox_Word.Name = val + '\t' + indVal.ToString() + '\t' + indDic.ToString();

                // vocabulary and pronouce
                RtboxAppendText(rTBox_Word, w.Vocabulary,
                    Config.colorVoc, 
                    new Font("Segoe UI", 13F, FontStyle.Bold));
                if (w.Pronounce != null && w.Pronounce != "")
                    RtboxAppendText(rTBox_Word, '\n' + w.Pronounce,
                        Config.colorPro, 
                        new Font("Segoe UI", 12F, FontStyle.Regular));
                // means
                for (var i = 0; i < w.Means.Count; i++)
                {
                    if (w.Means[i].TypeWord != null)
                    {
                        RtboxAppendText(rTBox_Word, "\n* " + w.Means[i].TypeWord,
                            Config.colorTyp,
                            new Font("Segoe UI", 11F, FontStyle.Bold));
                    }

                    for (var _i = 0; _i < w.Means[i].Meanings.Count; _i++)
                    {
                        RtboxAppendText(rTBox_Word, "\n   - " + w.Means[i].Meanings[_i],
                            Config.colorMea,
                            new Font("Segoe UI", 11F, FontStyle.Regular));
                        // sub mean, exam
                        var subMean = w.Means[i].SubMeans[_i];
                        var exam = w.Means[i].Examples[_i];
                        for (var j = 0; j < subMean.Count; j++)
                        {
                            RtboxAppendText(rTBox_Word, "\n     " + subMean[j],
                                Config.colorSub,
                                new Font("Segoe UI", 10F, FontStyle.Italic));
                        }
                        for (var j = 0; j < exam.Count; j++)
                        {
                            string[] e;
                            if (!exam[j].Contains('+'))
                                e = (exam[j] + '+').Split('+');
                            e = exam[j].Split('+');
                            RtboxAppendText(rTBox_Word, "\n     + \"" + e[0] + '\"',
                                Config.colorExm,
                                new Font("Segoe UI", 10F, FontStyle.Regular));
                            RtboxAppendText(rTBox_Word, " - " + e[1],
                                Config.colorExm,
                                new Font("Segoe UI", 10F, FontStyle.Italic));
                        }
                    }
                    if (w.Means[i].SubMeans.ContainsKey(-1))
                    {
                        var subMean = w.Means[i].SubMeans[-1];
                        for (var j = 0; j < subMean.Count; j++)
                        {
                            RtboxAppendText(rTBox_Word, "\n     " + subMean[j],
                                Config.colorSub,
                                new Font("Segoe UI", 10F, FontStyle.Italic));
                        }
                    }
                    if (w.Means[i].Examples.ContainsKey(-1))
                    {
                        var exam = w.Means[i].Examples[-1];
                        for (var j = 0; j < exam.Count; j++)
                        {
                            string[] e;
                            if (!exam[j].Contains('+'))
                                e = (exam[j] + '+').Split('+');
                            e = exam[j].Split('+');
                            RtboxAppendText(rTBox_Word, "\n     + \"" + e[0] + '\"',
                                Config.colorExm,
                                new Font("Segoe UI", 10F, FontStyle.Regular));
                            RtboxAppendText(rTBox_Word, " - " + e[1],
                                Config.colorExm,
                                new Font("Segoe UI", 10F, FontStyle.Italic));
                        }
                    }
                }
                // sub word
                for (var __i = 0; __i < w.SubWords.Count; __i++)
                {
                    var _w = w.SubWords[__i];

                    // vocabulary
                    RtboxAppendText(rTBox_Word, "\n# " + _w.Vocabulary,
                        Config.colorSub, 
                        new Font("Segoe UI", 11F, FontStyle.Bold));
                    // means
                    for (var i = 0; i < _w.Means.Count; i++)
                    {
                        if (_w.Means[i].TypeWord != null)
                        {
                            RtboxAppendText(rTBox_Word, "\n   * " + _w.Means[i].TypeWord,
                                Config.colorTyp,
                                new Font("Segoe UI", 11F, FontStyle.Bold));
                        }

                        for (var _i = 0; _i < _w.Means[i].Meanings.Count; _i++)
                        {
                            RtboxAppendText(rTBox_Word, "\n       - " + _w.Means[i].Meanings[_i],
                                Config.colorMea,
                                new Font("Segoe UI", 11F, FontStyle.Regular));
                            // sub mean, exam
                            var subMean = _w.Means[i].SubMeans[_i];
                            var exam = _w.Means[i].Examples[_i];
                            for (var j = 0; j < subMean.Count; j++)
                            {
                                RtboxAppendText(rTBox_Word, "\n        " + subMean[j],
                                    Config.colorSub,
                                    new Font("Segoe UI", 10F, FontStyle.Italic));
                            }
                            for (var j = 0; j < exam.Count; j++)
                            {
                                string[] e;
                                if (!exam[j].Contains('+'))
                                    e = (exam[j] + '+').Split('+');
                                e = exam[j].Split('+');
                                RtboxAppendText(rTBox_Word, "\n          + \"" + e[0] + '\"',
                                    Config.colorExm,
                                    new Font("Segoe UI", 10F, FontStyle.Regular));
                                RtboxAppendText(rTBox_Word, " - " + e[1],
                                    Config.colorExm,
                                    new Font("Segoe UI", 10F, FontStyle.Italic));
                            }
                        }
                        if (_w.Means[i].SubMeans.ContainsKey(-1))
                        {
                            var subMean = _w.Means[i].SubMeans[-1];
                            for (var j = 0; j < subMean.Count; j++)
                            {
                                RtboxAppendText(rTBox_Word, "\n        " + subMean[j],
                                    Config.colorSub,
                                    new Font("Segoe UI", 10F, FontStyle.Italic));
                            }
                        }
                        if (_w.Means[i].Examples.ContainsKey(-1))
                        {
                            var exam = _w.Means[i].Examples[-1];
                            for (var j = 0; j < exam.Count; j++)
                            {
                                string[] e;
                                if (!exam[j].Contains('+'))
                                    e = (exam[j] + '+').Split('+');
                                e = exam[j].Split('+');
                                RtboxAppendText(rTBox_Word, "\n          + \"" + e[0] + '\"',
                                    Config.colorExm,
                                    new Font("Segoe UI", 10F, FontStyle.Regular));
                                RtboxAppendText(rTBox_Word, " - " + e[1],
                                    Config.colorExm,
                                    new Font("Segoe UI", 10F, FontStyle.Italic));
                            }
                        }
                    }
                }
                rTBox_Word.ResumeLayout();
            }));
        }
        public static void LoadWordForView(RichTextBox rTBox_Word, string word)
        {
            Word w = ReadWord(new List<string>(word.Split('\n')));
            rTBox_Word.Invoke(new MethodInvoker(delegate ()
            {
                rTBox_Word.SuspendLayout();
                rTBox_Word.Text = "";
                rTBox_Word.Tag = w;

                // vocabulary and pronouce
                RtboxAppendText(rTBox_Word, w.Vocabulary,
                    Config.colorVoc,
                    new Font("Segoe UI", 11F, FontStyle.Bold));
                if (w.Pronounce != null && w.Pronounce != "")
                    RtboxAppendText(rTBox_Word, '\n' + w.Pronounce,
                        Config.colorPro,
                        new Font("Segoe UI", 10F, FontStyle.Regular));
                // means
                for (var i = 0; i < w.Means.Count; i++)
                {
                    if (w.Means[i].TypeWord != null)
                    {
                        RtboxAppendText(rTBox_Word, "\n* " + w.Means[i].TypeWord,
                            Config.colorTyp,
                            new Font("Segoe UI", 9F, FontStyle.Bold));
                    }

                    for (var _i = 0; _i < w.Means[i].Meanings.Count; _i++)
                    {
                        RtboxAppendText(rTBox_Word, "\n   - " + w.Means[i].Meanings[_i],
                            Config.colorMea,
                            new Font("Segoe UI", 9F, FontStyle.Regular));
                        // sub mean, exam
                        var subMean = w.Means[i].SubMeans[_i];
                        var exam = w.Means[i].Examples[_i];
                        for (var j = 0; j < subMean.Count; j++)
                        {
                            RtboxAppendText(rTBox_Word, "\n     " + subMean[j],
                                Config.colorSub,
                                new Font("Segoe UI", 8F, FontStyle.Italic));
                        }
                        for (var j = 0; j < exam.Count; j++)
                        {
                            string[] e;
                            if (!exam[j].Contains('+'))
                                e = (exam[j] + '+').Split('+');
                            e = exam[j].Split('+');
                            RtboxAppendText(rTBox_Word, "\n     + \"" + e[0] + '\"',
                                Config.colorExm,
                                new Font("Segoe UI", 8F, FontStyle.Regular));
                            RtboxAppendText(rTBox_Word, " - " + e[1],
                                Config.colorExm,
                                new Font("Segoe UI", 8F, FontStyle.Italic));
                        }
                    }
                    if (w.Means[i].SubMeans.ContainsKey(-1))
                    {
                        var subMean = w.Means[i].SubMeans[-1];
                        for (var j = 0; j < subMean.Count; j++)
                        {
                            RtboxAppendText(rTBox_Word, "\n     " + subMean[j],
                                Config.colorSub,
                                new Font("Segoe UI", 8F, FontStyle.Italic));
                        }
                    }
                    if (w.Means[i].Examples.ContainsKey(-1))
                    {
                        var exam = w.Means[i].Examples[-1];
                        for (var j = 0; j < exam.Count; j++)
                        {
                            string[] e;
                            if (!exam[j].Contains('+'))
                                e = (exam[j] + '+').Split('+');
                            e = exam[j].Split('+');
                            RtboxAppendText(rTBox_Word, "\n     + \"" + e[0] + '\"',
                                Config.colorExm,
                                new Font("Segoe UI", 8F, FontStyle.Regular));
                            RtboxAppendText(rTBox_Word, " - " + e[1],
                                Config.colorExm,
                                new Font("Segoe UI", 8F, FontStyle.Italic));
                        }
                    }
                }
                // sub word
                for (var __i = 0; __i < w.SubWords.Count; __i++)
                {
                    var _w = w.SubWords[__i];

                    // vocabulary
                    RtboxAppendText(rTBox_Word, "\n# " + _w.Vocabulary,
                        Config.colorSub,
                        new Font("Segoe UI", 9F, FontStyle.Bold));
                    // means
                    for (var i = 0; i < _w.Means.Count; i++)
                    {
                        if (_w.Means[i].TypeWord != null)
                        {
                            RtboxAppendText(rTBox_Word, "\n   * " + _w.Means[i].TypeWord,
                                Config.colorTyp,
                                new Font("Segoe UI", 9F, FontStyle.Bold));
                        }

                        for (var _i = 0; _i < _w.Means[i].Meanings.Count; _i++)
                        {
                            RtboxAppendText(rTBox_Word, "\n       - " + _w.Means[i].Meanings[_i],
                                Config.colorMea,
                                new Font("Segoe UI", 9F, FontStyle.Regular));
                            // sub mean, exam
                            var subMean = _w.Means[i].SubMeans[_i];
                            var exam = _w.Means[i].Examples[_i];
                            for (var j = 0; j < subMean.Count; j++)
                            {
                                RtboxAppendText(rTBox_Word, "\n        " + subMean[j],
                                    Config.colorSub,
                                    new Font("Segoe UI", 8F, FontStyle.Italic));
                            }
                            for (var j = 0; j < exam.Count; j++)
                            {
                                string[] e;
                                if (!exam[j].Contains('+'))
                                    e = (exam[j] + '+').Split('+');
                                e = exam[j].Split('+');
                                RtboxAppendText(rTBox_Word, "\n          + \"" + e[0] + '\"',
                                    Config.colorExm,
                                    new Font("Segoe UI", 8F, FontStyle.Regular));
                                RtboxAppendText(rTBox_Word, " - " + e[1],
                                    Config.colorExm,
                                    new Font("Segoe UI", 8F, FontStyle.Italic));
                            }
                        }
                        if (_w.Means[i].SubMeans.ContainsKey(-1))
                        {
                            var subMean = _w.Means[i].SubMeans[-1];
                            for (var j = 0; j < subMean.Count; j++)
                            {
                                RtboxAppendText(rTBox_Word, "\n        " + subMean[j],
                                    Config.colorSub,
                                    new Font("Segoe UI", 8F, FontStyle.Italic));
                            }
                        }
                        if (_w.Means[i].Examples.ContainsKey(-1))
                        {
                            var exam = _w.Means[i].Examples[-1];
                            for (var j = 0; j < exam.Count; j++)
                            {
                                string[] e;
                                if (!exam[j].Contains('+'))
                                    e = (exam[j] + '+').Split('+');
                                e = exam[j].Split('+');
                                RtboxAppendText(rTBox_Word, "\n          + \"" + e[0] + '\"',
                                    Config.colorExm,
                                    new Font("Segoe UI", 8F, FontStyle.Regular));
                                RtboxAppendText(rTBox_Word, " - " + e[1],
                                    Config.colorExm,
                                    new Font("Segoe UI", 8F, FontStyle.Italic));
                            }
                        }
                    }
                }
                rTBox_Word.ResumeLayout();
            }));
        }
        public static void LoadRuleWord(RichTextBox rTBox_Word)
        {
            rTBox_Word.Invoke(new MethodInvoker(delegate ()
            {
                float fSize = 10F;
                Font f = new Font("Segoe UI", fSize, FontStyle.Regular);
                Font f_bold = new Font("Segoe UI", fSize, FontStyle.Bold);
                Font f_italic = new Font("Segoe UI", fSize, FontStyle.Italic);
                Font f_under = new Font("Segoe UI", fSize, FontStyle.Underline);
                rTBox_Word.SuspendLayout();
                rTBox_Word.Text = "";

                RtboxAppendText(rTBox_Word, "@ từ vựng", Color.Red, f_bold);
                RtboxAppendText(rTBox_Word, " /phát âm/", Color.Black, f);

                RtboxAppendText(rTBox_Word, "\n* loại từ", Color.Black, f);
                RtboxAppendText(rTBox_Word, "\n- nghĩa", Color.Teal, f_under);
                RtboxAppendText(rTBox_Word, "\n+ bổ sung nghĩa", Color.Teal, f);
                RtboxAppendText(rTBox_Word, "\n= ví dụ + nghĩa của ví dụ", Color.Teal, f);

                RtboxAppendText(rTBox_Word, "\n! từ vựng liên quan", Color.Black, f_bold);

                RtboxAppendText(rTBox_Word, "\n* loại từ", Color.Black, f);
                RtboxAppendText(rTBox_Word, "\n- nghĩa", Color.SeaGreen, f_under);
                RtboxAppendText(rTBox_Word, "\n+ bổ sung nghĩa", Color.SeaGreen, f);
                RtboxAppendText(rTBox_Word, "\n= ví dụ + nghĩa của ví dụ", Color.SeaGreen, f);

                RtboxAppendText(rTBox_Word, "\n\n\n\n\n\n------------------- Lưu ý -------------------", Color.Black, new Font("Segoe UI", 8F, FontStyle.Italic));
                RtboxAppendText(rTBox_Word, "\nMàu đỏ: không thể thiếu", Color.Black, new Font("Segoe UI", 9F, FontStyle.Italic));
                RtboxAppendText(rTBox_Word, "\nKý tự đầu dòng {@,*,+,-,=}", Color.Black, new Font("Segoe UI", 9F, FontStyle.Italic));
                RtboxAppendText(rTBox_Word, "\nLưu ý ký tự đầu đúng thứ tự", Color.Black, new Font("Segoe UI", 9F, FontStyle.Italic));
                rTBox_Word.ResumeLayout();
            }));
        }
        public static void ExportFileDic(int indDic)
        {
            var sf = new SaveFileDialog();
            sf.Filter = "txt|*.txt";
            sf.Title = "Xuất từ điển: " + Resources.Resources.dics[indDic].Name;
            var r = sf.ShowDialog();
            if (r == DialogResult.OK)
            {
                if (File.Exists(sf.FileName))
                    Resources.Resources.main.searchForm.Invoke(new MethodInvoker(delegate ()
                    {
                        Resources.Resources.main.searchForm.Cursor = Cursors.WaitCursor;
                        File.WriteAllLines(sf.FileName, Resources.Resources.dics[indDic].ExportString());
                        Resources.Resources.main.searchForm.Cursor = Cursors.Default;
                    }));
                else
                    MessageBox.Show("Lỗi đường dẫn", "Xuất từ điển", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public class Translation
        {
            public string translatedText { get; set; }
        }

        public class Data
        {
            public List<Translation> translations { get; set; }
        }

        public class RootTrans
        {
            public Data data { get; set; }
        }
        public static string TranslateString(string ori)
        {
            var client = new WebClient();
            var key = Config.KeyApiTrans;
            if (Resources.Resources.user.KeyApiTrans != null && Resources.Resources.user.KeyApiTrans != "")
                key = Resources.Resources.user.KeyApiTrans;
            client.Headers.Add("x-rapidapi-key", key);
            client.Headers.Add("x-rapidapi-host", "google-translate1.p.rapidapi.com");
            client.QueryString.Add("q", ori);
            client.QueryString.Add("target", "vi");
            client.QueryString.Add("source", "en");

            try
            {
                byte[] responsebytes = client.UploadValues(@Config.ApiTrans, "POST", client.QueryString);
                var jsonString = Encoding.UTF8.GetString(responsebytes);
                var obj = JsonConvert.DeserializeObject<RootTrans>(jsonString);
                return obj.data.translations[0].translatedText;
            } catch
            {
                return null;
            }
        }
        #endregion
    }
}
