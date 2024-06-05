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
    public partial class kef2 : Form
    {
        public kef2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kefff1 kdeff = new kefff1();
            kdeff.Show(this);
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

            if (comboBox1.SelectedItem == "2.1 Εισαγωγή")
            {

                richTextBox1.Text = "Μολονότι όλοι οι οικονομικοί κύκλοι δεν είναι ταυτόσημοι, έχουν κάποια κοινά χαρακτηριστικά. Αυτή η άποψη στηρίζεται στην εξέταση των συγχρονισμένων κινήσεων των οικονομικών μεταβλητών σ’ έναν οικονομικό κύκλο. – Παρατηρείται μια τάση πολλών οικονομικών μεταβλητών να μετακινούνται μαζί μ’ έναν ομαλό και προβλεπόμενο τρόπο στη διάρκεια του οικονομικού κύκλου.";

            }

            else if (comboBox1.SelectedItem == "2.2 Κυκλικά Πρότυπα")
            {

                richTextBox1.Text = "Τα συνηθισμένα κυκλικά πρότυπα των βασικών μακροοικονομικών μεταβλητών ονομάζονται γνωρίσματα των οικονομικών κύκλων. Τα χαρακτηριστικά της κυκλικής συμπεριφοράς των μακροοικονομικών μεταβλητών, που έχουν σημασία στην ανάλυση των γνωρισμάτων των οικονομικών κύκλων, είναι: 1. η κατεύθυνση, 2. ο χρονισμός.\n\nΧαρακτηριστικό 1- Κατεύθυνση Με βάση αυτό το χαρακτηριστικό, διακρίνουμε 3 είδη μεταβλητών: i. Προκυκλική ii. Αντικυκλική iii. Ακυκλική\n\nΠροκυκλική μεταβλητή είναι εκείνη που κινείται προς την ίδια κατεύθυνση με τη συνολική οικονομική δραστηριότητα. Αυξάνεται στις ανθήσεις, και μειώνεται στις κάμψεις. Αντικυκλική μεταβλητή είναι εκείνη που κινείται προς την αντίθετη κατεύθυνση με τη συνολική οικονομική δραστηριότητα. Αυξάνεται στις κάμψεις, και μειώνεται στις ανθήσεις. Ακυκλική μεταβλητή είναι εκείνη που δεν έχει συγκεκριμένο κυκλικό πρότυπο συμπεριφοράς.\n\nΧαρακτηριστικό 2- Χρονισμός Με βάση αυτό το χαρακτηριστικό, διακρίνουμε 3 είδη μεταβλητών: i. Συμπορευόμενη ii. Προπορευόμενη iii. Υστερόχρονη\n\nΣυμπορευόμενη μεταβλητή είναι εκείνη όπου ο χρονισμός των κινήσεων της συμπίπτει χρονικά με εκείνον της συνολικής οικονομικής δραστηριότητας. Οι κορυφές και οι πυθμένες της μεταβλητής και της συνολικής οικονομικής δραστηριότητας σημειώνονται τον ίδιο περίπου χρόνο.\n\nΠροπορευόμενη μεταβλητή είναι εκείνη όπου ο χρονισμός των κινήσεων της προηγείται χρονικά του χρονισμού των κινήσεων της συνολικής οικονομικής δραστηριότητας. Οι κορυφές και οι πυθμένες της μεταβλητής προηγούνται των κορυφών και των πυθμένων της συνολικής οικονομικής δραστηριότητας.\n\nΥστερόχρονη μεταβλητή είναι εκείνη όπου ο χρονισμός των κινήσεων της ακολουθεί χρονικά το χρονισμό των κινήσεων της συνολικής οικονομικής δραστηριότητας. Οι κορυφές και οι πυθμένες της μεταβλητής έπονται των κορυφών και των πυθμένων της συνολικής οικονομικής δραστηριότητας.";


            }
            else if (comboBox1.SelectedItem == "2.3 Σύνοψη")
            {

                richTextBox1.Text = "Συνοπτικά, έχει παρατηρηθεί: 1. Η παραγωγή, η κατανάλωση και η επένδυση είναι προκυκλικές και συμπορευόμενες μεταβλητές. 2. Η απασχόληση είναι προκυκλική μεταβλητή, ενώ το ποσοστό ανεργίας είναι αντικυκλική μεταβλητή. 3. Η μέση παραγωγικότητα της εργασίας και ο πραγματικός μισθός είναι προκυκλικές μεταβλητές. 4. Το χρήμα και οι τιμές των μετοχών είναι προκυκλικές μεταβλητές και προπορεύονται του κύκλου. 5. Ο πληθωρισμός και τα ονομαστικά επιτόκια είναι προκυκλικές και υστερόχρονες μεταβλητές. 6. Το πραγματικό επιτόκιο είναι ακυκλική μεταβλητή.";

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kef3 kf = new kef3();
            kf.Show(this);
            this.Hide();
        }

        private void kef2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Διαλέξτε Ενότητα";
        }

        private void kef2_FormClosing(object sender, FormClosingEventArgs e)
        {
            aoth foee = new aoth();
            foee.Show();
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
