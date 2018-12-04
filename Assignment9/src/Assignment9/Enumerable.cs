using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace Assignment9
{
    public static class Enumerable
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> collection)
        {
            List<T> theCollection = collection.ToList();
            int count = theCollection.Count;
            Random numGenerator = new Random();
            while(theCollection.Any())
            {
                count--;
                int index = numGenerator.Next(count + 1);
                T item = theCollection[index];
                theCollection.RemoveAt(index);
                yield return item;
            }
        }
    }
}