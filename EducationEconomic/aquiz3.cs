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
    public partial class aquiz3 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public aquiz3()
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
        string quizname = "Quiz Makro 3";
        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    lblQuestion.Text = "Το υπόδειγμα AD-AS έχει 2 συνιστώσες: τη καμπύλη συναθροιστικής \nήτησης (AD), τη καμπύλη συναθροιστικής προσφοράς (AS).";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 1;

                    break;
                case 2:

                    lblQuestion.Text = "Η βραχυχρόνια και η μακροχρόνια ισορροπία  δεν περνάνε από το \nίδιο σημείο (Ε).";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 2;

                    break;
                case 3:

                    lblQuestion.Text = "Η βραχυχρόνια ισορροπία της οικονομίας επιτυγχάνεται στο \nσημείο όπου τέμνονται οι καμπύλες AD και SRAS.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";

                    correctAnswer = 1;

                    break;
                case 4:


                    lblQuestion.Text = "Η μακροχρόνια ισορροπία δεν επιτυγχάνεται στο σημείο \nόπου τέμνονται οι καμπύλες AD και LRAS.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 2;

                    break;

                case 5:
                    lblQuestion.Text = "Αν σημειωθεί κάποια μεταβολή στην οικονομία, η βραχυχρόνια \nισορροπία μπορεί να διαφέρει από τη μακροχρόνια.";

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

        private void aquiz3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
