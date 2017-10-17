using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------------------------------------------------------------------------
Comments by the professor:

------------------------------------------------------------------------------
Class Name:         Year
Created by:     	David Landry
Dates:              11/17-27/2016; Project date: 11/29/2016
Class:		        CS 218 A
Time:               Approx. 45 minutes.
Platform:           PC running Windows 10; 
                    Compiled with Visual Studio Community 2015 C#

Properties:                 
        private int m_year:             The numeric year
        private Year m_era:             The era, whether B.C. or A.D.

Description:
    This is a Year class, allowing the construction of a year object that
    contains both the year number and the era.  This allows properly ordered
    years, such as 1000 B.C., which comes before 500 B.C., which comes
    before 500 A.D., which comes before 1000 A.D.
------------------------------------------------------------------------------
Comments by the student:
    I was fairly lenient with format handling.  Rather than throw an
    exception if the user enters a bogus format for the year, I simply
    default the year to 1 A.D.  In hind-sight, it may have been better
    to throw a FormatException instead.
--------------------------------------------------------------------------- */

namespace Project3FamousPhilosophers
{
    public class Year
    {
        //--------------------------------------------------------------------
        // Private properties
        //--------------------------------------------------------------------
        private int m_year;
        private string m_era;

        //--------------------------------------------------------------------
        //  Constructors
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        //	Method:                 Year
        //	Description:            The default constructor.  Sets the year
        //                              to the default value of 1 A.D. if the
        //                              object was created without arguments.
        //	Parameters:             None
        //	Returns:                None
        //	Calls:                  setYear(int, string)
        //--------------------------------------------------------------------
        public Year()
        {
            setYear(1, "A.D.");
        }

        //--------------------------------------------------------------------
        //	Method:                 Year
        //	Description:            An overloaded constructor.  Sets the year
        //                              based on an integer argument for the
        //                              year and a string argument for the
        //                              era.
        //	Parameters:             An integer for the year number, and a
        //                              string for the era.
        //	Returns:                None
        //	Calls:                  setYear(int, string)
        //--------------------------------------------------------------------
        public Year(int year, string era)
        {
            setYear(year, era);
        }

        //--------------------------------------------------------------------
        //	Method:                 Year
        //	Description:            An overloaded constructor.  Sets the year
        //                              based on a single string argument
        //                              containing both a year number and era.
        //	Parameters:             A string for the year and era.
        //	Returns:                None
        //	Calls:                  setYear(string)
        //--------------------------------------------------------------------
        public Year(string year)
        {
            setYear(year);
        }

        //--------------------------------------------------------------------
        //	Method:                 Year
        //	Description:            The copy constructor.  Sets the year
        //                              to the values of the properties of
        //                              the other year.
        //	Parameters:             A Year object.
        //	Returns:                None
        //--------------------------------------------------------------------
        public Year(Year otherYear)
        {
            m_era = otherYear.m_era;
            m_year = otherYear.m_year;
        }

        //--------------------------------------------------------------------
        //  Mutators
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        //	Method:                 setYear
        //	Description:            Mutator for a Year object.  Sets the year
        //                              of a year object from an integer and
        //                              a string.
        //	Parameters:             An integer for the year number and a
        //                              string for the era.
        //	Returns:                None
        //	Called by:              Year(int, string) constructor
        //--------------------------------------------------------------------
        public void setYear(int year, string era = "a.d.")
        {
            if (year != 0)
            {
                m_year = year;
                switch (era.ToLower())
                {
                    case "ad":
                    case "a.d.":
                    case "ce":
                    case "c.e.":
                        m_era = "A.D.";
                        break;
                    case "bc":
                    case "b.c.":
                    case "bce":
                    case "b.c.e.":
                        m_era = "B.C.";
                        break;
                    default:
                        // If the era text format is incorrect, default to
                        //  1 A.D.
                        m_year = 1;
                        m_era = "A.D.";
                        break;
                }
            }
            else
            {
                // There's no such thing as year 0, so set the year to a
                //  default value of 1 A.D.
                m_year = 1;
                m_era = "A.D.";
            }
        }

        //--------------------------------------------------------------------
        //	Method:                 setYear
        //	Description:            Mutator for a Year object.  Sets the year
        //                              properties from a single string using
        //                              extensive string parsing.
        //	Parameters:             A string for the full year.
        //	Returns:                None
        //  Calls:                  setYear(int, string), 
        //                              Validation.isWhiteSpace,
        //                              Validation.isNumeric
        //	Called by:              Year(string) constructor
        //--------------------------------------------------------------------
        public void setYear(string year)
        {
            // construct a string stream to parse a string to see if it
            //  contains a valid year.
            System.IO.StringReader readYear = 
                new System.IO.StringReader(year);
            string tempYear = "";
            string tempEra = "";
            // Read past any whitespace at the beginning of the string stream.
            while (
                readYear.Peek() > 0 &&  // End of string has a value of -1.
                Validation.isWhiteSpace((char)readYear.Peek())
                )
            {
                readYear.Read();
            }

            // Check the string for proper year format.  It should either be 
            //  in the form of year then era, just year, or era then year.
            //  This first part of the if statement handles the year-then-era
            //  or just-year case.
            if (Validation.isNumeric((char)readYear.Peek()))
            {
                // Keep reading in numerals and assigning them to tempYear,
                //  which holds the string representation of the numeric part
                //  of the year.
                while (
                    readYear.Peek() > 0 &&
                    Validation.isNumeric((char)readYear.Peek())
                    )
                    tempYear += (char)readYear.Read();

                // Read past whitespace.
                while (
                    readYear.Peek() > 0 &&
                    Validation.isWhiteSpace((char)readYear.Peek())
                    )
                {
                    readYear.Read();
                }

                // Now, read in lettering and assign it to the era part of the
                //  year (A.D. or B.C.).
                while (
                    readYear.Peek() > 0 &&
                    !Validation.isWhiteSpace((char)readYear.Peek())
                    )
                {
                    tempEra += (char)readYear.Read();
                }
            }   // End if for the year-then-era case (or just-year case)
            else
            {
                // If, for some reason, the data contains a year with the era
                //  preceding the year, that should be ok too.  In this case,
                //  the method will read the era data first, then the numeric
                //  year.
                while (
                    readYear.Peek() > 0 &&
                    !Validation.isWhiteSpace((char)readYear.Peek())
                    )
                    tempEra += (char)readYear.Read();

                // Read past white space
                while (
                    readYear.Peek() > 0 &&
                    Validation.isWhiteSpace((char)readYear.Peek())
                    )
                    readYear.Read();

                // Assign the rest of the string to the year
                while (
                    readYear.Peek() > 0 &&
                    Validation.isNumeric((char)readYear.Peek())
                    )
                    tempYear += (char)readYear.Read();
            }   // End else if for the era-then-year case

            // If the era is missing from the string, assume the year is
            //  in A.D., and assign "ad" to tempEra.
            if (tempEra == "")
                tempEra = "ad";
            if (!Validation.isNumeric(tempYear) || tempYear == "")
                tempYear = "1";
            // Call the int/string version of the setYear method with tempYear
            //  as the year and tempEra as the era, which handles input 
            //  validation.
            setYear(int.Parse(tempYear), tempEra);
        }

        //--------------------------------------------------------------------
        //  Accessor- getYear
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        //	Method:                 getYear
        //	Description:            Retrieves the numeric portion of the
        //                              year
        //	Parameters:             None
        //	Returns:                An integer for the year (m_year)
        //--------------------------------------------------------------------
        public int getYear()
        {
            return m_year;
        }

        //--------------------------------------------------------------------
        //  Operator and string method overloading
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        //	Method:                 ToString
        //	Description:            ToString override method
        //	Parameters:             None
        //	Returns:                A string representation of the year 
        //                              object.
        //--------------------------------------------------------------------
        public override string ToString()
        {
            return m_year + " " + m_era;
        }

        //--------------------------------------------------------------------
        //	Method:                 operator >
        //	Description:            > operator overload.  Tests if the left
        //                              year is greater than the right year.
        //	Parameters:             2 Years; the first to the left of the
        //                              > operator, the second to the right.
        //	Returns:                A boolean: true if the first year is
        //                              "greater than" (i.e., comes after)
        //                              the second year.  False otherwise.
        //--------------------------------------------------------------------
        public static bool operator >(Year year1, Year year2)
        {
            if (year1.m_era == "B.C." && year2.m_era == "B.C.")
            {
                if (year1.m_year < year2.m_year)
                    return true;
                else
                    return false;
            }
            else if (year1.m_era == "A.D." && year2.m_era == "A.D.")
            {
                if (year1.m_year > year2.m_year)
                    return true;
                else
                    return false;
            }
            else if (year1.m_era == "B.C." && year2.m_era == "A.D.")
                return false;
            else
                return true;

        }

        //--------------------------------------------------------------------
        //	Method:                 operator <
        //	Description:            < operator overload.  Tests if the left
        //                              year is less than the right year
        //                              (i.e., comes before)
        //	Parameters:             2 Years; the first to the left of the
        //                              < operator, the second to the right.
        //	Returns:                A boolean: true if the first year is
        //                              "less than" (i.e., comes before)
        //                              the second year.  False otherwise.
        //--------------------------------------------------------------------
        public static bool operator <(Year year1, Year year2)
        {
            if (year1.m_era == "B.C." && year2.m_era == "B.C.")
            {
                if (year1.m_year > year2.m_year)
                    return true;
                else
                    return false;
            }
            else if (year1.m_era == "A.D." && year2.m_era == "A.D.")
            {
                if (year1.m_year < year2.m_year)
                    return true;
                else
                    return false;
            }
            else if (year1.m_era == "B.C." && year2.m_era == "A.D.")
                return true;
            else
                return false;
        }

        //--------------------------------------------------------------------
        //	Method:                 operator >=
        //	Description:            >= operator overload.  Tests if the left
        //                              year is greater than or equal to
        //                              the right year.
        //	Parameters:             2 Years; the first to the left of the
        //                              >= operator, the second to the right.
        //	Returns:                A boolean: true if the first year is
        //                              "greater than or equal to" (i.e., 
        //                              is the same or comes after)
        //                              the second year.  False otherwise.
        //  Calls:                  operator >
        //--------------------------------------------------------------------
        public static bool operator >=(Year year1, Year year2)
        {
            if (year1 > year2 || year1 == year2)
                return true;
            else
                return false;
        }

        //--------------------------------------------------------------------
        //	Method:                 operator <=
        //	Description:            <= operator overload.  Tests if the left
        //                              year is less than or equal to
        //                              the right year.
        //	Parameters:             2 Years; the first to the left of the
        //                              <= operator, the second to the right.
        //	Returns:                A boolean: true if the first year is
        //                              "less than or equal to" (i.e., 
        //                              is the same or comes before)
        //                              the second year.  False otherwise.
        //  Calls:                  operator <
        //--------------------------------------------------------------------
        public static bool operator <=(Year year1, Year year2)
        {
            if (year1 < year2 || year1 == year2)
                return true;
            else
                return false;
        }

        //--------------------------------------------------------------------
        //	Method:                 Parse
        //	Description:            Parse override method
        //	Parameters:             A string: the string to parse into a year.
        //	Returns:                A year object.
        //  Calls:                  Year default constructor, setYear(string)
        //--------------------------------------------------------------------
        public static Year Parse(string yearToParse)
        {
            Year theYear = new Year();
            theYear.setYear(yearToParse);
            return theYear;
        }
    }
}
