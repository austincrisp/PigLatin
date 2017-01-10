using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter either a word or a sentence: ");
            string input = Console.ReadLine();

            // Hard Mode Trigger/Requirement
            if (input.Contains(" "))
            {
                string[] words = input.Split(' ');                                         // split the string into individual words and store them in the words array

                foreach (string element in words)                                          // loop through each word and perform the conversion logic
                {
                    // Beginning of English to Pig Latin conversion logic
                    char firstLetter = element[0];                                         // look for the first letter in element (word in the sentence)
                    char secondLetter = element[1];                                        // look for the second letter in element (word in the sentence)
                    string cleanFirst = firstLetter.ToString().ToUpper();                  // change the first character into a string and let it work for lower and uppercase
                    string cleanSecond = secondLetter.ToString().ToUpper();                // change the second character into a string and let it work for lower and uppercase
                    string firstTwoLetters = cleanFirst + cleanSecond;                     // Concatenate the first and second letters together

                    string[] vowel = new string[6] { "A", "E", "I", "O", "U", "Y" };       // storing out the vowels

                    if (vowel.Contains(cleanFirst))                                        // first check - first letter is a vowel
                    {
                        Console.WriteLine($"{element + "way"}");
                    }
                    else if (vowel.Contains(cleanSecond) && !vowel.Contains(cleanFirst))   // second check - first letter is not a vowel and second letter is a vowel
                    {
                        string conVowel = element.Remove(0, 1);                            // remove first letter of the word
                        Console.WriteLine($"{conVowel + cleanFirst + "ay"}");
                    }
                    else if (!vowel.Contains(cleanFirst) && !vowel.Contains(cleanSecond))  // third check - neither the first nor second letter is a vowel
                    {
                        string doubleCon = element.Remove(0, 2);                           // remove first two letters of the word
                        Console.WriteLine($"{doubleCon + firstTwoLetters + "ay"}");
                    }
                    // Ending of English to Pig Latin conversion logic
                }
            }
            // Normal Mode Trigger/Requirement
            else if (!input.Contains(" "))
            {
                // Beginning of English to Pig Latin conversion logic
                char firstLetter = input[0];                                               // look for the first letter in the user input string
                char secondLetter = input[1];                                              // look for the second letter in the user input string
                string cleanFirst = firstLetter.ToString().ToUpper();                      // change the first character into a string and let it work for lower and uppercase
                string cleanSecond = secondLetter.ToString().ToUpper();                    // change the second character into a string and let it work for lower and uppercase
                string firstTwoLetters = cleanFirst + cleanSecond;                         // Concatenate the first and second letters together

                string[] vowel = new string[6] { "A", "E", "I", "O", "U", "Y" };           // storing out the vowels*/

                if (vowel.Contains(cleanFirst))                                            // first check - first letter is a vowel
                {
                    Console.WriteLine($"{input + "way"}");
                }
                else if (vowel.Contains(cleanSecond) && !vowel.Contains(cleanFirst))       // second check - first letter is not a vowel and second letter is a vowel
                {
                    string conVowel = input.Remove(0, 1);                                  // remove first letter of the word
                    Console.WriteLine($"{conVowel + cleanFirst + "ay"}");
                }
                else if (!vowel.Contains(cleanFirst) && !vowel.Contains(cleanSecond))      // third check - neither the first nor second letter is a vowel
                {
                    string doubleCon = input.Remove(0, 2);                                 // remove first two letters of the word
                    Console.WriteLine($"{doubleCon + firstTwoLetters + "ay"}");
                }
                // Ending of English to Pig Latin conversion logic
            }
        }
    }
}
