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
    public partial class aode : Form
    {
        public aode()
        {
            InitializeComponent();
        }

        private void aode_FormClosing(object sender, FormClosingEventArgs e)
        {
            theory cho = new theory();
            cho.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            akef1 akef = new akef1();
            akef.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            akef2 akefd = new akef2();
            akefd.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            akef3 akef22 = new akef3();
            akef22.Show(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            akef4 ake4f22 = new akef4();
            ake4f22.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            akef5 akef2552 = new akef5();
            akef2552.Show(this);
            this.Hide();
        }
    }
}
