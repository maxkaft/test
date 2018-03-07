using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Split_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> numbers = Console.ReadLine()
                .Split('|').Reverse().
                Select(s => s.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList()).ToList();

            //I MADE THIS CHANGE


            Console.WriteLine(string.Join(" ", number));
            
                           
        }
    }
}
