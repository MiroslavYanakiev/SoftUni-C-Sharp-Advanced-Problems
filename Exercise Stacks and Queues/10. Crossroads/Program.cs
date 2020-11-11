using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int counter = 0;
            string input = Console.ReadLine();
            while (!input.Contains("END"))
            {
                if (!input.Contains("green"))
                {
                    cars.Enqueue(input);
                }
                else
                {
                    
                    int currGreen = greenLight;
                    while (cars.Count != 0 && currGreen  > 0)
                    {
                        string currCar = cars.Dequeue();
                        currGreen -= currCar.Count();
                        if (currGreen >= 0)
                        {
                            counter++;
                            
                        }
                        else
                        {
                            if (freeWindow + currGreen < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currCar} was hit at {currCar[currCar.Length + currGreen + freeWindow]}.");
                                return;
                            }
                            counter++;
                        }
                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
