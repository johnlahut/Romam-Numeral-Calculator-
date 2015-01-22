/*
 *Author: John Lahut
 *Date: 2/23/2014
 *Project: Roman Numeral 
 *Filename: RomanClass
 *Purpose: To add and subtract roman numerals. Validates roman numbers. Converts roman numerals to a decimal value, and vise versa.
 *I/O: Output and input taken through frmMain.cs
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//*********************************************************************************************************************************************************************************
//                               ===DESCRIPTION OF METHODS===
//
//                                 ---PRIVATE METHODS---
//
// string [] FillRomanArr(string) - returns an array with size of the given string; each element in the array contains one letter
// bool IsRomanRepeated(string[]) - determines if the given string array (roman numeral represented as an array)  has a number repeated more than three times
// bool IsValidRomanCharacters(string[]) - determines if the given string array contains valid roman numeral characters
// decimal[] ConvertRomanArrToDecimalArr(string[]) - obtains an array of decimal values that are equivalent to the given roman numeral array
// void PrintRomanArray(string[]) - prints the array to the console in the format [element n] [element n+1]...[element array.length-1]
// void PrintDecimalArray(decimal[]) - prints the array to the console in the format [element n] [element n+1]...[element array.length-1]
//         
//                                 ---PUBLIC METHODS---
// bool IsValidRomanNumeral(string) - determines if the given string is a valid string of roman numerals
//
//*********************************************************************************************************************************************************************************


namespace Roman_Numeral
{
    class RomanClass
    {
        //PDM roman stores the value of the class's roman numeral
        private string roman = "";

        public const string ROMAN_ONE = "I";
        public const string ROMAN_FIVE = "V";
        public const string ROMAN_TEN = "X";
        public const string ROMAN_FIFTY = "L";
        public const string ROMAN_HUNDRED = "C";
        public const string ROMAN_FIVE_HUNDRED = "D";
        public const string ROMAN_THOUSAND = "M";

        public const decimal ONE = 1m;
        public const decimal FIVE = 5m;
        public const decimal TEN = 10m;
        public const decimal FIFTY = 50m;
        public const decimal HUNDRED = 100m;
        public const decimal FIVE_HUNDRED = 500m;
        public const decimal THOUSAND = 1000m;

        public const decimal VALID_SUBTRACT_VALUE = 0.1m;

        public RomanClass(string romanNumeral)
        {
            if (!IsValidRomanNum(romanNumeral))
            { throw new InvalidProgramException("Please enter a valid roman numeral, 0 < val < 4000"); }
            roman = romanNumeral;
        }


        //************************************************************/Private Methods/***********************************************************************

        //Pre: RomanClass is instantiated
        //Post: Given a string, returns the string in an array form
        //Purpose: To return  an array with size of the given string; each element in the array contains one letter
        private string[] FillRomanArr(string strNum)
        {
            string[] romanArr = new string[strNum.Length];
            for (int i = 0; i < strNum.Length; i++)
            {
                romanArr[i] = strNum.Substring(i, 1);
            }
            return romanArr;
        } //end FillRomanArr

        //Pre: RomanClass is instantiated
        //Post: Given an integer, returns the integer in an array form
        //Purpose: To return  an array with size of the given decimal; each element in the array contains one single-digit number
        private decimal[] FillDecArr(decimal decNum)
        {
            string strNum = Convert.ToString(decNum);
            string[] strArr = FillRomanArr(strNum);
            decimal[] decArr = new decimal[strNum.Length];
            for (int i = 0; i < strNum.Length; i++)
            {
                decArr[i] = Convert.ToDecimal(strArr[i]);
            }
            return decArr;
        } //end FillDecArr


        //Pre: RomanClass is instantiated , strArr is a valid array of strings
        //Post: Returns a boolean representing if the given roman numeral has a character repeated more than three times in a row
        //Purpose: To determine if the given string array (roman numeral represented as an array)  has a number repeated more than three times
        private bool IsRomanRepeated(string[] strArr)
        {
            if (strArr.Length == 3)
            { return false; }
            for (int i = 0; i < strArr.Length; i++)
            {
                if (i + 3 >= strArr.Length)
                { break; }
                if (strArr[i] == strArr[i + 1] && strArr[i + 1] == strArr[i + 2] && strArr[i + 2] == strArr[i + 3])
                { return true; }
            }
            return false;
        } //end IsRomanRepeated

        //Pre: RomanClass is instantiated, strArr is a valid array of strings
        //Post: Returns a boolean representing if the given string array contains valid roman numeral characters
        //Purpose: To determine if the given string array contains valid roman numeral characters
        private bool IsValidRomanCharacters(string[] strArr)
        {
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i] != ROMAN_ONE &&
                    strArr[i] != ROMAN_FIVE &&
                    strArr[i] != ROMAN_TEN &&
                    strArr[i] != ROMAN_FIFTY &&
                    strArr[i] != ROMAN_HUNDRED &&
                    strArr[i] != ROMAN_FIVE_HUNDRED &&
                    strArr[i] != ROMAN_THOUSAND)
                { return false; }
            }

            return true;
        } //end IsValidRomanCharacters

        //Pre: RomanClass is instantiated, romanArr is a valid array containing valid roman numeral characters
        //Post: Returns a decimal array that contains the decimal equivalent to the roman numeral
        //Purpose: To obtain an array of decimal values that are equivalent to the given roman numeral array
        private decimal[] ConvertRomanArrToDecimalArr(string[] romanArr)
        {
            decimal[] decArr = new decimal[romanArr.Length];
            for (int i = 0; i < decArr.Length; i++)
            {
                if (romanArr[i] == ROMAN_ONE)
                { decArr[i] = ONE; }
                else if (romanArr[i] == ROMAN_FIVE)
                { decArr[i] = FIVE; }
                else if (romanArr[i] == ROMAN_TEN)
                { decArr[i] = TEN; }
                else if (romanArr[i] == ROMAN_FIFTY)
                { decArr[i] = FIFTY; }
                else if (romanArr[i] == ROMAN_HUNDRED)
                { decArr[i] = HUNDRED; }
                else if (romanArr[i] == ROMAN_FIVE_HUNDRED)
                { decArr[i] = FIVE_HUNDRED; }
                else if (romanArr[i] == ROMAN_THOUSAND)
                { decArr[i] = THOUSAND; }
            }
            return decArr;
        } //End ConvertRomanArrToDecimalArr

        //Pre: RomanClass is instantiated
        //Post: Returns a boolean value representing if it is a valid roman numeral subtraction
        //Purpose: To determine if the two given numbers can be subtracted
        //***RULE*** A roman numeral can only be subtracted IFF the smaller digit is equal or greater than 1/10 of the larger digit
        private bool IsValidSubtraction(decimal larger, decimal smaller)
        {
            if (smaller / larger < VALID_SUBTRACT_VALUE)
            {
                return false;
            }
            return true;
        } //End IsValidSubtraction

        //Pre: RomanClass is instantiated, number is a valid decimal from 0-9
        //Post: Returns a string representing the roman value of that number in the thousands place
        //Purpose: To return a string value representing the romal value for a given decimal in the thousands place
        private string GenerateThousand(decimal number)
        {
            roman = "";
            int counter = Convert.ToInt16(number);
            while (counter > 0)
            {
                roman += ROMAN_THOUSAND;
                counter--;
            }

            return roman;
        } //end GenerateThousand


        //Pre: RomanClass is instantiated, number is a valid decimal from 0-9
        //Post: Returns a string representing the roman value of that number in the hundreds place
        //Purpose: To return a string value representing the romal value for a given decimal in the hundreds place
        private string GenerateHundred(decimal number)
        {
            int counter = Convert.ToInt16(number);
            if (number == 0)
            { return ""; }
            else if (number < 4)
            {
                while (counter > 0)
                {
                    roman += ROMAN_HUNDRED;
                    counter--;
                } return roman;
            }
            else if (number == 4)
            { return roman += ROMAN_HUNDRED + ROMAN_FIVE_HUNDRED; }
            else if (number == 5)
            { return roman += ROMAN_FIVE_HUNDRED; }
            else if (number < 9)
            {
                roman += ROMAN_FIVE_HUNDRED;
                while (counter - 5 > 0)
                {
                    roman += ROMAN_HUNDRED;
                    counter--;
                } return roman;
            }
            else
            { return roman += ROMAN_HUNDRED + ROMAN_THOUSAND; }
        }// end GenerateHundred


        //Pre: RomanClass is instantiated, number is a valid decimal from 0-9
        //Post: Returns a string representing the roman value of that number in the tens place
        //Purpose: To return a string value representing the romal value for a given decimal in the tens place
        private string GenerateTen(decimal number)
        {
            int counter = Convert.ToInt16(number);
            if (number == 0)
            { return ""; }
            else if (number < 4)
            {
                while (counter > 0)
                {
                    roman += ROMAN_TEN;
                    counter--;
                } return roman;
            }
            else if (number == 4)
            { return roman += ROMAN_TEN + ROMAN_FIFTY; }
            else if (number == 5)
            { return roman += ROMAN_FIFTY; }
            else if (number < 9)
            {
                roman += ROMAN_FIFTY;
                while (counter - 5 > 0)
                {
                    roman += ROMAN_TEN;
                    counter--;
                } return roman;
            }
            else
            { return roman += ROMAN_TEN + ROMAN_HUNDRED; }
        } //end GenerateTen

        //Pre: RomanClass is instantiated, number is a valid decimal from 0-9
        //Post: Returns a string representing the roman value of that number in the ones place
        //Purpose: To return a string value representing the romal value for a given decimal in the ones place
        private string GenerateOne(decimal number)
        {
            int counter = Convert.ToInt16(number);
            if (number == 0)
            { return ""; }
            else if (number < 4)
            {
                while (counter > 0)
                {
                    roman += ROMAN_ONE;
                    counter--;
                } return roman;
            }
            else if (number == 4)
            { return roman += ROMAN_ONE + ROMAN_FIVE; }
            else if (number == 5)
            { return roman += ROMAN_FIVE; }
            else if (number < 9)
            {
                roman += ROMAN_FIVE;
                while (counter - 5 > 0)
                {
                    roman += ROMAN_ONE;
                    counter--;
                } return roman;
            }
            else
            { return roman += ROMAN_ONE + ROMAN_TEN; }
        } //end GenerateOne



        //Pre: RomanClass is instantiated, strArr is a valid string array
        //Post: Outputs the contents of the array to the console
        //Purpose: To print the array to the console in the format [element n] [element n+1]...[element array.length-1]
        private void PrintRomanArray(string[] strArr)
        {
            for (int i = 0; i < strArr.Length; i++)
            { Console.Write("[" + strArr[i] + "] "); }
            Console.WriteLine();
        } //end PrintRomanArray


        //Pre: RomanClass is instantiated, decArr is a valid decimal array
        //Post: Outputs the contents of the array to the console
        //Purpose: To print the array to the console in the format [element n] [element n+1]...[element array.length-1]
        private void PrintDecArray(decimal[] intArr)
        {
            for (int i = 0; i < intArr.Length; i++)
            { Console.Write("[" + intArr[i].ToString() + "] "); }
            Console.WriteLine();
        } //end PrintDecimalArray


        //Post: Returns a boolean reflecting if the PDM roman is zero, which I am representing as a null string, or ""
        //Purpose: To determine if a roman numeral is nullus=null=""
        private bool IsZero()
        {
            if (roman == "")
            { return true; }
            return false;
        } //end IsZero

        //************************************************************/End Private Methods/***********************************************************************


        //************************************************************/Public Methods/****************************************************************************


        //Pre: RomanClass is instantiated
        //Post: Given a string, returns a boolean reflecting if the given string is a valid roman numeral entry
        //Purpose: To determine if a given string is a valid roman numeral entry
        public bool IsValidRomanNum(string strNum)
        {
            if (strNum == "Nullus")
            { return true; }
            string[] romanArr = FillRomanArr(strNum);
            //PrintRomanArray(romanArr);
            if (IsRomanRepeated(romanArr))
            { return false; }
            else if (!IsValidRomanCharacters(romanArr))
            { return false; }

            return true;
        }//end IsValidRomanNum


        //Pre: leftOp and rightOp are valid RomanClasses
        //Post: Returns a new RomanClass with its PDM roman set to the new value. **EXCEPT WHEN:**
        //      if either of the given RomanClasses are zero, it returns the one that has a value
        //      if both the given RomanClasses are zero, returns a null value
        //      if the sum is greater than 3999, returns a null value
        //Purpose: Override the default '+' operator to add two RomanClasses
        public static RomanClass operator +(RomanClass leftOp, RomanClass rightOp)
        {
            int leftRoman = leftOp.ConvertToDecimal();
            int rightRoman = rightOp.ConvertToDecimal();

            if (leftOp.IsZero())
            { return rightOp; }

            else if (rightOp.IsZero())
            { return leftOp; }

            if (leftRoman == 0 || rightRoman == 0)
            { return null; }

            int total = leftRoman + rightRoman;

            if (total > 3999)
            { return null; }

            return new RomanClass(leftOp.SetString(total));
        }// end '+' override

        //Pre: leftOp and rightOp are valid RomanClasses
        //Post: Returns a new RomanClass with its PDM roman set to the new value. Will always return a positive number, regardless of order. **EXCEPT WHEN:**
        //      if either of the given RomanClasses are zero, it returns the one that has a value
        //      if both the given RomanClasses are zero, returns a null value
        //      if both the given RomanClasses are equivalent, retuns nullus, or ""
        //Purpose: Override the default '-' operator to subtract two RomanClasses
        public static RomanClass operator -(RomanClass leftOp, RomanClass rightOp)
        {
            if (leftOp.IsZero())
            { return rightOp; }

            else if (rightOp.IsZero())
            { return leftOp; }

            int leftRoman = leftOp.ConvertToDecimal();
            int rightRoman = rightOp.ConvertToDecimal();

            if (leftRoman == rightRoman)
            { return new RomanClass(""); }
            else if (leftRoman > rightRoman)
            {
                return new RomanClass(leftOp.SetString(leftRoman - rightRoman));
            }
            else
            { return new RomanClass(leftOp.SetString(rightRoman - leftRoman)); }
        } //end '-' override

        //Pre: leftOp and rightOp are valid RomanClasses
        //Post: returns a true iff left > right
        //Purpose: To override the default '>' operator to comapre two RomanClasses
        public static bool operator >(RomanClass leftOp, RomanClass rightOp)
        {
            if (leftOp.ConvertToDecimal() > rightOp.ConvertToDecimal())
            { return true; }
            else
            { return false; }
        } //end '>' override

        //Pre: leftOp and rightOp are valid RomanClasses
        //Post: returns a true iff left < right
        //Purpose: To overload the default '<' operator to comapre two RomanClasses
        public static bool operator <(RomanClass leftOp, RomanClass rightOp)
        {
            if (leftOp.ConvertToDecimal() < rightOp.ConvertToDecimal())
            { return true; }
            else
            { return false; }
        } //end '<' override


        //Pre: RomanClass is instantiated
        //Post: Given a integer, base10num, returns the PDM roman, which is the roman numeral value of the given integer
        //Purpose: To return the updated value of the PDM roman
        public string SetString(decimal base10Num)
        {
            roman = "";
            if (base10Num > 3999 || base10Num < 0)
            { return null; }
            decimal[] base10Arr = FillDecArr(base10Num);
            if (base10Arr.Length == 4)
            {
                GenerateThousand(base10Arr[0]);
                GenerateHundred(base10Arr[1]);
                GenerateTen(base10Arr[2]);
                GenerateOne(base10Arr[3]);
            }
            else if (base10Arr.Length == 3)
            {
                GenerateHundred(base10Arr[0]);
                GenerateTen(base10Arr[1]);
                GenerateOne(base10Arr[2]);
            }
            else if (base10Arr.Length == 2)
            {
                GenerateTen(base10Arr[0]);
                GenerateOne(base10Arr[1]);
            }
            else
            { GenerateOne(base10Arr[0]); }

            if (roman == "")
            { return null; }
            return roman;
        } //end SetStrng


        //Pre: RomanClass is instantiated
        //Post: Returns a integer value of the roman PDM
        //Purpose: To convert the PDM roman to a base 10 integer value
        public int ConvertToDecimal()
        {
            decimal val = 0m;
            string[] romanArr = FillRomanArr(roman);
            decimal[] decArr = ConvertRomanArrToDecimalArr(romanArr);

            //PrintDecArray(decArr);
            //PrintRomanArray(romanArr);
            if (decArr.Length == 1)
            { val = decArr[0]; }

            else
            {
                for (int i = 0; i < decArr.Length; i++)
                {
                    if (i + 1 >= decArr.Length)
                    { val += decArr[i]; }

                    else if (decArr[i + 1] > decArr[i])
                    {
                        if (!IsValidSubtraction(decArr[i + 1], decArr[i]))
                        { return -1; }
                        val += (decArr[i + 1] - decArr[i]);
                        i++;
                    }
                    else
                    { val += decArr[i]; }
                }
            }

            //This check is to make sure that the roman number entered is not adding and subtracting from the same value. I.E. VLV is not 50, L is.
            string tempRoman = roman;
            roman = "";
            string temp = SetString(val);
            if (tempRoman != roman)
            {
                roman = tempRoman;
                return -1;
            }
            return Convert.ToInt16(val);
        }// end ConvertToDecimal


        //OVERRIDE TOSTRING()
        //
        //Post: Returns the string 'zero' if the RomanClass's PDM roman is "" or null, if not returns the string PDM roman
        //Purpose: So we can print the value of the RomanClass
        public override string ToString()
        {
            if (roman == null || roman == "")
            { return "Nullus"; }
            return roman;
        } //end override ToString

    }//end RomanClass

}//end namespace
