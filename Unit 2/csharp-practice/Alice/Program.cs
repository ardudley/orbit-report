using System;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string saying;
            string input;
            bool containsSearchResult;
            int first;
            int length;
            string newSaying;

            saying = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister " +
                "was reading, but it had no pictures or conversations in it, 'and what is the use of a book,'" +
                " thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Search for a word:");
            input = Console.ReadLine();
            input = input.ToLower();
            containsSearchResult = saying.ToLower().Contains(input);
            Console.WriteLine("Contains word: " + containsSearchResult);

            first = saying.IndexOf(input);
            length = input.Length;
            Console.WriteLine("The word is found at the index of " + first + " and it has a length of " + length + " letters.");

            newSaying = saying.Replace(input, "");
            Console.WriteLine(newSaying);
        }
    }
}
