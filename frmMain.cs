/*
 *Author: John Lahut
 *Date: 2/23/2014
 *Project: Roman Numeral 
 *Filename: frmMain.cs
 *Purpose: To add and subtract roman numerals. Validates roman numbers. Converts roman numerals to a decimal value, and vise versa.
 *I/O: Input taken through two text boxes, and displayed the txtResult
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Roman_Numeral
{
    public partial class frmMain : Form
    {
        
        //Post: frmMain is initialized on screen, and centered. Hides the To Roman and To Decimal buttons, as well as making the Result text box read-only. Focuses Calculate
        //Purpose: To initialize the main form
        public frmMain()
        {
            CenterToScreen();
            InitializeComponent();
            txtResult.ReadOnly = true;
            btnToRoman.Hide();
            btnToDec.Hide();
            btnCalc.Focus();
        }//end frmMain


        //Pre: Form is intantiated 
        //Post: Converts the text boxes from decimal to roman numerals
        //Purpose: To convert all text boxes from decimal to roman numerals
        private void btnToRoman_Click(object sender, EventArgs e)
        {
            RomanClass r1 = new RomanClass("");
            RomanClass r2 = new RomanClass("");
            RomanClass r3 = new RomanClass("");
            bool display1 = true;
            bool display2 = true;
            bool displayResult = true;
            bool buttons = true;

            //If zero, add the text Nullus
            if (txtRoman1.Text == "0")
            {
                display1 = false;
                txtRoman1.Text = "Nullus"; 
            }

            if (txtRoman2.Text == "0")
            {
                display2 = false;
                txtRoman2.Text = "Nullus";
            }

            if (txtResult.Text == "0")
            {
                displayResult = false;
                txtResult.Text = "Nullus";
            }

            //Make sure they are valid..
            if (displayResult == true)
            {
                try
                {
                    txtResult.Text = r1.SetString(Convert.ToInt16(txtResult.Text));
                }
                catch (FormatException i)
                {
                    buttons = false;
                    MessageBox.Show(txtResult.Text + " Is not valid for conversion.", "Invalid Input", MessageBoxButtons.OK);
                }
            }

            if (display1 == true)
            {
                try
                {
                    txtRoman1.Text = r2.SetString(Convert.ToInt16(txtRoman1.Text));
                }
                catch (FormatException i)
                {
                    buttons = false;
                    MessageBox.Show(txtRoman1.Text + " Is not valid for conversion.", "Invalid Input", MessageBoxButtons.OK);
                }
            }
            if (display2 == true)
            {
                try
                {
                    txtRoman2.Text = r3.SetString(Convert.ToInt16(txtRoman2.Text));
                }
                catch (FormatException i)
                {
                    buttons = false;
                    MessageBox.Show(txtRoman2.Text + " Is not valid for conversion.", "Invalid Input", MessageBoxButtons.OK);
                }
            }

            //If successfully converted all values, hide the To Roman button, and show the To Decimal button. Focuses Clear
            if (buttons)
            {
                btnToDec.Show();
                btnToRoman.Hide();
                btnClear.Focus();

            }
        } //end btnToRoman_Click

        //Pre: Form is intantiated 
        //Post: All fields are cleared
        //Purpose: To clear all values from the form, reseting it to its original state, and setting focus to calculate
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoman1.Clear();
            txtRoman2.Clear();
            txtResult.Clear();
            btnToDec.Hide();
            btnToRoman.Hide();
            btnCalc.Focus();
            radioDiff.Checked = false;
            radioSum.Checked = false;
        } //end btnClear_Click

        //Pre: Form is intantiated 
        //Post: Form main is closed
        //Purpose: To close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        } //end btnExit_Click

        //Pre: Form is intantiated 
        //Post: Calculated the requested operation, and populates result
        //Purpose: To add or subtract two roman numerals upon calculate press
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Calls AreValid
            bool valid = AreValid();

            //If valid roman numerals..
            if (valid == true)
            {
                RomanClass r1 = new RomanClass(txtRoman1.Text);
                RomanClass r2 = new RomanClass(txtRoman2.Text);
                bool repeat = true;

                //Test special case validity, ConvertToDecimal returns -1 if is invalid
                if (r1.ConvertToDecimal() == -1)
                {
                    repeat = false;
                    MessageBox.Show(txtRoman1.Text + " Is not a valid Roman Numeral.", "Invalid Input", MessageBoxButtons.OK);
                }

                if (r2.ConvertToDecimal() == -1)
                {
                    repeat = false;
                    MessageBox.Show(txtRoman2.Text + " Is not a valid Roman Numeral.", "Invalid Input", MessageBoxButtons.OK);
                }

                //If they have entered valid numerals...
                if (repeat)
                {
                    //Upon completion hide To Decimal
                    //If sum is checked, add
                    if (radioSum.Checked == true)
                    {
                        try
                        {
                            txtResult.Text = Add(r1, r2).ToString();
                        }
                        catch (NullReferenceException i)
                        { txtResult.Text = "Overflow 0 < sum < 4000"; }
                        btnToDec.Show();
                    }
                        //If difference is checked, add
                    else if (radioDiff.Checked == true)
                    {
                        txtResult.Text = (r1 - r2).ToString();
                        btnToDec.Show();
                    }
                }
            }
        }// end btnCalc_Click

        //Pre: Form is intantiated, r1 and r2 are valid RomanClasses
        //Post: Returns sum which is the added roman classes together
        //Purpose: To add two roman classes
        private RomanClass Add(RomanClass r1, RomanClass r2)
        {
            RomanClass sum;
            sum = r1 + r2;
            try { txtResult.Text = sum.ToString(); }
            catch (NullReferenceException i)
            { txtResult.Text = "Overflow 0 < sum < 4000"; }
            return sum;
        } // end Add

        //Pre: Form is intantiated 
        //Post: Returns a boolean representing if the entered roman numerals are valid
        //Purpose: To determine if the entered roman numerals are valid
        private bool AreValid()
        {
            RomanClass r1;
            RomanClass r2;
            try
            { r1 = new RomanClass(txtRoman1.Text); }
            catch (InvalidProgramException i)
            {
                MessageBox.Show(txtRoman1.Text + " Is not a valid Roman Numeral.", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }

            try
            { r2 = new RomanClass(txtRoman2.Text); }
            catch (InvalidProgramException i)
            {
                MessageBox.Show(txtRoman2.Text + " Is not a valid Roman Numeral.", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }

            if (r1.ConvertToDecimal() == -1)
            {
                MessageBox.Show(txtRoman1.Text + " Is not a valid Roman Numeral.", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }

            else if (r2.ConvertToDecimal() == -1)
            {
                MessageBox.Show(txtRoman2.Text + " Is not a valid Roman Numeral.", "Invalid Input", MessageBoxButtons.OK);
                return false;
            } return true;
        } //end AreValid


        //Pre: Form is intantiated 
        //Post: All fields are converted to decimal values, To Decimal button is hidden, and To Roman is visible
        //Purpose: To convert all fields to decimal values
        private void btnToDec_Click(object sender, EventArgs e)
        {
            //Checking if zero values are present

            if (txtRoman1.Text == "" || txtRoman1.Text == "Nullus")
            { txtRoman1.Text = "0"; }
            else
            {
                RomanClass r = new RomanClass(txtRoman1.Text);
                txtRoman1.Text = r.ConvertToDecimal().ToString();
            }

            if (txtRoman2.Text == "" || txtRoman2.Text == "Nullus")
            { txtRoman2.Text = "0"; }
            else
            {
                RomanClass r = new RomanClass(txtRoman2.Text);
                txtRoman2.Text = r.ConvertToDecimal().ToString();
            }

            //If overflow, print error message, if not convert
            if (txtResult.Text == "Nullus" || txtResult.Text == "")
            { txtResult.Text = "0"; }
            else if (txtResult.Text == "Overflow 0 < sum < 4000")
            { txtResult.Text = "Overflow 0 < sum < 4000"; }
            else
            {
                RomanClass r = new RomanClass(txtResult.Text);
                txtResult.Text = r.ConvertToDecimal().ToString();
            }
            btnToRoman.Show();
            btnToDec.Hide();
        }

        private void grpInput_Enter(object sender, EventArgs e)
        {

        }// end btnToDec_Click
    
    }// end frmMain

}// end namespace
