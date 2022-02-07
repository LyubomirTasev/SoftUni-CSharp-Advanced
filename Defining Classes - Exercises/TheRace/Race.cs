using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> racers;
        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.racers = new List<Racer>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return racers.Count(); } }

        public void Add(Racer racer)
        {
            if (Capacity > racers.Count)
            {
                racers.Add(racer);
            }
        }
        public bool Remove(string name)
        {
            if (racers.Where(x => x.Name == name).Any())
            {
                racers.Remove(racers.Where(x => x.Name == name).FirstOrDefault());
                return true;
            }
            else
            {
                return false;
            }
        }

        public Racer GetOldestRacer() => racers.OrderByDescending(x => x.Age).FirstOrDefault();
        public Racer GetRacer(string name) => racers.FirstOrDefault(x => x.Name == name);
        public Racer GetFastestRacer() => racers.OrderByDescending(x => x.Car.Speed).FirstOrDefault();

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Racers participating at {Name}:");
            sb.AppendLine($"{String.Join(Environment.NewLine, racers)}");

            return sb.ToString().TrimEnd();
        }
    }
}
