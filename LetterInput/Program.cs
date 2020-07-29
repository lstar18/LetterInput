using System;
using System.Linq;


namespace LetterInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type any word!");

            var userWord = Console.ReadLine();
            //takes user input and sets it as and variable
            char[] characterArray = userWord.ToCharArray();
            //takes input and sets it to an array of individual characters
            var endCharArr = characterArray.Select(c => c.ToString()).ToArray();
            //makes copy of array to final result of each iteration of character to
            for (int i = 0; i < characterArray.Length; i++)
            {
                var index = i;
                var character = string.Join("", Enumerable.Repeat(characterArray[i], i + 1));
                endCharArr[i] = FirstLetterCapital(character);
            }
            //loops over each character and prints it into end result array and then use Enurerable and repeat i+1 to increase the amount of time the next letter in the array prints out
            static string FirstLetterCapital(string word)
            {
                if (string.IsNullOrEmpty(word))
                {
                    return string.Empty;
                }
                char[] a = word.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                return new string(a);
            }
            //returns string with capital letter at the beginning
            Console.WriteLine($"Your word iterated is: " + string.Join('-', endCharArr));
        }
    }
}
