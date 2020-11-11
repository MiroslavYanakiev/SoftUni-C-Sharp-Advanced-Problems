using System;
using System.Collections.Generic;
using System.Text;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            var queue = new Queue<string>(input);
            while (queue.Count > 0)
            {
                string[] command = Console.ReadLine().Split();
                
                string action = command[0];
                if (action == "Play")
                {
                    queue.Dequeue();
                }
                else if (action == "Add")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < command.Length; i++)
                    {
                        sb.Append(command[i] + " ");
                    }
                    if (!queue.Contains(sb.ToString().Trim()))
                    {
                        queue.Enqueue(sb.ToString().Trim());
                    }
                    else
                    {
                        Console.WriteLine($"{sb.ToString().Trim()} is already contained!");
                    }
                }
                else if (action == "Show")
                {
                    Console.WriteLine(string.Join(", ",queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
