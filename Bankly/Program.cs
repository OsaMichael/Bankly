using System;
using System.Collections.Generic;
using System.Linq;

namespace Bankly
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            var sentence = "Michael goes to the stream Michael work at Cyberspace Michael can write C#";

            string[] arr = sentence.Split(' ');

            foreach (string word in arr)
            {
                if (word.Length >= 5) 
                {
                    if (dictionary.ContainsKey(word)) 
                        dictionary[word] = dictionary[word] + 1; 
                    else
                        dictionary[word] = 1;
                }
            }

            foreach (KeyValuePair<string, int> pair in dictionary)
                Console.WriteLine(string.Format("Number: {0}, Occurred: {1}<br />", pair.Key, pair.Value));

            Console.ReadLine();



        }
    }

}
