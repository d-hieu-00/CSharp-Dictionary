using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Resources.Model
{
    class Result
    {
        public List<string> Results { get; set; }
        public List<Dictionary<Word, Word>> DetailResult { get; set; }
        public Result()
        {
            Results = new List<string>();
            DetailResult = new List<Dictionary<Word, Word>>();
        }
        public Result(Result result)
        {
            Results = (List<string>)Classes.Utility.CloneList(result.Results);
            DetailResult = new List<Dictionary<Word, Word>>();
            foreach (var i in result.DetailResult)
                DetailResult.Add(Classes.Utility.CloneDictionaryCloningValues(i));
        }
        public Result Clone()
        {
            return new Result(this);
        }
    }
}
