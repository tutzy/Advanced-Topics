using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main()
        {
            // Input
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = Console.ReadLine();
            }

            // Main Logic
            int maxSequence = 0;
            string value = null;

            for (int i = 0; i < array.Length; i++)
            {
                int countSequence = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        countSequence++;
                        if (maxSequence < countSequence)
                        {
                            maxSequence = countSequence;
                            value = array[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("{0}", maxSequence);
            for (int i = 0; i < maxSequence; i++)
            {
                Console.WriteLine(value);
            }
            
        }
    }
}