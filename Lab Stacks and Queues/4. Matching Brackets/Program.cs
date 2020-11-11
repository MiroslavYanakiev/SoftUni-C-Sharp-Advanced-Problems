using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (currChar == '(')
                {
                    stack.Push(i);
                }
                else if (currChar == ')')
                {
                    int endIndex = i;
                   int startIndex = stack.Pop();
                    string substring = input.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
