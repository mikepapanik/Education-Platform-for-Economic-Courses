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
    public partial class final2 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public final2()
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
        string quizname = "Quiz Mikro Final";
        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    lblQuestion.Text = "Αντικείμενο της Μικροοικονομικής ανάλυσης είναι η διαδικασία λήψεως \nαποφάσεων των οικονομικών μονάδων:";

                    button1.Text = "μόνο καταναλωτών";
                    button2.Text = "καταναλωτών και επιχειρήσεων";
                    button3.Text = "μόνο επιχειρήσεων";
                    button4.Text = "κανένα από τα παραπάνω";


                    correctAnswer = 2;

                    break;
                case 2:

                    lblQuestion.Text = "Σύμφωνα με το Νόμο της Ζήτησης, όταν __________ η τιμή \nενός αγαθού, _________ η ζητούμενη ποσότητά του και το αντίστροφο με τους \nπροσδιοριστικούς παράγοντες της ζήτησης σταθερούς (ceteris paribus).";

                    button1.Text = "αυξάνεται,μειώνεται";
                    button2.Text = "αυξάνεται,αυξάνεται";
                    button3.Text = "μειώνεται,μειώνεται";
                    button4.Text = "μειώνεται,αυξάνεται";


                    correctAnswer = 4;

                    break;
                case 3:

                    lblQuestion.Text = "Ελαστική όταν ____, όταν, δηλαδή, η ποσοστιαία μεταβολή της \nπροσφερόμενης ποσότητας είναι μεγαλύτερη από την ποσοστιαία \nμεταβολή της τιμής.";

                    button1.Text = "Es>1";
                    button2.Text = "Es<1";
                    button3.Text = "Es=1";
                    button4.Text = "Es=0";

                    correctAnswer = 1;

                    break;
                case 4:


                    lblQuestion.Text = "Πλήρως Ανελαστική όταν ____, όταν, δηλαδή, η προσφερόμενη \nποσότητα δεν μεταβάλλεται καθόλου σε μια μεταβολή \nτης τιμής.";

                    button1.Text = "Es=1";
                    button2.Text = "Es=0";
                    button3.Text = "Es=2";
                    button4.Text = "Es<1";


                    correctAnswer = 2;

                    break;

                case 5:
                    lblQuestion.Text = "Τα δημόσια αγαθά έχουν δυο σημαντικές ιδιότητες:_______παραγωγής, \nαν ένα επιπλέον άτομο καταναλώσει το αγαθό και  είναι αδύνατον να \nαποκλειστεί κάποιο άτομο από την κατανάλωση του αγαθού.";

                    button1.Text = "δεν αυξάνεται το κόστος";
                    button2.Text = "αυξάνεται μελλοντικά το κόστος";
                    button3.Text = "αυξάνεται το κόστος";
                    button4.Text = "μειώνεται";

                    correctAnswer = 1;

                    break;

                case 6:
                    lblQuestion.Text = "_________ορίζεται ο λόγος του σταθερού κόστους προς \nτην ποσότητα προϊόντος . ";

                    button1.Text = "Μέσο σταθερό κόστος";
                    button2.Text = "Μέσο μεταβλητό κόστος";
                    button3.Text = "Μέσο Κόστος";
                    button4.Text = "Συνολικό κόστος";

                    correctAnswer = 1;

                    break;

                case 7:
                    lblQuestion.Text = "Αν το _______ της τελευταίας μονάδας που θα παράγει η \nεπιχείρηση είναι μεγαλύτερο από το οριακό έσοδο που θα εισπράξει από την \nπώλησή της, τότε θα μειώσει την παραγωγή της.";

                    button1.Text = "Οριακό κόστος";
                    button2.Text = "Μέσο κόστος";
                    button3.Text = "σταθερό κόστος";
                    button4.Text = "Συνολικό κόστος";

                    correctAnswer = 1;

                    break;

                case 8:
                    lblQuestion.Text = "Ορθολογικός Καταναλωτής ορίζεται αυτός, ο οποίος με δεδομένο το \nεισόδημά του και τις τιμές των αγαθών, θα επιλέξει εκείνους τους \nσυνδυασμούς αγαθών που __________τη χρησιμότητά του.";

                    button1.Text = "Σταθεροποιούν ";
                    button2.Text = "Μειώνουν";
                    button3.Text = "Ελαχιστοποιούν";
                    button4.Text = "Μεγιστοποιούν";

                    correctAnswer = 4;

                    break;
                case 9:
                    lblQuestion.Text = "Το εισόδημα των καταναλωτών: Όταν το αγαθό είναι ______ \nμια αύξηση του εισοδήματος μετατοπίζει την καμπύλη ζήτησης \nπρος τα έξω και δεξιά.";

                    button1.Text = "Υπηρεσία";
                    button2.Text = "Κατώτερο";
                    button3.Text = "Κανονικό";
                    button4.Text = "Προιόν";

                    correctAnswer = 3;

                    break;
                case 10:
                    lblQuestion.Text = "Η μορφή αγοράς εντός της οποίας λειτουργεί μια επιχείρηση \nθα καθορίσει τις αποφάσεις της σχετικά με την ποσότητα και την τιμή του \nπροϊόντος που θα προσφέρει. Οι μορφές αγοράς είναι:";

                    button1.Text = "Όλα τα παρακάτω";
                    button2.Text = "Ο Μονοπωλιακός Ανταγωνισμός";
                    button3.Text = "Μονοπώλιο και Ολιγοπώλιο";
                    button4.Text = "Ο τέλειος Ανταγωνισμός";

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

        private void final2_FormClosing(object sender, FormClosingEventArgs e)
        {
            aodquiz qeee = new aodquiz();
            qeee.Show();
            this.Hide();
        }
    }
    
}
