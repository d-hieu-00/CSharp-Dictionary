using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Resources.Model
{
    class User
    {
        public Dictionary<int, Dictionary<string, int>> History { get; set; }
        public Dictionary<int, Dictionary<string, int>> Favorite { get; set; }
        public Dictionary<string, int> Settings { get; set; }
        // key: name, value: path
        public Dictionary<string, string> PathDics { get; set; }
        public string KeyApiTrans = "";
        #region init
        public User()
        {
            History = new Dictionary<int, Dictionary<string, int>>();
            Favorite = new Dictionary<int, Dictionary<string, int>>();
            Settings = new Dictionary<string, int>();
            PathDics = new Dictionary<string, string>();
        }
        private string[] GetStringUser()
        {
            List<string> tmp = new List<string>();
            tmp.Add("@History");
            foreach(var k in History.Keys)
            {
                var v = History[k];
                tmp.Add('*' + k.ToString());
                foreach(var _k in v.Keys)
                {
                    var _v = v[_k];
                    tmp.Add('-' + _k + '\t' + _v.ToString());
                }
            }
            tmp.Add("@Favorite");
            foreach (var k in Favorite.Keys)
            {
                var v = Favorite[k];
                tmp.Add('*' + k.ToString());
                foreach (var _k in v.Keys)
                {
                    var _v = v[_k];
                    tmp.Add('-' + _k + '\t' + _v.ToString());
                }
            }
            tmp.Add("@Settings");
            foreach (var k in Settings.Keys)
            {
                var v = Settings[k];
                tmp.Add('-' + k + '\t' + v.ToString());
            }
            tmp.Add("@PathDics");
            foreach (var k in PathDics.Keys)
            {
                var v = PathDics[k];
                tmp.Add('-' + k + '\t' + @v);
            }
            tmp.Add("@KeyApiTrans");
            tmp.Add(KeyApiTrans);
            return tmp.ToArray();
        }
        public bool LoadUser()
        {
            if (!File.Exists(Classes.Config.DirConfig + Classes.Config.NameFileConfig))
            {
                Save();
                return true;
            }
            string[] dataLines = File.ReadAllLines(Classes.Config.DirConfig + Classes.Config.NameFileConfig);
            for (var i=0; i<dataLines.Length; i++)
            {
                if (dataLines[i] == "@History")
                {
                    for (var j=i+1; j<dataLines.Length; j++)
                    {
                        if (dataLines[j][0] == '@')
                        {
                            i = j - 1;
                            break;
                        }
                        if (dataLines[j][0] == '*')
                        {
                            var k = dataLines[j].TrimStart('*');
                            Dictionary<string, int> _t = new Dictionary<string, int>();
                            for (var _j=j+1; _j<dataLines.Length; _j++)
                            {
                                if (dataLines[_j][0] == '*' || dataLines[_j][0] == '@')
                                {
                                    j = _j - 1;
                                    break;
                                }
                                var d = dataLines[_j].Split('\t');
                                _t.Add(d[0].TrimStart('-'), Convert.ToInt32(d[1]));
                            }
                            History.Add(Convert.ToInt32(k), _t);
                        }
                    }
                } 
                else if (dataLines[i] == "@Favorite")
                {
                    for (var j = i + 1; j < dataLines.Length; j++)
                    {
                        if (dataLines[j][0] == '@')
                        {
                            i = j - 1;
                            break;
                        }
                        if (dataLines[j][0] == '*')
                        {
                            var k = dataLines[j].TrimStart('*');
                            Dictionary<string, int> _t = new Dictionary<string, int>();
                            for (var _j = j + 1; _j < dataLines.Length; _j++)
                            {
                                if (dataLines[_j][0] == '*' || dataLines[_j][0] == '@')
                                {
                                    j = _j - 1;
                                    break;
                                }
                                var d = dataLines[_j].Split('\t');
                                _t.Add(d[0].TrimStart('-'), Convert.ToInt32(d[1]));
                            }
                            Favorite.Add(Convert.ToInt32(k), _t);
                        }
                    }
                }
                else if (dataLines[i] == "@Settings")
                {
                    for (var j = i + 1; j < dataLines.Length; j++)
                    {
                        if (dataLines[j][0] == '@')
                        {
                            i = j - 1;
                            break;
                        }
                        var d = dataLines[j].Split('\t');
                        Settings.Add(d[0].TrimStart('-'), Convert.ToInt32(d[1]));
                    }
                }
                else if (dataLines[i] == "@PathDics")
                {
                    for (var j = i + 1; j < dataLines.Length; j++)
                    {
                        if (dataLines[j][0] == '@')
                        {
                            i = j - 1;
                            break;
                        }
                        var d = dataLines[j].Split('\t');
                        PathDics.Add(d[0].TrimStart('-'), @d[1]);
                    }
                }
                else if (dataLines[i] == "@KeyApiTrans")
                {
                    KeyApiTrans = dataLines[i + 1];
                    i++;
                }
            }
            return true;
        }
        public bool Save()
        {
            try
            {
                if (!Directory.Exists(Classes.Config.DirConfig))
                    Directory.CreateDirectory(Classes.Config.DirConfig);

                File.WriteAllLines(Classes.Config.DirConfig + Classes.Config.NameFileConfig, GetStringUser());
            } catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region add, remove
        public bool AddUpdateHistory(int indDic, string val, int key)
        {
            try
            {
                if (!History.ContainsKey(indDic))
                    History.Add(indDic, new Dictionary<string, int>());
                if (History[indDic].ContainsKey(val))
                    History[indDic].Remove(val);
                History[indDic].Add(val, key);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddUpdateFavorite(int indDic, string val, int key)
        {
            try
            {
                if (!Favorite.ContainsKey(indDic))
                    Favorite.Add(indDic, new Dictionary<string, int>());
                if (!Favorite[indDic].ContainsKey(val))
                    Favorite[indDic].Add(val, key);
                else
                    Favorite[indDic][val] = key;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddUpdateSettings(string key, int val)
        {
            try
            {
                if (!Settings.ContainsKey(key))
                    Settings.Add(key, val);
                else
                    Settings[key] = val;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddUpdatePathDics(string key, string val)
        {
            try
            {
                PathDics.Add(key, val);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveHistory(int indDic, string val)
        {
            try
            {
                return History[indDic].Remove(val);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool RemoveFavorite(int indDic, string val)
        {
            try
            {
                return Favorite[indDic].Remove(val);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool RemoveSettings(string val)
        {
            try
            {
                return Settings.Remove(val);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool RemovePathDics(string val)
        {
            try
            {
                return PathDics.Remove(val);
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
