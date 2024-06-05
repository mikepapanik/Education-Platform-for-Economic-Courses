using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationEconomic
{
    public partial class Form1 : Form
    {
        public static string username = "";
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 regist = new Form2();
            regist.Show(this);
            this.Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string usr = userNameTextBox.Text;
            string psw = PasswordTextBox.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Userap.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Userapp where Username='" + userNameTextBox.Text + "' AND Password='" + PasswordTextBox.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                username = userNameTextBox.Text;
                Choice choc = new Choice();
                choc.Show(this);
                this.Hide();

                MessageBox.Show("Έχετε Εισέλθει με Επιτυχία στην Εφαρμογή.");
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }

            con.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            arx qeeee = new arx();
            qeeee.Show();
            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "EducationHelp/educationn.chm", HelpNavigator.TopicId, "20");
        }

        private void loginbutton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για Είσοδο!!", loginbutton);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για Εγγραφή στην Εφαρμογή!!", button2);
        }
    }
}
