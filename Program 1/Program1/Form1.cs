// By: Patrick Warren
// Program 1
// Due Date: 02/14/2017
// Course section: CIS 199-02
 
 // This program takes in three inputs for a paint job and gives the numbers needed to complete the paint job,
 // including the total cost

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //Calculates all values needed for a paint job upon clicking calculate
        private void calculateButton_Click(object sender, EventArgs e)
        {

            float wallSpaceConv; //Input value of wall space to be converted
            int coatsConv; //Input value for amount of coats desired to be converted
            float pricePaintConv; //Input value for price per paint to be converted

            const int wallSpaceCalc = 330; //Input value of wall space to be calculated
            const int laborPerGallon = 6; //Labor per gallon to be calculated
            const decimal laborPerHour = 10.50m; //Labor per hour to be calculated

            //Catches exception for no entry or runs the program
            if (String.IsNullOrWhiteSpace(wallSpaceInput.Text) && String.IsNullOrWhiteSpace(coatsInput.Text) && String.IsNullOrWhiteSpace(priceInput.Text))
            {
                MessageBox.Show("One or more entries has not been filled out. Please try again"); //Shows a message box if one or more text boxes is empty
            }
            else
            {
                wallSpaceConv = float.Parse(wallSpaceInput.Text); //Convert input to float type number
                coatsConv = int.Parse(coatsInput.Text); //Convert input to integer type number
                pricePaintConv = float.Parse(priceInput.Text); //Convert input to float type number

                double sqFtOutput = wallSpaceConv * coatsConv; //Calculation for feet to be painted.
                double totalGallon = Math.Ceiling(sqFtOutput / wallSpaceCalc); //Calculation for total gallons to purchase
                double totalHours = (sqFtOutput / wallSpaceCalc) * laborPerGallon; //Calculates total hours for paint job
                double totalPaintPrice = pricePaintConv * totalGallon; //Total cost of paint
                double costLaborHours = totalHours * (double) laborPerHour; //Total cost of labor
                double totalJob = totalPaintPrice + costLaborHours; //Total cost of paint job
           
                totalSqFtOutput.Text = sqFtOutput.ToString("n1") + " sq ft"; //Displays total square feet
                gallonsOutput.Text = totalGallon.ToString("n1") + " gallons"; //Displays total gallons
                laborOutput.Text = totalHours.ToString("n1") + " hours"; //Displays total hours
                costPaintOutput.Text = totalPaintPrice.ToString("C"); //Displays total price of pain
                costLaborOutput.Text = costLaborHours.ToString("C"); //Displays total price of labor hours
                totalPaintJob.Text = totalJob.ToString("C"); //Displays total cost of the job
            }
        }
        //Clears all text boxes and labels
        private void clearButton_Click(object sender, EventArgs e)
        {
            wallSpaceInput.Clear(); //Clears wall space input
            coatsInput.Clear(); //Clears number of coats input
            priceInput.Clear(); //Clears price per paint input
            totalSqFtOutput.Text = String.Empty; //Clears Sq Feet label
            gallonsOutput.Text = String.Empty; //Clears total gallons needed label
            laborOutput.Text = String.Empty; //Cleas total hous needed label
            costPaintOutput.Text = String.Empty; //Clears total price for paint label
            costLaborOutput.Text = String.Empty; // Clears cost for labor label
            totalPaintJob.Text = String.Empty; //Clears total paint job label
        }
    }
}
