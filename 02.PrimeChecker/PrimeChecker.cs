using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            ulong number = ulong.Parse(Console.ReadLine());
            isPrime(number);
        }
        static void isPrime(ulong number)
        {
            bool prime = true;
            double maxDiv = Math.Sqrt(number);
                if (number % 2 == 0 && number!=2)
                {
                    prime = false;
                    Console.WriteLine(prime);
                }
                else if (number == 1)
                {
                    prime = false;
                    Console.WriteLine(prime);
                }
                else
                {
                    for (ulong i = 3; i <= maxDiv; i++)
                    {
                        if (number % i == 0)
                        {
                            prime = false; 
                        }
                    }
                    Console.WriteLine(prime);
                }
            }
        }
    }

