using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace EducationEconomic
{
    public partial class mailform : Form
    {
        sendmails msg;
        public mailform()
        {
            InitializeComponent();
        }

        private void mailform_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendmails msender = new sendmails();

            msender.Sendmail(textBox1, textBox2);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.Show("Στείλτε το μήνυμα σας ", button1);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Στείλτε το μήνυμα σας ", button1);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "EducationHelp/educationn.chm", HelpNavigator.TopicId, "12");
        }
    }
}
