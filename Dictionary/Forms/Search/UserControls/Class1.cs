using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms.Search.UserControls
{
    class Class1 : Button
    {
        public Class1()
        {
            ClientSizeChanged += new EventHandler(eventSizeChange);
            FlatAppearance.BorderSize = 0;
            BackColor = System.Drawing.Color.SeaGreen;
            FlatStyle = FlatStyle.Flat;


            Classes.Utility.RoundedControl(this);
        }

        private void eventSizeChange(object sender, EventArgs e)
        {
            Classes.Utility.RoundedControl(this);
        }
    }
}
