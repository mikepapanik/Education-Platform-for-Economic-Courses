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
    public partial class aoth : Form
    {
        public aoth()
        {
            InitializeComponent();
        }

        private void aoth_FormClosing(object sender, FormClosingEventArgs e)
        {
            theory cho = new theory();
            cho.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kefff1 kef = new kefff1();
            kef.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kef2 kefd = new kef2();
            kefd.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kef3 keffd = new kef3();
            keffd.Show(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kef4 keffdd = new kef4();
            keffdd.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kef5 keffddd = new kef5();
            keffddd.Show(this);
            this.Hide();
        }
    }
}
