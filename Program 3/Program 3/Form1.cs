// By: Patrick Warren
// Program 3
// Course: CIS 199-02
// Due Date: 03/07/2017
  
// This program takes the first letter of the students last name along with the 
// radio button associated with their grade level and tells the student when they
// are able to register

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Program3 : Form
    {
        public Program3()
        {
            InitializeComponent();
        }

        private void calcOutButton_Click(object sender, EventArgs e)
        {
           // string gradeLevelChecked = ""; //Will hold the value for radio buttons in the group

            const string FRESH_DAY_ONE = "Tuesday, April 4th at "; //Constant day one for Freshman
            const string FRESH_DAY_TWO = "Wednesday, April 5th at "; //Constant day two for Freshman
            const string SOPH_DAY_ONE = "Friday, March 31st at "; //Constant day one for Sophomore
            const string SOPH_DAY_TWO = "Monday, April 3rd at "; //Constant day two for Sophomore
            const string JUNIOR_DAY = "Thursday, March 30th at "; //Constant reg day for Junior
            const string SENIOR_DAY = "Wednesday, March 29th at "; //Constant reg day for Senior
            const string FIRST_TIME = "8:30 AM"; //1st registration time
            const string SECOND_TIME = "10:00 AM"; //2nd reg time
            const string THIRD_TIME = "11:30 AM"; //3rd reg time
            const string FOURTH_TIME = "2:00 PM"; //4th reg time
            const string FIFTH_TIME = "4:00 PM"; //5th reg time

            char lastName; //Variable to hold parsed characer

            //Parses the character and grade level, then finds the day and time they should register
            if (char.TryParse(lastNameInput.Text, out lastName))
            {

                lastName = Char.ToUpper(lastName); //Input value for last name

                //If-else statement will check to make sure that a character is indeed entered
                if (char.IsNumber(lastName) || char.IsPunctuation(lastName) || char.IsWhiteSpace(lastName))
                    MessageBox.Show("Please only enter the first letter of the last name.");
                else
                //Nested if-else for seniors and juniors
                if (seniorGradeLvl.Checked || juniorGradeLvl.Checked)
                {
                    if (lastName <= 'D' && seniorGradeLvl.Checked)
                        dateOfRegOut.Text = SENIOR_DAY + THIRD_TIME;
                    else
                        dateOfRegOut.Text = JUNIOR_DAY + THIRD_TIME;
                    if (lastName <= 'I' && seniorGradeLvl.Checked)
                        dateOfRegOut.Text = SENIOR_DAY + FOURTH_TIME;
                    else
                        dateOfRegOut.Text = JUNIOR_DAY + FOURTH_TIME;
                    if (lastName <= 'O' && seniorGradeLvl.Checked)
                       dateOfRegOut.Text = SENIOR_DAY + FIFTH_TIME;
                    else
                       dateOfRegOut.Text = JUNIOR_DAY + FIFTH_TIME;
                    if (lastName <= 'S' && seniorGradeLvl.Checked)
                       dateOfRegOut.Text = SENIOR_DAY + FIRST_TIME;
                    else
                       dateOfRegOut.Text = JUNIOR_DAY + FIRST_TIME;
                    if (lastName > 'S' && seniorGradeLvl.Checked)
                       dateOfRegOut.Text = SENIOR_DAY + SECOND_TIME;
                    else
                       dateOfRegOut.Text = JUNIOR_DAY + SECOND_TIME;
                }
                //Nested if-else check for sophomore and freshman
                else 
                {
                    if (lastName <= 'B' && sophGradeLvl.Checked)
                        dateOfRegOut.Text = SOPH_DAY_ONE + FIFTH_TIME;
                    else
                        dateOfRegOut.Text = FRESH_DAY_ONE + FIFTH_TIME;
                    if (lastName <= 'D' && sophGradeLvl.Checked)
                        dateOfRegOut.Text = SOPH_DAY_TWO + FIRST_TIME;
                    else
                        dateOfRegOut.Text = FRESH_DAY_TWO + FIRST_TIME;
                    if (lastName <= 'F' && sophGradeLvl.Checked)
                        dateOfRegOut.Text = SOPH_DAY_TWO + SECOND_TIME;
                    else
                        dateOfRegOut.Text = FRESH_DAY_TWO + SECOND_TIME;
                    if (lastName <= 'I' && sophGradeLvl.Checked)
                        dateOfRegOut.Text = SOPH_DAY_TWO + THIRD_TIME;
                    else
                        dateOfRegOut.Text = FRESH_DAY_TWO + THIRD_TIME;
                    if (lastName <= 'L' && sophGradeLvl.Checked)
                        dateOfRegOut.Text = SOPH_DAY_TWO + FOURTH_TIME;
                    else
                        dateOfRegOut.Text = FRESH_DAY_TWO + FOURTH_TIME;
                    if (lastName <= 'O' && sophGradeLvl.Checked)
                        dateOfRegOut.Text = SOPH_DAY_TWO + FIFTH_TIME;
                    else
                        dateOfRegOut.Text = FRESH_DAY_TWO + FIFTH_TIME;
                    if (lastName <= 'Q' && sophGradeLvl.Checked)
                        dateOfRegOut.Text = SOPH_DAY_ONE + FIRST_TIME;
                    else
                        dateOfRegOut.Text = FRESH_DAY_ONE + FIRST_TIME;
                    if (lastName <= 'S' && sophGradeLvl.Checked)
                        dateOfRegOut.Text = SOPH_DAY_ONE + SECOND_TIME;
                    else
                        dateOfRegOut.Text = FRESH_DAY_ONE + SECOND_TIME;
                    if (lastName <= 'V' && sophGradeLvl.Checked)
                        dateOfRegOut.Text = SOPH_DAY_ONE + THIRD_TIME;
                    else
                        dateOfRegOut.Text = FRESH_DAY_ONE + THIRD_TIME;
                    if (lastName > 'V' && sophGradeLvl.Checked)
                        dateOfRegOut.Text = SOPH_DAY_ONE + FOURTH_TIME;
                    else
                        dateOfRegOut.Text = FRESH_DAY_ONE + FOURTH_TIME;
                }
            } else
                MessageBox.Show("Please enter the first character of the last name.");
        }
        //Will clear all relavent labels/boxes that have data, and will set the default button as Freshman
        private void clearButton_Click(object sender, EventArgs e)
        {
            freshGradeLvl.Checked = true;
            lastNameInput.Clear();
            dateOfRegOut.Text = "";
        }
    }
}