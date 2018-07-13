using System;
using System.Collections.Generic;

namespace StringCount
{
    public class Program
    {
       public static void Main(string[] args)
        {
                Console.WriteLine("Please enter word of your choice: ");
                var word = Console.ReadLine();
                if (word == null) return;
                var charArray = word.ToCharArray();
                var listofCharacters = new Dictionary<char, int>();

                foreach (var character in charArray)
                {
                    const int count = 1;
                    var charFromWord = '\0';
                    charFromWord = character;
                    if (listofCharacters.ContainsKey(charFromWord))
                    {
                        if (listofCharacters.TryGetValue(charFromWord, out var val))
                        {

                            listofCharacters[charFromWord] = val + 1;
                        }
                    }
                    else
                        listofCharacters.Add(charFromWord, count);
                }

                foreach (var kvp in listofCharacters)
                {
                    Console.WriteLine(kvp.Value == 1 ? "Character: {0}: {1} time" : "Character: {0}: {1} times" , kvp.Key, kvp.Value );

                }
                Console.ReadLine();

            }
        }
}
