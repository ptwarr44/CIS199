// By: Patrick Warren
// Program 4
// Due: 04/25/2017
// CIS 199-02

// This file models the business logic for GroundPackages.
// Each has origin and destination zip codes, length,
// width, height, and weight.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class GroundPackage
    {
        private int _originZip; //Holds the value for the origin zip code
        private int _destZip; //Holds the value for the destination zip code
        private double _length; //Holds the value for length. Must be a positive number
        private double _width; //Holds the value for width. Must be a positive number
        private double _height; //Holds the value for height. Must be a positive number
        private double _weight; //Holds the value for weight. Must be a positive number

        // Validation values
        public const int MIN_ZIP = 00000; // Minimum zip code value
        public const int MAX_ZIP = 99999; // Maximum zip code value

        // Defaults to be used when constructor receives invalid data
        public const int DEFAULT_ORIGIN_ZIP = 40202;  // Default zip code
        public const int DEFAULT_DEST_ZIP = 90210;    // Default destinatn
        public const double DEFAULT_DIM = 1.0;        // Default dimension value

        //Precondition: None are empty nor whitespaces. All >= 0
        //Postcondition: GroundPackage is constructed with specificed properties
        public GroundPackage(int setOriginZip, int setDestZip, double setLength, double setWidth, double setHeight, double setWeight)
        {
            OriginZip = setOriginZip; //sets the input value for the origin zip code
            DestinationZip = setDestZip; //sets the input value for the destination zip code
            _length = setLength; //Sets the input value for length
            _width = setWidth; //Sets the input value for width
            _height = setHeight; //Sets the input value for height
            _weight = setWeight; //Sets the input value for weight
        }

        //Origin Zip property
        public int OriginZip
        {
            //precondition: none
            //postcondition: Origin Zip set is returned
            get
            {
                return _originZip;
            }
            //precondition: 00000 <= value <= 99999
            //postcondition: Origin Zip is set
            set
            {
                if (value >= 00000 && value <= 99999)
                    _originZip = value;
                else //else set back to 40202
                    _originZip = 40202;
            }
        }

        //Destination Zip property
        public int DestinationZip
        {
            //precondition: none
            //postcondition: Destination Zip set is returned
            get
            {
                return _destZip;
            }
            //precondition: 00000 <= value <= 99999
            //postcondition: Destination Zip is set
            set
            {
                if (value >= 00000 && value <= 99999)
                    _destZip = value;
                else //else set back to 90210
                    _destZip = 90210;
            }
        }

        public double Length
        {
            // Precondition:  None
            // Postcondition: The package's length has been returned
            get
            {
                return _length;
            }

            // Precondition:  value > 0
            // Postcondition: The package's length has been set to the
            //                specified value
            set
            {
                if (value > 0)
                    _length = value;
                else
                    _length = DEFAULT_DIM;
            }
        }

        public double Width
        {
            // Precondition:  None
            // Postcondition: The package's width has been returned
            get
            {
                return _width;
            }

            // Precondition:  value > 0
            // Postcondition: The package's width has been set to the
            //                specified value
            set
            {
                if (value > 0)
                    _width = value;
                else
                    _width = DEFAULT_DIM;
            }
        }

        public double Height
        {
            // Precondition:  None
            // Postcondition: The package's height has been returned
            get
            {
                return _height;
            }

            // Precondition:  value > 0
            // Postcondition: The package's height has been set to the
            //                specified value
            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = DEFAULT_DIM;
            }
        }

        public double Weight
        {
            // Precondition:  None
            // Postcondition: The package's weight has been returned
            get
            {
                return _weight;
            }

            // Precondition:  value > 0
            // Postcondition: The package's weight has been set to the
            //                specified value
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    _weight = DEFAULT_DIM;
            }
        }

        //Distance between zip codes property
        public int ZoneDistance
        {
            //preconditon: OriginZip and DestinationZip conditions have been met
            //postcondition: Distance between locations is returned
            get
            {
                return Math.Abs((DestinationZip / 10000) - (OriginZip / 10000)); //Returns the absolute value of the distance between two points
            }
        }

        //precondition: Length, width, height, weight, and zone distance are not empty and are valid
        //postcondition: Calculates the total cost of each ground package
        public double CalcCost()
        {
            double _totalCost = (.20 * (_length + _width + _height)) + (.5 * (ZoneDistance + 1) * _weight); 
                //holds value for the total cost

            return _totalCost;
        }

        //Precondition: None
        //Postcondition: Formatted string representing a ground package
        public override string ToString()
        {
            return string.Format("Origin Zip: " + OriginZip.ToString() + "{0}" +
                "Destination Zip: " + DestinationZip.ToString() + "{1}" +
                "Length: " + _length.ToString("F2") + " in" + "{2}" +
                "Width: " + _width.ToString("F2") + " in" + "{3}" +
                "Height: " + _height.ToString("F2") + " in" + "{4}" +
                "Weight: " + _weight.ToString("F2") + " lb(s)" + "{5}" +
                //"Distance between: " + ZoneDistance.ToString() + "{2}" +
                "Total Cost: " + CalcCost().ToString("C2") + "{6}",
                Environment.NewLine, Environment.NewLine, Environment.NewLine, Environment.NewLine, 
                Environment.NewLine, Environment.NewLine, Environment.NewLine); //Displays the Zip codes, total distance, and total cost.
        }
    }
}
