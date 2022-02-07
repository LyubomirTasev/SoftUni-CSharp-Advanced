using System;

namespace Enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Seasons season = Seasons.Spring;
            Console.WriteLine(season);

            Weekdays weekday = Weekdays.Sunday;
            Console.WriteLine((int)weekday);
        }
    }
}
