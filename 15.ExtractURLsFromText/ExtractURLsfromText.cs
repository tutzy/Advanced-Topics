using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ExtractURLsFromText
{
    class ExtractURLsfromText
    {
        static void Main()
        {
            
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

           
            string http = "http://";
            string www = "www.";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(http) || words[i].Contains(www))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}