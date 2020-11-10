using System;
using System.Collections.Generic;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            //Step 1: Break string into characters  

            string myString = "angela renee dudley";
            //int numCount = 1;
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            char[] charactersInString = myString.ToCharArray();

            foreach (char x in charactersInString)
            {
                if (characterCount.ContainsKey(x) == false) {
                    characterCount.Add(x, 1);
                } else
                {
                characterCount[x]++;

                }
            }
            



            foreach (var count in characterCount)
            {
                Console.WriteLine(count.Key + " = " + count.Value.ToString());
            }

           


            //Step 2: Loop through 

           

        }
    }
}
