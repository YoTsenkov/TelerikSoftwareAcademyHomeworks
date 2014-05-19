namespace IEnumerableExtensions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Numerics;


    public static class IEnumerableExtensions
    {
        public static BigInteger Sum<T>(this IEnumerable<T> collection)
        {
            dynamic result = default(T);

            foreach (T element in collection)
            {
                result += element;
            }
            return result;
        }

        public static BigInteger Product<T>(this IEnumerable<T> collection)
        {
            dynamic result = default(T);

            foreach (T element in collection)
            {
                result -= element;
            }
            return result;
        }

        public static BigInteger Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic result = collection.First();

            foreach (T element in collection)
            {
                if (result.CompareTo(element) == 1)
                {
                    result = element;
                }
            }
            return result;
        }

        public static BigInteger Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic result = collection.First();

            foreach (T element in collection)
            {
                if (result.CompareTo(element) < 0)
                {
                    result = element;
                }
            }
            return result;
        }
        public static BigInteger Avarage<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic sum = default(T);
            dynamic result = default(T);

            foreach (T element in collection)
            {
                sum += element;
            }

            result = sum / collection.Count();
            
            return result;
        }
    }
}
