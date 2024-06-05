using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationEconomic
{
    public partial class kefff1 : Form
    {
        public kefff1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

            if (comboBox1.SelectedItem == "1.1 Εισαγωγή")
            {

                richTextBox1.Text = "Μετά τη Βιομηχανική Επανάσταση, οι οικονομίες πολλών χωρών γνώρισαν μια εντυπωσιακή μεγέθυνση.  Ωστόσο, αυτή η οικονομική άνθηση διακόπηκε περιοδικά από διαστήματα, όπου η παραγωγή και το εισόδημα μειώνονται και η ανεργία αυξάνει.  Βέβαια, μετά την περίοδο της φθίνουσας οικονομικής δραστηριότητας σχεδόν πάντοτε η οικονομική μεγέθυνση ξανάρχιζε.";

            }

            else if (comboBox1.SelectedItem == "1.2 Τι Είναι ο Οικονομικός Κύκλος")
            {

                richTextBox1.Text = "Αυτή η ακολουθία της οικονομικής επέκτασης, της πρόσκαιρης κάμψης και στη συνέχεια της ανάκαμψης είναι γνωστή ως οικονομικός κύκλος. Η διακεκομμένη γραμμή δείχνει τη μέση κανονική πορεία μεγέθυνσης της συνολικής οικονομικής δραστηριότητας.  H συνεχής γραμμή δείχνει τις αυξήσεις και τις μειώσεις της υπάρχουσας οικονομικής δραστηριότητας.";


            }
            else if (comboBox1.SelectedItem == "1.3 Η Χρονική Περίοδος")
            {

                richTextBox1.Text = "Η χρονική περίοδος, κατά την οποία η συνολική οικονομική δραστηριότητα μειώνεται, ονομάζεται κάμψη ή κρίση. – Αν η κάμψη είναι ιδιαίτερα σοβαρή, ονομάζεται ύφεση. – Όταν η κάμψη φτάσει στο κατώτατο σημείο της, τον πυθμένα (Τ), η συνολική οικονομική δραστηριότητα αρχίζει ν’ αυξάνει. Η χρονική περίοδος, κατά την οποία η συνολική οικονομική δραστηριότητα αυξάνει, ονομάζεται επέκταση ή άνθηση. – Όταν η επέκταση φτάσει στο μέγιστο σημείο της, την κορυφή (Ρ), τότε η συνολική οικονομική δραστηριότητα αρχίζει πάλι να μειώνεται.";

            }
            else if (comboBox1.SelectedItem == "1.4 Ο Οικονομικός Κύκλος")
            {

                richTextBox1.Text = "Η όλη ακολουθία της συρρίκνωσης που ακολουθείται από άνθηση, μετρούμενη από κορυφή σε κορυφή, ή από πυθμένα σε πυθμένα, είναι ένας οικονομικός κύκλος. Οι κορυφές και οι πυθμένες ονομάζονται σημεία καμπής.\n\nΓενικά, ο οικονομικός κύκλος: 1.δεν είναι περιοδικός – Δεν παρατηρείται σε τακτά, προβλέψιμα διαστήματα, και δεν διαρκεί ένα δεδομένο χρονικό διάστημα. 2.είναι επαναλαμβανόμενος – Το τυπικό πρότυπο κάμψη-πυθμένας - επέκτασηκορυφή επαναλαμβάνεται συνεχώς στις βιομηχανικές χώρες. 3.είναι επίμονος – Συνήθως, από τη στιγμή που θα αρχίσει μια κάμψη ή μια επέκταση, θα διαρκέσει αρκετό χρονικό διάστημα(1 έτος ή περισσότερο).";

            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aoth keff = new aoth();
            keff.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kef2 kdef = new kef2();
            kdef.Show(this);
            this.Hide();
        }

        private void kefff1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Διαλέξτε Ενότητα";
        }

        private void kefff1_FormClosing(object sender, FormClosingEventArgs e)
        {
            aoth froe = new aoth();
            froe.Show();
            this.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Έπόμενο Κεφάλαιο ", button2);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Προηγούμενο Κεφάλαιο ", button1);
        }
    }
}
