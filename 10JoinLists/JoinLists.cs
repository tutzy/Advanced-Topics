﻿using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string firstLine = Console.ReadLine();
        string secondLine = Console.ReadLine();

        string[] firstLineNums = firstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] secondLineNums = secondLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<int> mainList = new List<int>();
        List<int> auxiliaryList = new List<int>();

        for (int i = 0; i < firstLineNums.Length; i++)
        {
            auxiliaryList.Add(int.Parse(firstLineNums[i]));
        }
        for (int j = 0; j < secondLineNums.Length; j++)
        {
            auxiliaryList.Add(int.Parse(secondLineNums[j]));
        }

        mainList = auxiliaryList.Distinct().ToList();

        mainList.Sort();

        foreach (var number in mainList)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}