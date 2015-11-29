using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine();
            var secondLine = Console.ReadLine();
            List<string> firstList=new List<string>(firstLine.Split());
            List<string> secondList = new List<string>(secondLine.Split());
            foreach (var item in secondList)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    if(item==firstList[i])
                    {
                        firstList.RemoveAt(i);
                        i--;
                    }
                }                
            }
            foreach (var item in firstList)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
