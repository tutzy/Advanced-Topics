using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _04.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Parse(Console.ReadLine());
            DateTime end = DateTime.Parse(Console.ReadLine());
            int sum = (end-start).Days;
            Console.WriteLine(sum);
        }
    }
}
