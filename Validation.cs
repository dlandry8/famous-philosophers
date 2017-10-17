using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Insert header here
// 40 minutes
// 11/15/2016

namespace Project3FamousPhilosophers
{
    class Validation
    {
        //--------------------------------------------------------------------
        // Method header goes here
        // Date: 11/15/2016
        //--------------------------------------------------------------------
        public static bool isNumeric(object input)
        {
            string toTest = input.ToString().ToLower();

            // Test for a to z:
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (toTest.Contains(i))
                    return false;
            }

            // Test for special characters:
            for (int i = 32; i <= 45; i++)
            {
                if (toTest.Contains((char)(i)))
                    return false;
            }
            if (toTest.Contains('/'))
                return false;
            for (int i = 58; i <= 64; i++)
            {
                if (toTest.Contains((char)(i)))
                    return false;
            }
            for (int i = 91; i <= 96; i++)
            {
                if (toTest.Contains((char)(i)))
                    return false;
            }
            for (int i = 123; i <= 126; i++)
            {
                if (toTest.Contains((char)(i)))
                    return false;
            }

            // Test for proper decimal format if decimal:
            bool hasDecimal = false;
            for (int i = 0; i < toTest.Length; i++)
            {
                // Check for decimal point character by character.  Return
                //  false if there is more than one decimal point.
                if (toTest[i] == '.')
                {
                    if (hasDecimal)
                        return false;
                    else
                        hasDecimal = true;
                }
            }

            // If the string does not contain letters or special characters,
            //  and has proper decimal point representation, then it is a
            //  proper number.  Return true!
            return true;
        }

        //--------------------------------------------------------------------
        // Method header goes here
        // Date: 11/17/2016
        //--------------------------------------------------------------------
        public static bool isWhiteSpace(char charToTest)
        {
            switch (charToTest)
            {
                case ' ':
                case '\n':
                case '\t':
                case '\b':
                case '\r':
                case '\f':
                    return true;
                default:
                    return false;
            }
        }

        //--------------------------------------------------------------------
        // Method header goes here
        // Date: 11/15/2016
        //--------------------------------------------------------------------
        public static bool isInRange(long input, long min, long max)
        {
            if (input >= min && input <= max)
                return true;
            else
                return false;
        }

        //--------------------------------------------------------------------
        // Method header goes here
        // Date: 11/15/2016
        //--------------------------------------------------------------------
        public static bool isInRange(double input, double min, double max)
        {
            if (input >= min && input <= max)
                return true;
            else
                return false;
        }

        //--------------------------------------------------------------------
        //  Method:     hasNumeral
        //  Date:       11/28
        //--------------------------------------------------------------------
        public static bool hasNumeral(object input)
        {
            string toTest = input.ToString().ToLower().Trim();
            for (int i = 48; i <= 57; i++)
            {
                if (toTest.Contains((char)i))
                    return true;
            }
            return false;
        }

    }// End class Validation
}// End namespace Project3FamousPhilosophers