// By: Patrick Warren
// Program 4
// Due: 04/25/2017
// CIS 199-02
 
// This program lets the user input all values of a ground package, including dimensions and zip codes.
// The user can then add these packages to the list box
// Once in the list, user has the ability to view specific details and change the "To" and "From" portions 
// of the selected package.

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Program4
{
    public partial class Program4 : Form
    {
        //List to hold the Ground Packages
        private List<GroundPackage> packageList = new List<GroundPackage>(); 

        //precondition: None
        //postcondition: Form is constructed and ready to load
        public Program4()
        {
            InitializeComponent();
        }

        //Precondition: none
        //Postcondition: Form's data are gathered/parsed and out parameters hold data entered.
        //               Otherwise, false is returned
        private bool ValidateGroundPackage(out int origin, out int destination, out double length,
            out double width, out double height, out double weight)
        {
            bool isValid = false; //Checks to see if all data fields are valid
            origin = destination = 0; //Intiialize values
            length = width = height = weight = 0; //Initialize values

            //Validate the phone and all measurements
            if (int.TryParse(zipOriginBox.Text, out origin))
            {
                if (int.TryParse(zipDestBox.Text, out destination))
                {
                    if (double.TryParse(lengthBox.Text, out length) && (length >= 0))
                    {
                        if (double.TryParse(widthBox.Text, out width) && (width >= 0))
                        {
                            if (double.TryParse(heightBox.Text, out height) && (height >= 0))
                            {
                                if (double.TryParse(weightBox.Text, out weight) && (weight >= 0))
                                {
                                    isValid = true; //If everything is met, isValid is true
                                }
                                else MessageBox.Show("Invalid Weight!"); //Invalid Weight
                            }
                            else MessageBox.Show("Invalid Height!"); //Invalid Height
                        }
                        else MessageBox.Show("Invalid Width!"); //Invalid Width
                    }
                    else MessageBox.Show("Invalid Length!"); //Invalid Length
                }
                else MessageBox.Show("Invalid Destionion Zip Code!"); //Invlaid Destination Zip Code
            }
            else MessageBox.Show("Invalid Origin Zip Code!"); //Invalid Origin Zip Code

            return isValid; 
        }
        //Precondition: ValidateGroundPackage has been met
        //Postcondition: Adds the item to the listbox and then clears the text boxes and resets focus
        private void addBtn_Click(object sender, EventArgs e)
        {
            GroundPackage package; //Holds the value for a new package
            int originZip; //Origin Zip Code entered
            int destZip; //Desitination Zip Code entered
            double length; //Entered length
            double width; //Entered wdith
            double height; //Entered height
            double weight; //Enetered weight

            //Gets the package and validates it. Will only pass if all values are valid
            if (ValidateGroundPackage(out originZip, out destZip, out length, out width, out height, out weight))
            {
                //Create a new package with the entered values
                package = new GroundPackage(originZip, destZip, length, width, height, weight);

                //Add packge to the list
                packageList.Add(package);

                //Add entry to list box
                endPackListBox.Items.Add("Package " + packageList.Count + ": " + package.OriginZip + " to " + package.DestinationZip);


                //Clear all text boxes
                zipOriginBox.Clear();
                zipDestBox.Clear();
                lengthBox.Clear();
                widthBox.Clear();
                heightBox.Clear();
                weightBox.Clear();

                //Reset focus
                zipOriginBox.Focus();
            }
        }

        //Precondition: User has selected an item in the list box
        //Postcondition: Displays the details of the item in a message box
        private void detailsBox_Click(object sender, EventArgs e)
        {
            int index; //Hold the index of the selected package

            index = endPackListBox.SelectedIndex; //Intialize the selected package

            if (index >= 0)
            {
                //Show the details of the box using ToString() method defined
                MessageBox.Show(packageList[index].ToString());
            }
            else //If nothing is selected, return an error
                MessageBox.Show("Please select a package from the list.");
        }

        //Precondition: User has selected an item in the list box
        //Postcondition: Selected item has the destination Zip code changed to 40292
        private void toCardsBox_Click(object sender, EventArgs e)
        {
            int index; //Hold the index of the selected package

            index = endPackListBox.SelectedIndex; //Initialize the selected package

            if (index >= 0)
            {
                //Set the destination zip code to 40292
                packageList[index].DestinationZip = 40292;
                endPackListBox.Items[index] = "Package " + (index + 1) + ": " + packageList[index].OriginZip + " to " +  packageList[index].DestinationZip;
            }
            else //If nothing is selected, return an error
                MessageBox.Show("Please select a package from the list.");
        }

        //Precondition: User has selected an item in the list box
        //Postcondition: Selected item has the Origin Zip code changed to 40292
        private void fromCardsBox_Click(object sender, EventArgs e)
        {
            int index; //Hold the index of the selected package

            index = endPackListBox.SelectedIndex; //Initialize the selected package

            if (index >= 0)
            {
                //Set the destination zip code to 40292
                packageList[index].OriginZip = 40292;
                endPackListBox.Items[index] = "Package " + (index + 1) + ": " + packageList[index].OriginZip + " to " + packageList[index].DestinationZip;
            }
            else //If nothing is selected, return an error
                MessageBox.Show("Please select a package from the list.");
        }
    }
}
