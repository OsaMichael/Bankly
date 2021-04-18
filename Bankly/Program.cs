using System;
using System.Linq;

namespace Bankly
{
    class Program
    {
        static void Main(string[] args)
        {

            var sentence = "Michael goes to the stream Michael work at Cyberspace Michael can write C#";


            var results = sentence.Split(' ').Where(x => x.Length > 5)
                              .GroupBy(x => x)
                              .Select(x => new { Count = x.Count(), Word = x.Key })
                              .OrderByDescending(x => x.Count);

            foreach (var item in results)
       
            Console.WriteLine(String.Format("{0} occured {1} times", item.Word, item.Count));

            Console.ReadLine();

        }
    }
}
