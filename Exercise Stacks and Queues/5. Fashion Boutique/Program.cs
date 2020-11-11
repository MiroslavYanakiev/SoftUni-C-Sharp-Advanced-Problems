using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int sum = 0;
            while (stack.Count > 0)
            {
                if(sum + stack.Peek() <= capacity)
                {
                    sum += stack.Pop();
                }
                else
                {
                    racks++;
                    sum = 0;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
