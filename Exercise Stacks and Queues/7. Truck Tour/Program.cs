using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var startQueue = new Queue<int>();


            int index = 0;
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                startQueue.Enqueue(input[0] - input[1]);
            }
            for (int i = 0; i < n; i++)
            {
                var testQueue = new Queue<int>(startQueue);
                if (testQueue.Peek() >= 0)
                {
                    index = i;
                    int check = 0;
                    for (int j = 0; j < n; j++)
                    {
                        check += testQueue.Dequeue();
                        if (check < 0)
                        {
                            break;
                        }
                    }
                    if (check >= 0)
                    {
                        Console.WriteLine(index);
                        return;
                    }
                    else
                    {
                        int currPump = startQueue.Peek();
                        startQueue.Dequeue();
                        startQueue.Enqueue(currPump);

                    }
                }
                else
                {
                    int currPump = startQueue.Peek();
                    startQueue.Dequeue();
                    startQueue.Enqueue(currPump);
                }
            }
        }
    }
}
