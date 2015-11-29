using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int row = 0;
            int col = 0;
            char letter = 'a';

            for (int i = 0; i < arr.Length; i++)
            {
                row = int.Parse(arr[0]);
                col = int.Parse(arr[1]);
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    char nextLetter = Convert.ToChar(letter + j);
                    Console.Write("{0}{1}{0}\t", letter, nextLetter);
                    if (3 * row > col * row)
                    {
                        Console.WriteLine();
                    }
                }
                letter++;
                Console.WriteLine();
            }
        }
    }
}
