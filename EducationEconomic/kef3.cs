﻿using System;
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
    public partial class kef3 : Form
    {
        public kef3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kef4 kf4 = new kef4();
            kf4.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kef2 kf1 = new kef2();
            kf1.Show(this);
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

            if (comboBox1.SelectedItem == "3.1 Εισαγωγή")
            {

                richTextBox1.Text = "Πώς εξηγούνται οι διακυμάνσεις του οικονομικού κύκλου; Υπάρχουν 2 βασικές θεωρίες των οικονομικών κύκλων: i. η κλασική, και ii. η κεϋνσιανή. Και οι 2 θεωρίες μπορούν να μελετηθούν σε ένα ενιαίο πλαίσιο, που ονομάζεται υπόδειγμα συναθροιστικής ζήτησης συναθροιστικής προσφοράς (AD-AS). Το υπόδειγμα AD-AS έχει 2 συνιστώσες: τη καμπύλη συναθροιστικής ζήτησης (AD), τη καμπύλη συναθροιστικής προσφοράς (AS).";

            }

            else if (comboBox1.SelectedItem == "3.2 Καμπύλη Συναθροιστικής Ζήτησης")
            {

                richTextBox1.Text = "Καμπύλη συναθροιστικής ζήτησης - Αυτή δείχνει τη συνολική ποσότητα αγαθών και υπηρεσιών που ζητείται από τα νοικοκυριά, τις επιχειρήσεις και το κράτος, σε κάθε επίπεδο τιμών (Ρ). - Έχει αρνητική κλίση, καθώς η συνολική ποσότητα αγαθών και υπηρεσιών που ζητείται, μειώνεται όταν το επίπεδο των τιμών αυξάνει.\n\nΜια αύξηση της συνολικής ζήτησης σε δεδομένο επίπεδο τιμών μετατοπίζει την καμπύλη συναθροιστικής ζήτησης προς τα πάνω και δεξιά (και αντίστροφα). Καμπύλη συναθροιστικής προσφοράς - Αυτή δείχνει την ποσότητα που είναι διατεθειμένοι να προσφέρουν οι παραγωγοί σε κάθε επίπεδο τιμών (Ρ). - Διακρίνεται σε:  Βραχυχρόνια καμπύλη (SRAS),  Μακροχρόνια καμπύλη (LRAS).\n\nΗ βραχυχρόνια καμπύλη συναθροιστικής προσφοράς είναι οριζόντια, καθώς οι τιμές είναι σταθερές βραχυχρόνια. - Η μακροχρόνια καμπύλη συναθροιστικής προσφοράς είναι κάθετη στο σημείο όπου παράγεται το προϊόν πλήρους απασχόλησης .\n\nΗ βραχυχρόνια ισορροπία της οικονομίας επιτυγχάνεται στο σημείο όπου τέμνονται οι καμπύλες AD και SRAS. Η μακροχρόνια ισορροπία επιτυγχάνεται στο σημείο όπου τέμνονται οι καμπύλες AD και LRAS.\n\nΌπως παρατηρούμε, η βραχυχρόνια και η μακροχρόνια ισορροπία περνάνε από το ίδιο σημείο (Ε). – Δεδομένου ότι οι τιμές έχουν προσαρμοστεί για να επιτευχθεί η μακροχρόνια ισορροπία, η καμπύλη SRAS πρέπει επίσης να περνά από το ίδιο σημείο. Ωστόσο, αν σημειωθεί κάποια μεταβολή στην οικονομία, η βραχυχρόνια ισορροπία μπορεί να διαφέρει από τη μακροχρόνια.\n\n";


            }
            else if (comboBox1.SelectedItem == "3.3 Συμπεράσματα")
            {

                richTextBox1.Text = "Γενικά, αυτό το υπόδειγμα χρησιμοποιήθηκε για τη μελέτη της αντίδρασης της οικονομίας στις διάφορες διαταραχές που σημειώνονται σ’ αυτήν.  Διακρίνουμε 2 είδη διαταραχών: i. Διαταραχή της συναθροιστικής ζήτησης ii. Διαταραχή της συναθροιστικής προσφοράςΔιαταραχή της συναθροιστικής ζήτησης Είναι μια μεταβολή στην οικονομία, που μετατοπίζει την καμπύλη AD. – Παράδειγμα δυσμενούς διαταραχής: Οι καταναλωτές γίνονται απαισιόδοξοι για το μέλλον, με συνέπεια να μειώσουν την τρέχουσα καταναλωτική τους δαπάνη, μετατοπίζοντας την καμπύλη AD προς τα αριστερά. Διαταραχή της συναθροιστικής προσφοράς Είναι μια μεταβολή στην οικονομία (όπως μια μεταβολή στην παραγωγικότητα ή στην προσφοράς εργασίας), που προκαλεί τη μετατόπιση της καμπύλης LRAS. – Παράδειγμα δυσμενούς διαταραχής: Μια σοβαρή ξηρασία που μειώνει σημαντικά την ετήσια συγκομιδή, θα μετατοπίσει προς τα αριστερά την καμπύλη LRAS.";

            }

        }

        private void kef3_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Διαλέξτε Ενότητα";
        }

        private void kef3_FormClosing(object sender, FormClosingEventArgs e)
        {
            aoth foeee = new aoth();
            foeee.Show();
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
