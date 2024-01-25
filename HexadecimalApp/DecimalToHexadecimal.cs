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

                string Converter(int any)
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

                List<string> HexdecimalCreator(int any)
                {
                    List<int> convertedList = Calculator(Sanitizer(any));

                    List<string> hexaChacacterList = convertedList.Select(i => Converter(i)).ToList();

                    //foreach(string s in  hexaChacacterList)
                    //{
                    //Console.WriteLine(s);
                    //}
                    return hexaChacacterList;
                }

                List<string> hexList = HexdecimalCreator(r);

                hexList.Reverse();

                string reversedString = string.Join("", hexList);

                List<string> hexListTwo = HexdecimalCreator(g);

                hexList.Reverse();

                string reversedStringTwo = string.Join("", hexList);

                List<string> hexListThree = HexdecimalCreator(b);

                hexList.Reverse();

                string reversedStringThree = string.Join("", hexList);

                Console.WriteLine(reversedString + reversedStringTwo + reversedStringThree);

                return reversedString + reversedStringTwo + reversedStringThree;

            }

        }


    }



