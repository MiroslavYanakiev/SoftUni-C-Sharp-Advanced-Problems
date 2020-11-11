using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversed = new Stack<char>(input);
            while (reversed.Count > 0)
            {
                var currChar = reversed.Pop();
                Console.Write(currChar);
            }
        }
    }
}
