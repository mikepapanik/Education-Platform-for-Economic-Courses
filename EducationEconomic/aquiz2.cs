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
    public partial class aquiz2 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public aquiz2()
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
        string quizname = "Quiz Makro 2";
        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    lblQuestion.Text = "Τα συνηθισμένα κυκλικά πρότυπα των βασικών μακροοικονομικών \nμεταβλητών ονομάζονται γνωρίσματα των οικονομικών κύκλων.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 1;

                    break;
                case 2:

                    lblQuestion.Text = "Προκυκλική μεταβλητή είναι εκείνη που κινείται προς διαφορετική \nκατεύθυνση με τη συνολική οικονομική δραστηριότητα.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 2;

                    break;
                case 3:

                    lblQuestion.Text = "Προπορευόμενη μεταβλητή είναι εκείνη όπου ο χρονισμός των κινήσεων \nτης προηγείται χρονικά του χρονισμού των κινήσεων της \nσυνολικής οικονομικής δραστηριότητας.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";

                    correctAnswer = 1;

                    break;
                case 4:


                    lblQuestion.Text = "Υστερόχρονη μεταβλητή είναι εκείνη όπου ο χρονισμός των κινήσεων \nτης δεν ακολουθεί χρονικά το χρονισμό των κινήσεων της συνολικής \nοικονομικής δραστηριότητας.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 2;

                    break;

                case 5:
                    lblQuestion.Text = "Το χρήμα και οι τιμές των μετοχών είναι προκυκλικές \nμεταβλητές και προπορεύονται του κύκλου.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";

                    correctAnswer = 1;

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

        private void aquiz2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
