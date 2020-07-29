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

            //Console.WriteLine($"{userWord}");

            char[] characterArray = userWord.ToCharArray();

            var endCharArr = characterArray.Select(c => c.ToString()).ToArray();
            for (int i = 0; i < characterArray.Length; i++)
            {
                var index = i;
                var character = string.Join("", Enumerable.Repeat(characterArray[i], i + 1));
                endCharArr[i] = FirstLetterCapital(character);
            }

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
            Console.WriteLine($"Your word iterated is: " + string.Join('-', endCharArr));
        }
    }
}
