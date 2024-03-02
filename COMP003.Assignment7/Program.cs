/*
 * Author: Oscar Mendez
 * Course: COMP-003A
 * Purpose: To replicate the outcome for the assignment
 */

namespace COMP003.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array CharacterCounter Section
            SectionSeparator();
            Console.WriteLine("Array - CharacterCounter Section");
            SectionSeparator();
            Console.WriteLine("Please enter a letter: ");
            char userChar = Convert.ToChar(Console.ReadLine());
            Console.Write("");
            Console.WriteLine("Please enter a word: ");
            string userWord = Console.ReadLine();
            Console.Write("");
            int charCount = CharacterCounter(userChar, userWord);
            Console.WriteLine($"There are '{charCount}' letter '{userChar}' in the word '{userWord}'.");

            // Array IsPalindrome Section
            SectionSeparator();
            Console.WriteLine("Array - IsPalindrome Section");
            SectionSeparator();
            Console.WriteLine("");
            Console.WriteLine("PLease enter a word to check if it is a palindrom");
            Console.Write("");
            string palindromeInput = Console.ReadLine();
            bool isPalindrome = IsPalindrome(palindromeInput);
            Console.WriteLine($"Is the word {palindromeInput} palindrome: {isPalindrome}");
            

            // List - Add Section



        }

        static void SectionSeparator()
        {
            Console.WriteLine("".PadRight(50,'*'));
        }

        static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();

            foreach (char c in word)
            {
                if (c == characterInput)
                {
                    count++;
                }
            }
            return count;
        }

        static bool IsPalindrome(string word)
        {
            string reversedWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            return word.ToLower() == reversedWord.ToLower();
        }
    }
}