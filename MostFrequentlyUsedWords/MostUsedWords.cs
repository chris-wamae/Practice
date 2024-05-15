using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MostFrequentlyUsedWords
{
    internal class MostUsedWords
    {
        public static List<string> MostUsedWordsFinder(string text)
        {
            //takes a string
            //finds the number of times each word has been used
            //returns the top three in descending order and in lowercase in an array

            //alphabetic sequences can contain apostrophes and still be considered the same word
            //the casing of words is ignored when matching


            //loop through each character in the string
            //store the index of the first character
            //when a whitespace is detected, store the indexes of all the characters before it
            //to the start(if it is the first word) / to the previous whitespace
            //look for another whitespace
            //check if the characters after it match the word
            //etc upto the end
            //if some are found, store the word in a list and the number of occurrences as current count variable
            //when adding a new word to the list, check the current count variable to decide its position on the list and whether to add it
            //go to the index of the first whitespace and repeat the process
            //if none are found, go to the index of the first whitespace and repeat the process


            Dictionary<string, int> textWords = new Dictionary<string, int>() { };

            var ordered = textWords.OrderByDescending(x => x.Value);
            int wordStartIndex = 0;
            int wordEndIndex = 0;

            for (int x = 0; x < text.Length; x++)
            {   
                text = Regex.Replace(text.Replace("'", ""), @"[^\w\s]"," ");

                if (Char.IsWhiteSpace(text[x]) || x + 1 == text.Length )
                {
                    wordEndIndex = x;

                    string foundWord = text.Substring(
                        wordStartIndex,
                        wordEndIndex - wordStartIndex + 1
                    );
                    if (textWords.ContainsKey(foundWord))
                    {
                        textWords[foundWord] += 1;
                    }
                    else
                    {
                        textWords[foundWord] = 1;
                    }
                    wordStartIndex = wordEndIndex + 1;
                }
            }

            foreach (var word in ordered)
            {
                Console.WriteLine(word.Key);
            }

            return new List<string>();
            // return new List<string>() {textWords.ElementAt(0).Key,textWords.ElementAt(1).Key,textWords.ElementAt(2).Key};
        }
    }
}
