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
    public partial class quizform1 : Form
    {
        public quizform1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aquiz1 aqui = new aquiz1();
            aqui.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aquiz2 aquie = new aquiz2();
            aquie.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aquiz3 aqudie = new aquiz3();
            aqudie.Show(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            aquiz4 aqudide = new aquiz4();
            aqudide.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aquiz5 aqudidde = new aquiz5();
            aqudidde.Show(this);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            final1 finn = new final1();
            finn.Show(this);
            this.Hide();
        }

        private void quizform1_FormClosing(object sender, FormClosingEventArgs e)
        {
            quizz fote = new quizz();
            fote.Show();
            this.Hide();
        }
    }
}
