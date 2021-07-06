using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Resources.Model
{
    class DataPractice
    {
        public List<Topic> Topics { get; }
        public List<string> Result { get; set; }
        public List<Dictionary<Word,Word>> DetailResult { get; set; }
        public DataPractice()
        {

        }
        public void LoadData()
        {

        }
        public void ReloadData()
        {

        }
        public bool AddTopic()
        {
            return true;
        }
    }
}
