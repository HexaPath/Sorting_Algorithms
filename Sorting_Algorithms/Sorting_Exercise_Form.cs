using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Algorithms
{
    public partial class Sorting_Exercise_Form : Form
    {
        Tab tab = new Tab();    // Declaring object tab

        public Sorting_Exercise_Form()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e) // When selected, add a number from textbox to an integer "Number",...  
        {
            int Number = 0; // Declaration of Number
            if(TextBox.Text == "" || TextBox.Text == null ) // Making sure, textbox is not empty
            {
                MessageBox.Show("Please, Input a number");  // If textbox is empty, return this message
            }
            else
            {
                Number = Convert.ToInt32(TextBox.Text); // If all is fine, convert textbox to int32 and save it in integer "Number"
            }

            
            tab.Add(Number);    // Add this number to the bunch => Send it to class
            TextBox.Clear();    // Cleare up the Textbox
            TextBox.Focus();    // Setting focus to TextBox
            TextBox.Select();   // Selecting TextBox's next input
            NumberDisplayLabel.Text = tab.ToString();   // Update numbers display
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            int Number = tab.Min();
            MessageBox.Show("Lowest number is " + Number);
            TextBox.Clear();    // Cleare up the Textbox
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            int Number = tab.Max();
            MessageBox.Show("Highest number is " + Number);
            TextBox.Clear();    // Cleare up the Textbox
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            int Number = tab.Sum();
            MessageBox.Show("Sum of all numbers is " + Number);
            TextBox.Clear();    // Cleare up the Textbox
        }

        private void BtnAvg_Click(object sender, EventArgs e)
        {
            double Avg = tab.Avg();
            Avg = Math.Round(Avg, 2);
            MessageBox.Show("Average number is " + Avg);
            TextBox.Clear();    // Cleare up the Textbox
        }

        private void BtnContains_Click(object sender, EventArgs e)
        {
            int Number = 0; // Declaration of Number
            if (TextBox.Text == "" || TextBox.Text == null) // Making sure, textbox is not empty
            {
                MessageBox.Show("Please, Input a number");  // If textbox is empty, return this message
            }
            else
            {
                Number = Convert.ToInt32(TextBox.Text); // If all is fine, convert textbox to int32 and save it in integer "Number"
             
                if(tab.Contains(Number))
                {
                    MessageBox.Show("Table contains " + Number);
                }
                else
                {
                    MessageBox.Show("Table does not contain " + Number);
                }
            }
            TextBox.Clear();    // Cleare up the Textbox 
        }

        private void BtnBinary_Click(object sender, EventArgs e)
        {
            int Number = 0; // Declaration of Number
            if (TextBox.Text == "" || TextBox.Text == null) // Making sure, textbox is not empty
            {
                MessageBox.Show("Please, Input a number");  // If textbox is empty, return this message
            }
            else
            {
                Number = Convert.ToInt32(TextBox.Text); // If all is fine, convert textbox to int32 and save it in integer "Number"
            
                if (tab.Binary(Number))
                {
                    MessageBox.Show("Table contains " + Number);
                }
                else
                {
                    MessageBox.Show("Table does not contain " + Number);
                }
            }
            NumberDisplayLabel.Text = tab.ToString();   // Update numbers display
            TextBox.Clear();    // Cleare up the Textbox 
        }

        private void BtnSelection_Click(object sender, EventArgs e)
        {
            if (tab.Selection() == true)
            {
                MessageBox.Show("Table is sorted");
            }
            else
            {
                MessageBox.Show("DaFaq Did Ya Do? This Should Not Have Happened");
            }
            NumberDisplayLabel.Text = tab.ToString();   // Update numbers display
        }

        private void BtnInsertion_Click(object sender, EventArgs e)
        {
            int Number = 0; // Declaration of Number
            if (TextBox.Text == "" || TextBox.Text == null) // Making sure, textbox is not empty
            {
                MessageBox.Show("Please, Input a number");  // If textbox is empty, return this message
            }
            else
            {
                Number = Convert.ToInt32(TextBox.Text); // If all is fine, convert textbox to int32 and save it in integer "Number"

                if (tab.Insertion(Number))
                {
                    MessageBox.Show("Table is sorted");
                }
                else
                {
                    MessageBox.Show("DaFaq Did Ya Do? This Should Not Have Happened");
                }
            }
            TextBox.Clear();    // Cleare up the Textbox 
            NumberDisplayLabel.Text = tab.ToString();   // Update numbers display
        }

        private void BtnBubbleSort_Click(object sender, EventArgs e)
        {
            if(tab.BubbleSort() == true)
            {
                MessageBox.Show("Table is sorted");
            }
            else
            {
                MessageBox.Show("DaFaq Did Ya Do? This Should Not Have Happened");
            }
            NumberDisplayLabel.Text = tab.ToString();   // Update numbers display
        }

        private void BtnFastEditing_Click(object sender, EventArgs e)
        {
            NumberDisplayLabel.Text = tab.ToString();   // Update numbers display 
        }
    }
}
