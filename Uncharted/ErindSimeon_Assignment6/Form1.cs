/*
 * Course: CSCI-473   Assignment :6    Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 04/15/2021
 * 
 * Description:
 * This file contains the code for the main window that implements the form.
 * this window will display 5 buttons where 4 of them will open other forms and display
 * what is on other forms and a button to close the application
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErindSimeon_Assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }
        /*
         * linearGraphButton(object sender, EventArgs e)
         * this method will open new Form2 and it will hide the existing form when form2 will be displayed
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void linearGraphButton(object sender, EventArgs e)
        {
     
            Form2 form2 = new Form2(); //generate a new form
            form2.FormClosed += new System.Windows.Forms.FormClosedEventHandler((s,args)=>this.Show()); //atyach event handler
            this.Hide(); //hide this form
            form2.Show(); //show form 2
        }
        /*
         * CloseApplication(object sender, EventArgs e)
         * this method will open close the application when exit button is clicked
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit(); //close hte application
        }
        /*
         * secondGraph(object sender, EventArgs e)
         * this method hides this form and opens form3
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void secondGraph(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); //generate a new form
            form3.FormClosed += new System.Windows.Forms.FormClosedEventHandler((s, args) => this.Show()); //atach event handler
            this.Hide(); //hide this form
            form3.Show(); //show form 3
        }
        /*
         * thirdGraph(object sender, EventArgs e)
         * this method hides this form and opens form4
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void thirdGraph(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();//generate a new form
            form4.FormClosed += new System.Windows.Forms.FormClosedEventHandler((s, args) => this.Show()); // atach event handler
            this.Hide(); //hide this form
            form4.Show(); //show form4
        }
        /*
         * fourthGraph(object sender, EventArgs e)
         * this method hides this form and opens form5
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void fourthGraph(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); //generate a new form
            form5.FormClosed += new System.Windows.Forms.FormClosedEventHandler((s, args) => this.Show()); //atach event handler
            this.Hide(); //hide this form
            form5.Show(); //show form 5
        }
    }
}
