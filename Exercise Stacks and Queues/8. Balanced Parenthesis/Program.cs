using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var queue = new Queue<char>(input);
            if (queue.Count % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            int counter = 0;
            while(queue.Any())
            {
                
                char first = queue.Dequeue();
                char next = queue.Peek();
                if (first == '{')
                {
                    if (next == '}')
                    {
                        queue.Dequeue();
                        counter = 0;
                        continue;
                    }
                    else
                    {
                        queue.Enqueue(first);
                    }
                    
                }
                else if(first == '[')
                {
                    if (next == ']')
                    {
                        queue.Dequeue();
                        counter = 0;
                        continue;
                    }
                    else
                    {
                        queue.Enqueue(first);
                    }
                }
                else if (first == '(')
                {
                    if (next == ')')
                    {
                        queue.Dequeue();
                        counter = 0;
                        continue;
                    }
                    else
                    {
                        queue.Enqueue(first);
                    }
                }
                else
                {
                    queue.Enqueue(first);
                }
                    counter++;
                if (counter == queue.Count)
                {
                    Console.WriteLine("NO");
                    return;
                }

            }
            Console.WriteLine("YES");
        }
    }
}
