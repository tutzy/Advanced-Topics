using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortingNumbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[]numbers=new int[n];
            int nextNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                nextNum = int.Parse(Console.ReadLine());
                numbers[i] = nextNum;
            }
                Array.Sort(numbers);
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }
                
	        }
        }
    }

