using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda
{
    public static class LinqHelper
    {
        public static bool Any2<T>(this IEnumerable<T> colletion, Predicate<T> predicate)
        {
            foreach (var item in colletion)
            {
                if (predicate(item))
                {
                    return true;
                }
            }

            return false;
        }

        public static IEnumerable<Person> Where2(this IEnumerable<Person> people, Predicate<Person> predicate)
        {
            foreach (var p in people)
            {
                if (predicate(p))
                {
                    yield return p;
                }
            }
        }

        public static Person First(this IEnumerable<Person> collection, Predicate<Person> predicate)
        {
            //if there return

            //if not there throw expection
        }
    }
}
