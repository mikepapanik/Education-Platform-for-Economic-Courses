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
    public partial class epilogkathigit : Form
    {
        public epilogkathigit()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mailform mailf = new mailform();
            mailf.Show(this);
            this.Hide();
        }

        private void epilogkathigit_FormClosing(object sender, FormClosingEventArgs e)
        {
            startkathig aree = new startkathig();
            aree.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            statkathigit statkath = new statkathigit();
            statkath.Show(this);
            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "EducationHelp/educationn.chm", HelpNavigator.TopicId, "21");
        }
    }
}
