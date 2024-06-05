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
    public partial class startkathig : Form
    {
        public static string username = "";
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public startkathig()
        {
            InitializeComponent();
        }

        private void startkathig_FormClosing(object sender, FormClosingEventArgs e)
        {
            arx rtt = new arx();
            rtt.Show();
            this.Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string usr = userNameTextBox.Text;
            string psw = PasswordTextBox.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Kathigit.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Kath where Username='" + userNameTextBox.Text + "' AND Password='" + PasswordTextBox.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                username = userNameTextBox.Text;
                epilogkathigit choce = new epilogkathigit();
                choce.Show(this);
                this.Hide();

                MessageBox.Show("Έχετε Εισέλθει με Επιτυχία στην Εφαρμογή.");
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }

            con.Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "EducationHelp/educationn.chm", HelpNavigator.TopicId, "21");
        }
    }
}
