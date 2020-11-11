using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            string command = Console.ReadLine().ToLower();
            while (!command.Contains("end"))
            {
                string[] action = command.Split();
                if (action.Contains("add"))
                {
                    int firstNum = int.Parse(action[1]);
                    int secondNum = int.Parse(action[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (action.Contains("remove"))
                {
                    int count = int.Parse(action[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
