using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            List<int> evenNums = new List<int>();
            while (queue.Count > 0)
            {
                int currNum = queue.Dequeue();
                if (currNum % 2 == 0)
                {
                    evenNums.Add(currNum);
                }
            }
            Console.WriteLine(string.Join(", ",evenNums));
        }
    }
}
