using Dictionary.Resources.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Resources
{
    class DataPractice
    {
        public List<Topic> Topics { get; }
        public List<Result> Results { get; }
        
        public DataPractice()
        {
            Topics = new List<Topic>();
            Results = new List<Result>();
        }
        public bool LoadData()
        {
            var dir = Directory.GetDirectories(Classes.Config.DirDataTopic);
            foreach (var i in dir)
            {
                var t = new Topic();
                t.Path = i;
                if (!t.LoadData())
                    return false;
                Topics.Add(t);
            }
            if (!File.Exists(Classes.Config.DirConfig + Classes.Config.NameFileResult))
            {
                if (Results.Count != 3)
                {
                    Results.Clear();
                    Results.Add(new Result());
                    Results.Add(new Result());
                    Results.Add(new Result());
                }
                Save();
                return true;
            }
            try
            {
                string[] dataLines = File.ReadAllLines(Classes.Config.DirConfig + Classes.Config.NameFileResult);
                for (var i = 0; i < dataLines.Length; i++)
                {
                    if (dataLines[i][0] == '@')
                    {
                        var r = new Result();
                        for (var j = i + 1; j < dataLines.Length; j++)
                        {
                            if (dataLines[j][0] == '-')
                            {
                                r.Results.Add(dataLines[j].Remove(0, 1));
                                var l = new List<string>();
                                for (var _j = j + 1; _j < dataLines.Length; _j++)
                                {
                                    if (dataLines[j][0] == '+')
                                        l.Add(dataLines[_j].Remove(0, 1));
                                    else
                                    {
                                        j = _j - 1;
                                        break;
                                    }
                                }
                                r.DetailResult.Add(l);
                            }
                            else
                            {
                                i = j - 1;
                                break;
                            }
                        }
                        Results.Add(r);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ReloadData()
        {
            Topics.Clear();
            Results.Clear();
            return LoadData();
        }
        public bool Save()
        {
            List<string> save = new List<string>();
            for (var i=0; i<Results.Count; i++)
            {
                save.Add("@");
                for (var j=0; j<Results[i].Results.Count; j++)
                {
                    save.Add("-" + Results[i].Results[j]);
                    for (var _j = 0; _j < Results[i].DetailResult[j].Count; _j++)
                        save.Add("+" + Results[i].DetailResult[j][_j]);
                }
            }
            try
            {
                if (!Directory.Exists(Classes.Config.DirConfig))
                    Directory.CreateDirectory(Classes.Config.DirConfig);

                File.WriteAllLines(Classes.Config.DirConfig + Classes.Config.NameFileResult, save.ToArray());
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool AddTopic()
        {
            return true;
        }
    }
}
