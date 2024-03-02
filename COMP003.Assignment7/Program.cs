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
            Console.Write("Please enter a letter: ");
            char userChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Please enter a word:");
            string userWord = Console.ReadLine();
            int charCount = CharacterCounter(userChar, userWord);
            Console.WriteLine($"There are '{charCount}' letter '{userChar}' in the word '{userWord}'.");
            SectionSeparator();



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
    }
}