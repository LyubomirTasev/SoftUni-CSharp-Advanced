using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());

            Queue<int[]> truckTour = new Queue<int[]>();

            for (int i = 0; i < petrolPumps; i++)
            {
                int[] pumpInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int petrol = pumpInfo[0];
                int distance = pumpInfo[1];

                truckTour.Enqueue(new int[] { petrol, distance });
            }

            int startIndex = 0;

            while (true)
            {
                int currentPetrol = 0;

                foreach (var info in truckTour)
                {
                    int truckPetrol = info[0];
                    int truckDistance = info[1];

                    currentPetrol += truckPetrol;
                    currentPetrol -= truckDistance;

                    if (currentPetrol < 0)
                    {
                        int[] element = truckTour.Dequeue();
                        truckTour.Enqueue(element);
                        startIndex++;
                        break;
                    }
                }

                if (currentPetrol >= 0)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}
