using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    public class DecimalToHexadecimalConverter
    {
        public static string Rgb(int r, int g, int b)
        {   
            //checks if the argument is out of bounds (0-255) and returns it as whichever its closest to
            int Sanitizer(int any)
            {
                if (any > 255)
                {
                    return 255;
                }
                else if (any < 0)
                {
                    return 0;
                }
                else
                    return any;
            }

            //converts decimals with letter representations in hexadecimals to the respective letter
            //it also converts 0 into a string of two zeros to satisfy the minimum hexadecimal length required
            string ConverterForSingleZero(int any)
            {
                Dictionary<int, string> dictionary = new Dictionary<int, string>()
        {
            { 0, "00" },
            { 10, "A" },
            { 11, "B" },
            { 12, "C" },
            { 13, "D" },
            { 14, "E" },
            { 15, "F" },
        };

                return dictionary.ContainsKey(any) ? dictionary[any] : any.ToString();
            }


            ////converts decimals with letter representations in hexadecimals to the respective letter
            //this method does not double the zeros if provided with a single one
            string ConverterForJoinedZero(int any)
            {
                Dictionary<int, string> dictionary = new Dictionary<int, string>()
        {
            { 10, "A" },
            { 11, "B" },
            { 12, "C" },
            { 13, "D" },
            { 14, "E" },
            { 15, "F" },
        };

                return dictionary.ContainsKey(any) ? dictionary[any] : any.ToString();
            }

            //perfoms arithmetic for converting decimals to hexadecimals 

            List<int> Calculator(int any)
            {
                List<int> rawHexNumbers = new List<int>();

                while ((any / 16) != 0)
                {
                    rawHexNumbers.Add(any % 16);
                    any = (any / 16);
                }
                if ((any / 16) == 0)
                {
                    rawHexNumbers.Add(any % 16);
                }

                return rawHexNumbers;
            }

            //converts a single decimal number into a hexadecimal by ultizing the above methods
            //it also checks whether the zeros inputted are isolated or part of another number to determine whether 
            //the should be doubled

            List<string> HexdecimalCreator(int any)
            {
                List<int> convertedList = Calculator(Sanitizer(any));

                if (convertedList.Count == 1)
                {
                    return convertedList.Select(i => ConverterForSingleZero(i)).ToList();
                }
                else
                {
                    return convertedList.Select(i => ConverterForJoinedZero(i)).ToList();
                }
            }

            List<string> hexList = HexdecimalCreator(r);

            hexList.Reverse();

            string reversedString = string.Join("", hexList);

            List<string> hexListTwo = HexdecimalCreator(g);

            hexListTwo.Reverse();

            string reversedStringTwo = string.Join("", hexListTwo);

            List<string> hexListThree = HexdecimalCreator(b);

            hexListThree.Reverse();

            string reversedStringThree = string.Join("", hexListThree);

            //checks if a converted letter/digit is isolated and prefixes a zero to it
            string SingleLetterCheck(string str)
            {
                if (str.Length == 1)
                {

                    string newStr = $"0{str}";
                    return newStr;
                }
                else
                {

                    return str;
                }
            }


            return SingleLetterCheck(reversedString)
                + SingleLetterCheck(reversedStringTwo)
                + SingleLetterCheck(reversedStringThree);
        }
    }
}
