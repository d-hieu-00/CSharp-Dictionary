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
        public Search searchForm;
        public Games gamesForm;
        public MainForm mainForm;
        public bool loadDone = false;

        public MainRes()
        {
            practiceForm = new PracticeForm();
            searchForm = new Search();
            gamesForm = new Games();
            mainForm = new MainForm();
            loadDone = true;
        }
    }
}
