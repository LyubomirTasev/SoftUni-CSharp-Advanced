using System;
using System.Collections.Generic;

namespace Generics_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = CreateArray<int>(10, 1);
            var stringArr = CreateArray<string>(3, "Sando");
            var arraysLists = CreateArray<List<string>>(10, new List<string>());

            var list = CreateList<int>(5);
            var list2 = CreateList<string>("Basi");
        }

        static T[] CreateArray<T>(int count, T element)
        {
            T[] result = new T[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = element;
            }

            return result;
        }

        static List<T> CreateList<T>(T item)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(item);
            }

            return list;
        }

        //static string[] CreateArrayOfString(int count, string element)
        //{
        //    string[] result = new string[count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        result[i] = element;
        //    }

        //    return result;
        //}
    }
}
