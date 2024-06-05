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
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            theory theor = new theory();
            theor.Show(this);
            this.Hide();
        }

        private void Choice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            quizz qui = new quizz();
            qui.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mailform mailf = new mailform();
            mailf.Show(this);
            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "EducationHelp/educationn.chm", HelpNavigator.TopicId, "17");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stat st = new stat();
            st.Show(this);
            this.Hide();
        }
    }
}
