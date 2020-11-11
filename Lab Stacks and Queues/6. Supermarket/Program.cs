using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            while (input != "End")
            {
                if (input != "Paid")
                {
                    queue.Enqueue(input);

                }
                else
                {
                    Console.WriteLine(string.Join(Environment.NewLine,queue));
                    queue.Clear();
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
