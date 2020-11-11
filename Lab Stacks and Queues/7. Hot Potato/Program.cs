using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(kids);
            int toss = int.Parse(Console.ReadLine());
            while (queue.Count != 1)
            {
                for (int i = 1; i < toss; i++)
                {
                    string currKid = queue.Dequeue();
                    queue.Enqueue(currKid);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
