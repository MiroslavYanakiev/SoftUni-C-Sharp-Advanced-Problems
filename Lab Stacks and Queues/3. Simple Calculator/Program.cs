using System;
using System.Collections;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Array.Reverse(input);
            var stack = new Stack<string>(input);
            while (stack.Count > 1)
            {
                int fisrtNum = int.Parse(stack.Pop());
                string action = stack.Pop();
                int secondNum = int.Parse(stack.Pop());
                if (action == "+")
                {
                    stack.Push((fisrtNum + secondNum).ToString());
                }
                else
                {
                    stack.Push((fisrtNum - secondNum).ToString());
                }
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
