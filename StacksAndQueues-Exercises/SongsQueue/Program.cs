using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] playlist = Console.ReadLine().Split(", ");
            Queue<string> queueOfSongs = new Queue<string>(playlist);

            while (queueOfSongs.Count > 0)
            {
                string command = Console.ReadLine();
                if (command == "Play")
                {
                    queueOfSongs.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queueOfSongs));
                }
                else
                {
                    int index = command.IndexOf(' ');
                    string song = command.Substring(index + 1);

                    if (queueOfSongs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queueOfSongs.Enqueue(song);
                    }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
