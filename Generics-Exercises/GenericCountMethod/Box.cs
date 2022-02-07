using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethod
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T item = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = item;
        }

        public int GreaterCount(double item)
        {
            int count = 0;
            foreach (var currElement in items)
            {
                if (currElement.CompareTo(item) > 0)
                {
                    count++;
                }
            }
            return count;            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
