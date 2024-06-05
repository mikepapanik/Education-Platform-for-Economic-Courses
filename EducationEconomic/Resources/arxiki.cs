using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationEconomic.Resources
{
    public partial class arxiki : Form
    {
        public arxiki()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mathi = new Form1();
            mathi.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void arxiki_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("Are you sure want exit from application?", "Smart Quarantine Exit", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes)
            {
                e.Cancel = false;


            }
            else if (dialogResult1 == DialogResult.No)
            {

                e.Cancel = true;
            }
        }
    }
}
