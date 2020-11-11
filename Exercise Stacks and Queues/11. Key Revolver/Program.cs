using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int tottalMoney = int.Parse(Console.ReadLine());
            Queue<int> locksQueue = new Queue<int>(locks);
            Stack<int> bulletsStack = new Stack<int>(bullets);
            int counter = 0;
            while (locksQueue.Count > 0 && bulletsStack.Count > 0)
            {
                int currBullet = bulletsStack.Pop();
                if (currBullet <= locksQueue.Peek())
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");

                }
                tottalMoney -= bulletPrice;
                counter++;
                if (counter == barrelSize && bulletsStack.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    counter = 0;
                }
            }
            
            if (locksQueue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
            else
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${tottalMoney}");
            }
        }
    }
}
