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
using System.Data.OleDb;

namespace EducationEconomic
{
    public partial class aodquiz5 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public aodquiz5()
        {
            InitializeComponent();
            totalQuestions = 5;
            askQuestion(questionNumber);
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=static.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        string username = Form1.username;
        string datee = DateTime.Now.ToShortDateString();
        string quizname = "Quiz Mikro 5";
        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    lblQuestion.Text = "Σταθερό κόστος (FC) όπου οι ποσότητες των συντελεστών \nείναι σταθερές ανεξάρτητα από τον όγκο παραγωγής της εταιρίας.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 1;

                    break;
                case 2:

                    lblQuestion.Text = "Συνολικό κόστος (TC)  είναι το κόστος που μεταβάλλεται \nκαθώς μεταβάλλεται ο όγκος παραγωγής.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 2;

                    break;
                case 3:

                    lblQuestion.Text = "Μεταβλητό κόστος (VC) είναι το κόστος που μεταβάλλεται \nκαθώς μεταβάλλεται ο όγκος παραγωγής.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";

                    correctAnswer = 1;

                    break;
                case 4:


                    lblQuestion.Text = "Μέσο κόστος (AC) είναι το άθροισμα του μέσου \nσταθερού και του μέσου μεταβλητού κόστους.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 1;

                    break;

                case 5:
                    lblQuestion.Text = "Μέσο μεταβλητό κόστος (AVC) ορίζεται ο λόγος του σταθερού \nκόστους προς την ποσότητα προϊόντος.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";

                    correctAnswer = 2;

                    break;
            }
        }
        private void ClickAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }
            else
            {
                MessageBox.Show("Η Απάντηση που δώσατε είναι Λανθασμένη!!");
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );
                con.Open();

                string userstatic = "INSERT INTO staticc VALUES ('" + username + "','" + score + "','" + percentage + "','" + quizname + "','" + datee + "')";


                cmd = new OleDbCommand(userstatic, con);

                cmd.ExecuteNonQuery();
                con.Close();

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void aodquiz5_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
