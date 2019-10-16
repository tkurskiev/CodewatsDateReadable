using System;

namespace CodeWarsDateReadable
{
    public static class Extensions
    {
        /// <exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
        public static bool IsPlural(this int number)
        {
            return Math.Abs(number) % 10 != 1;
        }

        /// <exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
        public static string GetDateString(this int number, string dateComponent)
        {
            return $"{number} {dateComponent}{(number.IsPlural() ? "s" : string.Empty)}";
        }
    }
}
