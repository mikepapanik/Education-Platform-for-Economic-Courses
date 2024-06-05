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
    public partial class akef5 : Form
    {
        public akef5()
        {
            InitializeComponent();
        }

        private void akef5_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Διαλέξτε Ενότητα";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            akef4 akef4444 = new akef4();
            akef4444.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aode aoddd = new aode();
            aoddd.Show(this);
            this.Hide();
            MessageBox.Show("ΤΕΛΟΣ ΕΚΜΑΘΗΣΗΣ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

            if (comboBox1.SelectedItem == "5.1 Θεωρία Κόστους")
            {

                richTextBox1.Text = "Κόστος για τις επιχειρήσεις είναι οι δαπάνες που πραγματοποιούνται για την παραγωγή και τη διάθεση του προϊόντος τους. Όπως και στην θεωρία παραγωγής μεγάλης σημασίας είναι ο παράγοντας χρόνος (βραχυχρόνιος/μακροχρόνιος) που η επιχείρηση καλείται να πάρει αποφάσεις αναφορικά με τους συντελεστές παραγωγής.\n\nΈχουμε μελετήσει ότι η συνάρτηση ίσου κόστους είναι της μορφής: C = r K + w L\n\nΆρα στην βραχυχρόνια περίοδο το συνολικό κόστος (C) είναι το άθροισμα του σταθερού κόστους ( rK) και του μεταβλητού κόστους ( wL). Στην μακροχρόνια περίοδο όμως, όπου η επιχείρηση έχει μεγάλο διάστημα στην διάθεση της για να μεταβάλλει του συντελεστές παραγωγής της, η συνάρτηση ίσου κόστους εξειδικεύεται ως: C = rK + wL , δηλαδή όλοι οι συντελεστές μπορούν να μεταβληθούν.\n\nΑκόμα οι καμπύλες παραγωγής και κόστους σχετίζονται αντίστροφα. Όταν οι καμπύλες μέσου προϊόντος και οριακού προϊόντος ανέρχονται οι καμπύλες μέσου κόστους και οριακού κόστους κατέρχονται. Στο επίπεδο προϊόντος, όπου οι καμπύλες μέσου προϊόντος και οριακού προϊόντος λαμβάνουν τη μέγιστη τιμή τους οι καμπύλες μέσου κόστους και οριακού κόστους λαμβάνουν την κατώτατη τιμή.";

            }

            else if (comboBox1.SelectedItem == "5.2 Η Συνάρτηση του Μακροχρόνιου Κόστους Παραγωγής")
            {

                richTextBox1.Text = "Το κύριο χαρακτηριστικό της μακροχρόνιας περιόδου είναι ότι όλες οι εισροές που λαμβάνουν μέρος στην παραγωγική διαδικασία είναι μεταβλητές. Επομένως, η καμπύλη του συνολικού κόστους στην μακροχρόνια περίοδο ξεκινά από την αρχή των αξόνων. Η μακροχρόνια καμπύλη μέσου κόστους (LAC) ή καμπύλη προγραμματισμού είναι η καμπύλη που περιλαμβάνει τα τμήματα των βραχυχρόνιων καμπυλών μέσου κόστους (SAC) που δείχνουν το χαμηλότερο δυνατό κόστος για κάθε επίπεδο παραγωγής. Τόσο η μακροχρόνια καμπύλη μέσου κόστους (LAC) όσο και η μακροχρόνια καμπύλη οριακού κόστους (LMC) έχουν προκύψει από την ένωση σημείων βραχυχρόνιων καμπυλών μέσου κόστους (SAC) και βραχυχρόνιων καμπυλών οριακού κόστους (SMC), αντίστοιχα.";


            }
            else if (comboBox1.SelectedItem == "5.3 Κόστος Παραγωγής στη Βραχυχρόνια Περίοδο")
            {

                richTextBox1.Text = "Τρεις έννοιες του συνολικού κόστους είναι σημαντικές για την ανάλυση της δομής του κόστους μιας εταιρίας βραχυχρονίως:\n\n1) Σταθερό κόστος (fixed cost, FC) όπου οι ποσότητες των συντελεστών είναι σταθερές ανεξάρτητα από τον όγκο παραγωγής της εταιρίας (π.χ. ενοίκια, ασφάλιστρα κτλ).\n\n2) Μεταβλητό κόστος (variable cost, VC) είναι το κόστος που μεταβάλλεται καθώς μεταβάλλεται ο όγκος παραγωγής (π.χ. κόστος υλικών, ημερομίσθια κτλ).\n\n3) Συνολικό κόστος (total cost, TC) παραγωγής ενός προϊόντος αποτελείται από το άθροισμα του σταθερού και μεταβλητού κόστους δηλαδή TC = FC + VC.";

            }
            else if (comboBox1.SelectedItem == "5.4 Έννοιες του Κόστους κατά Μονάδα Προϊόντος")
            {

                richTextBox1.Text = "Υπάρχουν 4 βασικές έννοιες κόστους κατά μονάδα προϊόντος:\n\n1) Μέσο σταθερό κόστος (average fixed cost, AFC) ορίζεται ο λόγος του σταθερού κόστους προς την ποσότητα προϊόντος.\n\n 2) Μέσο μεταβλητό κόστος (average variable cost, AVC) ορίζεται ο λόγος του μεταβλητού κόστους προς την ποσότητα προϊόντος.\n\n3) Μέσο κόστος (average cost, AC) είναι το άθροισμα του μέσου σταθερού και του μέσου μεταβλητού κόστους.\n\n4) Οριακό κόστος (marginal cost, MC) είναι το κόστος μιας επιπλέον μονάδας προϊόντος και είναι ο λόγος της μεταβολής του συνολικού κόστους με τη μεταβολή της ποσότητας του προϊόντος.";

            }
            else if (comboBox1.SelectedItem == "5.5 Λόγοι Eμφάνισης Oικονομιών Kλίμακας")
            {

                richTextBox1.Text = "1. Μεγαλύτερη εξειδίκευση των παραγωγικών μέσων, καλύτερο καταμερισμό των έργων και μεγαλύτερη αξιοποίηση του υπάρχοντος κεφαλαιουχικού εξοπλισμού.\n\n2. Δυνατότητα χρησιμοποίησης περισσότερου και τελειότερου κεφαλαιουχικού εξοπλισμού.\n\n3. Μειωμένο κόστος αγοράς ορισμένων μέσων παραγωγής.\n\n4. Οργάνωση της βιομηχανικής παραγωγής.\n\n5. Εκτέλεση μέσα στην επιχείρηση ορισμένων εξειδικευμένων εργασιών.\n\n6. Οικονομίες στο κόστος μεταφοράς.\n\n7. Αυξημένη δυνατότητα αξιοποίησης υποπροϊόντων της παραγωγικής διαδικασίας.\n\n8. Γραφειοκρατικά προβλήματα λόγω μεγέθους.\n\n9. Προβλήματα στην παραγωγική διαδικασία λόγω μεγέθους.\n\n10. Προβλήματα και δυσκολίες στη διακίνηση μεγάλων ποσοτήτων πρώτων υλών και τελικού προϊόντος.";

            }
        }

        private void akef5_FormClosing(object sender, FormClosingEventArgs e)
        {
            aode ae = new aode();
            ae.Show();
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
