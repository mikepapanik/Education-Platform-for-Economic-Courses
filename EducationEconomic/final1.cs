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
    public partial class final1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public final1()
        {
            InitializeComponent();
            totalQuestions = 10;
            askQuestion(questionNumber);
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=static.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        string username = Form1.username;
        string datee = DateTime.Now.ToShortDateString();
        string quizname = "Quiz Makro Final";
        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    lblQuestion.Text = "Ο οικονομικός κύκλος: ";

                    button1.Text = "δεν είναι περιοδικός";
                    button2.Text = "είναι επαναλαμβανόμενος";
                    button3.Text = "είναι επίμονος";
                    button4.Text = "Όλα τα παραπάνω";


                    correctAnswer = 4;

                    break;
                case 2:

                    lblQuestion.Text = "Όταν η επέκταση φτάσει στο μέγιστο σημείο της, την κορυφή (Ρ),\nτότε η συνολική οικονομική δραστηριότητα:";

                    button1.Text = "αρχίζει πάλι να μειώνεται";
                    button2.Text = "αρχίζει πάλι να αυξάνεται";
                    button3.Text = "παραμένει σταθερή";
                    button4.Text = "κανένα από τα παραπάνω";


                    correctAnswer = 1;

                    break;
                case 3:

                    lblQuestion.Text = "Προκυκλικές και συμπορευόμενες μεταβλητές είναι:";

                    button1.Text = "παραγωγή";
                    button2.Text = "η κατανάλωση";
                    button3.Text = "η επένδυση";
                    button4.Text = "Όλα τα παραπάνω";

                    correctAnswer = 4;

                    break;
                case 4:


                    lblQuestion.Text = "Κατεύθυνση , Με βάση αυτό το χαρακτηριστικό, διακρίνουμε :";

                    button1.Text = "Προκυκλική";
                    button2.Text = "Αντικυκλική";
                    button3.Text = "Ακυκλική";
                    button4.Text = "Όλα τα παραπάνω";


                    correctAnswer = 4;

                    break;

                case 5:
                    lblQuestion.Text = "Η Καμπύλη συναθροιστικής προσφοράς δείχνει την ποσότητα που είναι \nδιατεθειμένοι να προσφέρουν οι παραγωγοί σε κάθε επίπεδο τιμών (Ρ) \nκαι διακρίνεται σε:";

                    button1.Text = "Βραχυχρόνια";
                    button2.Text = "Μακροχρόνια";
                    button3.Text = "Όλα τα παραπάνω";
                    button4.Text = "Κανένα";

                    correctAnswer = 3;

                    break;

                case 6:
                    lblQuestion.Text = "Οι βασικές θεωρίες των οικονομικών κύκλων είναι:";

                    button1.Text = "η κλασική";
                    button2.Text = "η κεϋνσιανή ";
                    button3.Text = "συναθροιστική";
                    button4.Text = "κλασική και η κεϋνσιανή";

                    correctAnswer = 4;

                    break;

                case 7:
                    lblQuestion.Text = "Μια δυσμενής διαταραχή της συναθροιστικής ζήτησης θα μετατοπίσει \nτην καμπύλη AD προς :";

                    button1.Text = "αριστερά";
                    button2.Text = "δεξιά";
                    button3.Text = "κάτω";
                    button4.Text = "πάνω";

                    correctAnswer = 1;

                    break;

                case 8:
                    lblQuestion.Text = "Η οικονομία χρειάζεται πολύ χρόνο για να φθάσει:";

                    button1.Text = "βραχυχρόνια ισορροπία";
                    button2.Text = "μακροχρόνια ισορροπία";
                    button3.Text = "Όλα";
                    button4.Text = "Κανένα";

                    correctAnswer = 2;

                    break;
                case 9:
                    lblQuestion.Text = "Διακρίνουμε τη δαπάνη σε: Πραγματική δαπάνη (Υ) είναι το ποσό που ______ \nδαπανούν σε αγαθά και υπηρεσίες, και το οποίο είναι ίσο με το Α.Ε.Π. \nτης οικονομίας";

                    button1.Text = "τα νοικοκυριά";
                    button2.Text = "οι επιχειρήσεις";
                    button3.Text = "το κράτος";
                    button4.Text = "Όλα τα παραπάνω";

                    correctAnswer = 4;

                    break;
                case 10:
                    lblQuestion.Text = "Η καμπύλη IS απεικονίζει τη σχέση μεταξύ:";

                    button1.Text = "επιτοκίου";
                    button2.Text = "προϊόντος";
                    button3.Text = "κέρδους";
                    button4.Text = "επιτοκίου και προϊόντος";

                    correctAnswer = 4;

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

        private void final1_FormClosing(object sender, FormClosingEventArgs e)
        {
            quizform1 qee = new quizform1();
            qee.Show();
            this.Hide();
        }
    }
}
