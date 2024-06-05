using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationEconomic
{
    public partial class theory : Form
    {
        public theory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aoth aot = new aoth();
            aot.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aode aod = new aode();
            aod.Show(this);
            this.Hide();
        }

        private void theory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Choice ffore = new Choice();
            ffore.Show();
            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "EducationHelp/educationn.chm", HelpNavigator.TopicId, "11");
        }
    }
}
