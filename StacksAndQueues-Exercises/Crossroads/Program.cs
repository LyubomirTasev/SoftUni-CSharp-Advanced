using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightInSeconds = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int passedCars = 0;
            bool isHit = false;
            Queue<string> cars = new Queue<string>();

            while (command != "END")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    int currentGreenLight = greenLightInSeconds;

                    while (cars.Count > 0 && currentGreenLight > 0)
                    {
                        string currentCar = cars.Dequeue();

                        if (currentGreenLight - currentCar.Length >= 0)
                        {
                            currentGreenLight -= currentCar.Length;
                            passedCars++;
                            continue;
                        }
                        if (currentGreenLight + freeWindow - currentCar.Length >= 0)
                        {
                            currentGreenLight = 0;
                            passedCars++;
                            continue;
                        }
                        else
                        {
                            string hitChar = currentCar.Substring(currentGreenLight + freeWindow, 1);

                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {hitChar}");
                            isHit = true;
                            Environment.Exit(0);
                        }
                    }
                }
                if (isHit)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if (!isHit)
            {
                Console.WriteLine("Everyone is safe");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
