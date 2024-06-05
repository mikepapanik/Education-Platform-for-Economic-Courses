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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Userap.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Some fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBox3.Text == textBox6.Text)
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Userap.accdb"))
                {


                    con.Open();
                    bool exists = false;
                    {
                        using (OleDbCommand cmd = new OleDbCommand("select count(*) from [Userapp] where Username = @Userame", con))
                        {
                            cmd.Parameters.AddWithValue("Username", textBox1.Text);
                            exists = (int)cmd.ExecuteScalar() > 0;
                        }
                        if (exists)
                            MessageBox.Show("This Username is Already Exist", "Registrationed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {


                            string register = "INSERT INTO Userapp VALUES ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox4.Text + "')";


                            cmd = new OleDbCommand(register, con);

                            cmd.ExecuteNonQuery();
                            con.Close();

                            textBox1.Text = "";
                            textBox3.Text = "";
                            textBox2.Text = "";
                            textBox5.Text = "";
                            textBox4.Text = "";
                            textBox6.Text = "";
                            MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "";
                textBox6.Text = "";
                textBox3.Focus();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 foe = new Form1();
            foe.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε το κουμπί Register για να ολοκληρώσετε την εγγραφή σας, αφού πρώτα όμως έχετε συμπληρώσει όλα τα παραπάνω πεδία ", button1);

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε το κουμπί Cancel για ακύρωση", button2);
        }
    }
}
