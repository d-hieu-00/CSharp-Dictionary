using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms.Search.UserControls
{
    class s_ButtonRound : Button
    {
        public s_ButtonRound()
        {
            ClientSizeChanged += new EventHandler(eventSizeChange);
            FlatAppearance.BorderSize = 0;
            BackColor = System.Drawing.Color.MediumSpringGreen;
            FlatStyle = FlatStyle.Flat;


            Classes.Utility.RoundedControl(this);
        }
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
        private void eventSizeChange(object sender, EventArgs e)
        {
            Classes.Utility.RoundedControl(this);
        }
    }
}
