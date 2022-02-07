using System;
using System.Collections.Generic;
using System.Text;

namespace _01.BoxOfT
{
    public class Box<T>
    {
        private readonly Stack<T> box;

        public Box()
        {
            box = new Stack<T>();
        }

        public int Count => box.Count; // съкратен запис на get return, когато има само един return operator

        public void Add(T element)
        {
            box.Push(element);
        }

        public T Remove() => box.Pop();

        //private List<T> internalList = new List<T>();

        //public int Count
        //{
        //    get
        //    {
        //        return internalList.Count;
        //    }
        //}

        //public void Add(T item)
        //{
        //    internalList.Add(item);
        //}

        //public T Remove()
        //{
        //    T element = internalList[internalList.Count - 1];
        //    internalList.Remove(element);
        //    //internalList.RemoveAt(internalList.Count - 1);
        //    return element;
        //}
    }
}
