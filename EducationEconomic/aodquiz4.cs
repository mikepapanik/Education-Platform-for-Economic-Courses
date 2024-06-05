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
    public partial class aodquiz4 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public aodquiz4()
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
        string quizname = "Quiz Mikro 4";
        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    lblQuestion.Text = "Όταν όλες οι αγορές μιας οικονομίας είναι ανταγωνιστικές, ενδέχεται να \nδιαμορφωθεί μια κατανομή των πόρων που είναι γνωστή ως κατά Pareto \nαποτελεσματική κατανομή.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 1;

                    break;
                case 2:

                    lblQuestion.Text = "Εξωτερικές οικονομίες δεν δημιουργούνται, όταν η συμπεριφορά \nενός ατόμου ή μιας επιχείρησης προκαλεί κέρδος ή ζημιά σε \nκάποιον τρίτο.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 2;

                    break;
                case 3:

                    lblQuestion.Text = "Μια κατανομή των πόρων δεν είναι αποτελεσματική, όταν δεν υπάρχει \nάλλη κατανομή των πόρων που θα βελτίωνε τη θέση ενός ατόμου, χωρίς να \nεπιδεινώσει τη θέση κάποιου άλλου. ";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";

                    correctAnswer = 2;

                    break;
                case 4:


                    lblQuestion.Text = "Μια αποτελεσματική κατανομή των πόρων  είναι (πάντα) και μια \nδίκαιη κατανομή.";

                    button1.Text = "ΣΩΣΤΟ";
                    button2.Text = "ΛΑΘΟΣ";


                    correctAnswer = 2;

                    break;

                case 5:
                    lblQuestion.Text = "Τα δημόσια αγαθά έχουν δυο σημαντικές ιδιότητες, δεν αυξάνεται \nτο κόστος παραγωγής, αν ένα επιπλέον άτομο καταναλώσει το αγαθό και \nείναι αδύνατον να αποκλειστεί κάποιο άτομο από την κατανάλωση του αγαθού.";

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

        private void aodquiz4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
