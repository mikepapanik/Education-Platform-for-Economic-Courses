using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace EducationEconomic
{
    public partial class statkathigit : Form
    {
        public statkathigit()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=static.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        string username = Form1.username;
        private void statkathigit_FormClosing(object sender, FormClosingEventArgs e)
        {
            epilogkathigit foyee = new epilogkathigit();
            foyee.Show();
            this.Hide();
        }

        private void statkathigit_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var connectionString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=static.accdb";
            try
            {

                con = new OleDbConnection(connectionString);
                con.Open();

                da = new OleDbDataAdapter("select * from staticc", con);


                var ds = new DataSet();
                da.Fill(ds);
                DataTable table = ds.Tables[0];
                da.Dispose();
                con.Close();

                foreach (DataRow row in table.Rows)
                {
                    var items = new string[]
                    {
                        row[0].ToString(),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        row[4].ToString()

                    };
                    var value = new ListViewItem(items);
                    listView1.Items.Add(value);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var connectionString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=static.accdb";
            try
            {

                con = new OleDbConnection(connectionString);
                con.Open();

                if (textBox1.Text != "" && textBox2.Text == "")
                {
                    da = new OleDbDataAdapter("select * from staticc where username LIKE '%" + textBox1.Text + "%'", con);
                }
                else if (textBox2.Text != "" && textBox1.Text == "")
                {
                    da = new OleDbDataAdapter("select * from staticc where quizname LIKE '%" + textBox2.Text + "%'", con);
                }
                else
                {
                    da = new OleDbDataAdapter("select * from staticc where username LIKE '%" + textBox1.Text + "%' AND quizname LIKE '%" + textBox2.Text + "%'", con);
                }

                var ds = new DataSet();
                da.Fill(ds);
                DataTable table = ds.Tables[0];
                da.Dispose();
                con.Close();

                foreach (DataRow row in table.Rows)
                {
                    var items = new string[]
                    {
                        row[0].ToString(),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        row[4].ToString()

                    };
                    var value = new ListViewItem(items);
                    listView1.Items.Add(value);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
