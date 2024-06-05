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
    public partial class kef4 : Form
    {
        public kef4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kef3 kfdd = new kef3();
            kfdd.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kef5 kfff = new kef5();
            kfff.Show(this);
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

            if (comboBox1.SelectedItem == "4.1 Εισαγωγή")
            {

                richTextBox1.Text = "Ας υποθέσουμε ότι, αρχικά, η οικονομία βρίσκεται σε ισορροπία (τόσο βραχυχρόνια, όσο και μακροχρόνια) στο σημείο Ε. Μια δυσμενής διαταραχή της συναθροιστικής ζήτησης θα μετατοπίσει την καμπύλη AD προς τα αριστερά. Τώρα, η νέα βραχυχρόνια ισορροπία είναι στο σημείο F. – Το προϊόν έχει μειωθεί, ενώ το επίπεδο τιμών έχει παραμείνει σταθερό.\n\nΩστόσο, η οικονομία δεν θα μείνει στο σημείο F για πάντα. Οι επιχειρήσεις θα αντιδράσουν στη χαμηλότερη ζήτηση προσαρμόζοντας τις τιμές τους προς τα κάτω, μέχρι η οικονομία να φθάσει στο σημείο Η.\n\nΗ νέα μακροχρόνια ισορροπία είναι το σημείο Η. – Το προϊόν βρίσκεται στο αρχικό του επίπεδο, αλλά το επίπεδο τιμών έχει μειωθεί.";

            }

            else if (comboBox1.SelectedItem == "4.2 Χρονικό Διάστημα που Απαιτείται για να Φτάσουμε στη Μακροχρόνια Ισορροπία;")
            {

                richTextBox1.Text = "Ποιο χρονικό διάστημα απαιτείται για να φτάσουμε στη μακροχρόνια ισορροπία; Κλασική θεωρία: η οικονομία μετακινείται σχεδόν άμεσα στο σημείο Η, με συνέπεια η δυσμενής διαταραχή της AD να μην έχει ουσιαστικά καμία επίπτωση στο προϊόν • Οι τιμές προσαρμόζονται αρκετά γρήγορα. • Οι κάμψεις είναι μικρής διάρκειας. • Δεν υπάρχει ανάγκη κρατικής παρέμβασης.\n\n";


            }
            else if (comboBox1.SelectedItem == "4.3 Κεϋνσιανή θεωρία")
            {

                richTextBox1.Text = "Κεϋνσιανή θεωρία: η διαδικασία προσαρμογής διαρκεί περισσότερο, και έτσι η δυσμενής διαταραχή της AD μπορεί να οδηγήσει σε μείωση του προϊόντος. • Οι τιμές προσαρμόζονται αργά. • Η προσαρμογή μπορεί να χρειαστεί μερικά χρόνια. • Η κυβέρνηση μπορεί να αντιμετωπίσει τις κάμψεις αυξάνοντας τις δαπάνες της, και μετατοπίζοντας την καμπύλη AD προς τα δεξιά. • Υποθέστε ότι η οικονομία, αρχικά, βρίσκεται σε μακροχρόνια ισορροπία στο σημείο E. • Θεωρήστε τώρα ότι σημειώνεται η δυσμενής διαταραχή της προσφοράς, μειώνοντας το προϊόν της πλήρους απασχόλησης, και μετατοπίζοντας την καμπύλη LRAS αριστερά. • Η νέα μακροχρόνια ισορροπία σημειώνεται στο σημείο F. – To επίπεδο προϊόντος είναι χαμηλότερο από το αρχικό, ενώ το επίπεδο των τιμών είναι υψηλότερο. – H κάμψη συνοδεύεται από αύξηση των τιμών. • Κλασική θεωρία: Η οικονομία μετακινείται γρήγορα από το σημείο Ε στο F και παραμένει στο F.  Θεωρούν τις διαταραχές της συναθροιστικής προσφοράς ως την κύρια αιτία των διακυμάνσεων του προϊόντος. • Κεϋνσιανή θεωρία: Η οικονομία χρειάζεται πολύ χρόνο για να φθάσει στη μακροχρόνια ισορροπία.  Ωστόσο, συμφωνούν με τους κλασικούς, ότι μακροχρόνια η δυσμενής διαταραχή της προσφοράς θα μειώσει το προϊόν και θα αυξήσει το επίπεδο των τιμών.";

            }
      
        }

        private void kef4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Διαλέξτε Ενότητα";
        }

        private void kef4_FormClosing(object sender, FormClosingEventArgs e)
        {
            aoth feoe = new aoth();
            feoe.Show();
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
