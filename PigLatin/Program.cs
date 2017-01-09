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
            Console.WriteLine("Please enter a word: ");
            string word = Console.ReadLine();

            char firstLetter = word[0];
            char secondLetter = word[1];
            string cleanFirst = firstLetter.ToString().ToUpper();
            string cleanSecond = secondLetter.ToString().ToUpper();
            string firstTwoLetters = cleanFirst + cleanSecond;

            string[] vowel = new string[6] { "A", "E", "I", "O", "U", "Y" };

            if (vowel.Contains(cleanFirst))
            {
                Console.WriteLine($"{word + "way"}");
            }
            else if (vowel.Contains(cleanSecond) && !vowel.Contains(cleanFirst))
            {
                string conVowel = word.Remove(0, 1);
                Console.WriteLine($"{conVowel + cleanFirst + "ay"}");
            }
            else if (!vowel.Contains(cleanFirst) && !vowel.Contains(cleanSecond))
            {
                string doubleCon = word.Remove(0, 2);
                Console.WriteLine($"{doubleCon + firstTwoLetters + "ay"}");
            }
            

            /*foreach (string element in vowel)
            {
                if (vowel.Contains(element))
                {
                    Console.WriteLine($"{word + "way"}");
                }
            }*/

            /*for (int i = 0; i < vowel.Length; i++)
            {
                if (cleanFirst != vowel[i] && cleanSecond == vowel[i])
                {
                    string conVowel = word.Remove(0, 1);
                    Console.WriteLine($"{conVowel+cleanFirst+"ay"}");
                    break;
                }
                else if (cleanFirst != vowel[i] && cleanSecond != vowel[i])
                {
                    string doubleCon = word.Remove(0, 2);
                    Console.WriteLine($"{doubleCon+firstTwoLetters+"ay"}");
                    break;
                }
                else if (cleanFirst == vowel[i])
                {
                    Console.WriteLine($"{word+"way"}");
                    break;
                }
            }*/

            /*char first = word[0];
            char second = word[1];
            string cleanFirst = first.ToString().ToUpper();
            string cleanSecond = second.ToString().ToUpper();*/

            //string firstTwoLetters = first.ToString() + second.ToString();

            /*if (cleanFirst == "A" ||
                cleanFirst == "E" ||
                cleanFirst == "I" ||
                cleanFirst == "O" ||
                cleanFirst == "U" ||
                cleanFirst == "Y")
            {
                Console.WriteLine($"{word+"way"}");
            }*/
        }
    }
}
