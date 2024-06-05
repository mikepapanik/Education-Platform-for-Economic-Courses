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
    public partial class quizz : Form
    {
        public quizz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quizform1 aowd = new quizform1();
            aowd.Show(this);
            this.Hide();
        }

        private void quizz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Choice fotye = new Choice();
            fotye.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aodquiz aoddquiz = new aodquiz();
            aoddquiz.Show(this);
            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "EducationHelp/educationn.chm", HelpNavigator.TopicId, "13");
        }
    }
}
