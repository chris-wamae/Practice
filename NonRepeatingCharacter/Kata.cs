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
            string st = s.ToLower();
            int length = s.Length;
            string resultString = "";
            bool hasRun = false;
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();

            for (int i = 0; i < length; i++)
            {
                charDictionary[st[i]] = 0;
            }

            for (int i = 0; i < length; i++)
            {
               charDictionary[st[i]] += 1;
            }

            for (int i = 0; i < length; i++)
            {
            if (charDictionary[st[i]] == 1 && !hasRun)
                {
                        resultString = s[i].ToString();
                        hasRun = true;
                }
            }

            return resultString;
        }
    }

}




