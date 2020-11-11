using System;
using System.Collections.Generic;
using System.Linq;
namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> cupsQueue = new Queue<int>(cups);
            Stack<int> bottlesStack = new Stack<int>(bottles);
            int wastedWater = 0;
            while (cupsQueue.Count > 0 && bottlesStack.Count > 0)
            {
                int cup = cupsQueue.Peek();
                while (cup > 0)
                {
                    
                    int currBottle = bottlesStack.Pop();
                    if (currBottle < cup)
                    {
                        cup -= currBottle;
                    }
                    else
                    {
                        wastedWater += currBottle - cup;
                        cup -= currBottle;
                        cupsQueue.Dequeue();
                        
                    }
                }
            }
            if (cupsQueue.Count <= 0)
            {
                Console.Write("Bottles: ");
                Console.WriteLine(string.Join(" ",bottlesStack));
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.Write("Cups: ");
                Console.WriteLine(string.Join(" ",cupsQueue));
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
