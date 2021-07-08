using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Resources.Model
{
    public class Result
    {
        public List<string> Results { get; set; }
        public List<List<string>> DetailResult { get; set; }
        public Result()
        {
            Results = new List<string>();
            DetailResult = new List<List<string>>();
        }
        public Result(Result result)
        {
            Results = (List<string>)Classes.Utility.CloneList(result.Results);
            DetailResult = new List<List<string>>();
            foreach (var i in result.DetailResult)
                DetailResult.Add((List<string>)Classes.Utility.CloneList(i));
        }
        public Result Clone()
        {
            return new Result(this);
        }
        public void Clear()
        {
            Results.Clear();
            DetailResult.Clear();
        }
    }
}
