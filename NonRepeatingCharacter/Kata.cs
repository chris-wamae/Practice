using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRepeatingCharacter
{
    public class Kata
    {
        public static string FirstNonRepeatingLetter(string s)
        {

            string Tester(char t, char[] charArray)
            {
                string passChar = "";
                //can we avoid this list?

                List<char> charList = new List<char>();

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (Char.ToLower(charArray[i]) == Char.ToLower(t))
                    {
                        charList.Add(charArray[i]);
                    }
                }

                if (charList.Count == 0)
                {
                    passChar = t.ToString();
                };

                return passChar;
            }




            //;

            //void Looper() { }
            //;

            //take the first character
            //compare it to all other characters
            //stop if it is not repeated and return it as a string
            //take second character
            //compare it to all other characters
            //stop if it is not repeated and return it as a string etc...

            string StringSorter(string s, int index)
            {
                char[] allCharacters = s.ToCharArray();
                char test = allCharacters[index];
                char[] remainingCharacters = new char[allCharacters.Length];

                 for(int c = 0;c < allCharacters.Length; c++) 
                { 
                 if(c != index)
                    {
                        remainingCharacters[c] = allCharacters[c];
                    }
                }

                // foreach(char c in remainingCharacters) 
                //{
                //Console.WriteLine($"This is the character {c}");
                
                //}

                 return Tester(test, remainingCharacters);

            }

            string foundString = "";

             for(int i = 0;i < s.Length && foundString == "";i++) 
            {
               foundString =  StringSorter(s, i);
            }

             return foundString;

        }
    }
}
