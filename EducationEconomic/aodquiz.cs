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
    public partial class aodquiz : Form
    {
        public aodquiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aodquiz1 aodq = new aodquiz1();
            aodq.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aodquiz2 aodqq = new aodquiz2();
            aodqq.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aodquiz3 aodqqq = new aodquiz3();
            aodqqq.Show(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            aodquiz4 aodqqqq = new aodquiz4();
            aodqqqq.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aodquiz5 aodqqqqq = new aodquiz5();
            aodqqqqq.Show(this);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            final2 aodqqqqqq = new final2();
            aodqqqqqq.Show(this);
            this.Hide();
        }

        private void aodquiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            quizz cdho = new quizz();
            cdho.Show();
            this.Hide();
        }
    }
}
