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
    public partial class aodquiz1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public aodquiz1()
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
        string quizname = "Quiz Mikro 1";
        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    lblQuestion.Text = "Ορθολογικός Καταναλωτής με δεδομένο το εισόδημά του και τις \nτιμές των αγαθών, θα επιλέξει τους συνδυασμούς αγαθών \nπου μεγιστοποιούν τη χρησιμότητά του";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 1;

                    break;
                case 2:

                    lblQuestion.Text = "Αν |Ed|=0, τότε την ονομάζουμε πλήρως ελαστική.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 2;

                    break;
                case 3:

                    lblQuestion.Text = "Αν |Ed|>1 τότε την ονομάζουμε ελαστική και η ποσοστιαία \nμεταβολή της ζητούμενης ποσότητας είναι μεγαλύτερη από την \nποσοστιαία μεταβολή της τιμής.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";

                    correctAnswer = 1;

                    break;
                case 4:


                    lblQuestion.Text = "Από την πλευρά των επιχειρήσεων, εξετάζεται ποια ποσότητα \nπροϊόντος θα προσφέρουν για κάθε τιμή και πώς προκύπτει \nη καμπύλη προσφοράς.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 1;

                    break;

                case 5:
                    lblQuestion.Text = "Αν |Ed|=oo, τότε την ονομάζουμε πλήρως ανελαστική.";

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

        private void aodquiz1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
