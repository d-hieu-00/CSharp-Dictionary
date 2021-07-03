using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms.Practice
{
    public partial class PracticeForm : Form
    {
        public PracticeForm()
        {
            InitializeComponent();
        }
        private void PracticeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Resources.Resources.main.practiceForm = new PracticeForm();
        }
    }
}
