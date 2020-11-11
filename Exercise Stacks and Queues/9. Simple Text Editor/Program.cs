using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var text = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                if (command == "1")
                {
                    string appendText = input[1];
                    if (text.Any())
                    {
                        string currText = text.Peek();
                        currText += appendText;
                        text.Push(currText);
                    }
                    else
                    {
                        text.Push(appendText);

                    }
                }
                else if (command == "2")
                {
                    int count = int.Parse(input[1]);
                    if (!text.Any())
                    {
                        continue;
                    }
                    else
                    {
                        string currText = text.Peek();
                       currText = currText.Remove(currText.Length - count, count);
                        text.Push(currText);
                    }
                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]);
                    string currText = text.Peek();
                    Console.WriteLine(currText[index - 1] );
                }
                else if (command == "4")
                {
                    text.Pop();
                }
            }
        }
    }
}
