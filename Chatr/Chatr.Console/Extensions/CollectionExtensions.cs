namespace Chatr.Console.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CollectionExtensions
    {
        public static T PickRandom<T>(this ICollection<T> source)
        {
            return source.PickRandom(1).First();
        }

        public static IEnumerable<T> PickRandom<T>(this ICollection<T> source, int count)
        {
            return source.Shuffle().Take(count);
        }

        public static IEnumerable<T> Shuffle<T>(this ICollection<T> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }
    }
}