using Dictionary.Forms.Search;
using Dictionary.Forms.Game;
using Dictionary.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictionary.Forms.Practice;

namespace Dictionary.Resources
{
    class MainRes
    {
        public PracticeForm practiceForm;
        public Games gamesForm;
        public Search searchForm;
        public MainForm mainForm;
        public bool loadDone = false;

        public MainRes()
        {
            practiceForm = new PracticeForm();
            gamesForm = new Games();
            searchForm = new Search();
            mainForm = new MainForm();
            loadDone = true;
        }
    }
}
